using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using BilibiliDM_PluginFramework;

namespace DanmakuMotionPlugin
{
    public class CS_Danmaku_Plgin : DMPlugin
    {
        public 
            string setting_in_main_program = "Test";
            bool setting_dialog_status = false;

        public CS_Danmaku_Plgin()
        {
            PluginAuth = "SgDylan";
            PluginName = "DanmakuMotion";
            PluginDesc = "直播弹幕操纵动作程式";
            PluginCont = "me@lolicon.link";
            PluginVer = "v0.1";
            ReceivedDanmaku += CS_Danmaku_Plgin_ReceivedDanmaku;
        }

        private void CS_Danmaku_Plgin_ReceivedDanmaku(object sender, BilibiliDM_PluginFramework.ReceivedDanmakuArgs e)
        {
            if (Status)
            {
                if (e.Danmaku.MsgType == MsgTypeEnum.Comment)
                {
                    //MessageBox.Show(e.Danmaku.CommentText);
                    switch (e.Danmaku.CommentText)
                    {
                        case "up":
                            SendKeys.SendWait("{UP}");
                            break;
                        case "down":
                            SendKeys.SendWait("{DOWN}");
                            break;
                        case "left":
                            SendKeys.SendWait("{LEFT}");
                            break;
                        case "rigth":
                            SendKeys.SendWait("{RIGHT}");
                            break;
                        case "enter":
                            SendKeys.SendWait("{ENTER}");
                            break;
                        case "space":
                            SendKeys.SendWait(" ");
                            break;
                        default:
                            break;
                    }
                }
            }
        }

        public override void Admin()
        {
            base.Admin();
            //run setting dialog
            setting_dialog(setting_in_main_program, setting_dialog_status);
        }

        public void setting_dialog(string now_setting, bool status)
        {
            if (status) return;
            Setting settingwindow = new Setting();
            settingwindow.Show();
        }
    }

    //static class Program
    //{
    //    /// <summary>
    //    /// 应用程序的主入口点。
    //    /// </summary>
    //    [STAThread]
    //    static void Main()
    //    {
    //        Application.EnableVisualStyles();
    //        Application.SetCompatibleTextRenderingDefault(false);
    //        Application.Run(new Setting());
    //    }
    //}
}
