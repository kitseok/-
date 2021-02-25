using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SmartFactory
{
    public partial class Consult : MetroFramework.Forms.MetroForm
    {

        MySqlConnection conn =
       new MySqlConnection("Server=127.0.0.1;Database=GOLONGX2;Uid=root;Pwd=tiger;");

        public Consult()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Consult_Load(object sender, EventArgs e)
        {

            try
            {
                conn.Open();

                metroListView2.View = View.Details;
                MySqlDataAdapter adpt = new MySqlDataAdapter("select * from defectcheck", conn);
                DataTable dt = new DataTable();
                adpt.Fill(dt);
                metroListView2.Items.Clear();

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    DataRow ddr = dt.Rows[i];
                    ListViewItem listitem = new ListViewItem(ddr["defe_num"].ToString());
                    listitem.SubItems.Add(ddr["defe_code"].ToString());
                    listitem.SubItems.Add(ddr["inpro_num1"].ToString());
                    // listitem.SubItems.Add(ddr["part_size"].ToString());
                    // listitem.SubItems.Add(ddr["part_stock"].ToString());
                    metroListView2.Items.Add(listitem);
                }


                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        
        private void bunifuFlatButton1_Click_1(object sender, EventArgs e) // 제품추가
        {
            ProductAct pa2 = new ProductAct();
            pa2.ShowDialog();
        }

        private void bunifuFlatButton2_Click_1(object sender, EventArgs e) // 제품 관리
        {
            Process pro2 = new Process();
            pro2.ShowDialog();
        }

        private void bunifuFlatButton3_Click_1(object sender, EventArgs e) // 제품별 부품 추가
        {
            addinfoPart aip2 = new addinfoPart();
            aip2.ShowDialog();
        }

        private void bunifuFlatButton4_Click_1(object sender, EventArgs e) // 공정 현황
        {
            StartFactory sf2 = new StartFactory();
            sf2.Show();
        }

        private void bunifuFlatButton5_Click_1(object sender, EventArgs e) // 부품 추가
        {
            inputPart ip2 = new inputPart();
            ip2.ShowDialog();
        }

        private void bunifuFlatButton6_Click_1(object sender, EventArgs e) // 부품 관리

        {
            Consult cs2 = new Consult();
            cs2.ShowDialog();
        }
    }
}
