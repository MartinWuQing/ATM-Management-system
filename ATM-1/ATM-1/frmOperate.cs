using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ATM_1
{
    public partial class frmOperate : Form
    {
        public frmOperate()
        {
            InitializeComponent();
        }

        private void btnBalance_Click(object sender, EventArgs e)
        {
            frmBalance fb = new frmBalance();
            fb.Show();
        }

        private void btnChangePassWord_Click(object sender, EventArgs e)
        {
            frmChangePassWord fcpw = new frmChangePassWord();
            fcpw.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmDetail fd = new frmDetail();
            fd.Show();

        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            frmLogin fl = new frmLogin();
            fl.Show();
            this.Close();
        }

        private void btnSaveMoney_Click(object sender, EventArgs e)
        {
            cunkuan ck = new cunkuan();
            ck.Show();

        }

        private void btnGetMoney_Click(object sender, EventArgs e)
        {
            qukuan qk = new qukuan();
            qk.Show();
        }

        private void btnChageMony_Click(object sender, EventArgs e)
        {
            TransferMoney1 tm = new TransferMoney1();
            tm.Show();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            frmLogin fl = new frmLogin();
            fl.Show();
            this.Close();
        }

        private void frmOperate_Load(object sender, EventArgs e)
        {

            SoundPlayer sp=new SoundPlayer ();
            sp.SoundLocation = @"C:\Users\Administrator\Desktop\ATM-V1.0\1月7日 12点51分.WAV";
            sp.Play();

            
        }
    }
}
