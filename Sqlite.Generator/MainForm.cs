using Microsoft.Data.Sqlite;
using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sqlite.Generator
{
    public partial class MainForm : UIForm
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void chb_IsEncryption_CheckedChanged(object sender, EventArgs e)
        {
            txt_pwd.Enabled = chb_IsEncryption.Checked;
        }

        private void btn_Generator_Click(object sender, EventArgs e)
        {
            try
            {
                var dbName = txt_DbName.Text.Trim();
                var pwd = txt_pwd.Text.Trim();
                if (string.IsNullOrWhiteSpace(dbName))
                {
                    UIMessageBox.ShowWarning("请输入数据库名称");
                    return;
                }
                dbName = $@"{dbName}.db";
                if (File.Exists(Path.Combine(txt_OutPutPath.Text, dbName)))
                {
                    UIMessageBox.ShowWarning($@"文件名已存在：{dbName}");
                    return;
                }

                if (chb_IsEncryption.Checked && string.IsNullOrWhiteSpace(pwd))
                {
                    UIMessageBox.ShowWarning("请输入密码");
                    return;
                }

                var connet = new SqliteConnectionStringBuilder()
                {
                    Mode = SqliteOpenMode.ReadWriteCreate,
                    DataSource = dbName
                };

                if (chb_IsEncryption.Checked)
                {
                    connet.Password = pwd;
                }

                using (SqliteConnection sqliteConnection = new SqliteConnection(connet.ToString()))
                {
                    sqliteConnection.Open();
                    SqliteCommand command = new SqliteCommand("create table CanDeleteMe(A char(1) not null)", sqliteConnection);
                    command.ExecuteNonQuery();
                }

                if (!File.Exists(dbName))
                {
                    UIMessageBox.ShowError("生成失败！");
                    return;
                }

                FileInfo file = new FileInfo(dbName);
                file.MoveTo(Path.Combine(txt_OutPutPath.Text, file.Name));


                UIMessageBox.ShowSuccess($@"生成成功！{Environment.NewLine}数据库文件名：{dbName}");
            }
            catch (Exception ex)
            {
                UIMessageBox.ShowError(ex.ToString());
            }

        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            txt_DbName.Text = string.Empty;
            txt_pwd.Text = string.Empty;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            txt_OutPutPath.Text = AppDomain.CurrentDomain.SetupInformation.ApplicationBase;
        }

        private void btn_OutPutPath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.Description = "选择输出文件夹";
            dialog.SelectedPath = txt_OutPutPath.Text;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                txt_OutPutPath.Text = dialog.SelectedPath;
            }
        }
    }
}
