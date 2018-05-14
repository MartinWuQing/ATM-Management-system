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
    public partial class frmBalance : Form
    {
        public frmBalance()
        {
            InitializeComponent();
        }

        private void frmBalance_Load(object sender, EventArgs e)
        {
            BindData();
        }
       
        
        void BindData()
        {

            string sql = "select UserID as 用户帐号,UserName1 as 姓名,UserSex as 性别,UserMoney as 账户余额 from StudengInfomation where UserName1='"+frmLogin .username +"'";
            SqlConnection conn = new SqlConnection(OprateDB.ConnString);
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql,conn);
            //填充数据的语句

          SqlDataAdapter da = new SqlDataAdapter();
          DataSet ds = new DataSet();
          
            da.SelectCommand = cmd;
            da.Fill(ds);

            DataGridView1.DataSource = ds.Tables[0];
            conn.Close();
        
        
        
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        
    }
}
