using PreviewDemo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Channels;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using TGMTcontrols;
using TGMTcs;


namespace CameraController
{
    public partial class FormMain : Form
    {
        static FormMain m_instance;
        bool _inited = false;
        string _classPath = "";
        private Int32 m_lUserID = -1;
        private uint iLastErr = 0;
        private string str;
        private Int32 m_lRealHandle = -1;
        private bool m_bInitSDK = false;
        //private System.Windows.Forms.PictureBox RealPlayWnd;
        CHCNetSDK.REALDATACALLBACK RealData = null;
        public int m_lChannel = 1;

        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public FormMain()
        {
            InitializeComponent();
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        
        public static FormMain GetInstance()
        {
            if (m_instance == null)
                m_instance = new FormMain();
            return m_instance;
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////

        private void FormMain_Load(object sender, EventArgs e)
        {
            m_bInitSDK = CHCNetSDK.NET_DVR_Init();
            if(m_bInitSDK == false)
            {
                MessageBox.Show("NET_DVR_Init error!");
                return;
            }
            else
            {
                CHCNetSDK.NET_DVR_SetLogToFile(3, "C:\\SdkLog\\", true);
            }

            comboBoxSpeed.SelectedIndex = 3;

            txt_password.Text = TGMTini.GetInstance().ReadString("password", "");


            this.Text += " " + TGMTutil.GetVersion();

#if DEBUG
            this.Text += " *";
#endif
            _inited = true;
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////

        private void txt_password_TextChanged(object sender, EventArgs e)
        {
            if(_inited)
                return;

            TGMTini.GetInstance().SaveValue("password", txt_password.Text);
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////

        private void btn_connect_Click(object sender, EventArgs e)
        {
            if(txt_ip.Text == "" || txt_port.Text == "" ||
                txt_username.Text == "" || txt_password.Text == "")
            {
                MessageBox.Show("Please input IP, Port, User name and Password!");
                return;
            }
            if(m_lUserID < 0)
            {
                string DVRIPAddress = txt_ip.Text;
                Int16 DVRPortNumber = Int16.Parse(txt_port.Text);
                string DVRUserName = txt_username.Text;
                string DVRPassword = txt_password.Text;

                CHCNetSDK.NET_DVR_DEVICEINFO_V30 DeviceInfo = new CHCNetSDK.NET_DVR_DEVICEINFO_V30();

                //µÇÂ¼Éè±¸ Login the device
                m_lUserID = CHCNetSDK.NET_DVR_Login_V30(DVRIPAddress, DVRPortNumber, DVRUserName, DVRPassword, ref DeviceInfo);
                if(m_lUserID < 0)
                {
                    iLastErr = CHCNetSDK.NET_DVR_GetLastError();
                    str = "NET_DVR_Login_V30 failed, error code= " + iLastErr; //µÇÂ¼Ê§°Ü£¬Êä³ö´íÎóºÅ
                    MessageBox.Show(str);
                    return;
                }
                else
                {
                    
                    lbl_status.Text = "Connected";
                    btn_connect.Text = "Logout";
                    Play();
                }

                circle1.Visible = true;
            }
            else
            {
                Stop();

                if(!CHCNetSDK.NET_DVR_Logout(m_lUserID))
                {
                    iLastErr = CHCNetSDK.NET_DVR_GetLastError();
                    str = "NET_DVR_Logout failed, error code= " + iLastErr;
                    MessageBox.Show(str);
                    return;
                }
                m_lUserID = -1;
                btn_connect.Text = "Connect";

                circle1.Visible = false;
            }            
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////

        void Play()
        {
            if(m_lUserID < 0)
            {
                MessageBox.Show("Please login the device firstly");
                return;
            }

            if(m_lRealHandle < 0)
            {
                CHCNetSDK.NET_DVR_PREVIEWINFO lpPreviewInfo = new CHCNetSDK.NET_DVR_PREVIEWINFO();
                lpPreviewInfo.hPlayWnd = pictureBox1.Handle;//Ô¤ÀÀ´°¿Ú
                lpPreviewInfo.lChannel = Int16.Parse(textBoxChannel.Text);//Ô¤teÀÀµÄÉè±¸Í¨µÀ
                lpPreviewInfo.dwStreamType = 0;//ÂëÁ÷ÀàÐÍ£º0-Ö÷ÂëÁ÷£¬1-×ÓÂëÁ÷£¬2-ÂëÁ÷3£¬3-ÂëÁ÷4£¬ÒÔ´ËÀàÍÆ
                lpPreviewInfo.dwLinkMode = 0;//Á¬½Ó·½Ê½£º0- TCP·½Ê½£¬1- UDP·½Ê½£¬2- ¶à²¥·½Ê½£¬3- RTP·½Ê½£¬4-RTP/RTSP£¬5-RSTP/HTTP 
                lpPreviewInfo.bBlocked = true; //0- ·Ç×èÈûÈ¡Á÷£¬1- ×èÈûÈ¡Á÷
                lpPreviewInfo.dwDisplayBufNum = 1; //²¥·Å¿â²¥·Å»º³åÇø×î´ó»º³åÖ¡Êý
                lpPreviewInfo.byProtoType = 0;
                lpPreviewInfo.byPreviewMode = 0;


                if(textBoxID.Text != "")
                {
                    lpPreviewInfo.lChannel = -1;
                    byte[] byStreamID = System.Text.Encoding.Default.GetBytes(textBoxID.Text);
                    lpPreviewInfo.byStreamID = new byte[32];
                    byStreamID.CopyTo(lpPreviewInfo.byStreamID, 0);
                }


                if(RealData == null)
                {
                    RealData = new CHCNetSDK.REALDATACALLBACK(RealDataCallBack);//Ô¤ÀÀÊµÊ±Á÷»Øµ÷º¯Êý
                }

                IntPtr pUser = new IntPtr();//ÓÃ»§Êý¾Ý

                //´ò¿ªÔ¤ÀÀ Start live view 
                m_lRealHandle = CHCNetSDK.NET_DVR_RealPlay_V40(m_lUserID, ref lpPreviewInfo, null/*RealData*/, pUser);
                if(m_lRealHandle < 0)
                {
                    iLastErr = CHCNetSDK.NET_DVR_GetLastError();
                    str = "NET_DVR_RealPlay_V40 failed, error code= " + iLastErr; //Ô¤ÀÀÊ§°Ü£¬Êä³ö´íÎóºÅ
                    MessageBox.Show(str);
                    return;
                }
                else
                {

                }
            }
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////

        void Stop()
        {
            if(!CHCNetSDK.NET_DVR_StopRealPlay(m_lRealHandle))
            {
                iLastErr = CHCNetSDK.NET_DVR_GetLastError();
                str = "NET_DVR_StopRealPlay failed, error code= " + iLastErr;
                MessageBox.Show(str);
                return;
            }
            m_lRealHandle = -1;
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public void RealDataCallBack(Int32 lRealHandle, UInt32 dwDataType, IntPtr pBuffer, UInt32 dwBufSize, IntPtr pUser)
        {
            if(dwBufSize > 0)
            {
                byte[] sData = new byte[dwBufSize];
                Marshal.Copy(pBuffer, sData, 0, (Int32)dwBufSize);

                string str = "ÊµÊ±Á÷Êý¾Ý.ps";
                FileStream fs = new FileStream(str, FileMode.Create);
                int iLen = (int)dwBufSize;
                fs.Write(sData, 0, iLen);
                fs.Close();
            }
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////

        private void btn_up_MouseDown(object sender, MouseEventArgs e)
        {
            CHCNetSDK.NET_DVR_PTZControlWithSpeed(m_lRealHandle, CHCNetSDK.TILT_UP, 0, (uint)comboBoxSpeed.SelectedIndex + 1);
        }

        private void btn_up_MouseUp(object sender, MouseEventArgs e)
        {
            CHCNetSDK.NET_DVR_PTZControlWithSpeed(m_lRealHandle, CHCNetSDK.TILT_UP, 1, (uint)comboBoxSpeed.SelectedIndex + 1);
        }

        private void btn_down_MouseDown(object sender, MouseEventArgs e)
        {
            CHCNetSDK.NET_DVR_PTZControlWithSpeed(m_lRealHandle, CHCNetSDK.TILT_DOWN, 0, (uint)comboBoxSpeed.SelectedIndex + 1);
        }

        private void btn_down_MouseUp(object sender, MouseEventArgs e)
        {
            CHCNetSDK.NET_DVR_PTZControlWithSpeed(m_lRealHandle, CHCNetSDK.TILT_DOWN, 1, (uint)comboBoxSpeed.SelectedIndex + 1);
        }

        private void btn_left_MouseDown(object sender, MouseEventArgs e)
        {
            CHCNetSDK.NET_DVR_PTZControlWithSpeed(m_lRealHandle, CHCNetSDK.PAN_LEFT, 0, (uint)comboBoxSpeed.SelectedIndex + 1);
        }

        private void btn_left_MouseUp(object sender, MouseEventArgs e)
        {
            CHCNetSDK.NET_DVR_PTZControlWithSpeed(m_lRealHandle, CHCNetSDK.PAN_LEFT, 1, (uint)comboBoxSpeed.SelectedIndex + 1);
        }

        private void btn_right_MouseDown(object sender, MouseEventArgs e)
        {
            CHCNetSDK.NET_DVR_PTZControlWithSpeed(m_lRealHandle, CHCNetSDK.PAN_RIGHT, 0, (uint)comboBoxSpeed.SelectedIndex + 1);
        }

        private void btn_right_MouseUp(object sender, MouseEventArgs e)
        {
            CHCNetSDK.NET_DVR_PTZControlWithSpeed(m_lRealHandle, CHCNetSDK.PAN_RIGHT, 1, (uint)comboBoxSpeed.SelectedIndex + 1);
        }

        private void btn_flip_Click(object sender, EventArgs e)
        {
            bool setResult = HCNetWrapper.MirrorCamera(m_lRealHandle, m_lChannel);
        }



        private void btn_getImageConfig_Click(object sender, EventArgs e)
        {
            uint brightness = 0;
            uint contrast = 0;
            uint saturation = 0;
            uint hue = 0;

            bool result = CHCNetSDK.NET_DVR_GetVideoEffect(
                m_lRealHandle,
                m_lChannel,              // channel
                ref brightness,
                ref contrast,
                ref saturation,
                ref hue
            );

            if(result)
            {
                Console.WriteLine($"Brightness:  {brightness}");
                Console.WriteLine($"Contrast:    {contrast}");
                Console.WriteLine($"Saturation:  {saturation}");
                Console.WriteLine($"Hue:         {hue}");

                txt_brightness.Value = (int)brightness;
                txt_contrast.Value = (int)contrast;
                txt_saturation.Value = (int)saturation;
                txt_hue.Value = (int)hue;

                btn_setImageConfig.Enabled = true;
            }
            else
            {
                uint errorCode = CHCNetSDK.NET_DVR_GetLastError();
                Console.WriteLine($"Failed. Error: {errorCode}");
                btn_setImageConfig.Enabled = false;
            }
        }

        private void btn_setImageConfig_Click(object sender, EventArgs e)
        {
            SetVideoEffect();
        }

        void SetVideoEffect()
        {
            uint brightness = (uint)txt_brightness.Value;
            uint contrast = (uint)txt_contrast.Value;
            uint saturation = (uint)txt_saturation.Value;
            uint hue = (uint)txt_hue.Value;

            bool result = HCNetWrapper.SetVideoEffect(
                m_lRealHandle,
                m_lChannel,
                brightness,
                contrast,
                saturation,
                hue
            );
            if(result)
            {
                Console.WriteLine("Set video effect success");
            }
            else
            {
                uint errorCode = CHCNetSDK.NET_DVR_GetLastError();
                Console.WriteLine($"Failed to set video effect. Error: {errorCode}");
            }
        }

        
        private void txt_brightness_ValueChanged(object sender, EventArgs e)
        {
            SetVideoEffect();
        }

        private void txt_contrast_ValueChanged(object sender, EventArgs e)
        {
            SetVideoEffect();
        }

        private void txt_saturation_ValueChanged(object sender, EventArgs e)
        {
            SetVideoEffect();
        }

        private void txt_hue_ValueChanged(object sender, EventArgs e)
        {
            SetVideoEffect();
        }


    }
}
