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

namespace ProjectShop
{
    public partial class frmSuaThongTin : Form
    {
        private string id;
        private SqlConnection mySqlConnection ;
        private SqlCommand mySqlCommand;
        private string sqlConnectString = "Data Source=DESKTOP-0LCSSEC;Initial Catalog=QuanLyBanHang;Integrated Security=True";
        public frmSuaThongTin()
        {
            InitializeComponent();
        }
        public frmSuaThongTin( string a)
        {
            InitializeComponent();
            id = a;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {

        }

        private void frmSuaThongTin_Load(object sender, EventArgs e)
        {
            mySqlConnection = new SqlConnection(sqlConnectString);
            mySqlConnection.Open();
            string sqlStringExcuteSelect = "select * from Users where userID = "+Convert.ToInt32(id);
            mySqlCommand = new SqlCommand(sqlStringExcuteSelect, mySqlConnection);
            SqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();

            
        }
    }
}
