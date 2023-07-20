using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;

namespace DevExpressExample
{
    public partial class Login : DevExpress.XtraEditors.XtraForm
    {
        public Login()
        {
            InitializeComponent();
        }

        // 로그인
        private void LoginBtn_Click(object sender, EventArgs e)
        {
            int counter = 0;

            if (IdBox.Text.Length == 0)
                IdLabel.Text = "아이디를 입력하세요.";  else{ IdLabel.Text = ""; counter++;}
            if (PasswordBox.Text.Length == 0)
                PasswordLabel.Text = "패스워드를 입력하세요."; else{ PasswordLabel.Text = ""; counter++;}

            if (counter == 2)
            {
                LoginUserId(IdBox.Text, PasswordBox.Text);
            }
        }


        // 로그인 아이디 조회
        public void LoginUserId(string login_Id, string login_Password)
        {
            bool login = false;

            // DB와 연결
            string connectionString = string.Format("Server={0};Database={1};Uid={2}; Pwd={3};", "NOVA", "UserDB", "nova", "1954");

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
               
                string sql = $"select * from [UserInfo] WHERE id='{login_Id}'";

                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader mdr = cmd.ExecuteReader();
                while (mdr.Read())
                {
                    if (login_Id == (string)mdr["id"] && login_Password == (string)mdr["password"])
                    {
                        login = true;
                        Prograｍ.MainForm.Show();
                        this.Hide();
                    }
                }
                mdr.Close();

                if (!login)
                {
                    MessageBox.Show("아이디 혹은 비밀번호가 맞지 않습니다.", "로그인", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // 비밀번호 가리기
        private void PasswordBox_TextChanged(object sender, EventArgs e)
        {
            if (PasswordBox.PasswordChar == (char)0)
            {
                PasswordBox.PasswordChar = '*';
            }
        }

        // 회원가입
        private void UserCreate_Click(object sender, EventArgs e)
        {
            new UserCreate().ShowDialog();
        }

        // 아이디/비밀번호 찾기
        private void FindId_Click(object sender, EventArgs e)
        {
            new FindId().ShowDialog();
        }

    }
}