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
    public partial class inputPart : MetroFramework.Forms.MetroForm
    {
        MySqlConnection conn =
      new MySqlConnection("Server=127.0.0.1;Database=GOLONGX2;Uid=root;Pwd=tiger;");

        public inputPart()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void bt_save_Click(object sender, EventArgs e)// 저장
        {
            string code = "insert into partdb(part_code, part_name, part_size, part_stock) values('" + tb_code.Text + "','" + tb_name.Text + "','" + textBox2.Text + "','" + textBox1.Text + "')";

            conn.Open();

            MySqlCommand command1 = new MySqlCommand(code, conn);


            try
            {
                if (command1.ExecuteNonQuery() == 1)
                {

                    MessageBox.Show("저장 완료되었습니다.");
                }
                else
                {
                    MessageBox.Show("저장 실패.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            conn.Close();
            inputPart_Load(sender, e);
        }

        private void bt_modify_Click(object sender, EventArgs e)// 수정
        {
            string update1 = "update partdb set part_name = '" + tb_name.Text + "' where part_code = '" + tb_code.Text + "'";
            string update2 = "update partdb set part_size = '" + textBox2.Text + "' where part_code = '" + tb_code.Text + "'";
            string update3 = "update partdb set part_stock = '" + textBox1.Text + "' where part_code = '" + tb_code.Text + "'";

            conn.Open();

            MySqlCommand command1 = new MySqlCommand(update1, conn);
            command1.ExecuteNonQuery();


            MySqlCommand command2 = new MySqlCommand(update2, conn);
            command2.ExecuteNonQuery();


            MySqlCommand command3 = new MySqlCommand(update3, conn);
            command3.ExecuteNonQuery();




            MessageBox.Show("수정 완료되었습니다.");

            conn.Close();
            inputPart_Load(sender, e);
        }

        private void bt_delete_Click(object sender, EventArgs e)// 삭제
        {
            string del = "delete from  partdb where part_code='" + tb_code.Text + "'";

            conn.Open();

            MySqlCommand command1 = new MySqlCommand(del, conn);


            try
            {
                if (command1.ExecuteNonQuery() == 1)
                {

                    MessageBox.Show("삭제 완료되었습니다.");
                }
                else
                {
                    MessageBox.Show("삭제 실패.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            conn.Close();
            inputPart_Load(sender, e);
        }

        private void inputPart_Load(object sender, EventArgs e)
        {
            try
            {
                conn.Open();

                listView1.View = View.Details;
                MySqlDataAdapter adpt = new MySqlDataAdapter("select * from partdb", conn);
                DataTable dt = new DataTable();
                adpt.Fill(dt);
                listView1.Items.Clear();

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    DataRow ddr = dt.Rows[i];
                    ListViewItem listitem = new ListViewItem(ddr["part_code"].ToString());
                    listitem.SubItems.Add(ddr["part_name"].ToString());
                    listitem.SubItems.Add(ddr["part_size"].ToString());
                    listitem.SubItems.Add(ddr["part_stock"].ToString());
                    listView1.Items.Add(listitem);
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
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

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 1)
            {
                ListView.SelectedListViewItemCollection items = listView1.SelectedItems;
                ListViewItem lvitem = items[0];
                tb_code.Text = lvitem.SubItems[0].Text;
                tb_name.Text = lvitem.SubItems[1].Text;
                textBox2.Text = lvitem.SubItems[2].Text;
                textBox1.Text = lvitem.SubItems[3].Text;
            }
        }
    }
}
