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

namespace DanmakuMotionPlugin
{
    public partial class Setting : Form
    {
        public 
            string setting_file_path;

        public Setting()
        {
            InitializeComponent();
        }

        private void 幫助HToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("您可以通過本程式修改鍵盤綁定設置，亦可藉由設定檔直接修改。\n修改配置窗口預載入或手動載入的配置文檔時，標記爲‘key’及‘motion’的值分別代表目標彈幕及對應的操作。\n例如： ‘key’爲‘a’，同一行的‘motion’爲‘test’，則當插件接受到彈幕爲‘a’時，計算機會通過模擬鍵盤輸出‘test’。\n更加詳細的用法請自行閲讀原始碼：\nhttps://github.com/Sg4Dylan/DanmakuMotion", "幫助", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }

        private void 關於AToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("作者： Sg4Dylan @ Github\n授權協議： GPLv2\n插件版本： 0.2 Beta\n感謝您的使用！", "關於", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void 導入預設文件IToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ImportSettingDialog = new OpenFileDialog();
            ImportSettingDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\弹幕姬\\Plugins\\";
            ImportSettingDialog.FileName = "setting.xml";
            ImportSettingDialog.Filter = "程式設置檔文件 (*.xml)|*.xml|所有文件 (*.*)|*.*";
            ImportSettingDialog.FilterIndex = 1;
            ImportSettingDialog.RestoreDirectory = true;
            if (ImportSettingDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    DisplaySet.Clear();
                    DisplaySet.ReadXml(ImportSettingDialog.FileName);
                    dataGridView1.DataSource = DisplaySet;
                    dataGridView1.DataMember = "event";
                    setting_file_path = ImportSettingDialog.FileName;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("讀取設置檔失敗，原始錯誤檔如下: \n" + ex.Message);
                }
            }
        }

        private void 導出預設文件OToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ExportSettingDialog = new OpenFileDialog();
            ExportSettingDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\弹幕姬\\Plugins\\";
            ExportSettingDialog.FileName = "setting.xml";
            ExportSettingDialog.Filter = "程式設置檔文件 (*.xml)|*.xml|所有文件 (*.*)|*.*";
            ExportSettingDialog.FilterIndex = 1;
            ExportSettingDialog.RestoreDirectory = true;

            if (ExportSettingDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if (DisplaySet == null) { return; }
                    string filename = ExportSettingDialog.FileName;
                    System.IO.FileStream stream = new System.IO.FileStream
                        (filename, System.IO.FileMode.Create);
                    DisplaySet.WriteXml(stream);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("導出設置檔失敗，原始錯誤檔如下: \n" + ex.Message);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (DisplaySet == null)
            {
                MessageBox.Show("當前數據内容爲空，無法保存！", "保存錯誤", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            try
            {
                string filename = setting_file_path;
                System.IO.FileStream stream = new System.IO.FileStream
                    (filename, System.IO.FileMode.Create);
                DisplaySet.WriteXml(stream);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("導出設置檔失敗，原始錯誤檔如下: \n" + ex.Message);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void Setting_Load(object sender, EventArgs e)
        {
            try
            {
                DisplaySet.Clear();
                DisplaySet.ReadXml(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\弹幕姬\\Plugins\\setting.xml");
                dataGridView1.DataSource = DisplaySet;
                dataGridView1.DataMember = "event";
            }
            catch (Exception ex)
            {
                MessageBox.Show("載入預設檔失敗，請檢查插件目錄下是否存在配置文件！ 詳細錯誤信息: \n" + ex.Message);
            }

        }
    }
}
