namespace WindowHide
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_SetAction = new System.Windows.Forms.Button();
            this.txt_HotKey = new System.Windows.Forms.TextBox();
            this.btn_Reset = new System.Windows.Forms.Button();
            this.lbl_RegisteredProcess = new System.Windows.Forms.Label();
            this.txt_RegisteredProcess = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_TopMost = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_SetAction
            // 
            this.btn_SetAction.Location = new System.Drawing.Point(15, 11);
            this.btn_SetAction.Name = "btn_SetAction";
            this.btn_SetAction.Size = new System.Drawing.Size(122, 30);
            this.btn_SetAction.TabIndex = 0;
            this.btn_SetAction.Text = "设置快捷键";
            this.btn_SetAction.UseVisualStyleBackColor = true;
            this.btn_SetAction.Click += new System.EventHandler(this.btn_SetAction_Click);
            // 
            // txt_HotKey
            // 
            this.txt_HotKey.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txt_HotKey.Enabled = false;
            this.txt_HotKey.Location = new System.Drawing.Point(149, 12);
            this.txt_HotKey.Name = "txt_HotKey";
            this.txt_HotKey.ReadOnly = true;
            this.txt_HotKey.Size = new System.Drawing.Size(122, 28);
            this.txt_HotKey.TabIndex = 1;
            this.txt_HotKey.Text = "Alt+F1";
            this.txt_HotKey.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_HotKey_KeyUp);
            // 
            // btn_Reset
            // 
            this.btn_Reset.Location = new System.Drawing.Point(24, 146);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(247, 30);
            this.btn_Reset.TabIndex = 2;
            this.btn_Reset.Text = "重置";
            this.btn_Reset.UseVisualStyleBackColor = true;
            this.btn_Reset.Click += new System.EventHandler(this.btn_Reset_Click);
            // 
            // lbl_RegisteredProcess
            // 
            this.lbl_RegisteredProcess.AutoSize = true;
            this.lbl_RegisteredProcess.Location = new System.Drawing.Point(21, 81);
            this.lbl_RegisteredProcess.Name = "lbl_RegisteredProcess";
            this.lbl_RegisteredProcess.Size = new System.Drawing.Size(116, 18);
            this.lbl_RegisteredProcess.TabIndex = 3;
            this.lbl_RegisteredProcess.Text = "当前注册应用";
            // 
            // txt_RegisteredProcess
            // 
            this.txt_RegisteredProcess.Location = new System.Drawing.Point(149, 75);
            this.txt_RegisteredProcess.Name = "txt_RegisteredProcess";
            this.txt_RegisteredProcess.ReadOnly = true;
            this.txt_RegisteredProcess.Size = new System.Drawing.Size(122, 28);
            this.txt_RegisteredProcess.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "Ctrl+F1隐藏";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "置于最上层";
            // 
            // cb_TopMost
            // 
            this.cb_TopMost.AutoSize = true;
            this.cb_TopMost.Checked = true;
            this.cb_TopMost.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_TopMost.Location = new System.Drawing.Point(149, 48);
            this.cb_TopMost.Name = "cb_TopMost";
            this.cb_TopMost.Size = new System.Drawing.Size(22, 21);
            this.cb_TopMost.TabIndex = 7;
            this.cb_TopMost.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(146, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 18);
            this.label3.TabIndex = 8;
            this.label3.Text = "Alt+F2关闭";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 188);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cb_TopMost);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_RegisteredProcess);
            this.Controls.Add(this.lbl_RegisteredProcess);
            this.Controls.Add(this.btn_Reset);
            this.Controls.Add(this.txt_HotKey);
            this.Controls.Add(this.btn_SetAction);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_SetAction;
        private System.Windows.Forms.TextBox txt_HotKey;
        private System.Windows.Forms.Button btn_Reset;
        private System.Windows.Forms.Label lbl_RegisteredProcess;
        private System.Windows.Forms.TextBox txt_RegisteredProcess;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox cb_TopMost;
        private System.Windows.Forms.Label label3;
    }
}

