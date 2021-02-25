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
    public partial class addinfoPart : MetroFramework.Forms.MetroForm
    {
        MySqlConnection conn =
      new MySqlConnection("Server=127.0.0.1;Database=GOLONGX2;Uid=root;Pwd=tiger;");

        public addinfoPart()
        {
            InitializeComponent();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            ProductAct pa3 = new ProductAct();
            pa3.ShowDialog();
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
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

        private void addinfoPart_Load(object sender, EventArgs e)
        {
            try
            {
                conn.Open();

                metroListView2.View = View.Details;
                MySqlDataAdapter adpt = new MySqlDataAdapter("select * from partdb", conn);
                DataTable dt = new DataTable();
                adpt.Fill(dt);
                metroListView2.Items.Clear();

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    DataRow ddr = dt.Rows[i];
                    ListViewItem listitem = new ListViewItem(ddr["part_code"].ToString());
                    listitem.SubItems.Add(ddr["part_name"].ToString());
                    // listitem.SubItems.Add(ddr["part_size"].ToString());
                    // listitem.SubItems.Add(ddr["part_stock"].ToString());
                    metroListView2.Items.Add(listitem);
                }

                metroListView1.View = View.Details;
                MySqlDataAdapter adpt1 = new MySqlDataAdapter("select * from prodb", conn);
                DataTable dt1 = new DataTable();
                adpt1.Fill(dt1);
                metroListView1.Items.Clear();

                for (int i = 0; i < dt1.Rows.Count; i++)
                {
                    DataRow ddr = dt1.Rows[i];
                    ListViewItem listitem = new ListViewItem(ddr["pro_code"].ToString());
                    listitem.SubItems.Add(ddr["pro_name"].ToString());
                    // listitem.SubItems.Add(ddr["part_size"].ToString());
                    // listitem.SubItems.Add(ddr["part_stock"].ToString());
                    metroListView1.Items.Add(listitem);
                }





                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            conn.Open();
            if (metroListView1.SelectedItems.Count == 1)
            {

                ListView.SelectedListViewItemCollection items = metroListView2.SelectedItems;

                // ListView.SelectedListViewItemCollection items1 = metroListView3.SelectedItems;
                //ListViewItem lvitem = items[1];
                //ListViewItem lvitem1 = items1[0];
                int row = metroListView1.SelectedItems[0].Index;
                int row1 = metroListView2.SelectedItems[0].Index;
                string a = metroListView1.Items[row].SubItems[0].Text;
                string b = metroListView1.Items[row].SubItems[1].Text;
                string c = metroListView2.Items[row].SubItems[0].Text;

                //string code = "insert into essential(ess_num, pro_code) values(" + a + ',' + b + ")";
                //MySqlCommand command1 = new MySqlCommand(code, conn);
                //command1.ExecuteNonQuery();
                // //command2;

                //for (int i=0; i < metroListView2.SelectedItems.Count; i++)
                //{

                //    MySqlCommand command2 = new MySqlCommand("update essential set part_code" + i + " = '" + c + "' where pro_code = '" + b + "'", conn);
                //    command2.ExecuteNonQuery();
                //}

                string code = "insert into essential(ess_num) values('" + a.ToString() + "')";
                MySqlCommand command1 = new MySqlCommand(code, conn);
                command1.ExecuteNonQuery();

                foreach (ListViewItem lvi in items)
                {
                    code = "insert into essential(ess_num) values('" + lvi.Text + "')";
                    command1 = new MySqlCommand(code, conn);
                    command1.ExecuteNonQuery();
                }

                code = "select ess_num from essential order by field(ess_num,'" + a.ToString() + "') desc, ess_num asc";
                command1 = new MySqlCommand(code, conn);
                command1.ExecuteNonQuery();


                //ListViewItem list = new ListViewItem(a);
                //list.SubItems.Add(b);
                //foreach (ListViewItem lvi in items)
                //{

                //    list.SubItems.Add(lvi.Text);
                //}

                //metroListView3.Items.Add(list);

                // metroListView3.Items[0].SubItems[0].Text = a;
                //metroListView3.Items[0].SubItems[1].Text = b;

            }


            //for (int i = 0; i < metroListView1.SelectedItems.Count; i++)
            //{

            //    ListView.SelectedListViewItemCollection items = metroListView2.SelectedItems;
            //    ListView.SelectedListViewItemCollection items1 = metroListView3.SelectedItems;
            //    ListViewItem lvitem = items[0];
            //    ListViewItem lvitem1 = items1[2];
            //    lvitem1.SubItems[j].Text = lvitem.SubItems[i].Text;
            //    j++;
            //}

            conn.Close();
            addinfoPart_Load(sender, e);
        }
    }
}
