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

namespace ATM_1
{
    public partial class frmChangePassWord : Form
    {
        public frmChangePassWord()
        {
            InitializeComponent();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnok_Click(object sender, EventArgs e)
        {

            //1.先判断两次新密码是否输入一致
            if (txtNewPassWord1.Text.Trim() == txtNewPassWord2.Text.Trim())
            {

                #region//使用类封装
              
                string sqlCheckPwd = "select * from UserInfo Where UserName='" + frmLogin.username + "'and UserPwd='" + txtOldPassWord.Text.Trim() + "' ";
                if(OprateDB .ExecuteReader (sqlCheckPwd ))
                {
                    //更新语句--更新数据库
                    string sql = "update UserInfo set UserPwd='" + txtNewPassWord1.Text.Trim() + "'where UserName='" + frmLogin.username + "' ";

                    if(OprateDB .ExecuteNonQuery(sql)==1)
                    {

                        MessageBox.Show("密码修改成功！");
                    }
                    else
                    {
                        MessageBox.Show("密码修改失败！");

                    }
                }
                else
                {

                    MessageBox.Show("旧密码不正确！");
                }


                
                
                
                #endregion




                
            }
            else
            {
                MessageBox.Show("两次密码输入不一致，请重新输入！");
            
            }
            }

        private void label5_Click(object sender, EventArgs e)
        {
            
        }

      

        private void frmChangePassWord_Load(object sender, EventArgs e)
        {
            label5.Text = frmLogin.username;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtNewPassWord1.Text  = "";
            txtNewPassWord2.Text  = "";
            txtOldPassWord.Text  = "";

        }

        private void txtOldPassWord_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            frmOperate fl = new frmOperate();
            fl.Show();
            this.Close();
        }
    }
}
