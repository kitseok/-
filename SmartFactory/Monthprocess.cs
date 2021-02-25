using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;
using System.Windows.Forms.DataVisualization.Charting;

namespace SmartFactory
{
    public partial class Monthprocess : MetroFramework.Forms.MetroForm
    {

      
        public Monthprocess()
        {
            InitializeComponent();
          


        }
        // AI 분석 임의의 텍스트 출력 
        private void btn_Ai_Click(object sender, EventArgs e)
        {
            StreamReader SR = new StreamReader("4test.txt");    //읽어들일 TXT 파일의 경로를 
                                                                    //매개변수로 StreamReader 생성

            string result = "";                                     //읽은 TXT파일을 저장시킬 변수
            result = SR.ReadToEnd();                                //처음부터 끝까지 읽은 후 저장

            tb_AI.Text = result;                                 //textbox폼에 전체 읽은 문구를 표출
            SR.Close();                                             //StreamReader를 닫아줌


      
        }

        public StreamReader ReadFile(string mir_directory, string mir_fileName)
        {
            //해당 디렉토리가 존재하지 않으면 Null 리턴
            DirectoryInfo di = new DirectoryInfo(mir_directory);
            if (!di.Exists) { return null; }

            //해당 디렉토리에 파일이 존재 하지 않으면 Null 리턴
            FileInfo fi = new FileInfo(mir_directory + @"\" + mir_fileName);
            if (!fi.Exists) { return null; }

            //파일을 읽어 Buffer에 저장, 한글문장일경우 Encoding을 지정해줘야한다.
            StreamReader sr = new StreamReader(mir_directory + @"\" + mir_fileName, Encoding.GetEncoding(949));
            return sr;
        }

        /// <summary>
        /// ReadToEnd() - 버퍼에 있는 모든 텍스트를 한번에 가져온다.
        /// </summary>
        /// <param name="sr">
        public void MirReadToEnd(StreamReader sr)
        {
            if (sr != null)
            {
                tb_AI.Text = sr.ReadToEnd();
            }
        }
        /// <summary>
        /// ReadLie() - 버퍼에 있는 텍스트를 한줄씩 가져온다.
        /// </summary>
        public void MirReadLine(StreamReader sr)
        {
            if (sr != null)
            {
                // Peek() - 버퍼에 있는 다음문자를 int형식으로 복사하여 가져온다.(없을경우 -1을 리턴한다.)
                while (sr.Peek() > -1)
                {
                    tb_AI.Text = tb_AI.Text + "   " + sr.ReadLine();
                }
            }
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void Monthprocess_Load(object sender, EventArgs e)
        {
            mP_4.Visible = false;
            mP_5.Visible = false;
            mP_6.Visible = false;
            chart1.Series[0].Points.Add(3000);
            chart1.Series[1].Points.Add(1000);
            chart1.Series[2].Points.Add(2500);

            chart2.Series[0].Points.Add(1200);
            chart2.Series[1].Points.Add(2700);
            chart2.Series[2].Points.Add(2500);

            chart3.Series[0].Points.Add(1100);
            chart3.Series[1].Points.Add(1700);
            chart3.Series[2].Points.Add(1500);
            /* ===============================================*/
            
            chart4.Series[0].Points.AddXY("10", 2000);
            chart4.Series[0].Points.AddXY("12", 3000);
            chart4.Series[0].Points.AddXY("14", 1500);
            chart4.Series[0].Points.AddXY("15", 1700);
            chart4.Series[0].Points.AddXY("18", 900);

            chart4.Series[1].Points.AddXY("10", 1000);
            chart4.Series[1].Points.AddXY("12", 2000);
            chart4.Series[1].Points.AddXY("14", 1200);
            chart4.Series[1].Points.AddXY("15", 1800);
            chart4.Series[1].Points.AddXY("18", 1500);

            /* ===============================================*/
            chart5.Series[0].Points.AddXY("10", 1500);
            chart5.Series[0].Points.AddXY("12", 1000);
            chart5.Series[0].Points.AddXY("14", 1700);
            chart5.Series[0].Points.AddXY("15", 700);
            chart5.Series[0].Points.AddXY("18", 600);

            chart5.Series[1].Points.AddXY("10", 2000);
            chart5.Series[1].Points.AddXY("12", 1500);
            chart5.Series[1].Points.AddXY("14", 1800);
            chart5.Series[1].Points.AddXY("15", 1200);
            chart5.Series[1].Points.AddXY("18", 1500);

            /* =================================================*/

            chart6.Series[0].Points.AddXY("10", 1100);
            chart6.Series[0].Points.AddXY("12", 900);
            chart6.Series[0].Points.AddXY("14", 1600);
            chart6.Series[0].Points.AddXY("15", 700);
            chart6.Series[0].Points.AddXY("18", 900);

            chart6.Series[1].Points.AddXY("10", 1700);
            chart6.Series[1].Points.AddXY("12", 850);
            chart6.Series[1].Points.AddXY("14", 1800);
            chart6.Series[1].Points.AddXY("15", 540);
            chart6.Series[1].Points.AddXY("18", 1600);




            Random rand = new Random();
            for (int i = 0; i < 5; i++)
            {
                chart4.Series[0].Points.Add(rand.Next(500));
                chart4.Series[1].Points.Add(rand.Next(500));
                chart5.Series[0].Points.Add(rand.Next(500));
                chart5.Series[1].Points.Add(rand.Next(500));
                chart6.Series[0].Points.Add(rand.Next(500));
                chart6.Series[1].Points.Add(rand.Next(500));
            }

            
        

            /*
            for(int i = 0; i<100; i++)
            {
                Thread.Sleep(7500);
                cp_ex.Value = i; //4월 예상
            }

            for (int i = 0; i < 100; i++)
            {
                Thread.Sleep(4500);
                cp_now.Value = i; //4월 예상
            }
            for (int i = 0; i < 100; i++)
            {
                Thread.Sleep(7500);
                bunifuCircleProgressbar2.Value = i; //5월 예상
            }

            for (int i = 0; i < 100; i++)
            {
                Thread.Sleep(4500);
                bunifuCircleProgressbar1.Value = i; //5월 현재
            }
            for (int i = 0; i < 100; i++)
            {
                Thread.Sleep(7500);
                bunifuCircleProgressbar4.Value = i; // 6월 예상
            }

            for (int i = 0; i < 100; i++)
            {
                Thread.Sleep(4500);
                bunifuCircleProgressbar3.Value = i; // 6월 현재
            }

            
            */


        }

        
       

        private void btn_Ai5_Click(object sender, EventArgs e)
        {
            StreamReader SR = new StreamReader("5test.txt");    //읽어들일 TXT 파일의 경로를 
                                                                //매개변수로 StreamReader 생성

            string result = "";                                     //읽은 TXT파일을 저장시킬 변수
            result = SR.ReadToEnd();                                //처음부터 끝까지 읽은 후 저장

            textBox1.Text = result;                                 //textbox폼에 전체 읽은 문구를 표출
            SR.Close();                                             //StreamReader를 닫아줌

        }

        private void mP_5_Paint(object sender, PaintEventArgs e)
        {
          
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
          if(treeView1.SelectedNode.Text == "4월 지표")
          {
                mP_4.Visible = true;
                mP_5.Visible = false; 
                mP_6.Visible = false;



          }
            if (treeView1.SelectedNode.Text == "5월 지표")
            {
                mP_4.Visible = true;
                mP_5.Visible = true;
                mP_6.Visible = false;



            }
            if (treeView1.SelectedNode.Text == "6월 지표")
            {
                mP_4.Visible = true;
                mP_5.Visible = true;
                mP_6.Visible = true;



            }
        }

        private void mP_6_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void btn_AI6_Click(object sender, EventArgs e)
        {
            StreamReader SR = new StreamReader("6test.txt");    //읽어들일 TXT 파일의 경로를 
                                                                //매개변수로 StreamReader 생성

            string result = "";                                     //읽은 TXT파일을 저장시킬 변수
            result = SR.ReadToEnd();                                //처음부터 끝까지 읽은 후 저장

            tb_AI6.Text = result;                                 //textbox폼에 전체 읽은 문구를 표출
            SR.Close();                                             //StreamReader를 닫아줌
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e) // 제품 추가 버튼
        {
            ProductAct pAc = new ProductAct();
            pAc.ShowDialog();

        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e) // 제품 관리 버튼
        {
            Process pcs = new Process();
            pcs.ShowDialog();
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)// 제품별 부품 추가 버튼
        {
            addinfoPart aip = new addinfoPart();
            aip.ShowDialog();
        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)// 공정현황
        {
            StartFactory sfa = new StartFactory();
            sfa.Show();
        }

        private void bunifuFlatButton5_Click(object sender, EventArgs e) // 부품 추가
        {
            inputPart ipa = new inputPart();
            ipa.ShowDialog();
        }

        private void bunifuFlatButton6_Click(object sender, EventArgs e) // 부품 관리
        {
            Consult csu = new Consult();
            csu.ShowDialog();
        }

        
    }
}
