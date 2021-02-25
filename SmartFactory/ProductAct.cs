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
    public partial class ProductAct : MetroFramework.Forms.MetroForm
    {
        MySqlConnection conn =
       new MySqlConnection("Server=127.0.0.1;Database=GOLONGX2;Uid=root;Pwd=tiger;");

        public ProductAct()
        {
            InitializeComponent();
        }

        private void bt_Add_Click(object sender, EventArgs e)
        {
            string code = "insert into prodb(pro_code, pro_name, pro_cap, pro_gra) values('" + tb_model.Text + "','" + tb_code.Text + "','" + tb_energy.Text + "','" + tb_volume.Text + "')";

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
            
            ProductAct_Load(sender, e);

            


        }

        private void lb_1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           


        }

        

        private void ProductAct_Load(object sender, EventArgs e)
        {
            //tb_model.Text = lb_1.Text;
        }

        
        private void bunifuFlatButton1_Click_1(object sender, EventArgs e)
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

        private void lb_1_MouseHover(object sender, EventArgs e)
        {
            this.toolTip1.ToolTipTitle = "REMOTE";
            this.toolTip1.IsBalloon = true;
          //  this.toolTip1.SetToolTip(this.lb_1, "TB_1 2세대 리모컨 입니다.");
        }
    }
}
