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
    public partial class FormThemMoiNguoiDung : Form
    {
        private string sqlConnectString = "Data Source=DESKTOP-0LCSSEC;Initial Catalog=QuanLyBanHang;Integrated Security=True";
        private SqlConnection mySqlConnection;
        private SqlCommand mySqlCommand;
        public FormThemMoiNguoiDung()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormThemMoiNguoiDung_Load(object sender, EventArgs e)
        {
            mySqlConnection = new SqlConnection(sqlConnectString);
            mySqlConnection.Open();
        }

        private void btnThemMoiDuLieu_Click(object sender, EventArgs e)
        {
            if (!checkInput())
            {
                string fullname = txtFullName.Text;
                string username = txtUserName.Text;
                string password = txtMatKhau.Text;

                string sqlStringExcute = "insert into [Users] (fullname,username,password) values ('"+fullname+"','"+username+"','"+password+"')";

                mySqlCommand = new SqlCommand(sqlStringExcute, mySqlConnection);
                if (mySqlCommand.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("thành công");
                    
                }
                else
                {
                    MessageBox.Show("Thất bại");
                }
            }
        }

        private bool checkInput()
        {
            if (txtFullName.Text.Trim() == "" || txtUserName.Text.Trim() == ""||txtMatKhau.Text.Trim()=="")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu!!","Thông báo");
                return true;
            }
           String sqlStringExcute = "select userID from Users where username = '"+txtUserName.Text+"'";
           mySqlCommand = new SqlCommand(sqlStringExcute, mySqlConnection);
           SqlDataReader dtReader =  mySqlCommand.ExecuteReader();
           if (dtReader.HasRows)
           {
               MessageBox.Show("Tên đăng nhập đã được sử dụng, vui lòng thử lại!!", "Thông báo");
               dtReader.Close();
               return true;
           }
           dtReader.Close();
            return false;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {

            Close();
            UserForm userForm = new UserForm();
            userForm.Show();
            
        }
    }
}
