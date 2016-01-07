using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BilibiliDM_PluginFramework;

namespace CS_Danmaku_Plgin
{
    public class CS_Danmaku_Plgin:DMPlugin
    {
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
        }
    }
}
