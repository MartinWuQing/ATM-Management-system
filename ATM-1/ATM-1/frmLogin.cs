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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        public  static string username = null;


        int i = 0;
        private void label1_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// 1.点击确定
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLogin_Click(object sender, EventArgs e)
        {
            #region //使用类封装
            string sql = "select * from UserInfo Where UserName='" + txtUserName.Text.Trim().ToLower() + "'and UserPwd='" + txtPassWord.Text.Trim() + "' ";
               if( OprateDB.ExecuteReader(sql))
               {
                   //写上用户名
                   username = txtUserName.Text.Trim().ToLower(); 
                   frmOperate frm = new frmOperate();
                   frm.Show();
                  this.Hide();

               }
               else
               {
                   i++;
                   if(i==1)
                   {
                       MessageBox.Show("用户名或密码错误，您还有二次机会");
                  MessageBox.Show("用户名或密码错误", "出错了",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                   }
                   if(i==2)
                   {

                       MessageBox.Show("用户名或密码错误，您还有一次机会");
                       MessageBox.Show("用户名或密码错误", "出错了",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);

                   }

                   if (i == 3)
                   {

                       MessageBox.Show("用户名或密码错误，您还有0次机会");
                       MessageBox.Show("卡已被锁定", "请30分钟再试！",
                       MessageBoxButtons.OK, MessageBoxIcon.Error);
                       i = 0;

                   }


               }
            
            
            
            
            
            #endregion        
        }

        private void txtUserName_MouseHover(object sender, EventArgs e)
        {
            txtUserName.Focus();
        }

       
        private void txtUserName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                txtPassWord.Focus();

            }
        }

        private void txtPassWord_MouseHover(object sender, EventArgs e)
        {
            txtPassWord.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtUserName.Text = "";
            txtPassWord.Text  = "";
        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPassWord_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            //播放音乐
            SoundPlayer sp1 = new SoundPlayer();
            //SoundPlayer sp2 = new SoundPlayer();
            //sp2.SoundLocation = @"C:\Users\Administrator\Desktop\ATM-V1.0\qukuan.WAV";
            sp1.SoundLocation = @"C:\Users\Administrator\Desktop\ATM-V1.0\纯音乐 - Kiss The Rain - 纯音乐版.WAV";
            sp1.Play();

            //sp2.Play();
        }

        private void txtPassWord_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                txtUserName.Focus();

            }
        }
    }
}
