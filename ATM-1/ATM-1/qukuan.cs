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
    public partial class qukuan : Form
    {
        public qukuan()
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
            SqlDataReader dr = command .ExecuteReader();
            if(dr.Read ())
            {
                if (this.txtqukuan.Text == "")
                {
                    MessageBox.Show("取款金额不能为空");
                    txtqukuan.Focus();
                }
                else if (int.Parse(this.txtqukuan.Text) <= 0)
                {
                    MessageBox.Show("金额大于0！");
                    this.txtqukuan.Text = "";
                    txtqukuan.Focus();

                }
                
                else  if (float.Parse(this.txtqukuan.Text) > float.Parse(dr["UserMoney"].ToString().Trim())) 
                {

                    MessageBox.Show("您的账户余额不足！");
                    this.txtqukuan.Text = "";
                    txtqukuan.Focus();
                }

               
                else if (int.Parse(this.txtqukuan.Text) % 50 != 0)
                {
                    MessageBox.Show("金额必须为50的倍数！");
                    this.txtqukuan.Text = "";
                    txtqukuan.Focus();
                
                }
                else 
                {
                //取钱处理
                    decimal a = Convert.ToDecimal(txtqukuan.Text.Trim());
                    string sql = "update StudengInfomation set UserMoney=UserMoney-'" + a + "' where UserName1='" + frmLogin.username + "' ";
                    if (OprateDB.ExecuteNonQuery(sql) == 1)
                    {

                        MessageBox.Show("取款成功！");
                    }
                    else
                    {
                        MessageBox.Show("取款款失败！");

                    }             
                 }//大else结尾
              }//if结尾\
            conn.Close();
            dr.Close();
          }

        private void txtqukuan_TextChanged(object sender, EventArgs e)
        {

        }

        private void qukuan_Load(object sender, EventArgs e)
        {
            SoundPlayer sp = new SoundPlayer();
            sp.SoundLocation = @"C:\Users\Administrator\Desktop\ATM-V1.0\qukuan.WAV";
            sp.Play();
        }//privte结尾 
    }//public
}//namespace结尾
