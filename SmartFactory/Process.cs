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
    public partial class Process : MetroFramework.Forms.MetroForm
    {
        MySqlConnection conn =
     new MySqlConnection("Server=127.0.0.1;Database=GOLONGX2;Uid=root;Pwd=tiger;");

        public Process()
        {
            InitializeComponent();
        }

        private void lk_mon_Click(object sender, EventArgs e)
        {
            Monthprocess mp = new Monthprocess();
            mp.Show();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            ProductAct pa3 = new ProductAct();
            pa3.ShowDialog();
        }

       

        private void bunifuFlatButton2_Click_1(object sender, EventArgs e)
        {
            Process pro3 = new Process();
            pro3.ShowDialog();
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            addinfoPart aip3 = new addinfoPart();
            aip3.ShowDialog();
        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            StartFactory sf3 = new StartFactory();
            sf3.Show();
        }

        private void bunifuFlatButton5_Click(object sender, EventArgs e)
        {
            inputPart ip3 = new inputPart();
            ip3.ShowDialog();
        }

        private void bunifuFlatButton6_Click(object sender, EventArgs e)
        {
            Consult cs3 = new Consult();
            cs3.ShowDialog();
        }

        private void Process_Load(object sender, EventArgs e)
        {
            try
            {
                conn.Open();

                listView2.View = View.Details;
                MySqlDataAdapter adpt = new MySqlDataAdapter("select * from success", conn);
                DataTable dt = new DataTable();
                adpt.Fill(dt);
                listView2.Items.Clear();

                listView1.View = View.Details;
                MySqlDataAdapter adpt1 = new MySqlDataAdapter("select * from prodb", conn);
                DataTable dt1 = new DataTable();
                adpt1.Fill(dt1);
                listView1.Items.Clear();
                

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    DataRow ddr = dt.Rows[i];
                    ListViewItem listitem = new ListViewItem(ddr["succ_num"].ToString());
                    listitem.SubItems.Add(ddr["inpro_num"].ToString());
                    listitem.SubItems.Add(ddr["todate"].ToString());
                    // listitem.SubItems.Add(ddr["part_size"].ToString());
                    // listitem.SubItems.Add(ddr["part_stock"].ToString());
                    listView2.Items.Add(listitem);
                }

               

                for (int i = 0; i < dt1.Rows.Count; i++)
                {
                    DataRow ddr = dt1.Rows[i];
                    ListViewItem listitem = new ListViewItem(ddr["pro_code"].ToString());
                    listitem.SubItems.Add(ddr["pro_name"].ToString());
                    listitem.SubItems.Add(ddr["pro_cap"].ToString());
                    listitem.SubItems.Add(ddr["pro_gra"].ToString());
                    // listitem.SubItems.Add(ddr["part_size"].ToString());
                    // listitem.SubItems.Add(ddr["part_stock"].ToString());
                    listView1.Items.Add(listitem);
                }


                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
