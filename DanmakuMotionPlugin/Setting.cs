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
        public string json_info;

        public Setting()
        {
            InitializeComponent();
        }

        private void 幫助HToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("您可以通過本程式修改鍵盤綁定設置，亦可藉由設定檔直接修改，相關語法詳見設定檔本體。","幫助", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }

        private void 關於AToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("作者： Sg4Dylan @ Github\n 授權協議： GPLv2\n感謝您的使用！", "關於", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void 導入預設文件IToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stream myStream = null;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = "d:\\";
            openFileDialog1.Filter = "程式設置檔文件 (*.ini)|*.ini|所有文件 (*.*)|*.*";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((myStream = openFileDialog1.OpenFile()) != null)
                    {
                        using (myStream)
                        {
                            // Insert code to read the stream here.
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("讀取設置檔失敗，原始錯誤檔如下: \n" + ex.Message);
                }
            }
        }

        private void 導出預設文件OToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stream myStream = null;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = "d:\\";
            openFileDialog1.Filter = "程式設置檔文件 (*.ini)|*.ini|所有文件 (*.*)|*.*";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((myStream = openFileDialog1.OpenFile()) != null)
                    {
                        using (myStream)
                        {
                            // Insert code to read the stream here.
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("導出設置檔失敗，原始錯誤檔如下: \n" + ex.Message);
                }
            }
        }
    }
}
