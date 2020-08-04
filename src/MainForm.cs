using System;
using System.Diagnostics;
using System.Windows.Forms;
using static WindowHide.HotKey;

namespace WindowHide
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private KeyModifiers key1 = KeyModifiers.Alt;
        private Keys key2 = Keys.F1;
        private Process registeredProcess;
        private IntPtr registeredHandle;
        private bool isVisible = true;


        protected override void WndProc(ref Message m)
        {
            try
            {
                const int WM_HOTKEY = 0x0312;
                switch (m.Msg)
                {
                    case WM_HOTKEY:
                        switch (m.WParam.ToInt32())
                        {
                            case 100:
                                var processHandle = HotKey.GetForegroundWindow();
                                //非0非当前窗口
                                if (processHandle != 0 && processHandle != Handle.ToInt32())
                                {
                                    //注册过或注册的已关闭
                                    if (registeredProcess == null || registeredProcess.HasExited)
                                    {
                                        int processId;
                                        HotKey.GetWindowThreadProcessId(new IntPtr(processHandle), out processId);
                                        Process process = Process.GetProcessById(processId);
                                        if (process != null)
                                        {
                                            HotKey.SetForegroundWindow((int)this.Handle);
                                            if (DialogResult.Yes == MessageBox.Show($"是否为{process.MainWindowTitle}设置隐藏", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                                            {
                                                HotKey.RegisterHotKey(Handle, 100, key1, key2);
                                                this.txt_RegisteredProcess.Text = process.MainWindowTitle;
                                                if (this.cb_TopMost.Checked)
                                                {
                                                    TopMostWindow.SetTopomost(process.Handle);
                                                }
                                                registeredProcess = process;
                                            }
                                            else
                                            {
                                                registeredProcess = null;
                                            }
                                        }
                                    }
                                    else
                                    {
                                        if (isVisible)
                                        {
                                            registeredHandle = registeredProcess.MainWindowHandle;
                                            HotKey.ShowWindow(registeredHandle, 0);
                                            isVisible = false;
                                        }
                                        else
                                        {
                                            HotKey.ShowWindow(registeredHandle, 5);
                                            isVisible = true;
                                        }
                                    }
                                }
                                break;
                            case 101:
                                if (registeredProcess != null && !registeredProcess.HasExited)
                                {
                                    registeredProcess.Kill();
                                }
                                break;
                            case 105:
                                if (HotKey.IsWindowVisible(this.Handle))
                                {
                                    HotKey.ShowWindow(this.Handle, 0);
                                }
                                else
                                {
                                    HotKey.ShowWindow(this.Handle, 5);
                                }
                                break;
                        }
                        break;
                }
                base.WndProc(ref m);
            }
            catch (Exception e) { 
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            HotKey.RegisterHotKey(Handle, 100, key1, key2);
            HotKey.RegisterHotKey(Handle, 101, KeyModifiers.Alt, Keys.F2);
            HotKey.RegisterHotKey(Handle, 105, KeyModifiers.Ctrl, Keys.F1);
        }

        private void btn_SetAction_Click(object sender, EventArgs e)
        {
            this.txt_HotKey.Enabled = true;
            this.btn_SetAction.Enabled = false;
        }

        private void txt_HotKey_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Alt)
            {
                this.txt_HotKey.Text = $"Alt+{e.KeyCode.ToString()}";
                HotKey.UnregisterHotKey(Handle, 100);
                this.key2 = e.KeyCode;
                HotKey.RegisterHotKey(Handle, 100, key1, key2);
            }
            else 
            {
                MessageBox.Show("快捷键必须为Alt键加上其他有效键", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            this.txt_HotKey.Enabled = false;
            this.btn_SetAction.Enabled = true;
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            try
            {
                if (registeredProcess != null && !registeredProcess.HasExited)
                {
                    HotKey.ShowWindow(registeredHandle, 5);
                }
            }
            catch (Exception exp) { 
            }
            finally
            {
                registeredProcess = null;
                registeredHandle = new IntPtr();
                key1 = KeyModifiers.Alt;
                key2 = Keys.F1;
                this.txt_HotKey.Text = "Alt+F1";
                this.txt_RegisteredProcess.Text = string.Empty;
            }
        }
    }
}
