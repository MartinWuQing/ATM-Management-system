using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data .SqlClient ;
using System.Media;

namespace ATM_1
{
    public partial class TransferMoney1 : Form
    {
        public TransferMoney1()
        {
            InitializeComponent();
        }

        private void btnzhuanzhang_Click(object sender, EventArgs e)
        {
            //转账预处理
            string connString = @" Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\ATM.mdf;Integrated Security=True";
            string sqlck = "select UserMoney from StudengInfomation where UserName1='" + frmLogin.username + "' ";
            SqlConnection conn = new SqlConnection(connString);
            conn.Open();
            SqlCommand command = new SqlCommand(sqlck, conn);
            SqlDataReader dr = command .ExecuteReader();
            if (dr.Read())
            {
                if (this.txtjine.Text == "")
                {
                    MessageBox.Show("取款金额不能为空");
                    txtjine.Focus();
                }
                else if (int.Parse(this.txtjine.Text) <= 0)
                {
                    MessageBox.Show("金额大于0！");
                    this.txtjine.Text = "";
                    txtjine.Focus();

                }
                else if (float.Parse(this.txtjine.Text) > float.Parse(dr["UserMoney"].ToString().Trim()))
                {
                    MessageBox.Show("您的账户余额不足！");
                    this.txtjine.Text = "";
                    txtjine.Focus();
                }
                else if (int.Parse(this.txtjine.Text) % 50 != 0)
                {
                    MessageBox.Show("金额必须为50的倍数！");
                    this.txtjine.Text = "";
                    txtjine.Focus();

                }
                else
                {
                    //马老师指导
                    decimal a = Convert.ToDecimal(txtjine.Text.Trim());
                    decimal b = Convert.ToDecimal(txtzhanghao.Text.Trim());

                    string sql = "update StudengInfomation set UserMoney=UserMoney+'" + a + "' where UserID='" + b + "' ";

                    string sqll = "update StudengInfomation set UserMoney=UserMoney-'" + a + "' where UserName1='" + frmLogin.username + "' ";
                    if (OprateDB.ExecuteNonQuery(sql) == 1)
                    {
                        if (OprateDB.ExecuteNonQuery(sqll) == 1)
                        {
                            MessageBox.Show("转账成功！");

                        }
                        else
                        {
                            MessageBox.Show("转账失败！");
                        }
                    }
                    else
                    {
                        MessageBox.Show("转账失败！");
                    }
                }//大else 结尾
            }//if结尾
            conn.Close();
            dr.Close();

         }

        private void txtzhanghao_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtjine_TextChanged(object sender, EventArgs e)
        {

        }

        private void TransferMoney1_Load(object sender, EventArgs e)
        {
            SoundPlayer sp = new SoundPlayer();
            sp.SoundLocation = @"C:\Users\Administrator\Desktop\ATM-V1.0\zhuangzhang.WAV";
            sp.Play();
        }//private结尾
    }//public 结尾
}//namespace结尾
