
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tulpep.NotificationWindow;
using MySql.Data.MySqlClient;
using System.Threading;

namespace SmartFactory
{
    public partial class StartFactory : MetroFramework.Forms.MetroForm
    {
        MySqlConnection conn =
      new MySqlConnection("Server=127.0.0.1;Database=GOLONGX2;Uid=root;Pwd=tiger;");

        public StartFactory()
        {
            InitializeComponent();

           

            this.Load += StartFactory_Load;
            this.btnStart.Click += Click_btnStart;
            this.btnStop.Click += Click_btnStop;
           

            // BackgroundWorker 
            this.bgWorker.DoWork += bgWorker_DoWork;
            this.bgWorker.ProgressChanged += bgWorker_ProgressChanged;
            this.bgWorker.RunWorkerCompleted += bgWorker_RunWorkerCompleted;
        }


       

        private void StartFactory_Load(object sender, EventArgs e)
        {
            try
            {
                // 작업 취소를 사용
                this.bgWorker.WorkerSupportsCancellation = true;

                // 작업 진행률 업데이트 보고를 사용
                this.bgWorker.WorkerReportsProgress = true;
                this.btnStart.Enabled = true;
                this.btnStop.Enabled = false;

                this.lblStatus.Text = "0";
            }
            catch (Exception ex)
            {
                throw new Exception("오류가 발생했습니다", ex);
            }

           // pb_Pause.Visible = true;
           // pb_Start.Visible = false;
        }




       

        /// <summary>
        /// 처리할 작업입니다.
        /// </summary>
        private void DoWork(BackgroundWorker worker, DoWorkEventArgs e)
        {
            /*
             * 실행중인 Form 과 다른 쓰레드에서 동작하므로 
             * 처리할 메서드에서는 UI 객체의 속성값(Value, Text 등..)을 사용하지 못합니다.
             * 
             * 작업에 필요한 값은 매개변수로 전달받아야 하고 UI객체의 상태를 변화시킬 필요가 있는 경우
             * ProgressChanged
             * RunWorkerCompleted
             * 이벤트를 사용해야 합니다.
             */

            double nMax = 100.0;
            int nExe = 0;




            conn.Open();
            List<String> testlist = new List<String>();

            //partlist.View = View.Details;
            MySqlDataAdapter adpt = new MySqlDataAdapter("select * from essential", conn);
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            //partlist.Items.Clear();

            MySqlDataAdapter adpt2 = new MySqlDataAdapter("select * from partdb", conn);
            DataTable dt2 = new DataTable();
            adpt.Fill(dt2);

            //for (int i = 0; i < dt.Rows.Count; i++)
            //{
            //    DataRow ddr = dt.Rows[i];
            //    ListViewItem listitem = new ListViewItem(ddr["ess_num"].ToString());
            //    //listitem.SubItems.Add(ddr["part_name"].ToString());
            //    // listitem.SubItems.Add(ddr["part_size"].ToString());
            //    // listitem.SubItems.Add(ddr["part_stock"].ToString());
            //    partlist.Items.Add(listitem);
            //}


            int a = 1;
            int b = int.Parse(comboBox1.Text);
            //실패 횟수
            int p = 0;
            //성공 횟수
            int o = 0;
            //불량코드
            string str = "";
            //완료코드
            string str1 = "";
            //개수
            int vvv = 4;
            int rrr;
            int yyy;
            int ttt = 100 / (dt.Rows.Count - 1);
            textBox1.Clear();
            double v = b * dt.Rows.Count;
            string sss = "bad size";
           // DateTime dtt;
            string abc = DateTime.Now.ToShortDateString();
            //공정시작
            while (a <= b)
            {
                int k = 0;
                Random ran = new Random();
                int ccc = ran.Next(1, 8);
                if (worker.CancellationPending)
                {
                    e.Cancel = true;
                    break;
                }
                else
                {

                    if (ErrorFlag)
                    {
                        ErrorFlag = false;
                        throw new Exception("예외 발생 시뮬레이션");
                    }

                    textBox1.Text += a + "번째 공정 시작 " + Environment.NewLine;
                    // textBox1.AppendText(a + "번쨰 공정 시작 ");
                    for (int j = 1; j < dt.Rows.Count; j++)
                    {
                        DataRow ddr = dt.Rows[j];
                        string bbb = ddr["ess_num"].ToString();
                        textBox1.Text += "부품 명  " + bbb + "공정 시작 " + Environment.NewLine;

                        string code2 = "update partdb set part_stock = part_stock - 4 where part_code = '" + bbb + "'";
                        MySqlCommand command2 = new MySqlCommand(code2, conn);
                        command2.ExecuteNonQuery();

                        //   textBox1.AppendText("부품 명 : " + bbb + " 공정 시작 ");
                        // DelaySystem(1000);
                        Thread.Sleep(500);
                        worker.ReportProgress((int)((j * ttt / nMax) * 100));


                        //불량 공정
                        if (j == ccc)
                        {
                            str = a.ToString() + "_" + bbb;
                            textBox1.Text += "불량부품 : " + bbb + Environment.NewLine;
                            rrr = a;
                           // MessageBox.Show(rrr.ToString());
                            string code = "insert into defectcheck(defe_num, defe_code,inpro_num1) values('" + bbb + "_" + j + "_" + a + "','" + str + "','"+sss.ToString()+"')";
                            MySqlCommand command1 = new MySqlCommand(code, conn);
                            command1.ExecuteNonQuery();
                            p++;
                           // Thread.Sleep(1000);
                            break;
                        }
                        else
                        {
                            k++;
                        }

                    }

                    //완료 공정
                    if (k == dt.Rows.Count - 1)
                    {

                        //MessageBox.Show("성공");
                        str1 = a.ToString() + "_pro";
                        yyy = a;
                        string code1 = "insert into success(succ_num, inpro_num,todate) values('" + a + "_" + b + "','" + str1 + "','"+abc.ToString()+"')";
                        MySqlCommand command2 = new MySqlCommand(code1, conn);
                        command2.ExecuteNonQuery();


                        // int dr = int.Parse(ddr["part_code"]);

                        o++;
                       // Thread.Sleep(1000);
                    }
                    a++;
                    // 시간이 걸리는 작업을 실행합니다.
                    // System.Threading.Thread.Sleep(200);
                    //  nExe++;

                    // 진행률 업데이트하기 위해 ProgressChanged 이벤트를 발생시킵니다.

                }



            }
            textBox1.Text += "성공 : " + o + "실패 : " + p + Environment.NewLine;
            conn.Close();

            //while (nMax > nExe)
            //{
            //    // 작업이 취소 요청이 되었는지 검사
            //    if (worker.CancellationPending)
            //    {
            //        e.Cancel = true;
            //        break;
            //    }
            //    else
            //    {
            //        if (ErrorFlag)
            //        {
            //            ErrorFlag = false;
            //            throw new Exception("예외 발생 시뮬레이션");
            //        }

            //        // 시간이 걸리는 작업을 실행합니다.
            //        System.Threading.Thread.Sleep(200);
            //        nExe++;

            //        // 진행률 업데이트하기 위해 ProgressChanged 이벤트를 발생시킵니다.
            //        worker.ReportProgress((int)((nExe / nMax) * 100));
            //    }
            //}
        }



        private void AppendMessage(string message)
        {
            textBox1.AppendText($"[{DateTime.Now:yyyy-MM-dd HH:mm:ss}]: {message}{Environment.NewLine}");
            textBox1.ScrollToCaret();
            
        }


  

        /// <summary>
        /// 시작버튼 클릭
        /// </summary>
        private void Click_btnStart(object sender, EventArgs e)
        {

           

            try
            {
                
                this.progressBar.Value = 0;
               // this.progressBar.Maximum = 100;
               // this.progressBar.Step = 1;

                this.lblStatus.Text = "0";

                this.btnStart.Enabled = false;
                this.btnStop.Enabled = true;

                this.Cursor = Cursors.WaitCursor;

                AppendMessage("작업을 시작합니다.");

                // 비동기로 작업을 시작합니다. DoWork 이벤트를 발생
                this.bgWorker.RunWorkerAsync(null);
            }
            catch (Exception ex)
            {
                throw new Exception("오류가 발생했습니다", ex);
            }

            PopupNotifier popup = new PopupNotifier();
            popup.Image = Properties.Resources.warning;
            popup.TitleText = "공정을 시작합니다";
            popup.ContentText = "작업이 진행중입니다.";
            popup.Popup();

            //pb_Start.Visible = true;
            //pb_Pause.Visible = false;
        }

        private void Click_btnStop(object sender, EventArgs e)
        {
            try
            {
                // 작업 취소요청
                this.bgWorker.CancelAsync();
            }
            catch (Exception ex)
            {
                throw new Exception("오류가 발생했습니다", ex);
            }
            //pb_Pause.Visible = true;
            //pb_Start.Visible = false;
        }


        private void Click_btnError(object sender, EventArgs e)
        {
            ErrorFlag = true;
        }

        /// <summary>
        /// 작업을 시작
        /// </summary>
        private void bgWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            this.DoWork((BackgroundWorker)sender, e);
            e.Result = null;

            //try
            //{
            //    this.DoWork((BackgroundWorker)sender, e);
            //    e.Result = null;
            //}
            //catch (Exception ex)
            //{
            //    throw new Exception("오류가 발생했습니다", ex);
            //}
        }

        /// <summary>
        /// 작업 진행률을 업데이트
        /// </summary>
        private void bgWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            try
            {
                this.progressBar.Value = e.ProgressPercentage;
                int nTmp = 0;
                int.TryParse(this.lblStatus.Text, out nTmp);
                nTmp++;
                this.lblStatus.Text = nTmp.ToString();
            }
            catch (Exception ex)
            {
                throw new Exception("오류가 발생했습니다", ex);
            }
        }

        /// <summary>
        /// 작업이 완료상태(예외, 취소, 완료)가 되면 발생하는 이벤트입니다
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bgWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            try
            {
                if (e.Error != null)    // 예외 발생
                {
                    AppendMessage(String.Format("{0} ==> {1}", "예외가 발생했습니다.", e.Error.Message));
                }
                else if (e.Cancelled)   // 작업취소
                {
                    AppendMessage("작업이 취소되었습니다.");
                }
                else                    // 완료
                {
                    AppendMessage("작업이 완료되었습니다.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception("오류가 발생했습니다", ex);
            }
            finally
            {
                this.btnStart.Enabled = true;
                this.btnStop.Enabled = false;
                this.Cursor = Cursors.Default;
            }
        }

       

        private static bool ErrorFlag = false;

        private void metroLabel2_Click(object sender, EventArgs e)
        {

        }
    }




}


            

 