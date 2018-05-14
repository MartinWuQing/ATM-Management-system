using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Media;

namespace ATM_1
{
    public partial class cunkuan : Form
    {
        public cunkuan()
        {
            InitializeComponent();
           
             
        }
          
           

        private void button1_Click(object sender, EventArgs e)
        {


            //取钱预处理
            string connString = @" Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\ATM.mdf;Integrated Security=True";
            string sqlck = "select UserMoney from StudengInfomation where UserName1='" + frmLogin.username + "' ";
            SqlConnection conn = new SqlConnection(connString);
            conn.Open();
            SqlCommand command = new SqlCommand(sqlck, conn);
            SqlDataReader dr = command.ExecuteReader();
            if (dr.Read())
            {
                if (this.txtcunkuan.Text == "")
                {
                    MessageBox.Show("存款金额不能为空");
                    txtcunkuan.Focus();
                }
                else if (int.Parse(this.txtcunkuan.Text) <= 0)
                {
                    MessageBox.Show("金额大于0！");
                    this.txtcunkuan.Text = "";
                    txtcunkuan.Focus();

                }

              


                else if (int.Parse(this.txtcunkuan.Text) % 50 != 0)
                {
                    MessageBox.Show("金额必须为50的倍数！");
                    this.txtcunkuan.Text = "";
                    txtcunkuan.Focus();

                }
                else
                {
                    //取钱处理
                    decimal a = Convert.ToDecimal(txtcunkuan.Text.Trim());
                    string sql = "update StudengInfomation set UserMoney=UserMoney+'" + a + "' where UserName1='" + frmLogin.username + "' ";
                    if (OprateDB.ExecuteNonQuery(sql) == 1)
                    {

                        MessageBox.Show("存款成功！");
                    }
                    else
                    {
                        MessageBox.Show("存款失败！");

                    }
                }//大else结尾
            }//if结尾\
            conn.Close();
            dr.Close();
        }

        private void txtcunkuan_TextChanged(object sender, EventArgs e)
        {

        }

        private void cunkuan_Load(object sender, EventArgs e)
        {
            SoundPlayer sp = new SoundPlayer();
            sp.SoundLocation = @"C:\Users\Administrator\Desktop\ATM-V1.0\cunkuan.WAV";
            sp.Play();
        }
    }
}
