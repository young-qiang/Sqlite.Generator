namespace Sqlite.Generator
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btn_Generator = new Sunny.UI.UIButton();
            this.txt_DbName = new Sunny.UI.UITextBox();
            this.txt_pwd = new Sunny.UI.UITextBox();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.chb_IsEncryption = new Sunny.UI.UICheckBox();
            this.btn_Reset = new Sunny.UI.UIButton();
            this.btn_OutPutPath = new Sunny.UI.UIButton();
            this.uiGroupBox1 = new Sunny.UI.UIGroupBox();
            this.txt_OutPutPath = new Sunny.UI.UIRichTextBox();
            this.uiGroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Generator
            // 
            this.btn_Generator.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Generator.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Generator.Location = new System.Drawing.Point(24, 403);
            this.btn_Generator.MinimumSize = new System.Drawing.Size(1, 1);
            this.btn_Generator.Name = "btn_Generator";
            this.btn_Generator.Size = new System.Drawing.Size(150, 35);
            this.btn_Generator.TabIndex = 0;
            this.btn_Generator.Text = "生成";
            this.btn_Generator.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Generator.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.btn_Generator.Click += new System.EventHandler(this.btn_Generator_Click);
            // 
            // txt_DbName
            // 
            this.txt_DbName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_DbName.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_DbName.Location = new System.Drawing.Point(17, 46);
            this.txt_DbName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_DbName.MinimumSize = new System.Drawing.Size(1, 16);
            this.txt_DbName.Name = "txt_DbName";
            this.txt_DbName.Radius = 10;
            this.txt_DbName.ShowText = false;
            this.txt_DbName.Size = new System.Drawing.Size(294, 29);
            this.txt_DbName.TabIndex = 1;
            this.txt_DbName.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txt_DbName.Watermark = "数据库名称";
            this.txt_DbName.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // txt_pwd
            // 
            this.txt_pwd.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_pwd.Enabled = false;
            this.txt_pwd.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_pwd.Location = new System.Drawing.Point(17, 122);
            this.txt_pwd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_pwd.MinimumSize = new System.Drawing.Size(1, 16);
            this.txt_pwd.Name = "txt_pwd";
            this.txt_pwd.Radius = 10;
            this.txt_pwd.ShowText = false;
            this.txt_pwd.Size = new System.Drawing.Size(294, 29);
            this.txt_pwd.TabIndex = 3;
            this.txt_pwd.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txt_pwd.Watermark = "密码";
            this.txt_pwd.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiLabel1
            // 
            this.uiLabel1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel1.Location = new System.Drawing.Point(318, 52);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(46, 23);
            this.uiLabel1.TabIndex = 4;
            this.uiLabel1.Text = ".db";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiLabel1.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // chb_IsEncryption
            // 
            this.chb_IsEncryption.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chb_IsEncryption.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.chb_IsEncryption.Location = new System.Drawing.Point(17, 85);
            this.chb_IsEncryption.MinimumSize = new System.Drawing.Size(1, 1);
            this.chb_IsEncryption.Name = "chb_IsEncryption";
            this.chb_IsEncryption.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.chb_IsEncryption.Size = new System.Drawing.Size(130, 29);
            this.chb_IsEncryption.TabIndex = 5;
            this.chb_IsEncryption.Text = "是否需要加密";
            this.chb_IsEncryption.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.chb_IsEncryption.CheckedChanged += new System.EventHandler(this.chb_IsEncryption_CheckedChanged);
            // 
            // btn_Reset
            // 
            this.btn_Reset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Reset.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Reset.Location = new System.Drawing.Point(191, 403);
            this.btn_Reset.MinimumSize = new System.Drawing.Size(1, 1);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(150, 35);
            this.btn_Reset.TabIndex = 0;
            this.btn_Reset.Text = "重置";
            this.btn_Reset.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Reset.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.btn_Reset.Click += new System.EventHandler(this.btn_Reset_Click);
            // 
            // btn_OutPutPath
            // 
            this.btn_OutPutPath.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_OutPutPath.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_OutPutPath.Location = new System.Drawing.Point(17, 159);
            this.btn_OutPutPath.MinimumSize = new System.Drawing.Size(1, 1);
            this.btn_OutPutPath.Name = "btn_OutPutPath";
            this.btn_OutPutPath.Size = new System.Drawing.Size(150, 35);
            this.btn_OutPutPath.TabIndex = 6;
            this.btn_OutPutPath.Text = "修改输出路径";
            this.btn_OutPutPath.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_OutPutPath.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.btn_OutPutPath.Click += new System.EventHandler(this.btn_OutPutPath_Click);
            // 
            // uiGroupBox1
            // 
            this.uiGroupBox1.Controls.Add(this.txt_OutPutPath);
            this.uiGroupBox1.Controls.Add(this.txt_DbName);
            this.uiGroupBox1.Controls.Add(this.txt_pwd);
            this.uiGroupBox1.Controls.Add(this.btn_OutPutPath);
            this.uiGroupBox1.Controls.Add(this.uiLabel1);
            this.uiGroupBox1.Controls.Add(this.chb_IsEncryption);
            this.uiGroupBox1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiGroupBox1.Location = new System.Drawing.Point(10, 39);
            this.uiGroupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiGroupBox1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiGroupBox1.Name = "uiGroupBox1";
            this.uiGroupBox1.Padding = new System.Windows.Forms.Padding(0, 32, 0, 0);
            this.uiGroupBox1.Radius = 1;
            this.uiGroupBox1.Size = new System.Drawing.Size(380, 354);
            this.uiGroupBox1.TabIndex = 8;
            this.uiGroupBox1.Text = null;
            this.uiGroupBox1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.uiGroupBox1.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // txt_OutPutPath
            // 
            this.txt_OutPutPath.FillColor = System.Drawing.Color.White;
            this.txt_OutPutPath.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_OutPutPath.Location = new System.Drawing.Point(14, 201);
            this.txt_OutPutPath.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_OutPutPath.MinimumSize = new System.Drawing.Size(1, 1);
            this.txt_OutPutPath.Name = "txt_OutPutPath";
            this.txt_OutPutPath.Padding = new System.Windows.Forms.Padding(2);
            this.txt_OutPutPath.ReadOnly = true;
            this.txt_OutPutPath.ShowText = false;
            this.txt_OutPutPath.Size = new System.Drawing.Size(350, 139);
            this.txt_OutPutPath.TabIndex = 7;
            this.txt_OutPutPath.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.txt_OutPutPath.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(401, 446);
            this.Controls.Add(this.uiGroupBox1);
            this.Controls.Add(this.btn_Reset);
            this.Controls.Add(this.btn_Generator);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.ShowRadius = false;
            this.ShowShadow = true;
            this.Text = "SQLite生成器";
            this.TextAlignment = System.Drawing.StringAlignment.Center;
            this.ZoomScaleRect = new System.Drawing.Rectangle(15, 15, 800, 450);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.uiGroupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UIButton btn_Generator;
        private Sunny.UI.UITextBox txt_DbName;
        private Sunny.UI.UITextBox txt_pwd;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UICheckBox chb_IsEncryption;
        private Sunny.UI.UIButton btn_Reset;
        private Sunny.UI.UIButton btn_OutPutPath;
        private Sunny.UI.UIGroupBox uiGroupBox1;
        private Sunny.UI.UIRichTextBox txt_OutPutPath;
    }
}