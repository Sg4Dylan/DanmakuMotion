using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using BilibiliDM_PluginFramework;
using System.Xml;
using System.Xml.Linq;

namespace DanmakuMotionPlugin
{
    public class DanmakuMotionPlugin : DMPlugin
    {
        public 
            string setting_file_path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\弹幕姬\\Plugins\\setting.xml";
            Setting settingwindow = new Setting();
            XmlDocument xml = new XmlDocument();

        public DanmakuMotionPlugin()
        {
            PluginAuth = "SgDylan";
            PluginName = "DanmakuMotion";
            PluginDesc = "直播弹幕操纵动作程式";
            PluginCont = "me@lolicon.link";
            PluginVer = "0.2 Beta";
            ReceivedDanmaku += DanmakuMotionPlugin_ReceivedDanmaku;
        }

        private void DanmakuMotionPlugin_ReceivedDanmaku(object sender, BilibiliDM_PluginFramework.ReceivedDanmakuArgs e)
        {
            if (Status)
            {
                if (e.Danmaku.MsgType == MsgTypeEnum.Comment)
                {
                    //載入配置文件
                    try
                    {
                        xml.Load(setting_file_path);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("配置參數載入異常，詳見： " + ex.Message);
                    }
                    //彈幕權限分割
                    if (e.Danmaku.isAdmin)
                    {
                        string admin_comment = e.Danmaku.CommentText;
                        SendKeys.SendWait(admin_comment);
                    }
                    else
                    {
                        string normal_user_comment = e.Danmaku.CommentText;
                        try
                        {
                            string normal_user_command = "";
                            XmlNodeList xnList = xml.SelectNodes("/Key_Vector_Setting/event");
                            foreach (XmlNode xn in xnList)
                            {
                                string key = xn["key"].InnerText;
                                if (key == normal_user_comment)
                                {
                                    normal_user_command = xn["motion"].InnerText;
                                }
                            }
                            SendKeys.SendWait(normal_user_command);
                        }
                        catch (Exception ex)
                        {
                            AddDM("用戶彈幕參數錯誤");
                            Log("用戶非法彈幕參數，詳細信息" + ex.Message);
                        }
                    }
                }
            }
        }

        public override void Admin()
        {
            base.Admin();
            setting_dialog();
        }

        public void setting_dialog()
        {
            if (settingwindow.ShowDialog() == DialogResult.OK)
            {
                setting_file_path = settingwindow.setting_file_path;
            }
        }
    }
}
