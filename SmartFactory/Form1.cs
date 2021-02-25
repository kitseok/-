using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Security.Cryptography;

namespace SmartFactory
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        public Form1()
        {
            InitializeComponent();
            #region Loading Window 사용을 위한 전처리
            int sleepTime = 1000;
            Thread splashthread = new Thread(new ThreadStart(LoadingScreen.ShowSplashScreen));
            splashthread.IsBackground = true;
            splashthread.Start();
            #endregion


            #region Loading 1
            Thread.Sleep(sleepTime);
            LoadingScreen.UdpateStatusText("Loading 1..");

            try
            {
                Thread.Sleep(sleepTime);
                LoadingScreen.UdpateStatusTextWithStatus("Loading 1 OK", TypeOfMessage.Success);
                Thread.Sleep(sleepTime);
            }
            catch (System.Exception ex)
            {
                LoadingScreen.UdpateStatusTextWithStatus("Loading 1 Fail", TypeOfMessage.Error);
                Environment.Exit(0);
            }
            #endregion


            #region Loading 2
            LoadingScreen.UdpateStatusText("Loading 2..");

            try
            {
                Thread.Sleep(sleepTime);
                LoadingScreen.UdpateStatusTextWithStatus("Loading 2 OK", TypeOfMessage.Success);
                Thread.Sleep(sleepTime);
            }
            catch (System.Exception ex)
            {
                LoadingScreen.UdpateStatusTextWithStatus("Loading 2 Fail", TypeOfMessage.Error);
                Environment.Exit(0);
            }
            #endregion


            LoadingScreen.CloseSplashScreen();
        }

         
        private void bt_addP_Click(object sender, EventArgs e)
        {
            ProductAct pa = new ProductAct();
            pa.Show();
        }

        private void bt_Pro_Click(object sender, EventArgs e)
        {
            StartFactory sf = new StartFactory();
            sf.Show();
               
        }

        private void bt_conP_Click(object sender, EventArgs e)
        {
            Process pc = new Process();
            pc.Show();
        }

        private void bt_addinFo_Click(object sender, EventArgs e)
        {
            addinfoPart ap = new addinfoPart();
            ap.Show();
        }

        private void bt_pConsult_Click(object sender, EventArgs e)
        {
            Consult cs = new Consult();
            cs.Show();
            
        }

        private void bt_addPart_Click(object sender, EventArgs e)
        {
            inputPart ip = new inputPart();
            ip.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
