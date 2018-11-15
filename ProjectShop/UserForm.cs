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
    public partial class UserForm : Form
    {
        private string sqlConnectString = "Data Source=DESKTOP-0LCSSEC;Initial Catalog=QuanLyBanHang;Integrated Security=True";
        private SqlConnection mySqlConnection;
        private SqlCommand mySqlCommand;
        public UserForm()
        {
            InitializeComponent();
            mySqlConnection = new SqlConnection(sqlConnectString);
            mySqlConnection.Open();

        }

        private void UserForm_Load(object sender, EventArgs e)
        {
            string sqlExcuteString = "select * from Users order by userID";
            mySqlCommand = new SqlCommand(sqlExcuteString,mySqlConnection);

            SqlDataReader myDataReader = mySqlCommand.ExecuteReader();

            DataTable tbUser = new DataTable();
            tbUser.Load(myDataReader);

            dataGridView1.DataSource = tbUser;


        }

        private void btnThemMoiNguoiDung_Click(object sender, EventArgs e)
        {
            Close();
            FormThemMoiNguoiDung frmThemMoi = new FormThemMoiNguoiDung();
            frmThemMoi.Show();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmSuaThongTin frm = new frmSuaThongTin(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString());
            frm.Show();
            
        }
    }
}
