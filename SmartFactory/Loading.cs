using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartFactory
{
    public partial class Loading : Form
    {

        delegate void StringParameterDelegate(string Text);
        delegate void StringParameterWithStatusDelegate(string Text, TypeOfMessage tom);
        delegate void SplashShowCloseDelegate();

        bool CloseSplashScreenFlag = false;
        public Loading()
        {
            InitializeComponent();

            this.label1.Parent = this.pictureBox1;
            label1.Text = "Wait";
            label1.ForeColor = Color.Green;
        }


        public void ShowSplashScreen()
        {
            if (InvokeRequired)
            {
                BeginInvoke(new SplashShowCloseDelegate(ShowSplashScreen));
                return;
            }
            this.Show();
            Application.Run(this);
        }

        public void CloseSplashScreen()
        {
            if (InvokeRequired)
            {
                BeginInvoke(new SplashShowCloseDelegate(CloseSplashScreen));
                return;
            }
            CloseSplashScreenFlag = true;
            this.Close();
        }

        public void UdpateStatusText(string Text)
        {
            if (InvokeRequired)
            {
                BeginInvoke(new StringParameterDelegate(UdpateStatusText), new object[] { Text });
                return;
            }
            label1.ForeColor = Color.Green;
            label1.Text = Text;
        }

        public void UdpateStatusTextWithStatus(string Text, TypeOfMessage tom)
        {
            if (InvokeRequired)
            {
                BeginInvoke(new StringParameterWithStatusDelegate(UdpateStatusTextWithStatus), new object[] { Text, tom });
                return;
            }

            switch (tom)
            {
                case TypeOfMessage.Error:
                    label1.ForeColor = Color.Red;
                    break;
                case TypeOfMessage.Warning:
                    label1.ForeColor = Color.Yellow;
                    break;
                case TypeOfMessage.Success:
                    label1.ForeColor = Color.Green;
                    break;
            }
            label1.Text = Text;

        }

        private void SplashForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (CloseSplashScreenFlag == false)
                e.Cancel = true;
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            FormEffect(this);
        }


        // 이 메서드를 이용하게 된다.
        private void FormEffect(Form fm)
        {
            double[] opacity = new double[] { 0.1d, 0.3d, 0.7d, 0.8d, 0.9d, 1.0d };
            int cnt = 0;
            System.Windows.Forms.Timer tm = new System.Windows.Forms.Timer();
            {
                fm.RightToLeftLayout = false;
                fm.Opacity = 0d;
                tm.Interval = 70;   // 나타나는 속도를 조정함.          
                tm.Tick += delegate (object obj, EventArgs e)
                {
                    if ((cnt + 1 > opacity.Length) || fm == null)
                    {
                        tm.Stop();
                        tm.Dispose();
                        tm = null;
                        return;
                    }
                    else
                    {
                        fm.Opacity = opacity[cnt++];
                    }
                };
                tm.Start();
            }
        }

        
    

    }
}
