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
    public partial class FindId : DevExpress.XtraEditors.XtraForm
    {

        public FindId()
        {
            InitializeComponent();
        }

        // 아이디 찾기 버튼
        private void FindIdBtn_Click(object sender, EventArgs e)
        {
            int counter = 0;

            if (NameBox.Text.Length == 0)
                NameLabel.Text = "이름을 입력하세요."; else { NameLabel.Text = ""; counter++;}

            if (EmailBox.Text.Length == 0)
                EmailLabel.Text = "이메일을 입력하세요."; else { EmailLabel.Text = ""; counter++;}

            if (counter == 2)
            {
                FindUserId(NameBox.Text, EmailBox.Text);
            }
        }


        // DB에서 아이디 찾기
        private void FindUserId(string username, string useremail)
        {
            bool isfind = false;

            string connectionstring = string.Format("Server={0};Database={1};Uid={2}; Pwd={3};", "Nova", "UserDB", "nova", "1954");
            string sql = $"SELECT * FROM UserInfo WHERE name ='{username}' AND email = '{useremail}'";

            using (SqlConnection conn = new SqlConnection(connectionstring))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader mdr = cmd.ExecuteReader();

                while (mdr.Read())
                {
                    if (username == (string)mdr["name"] && useremail == (string)mdr["email"])
                    {
                        isfind = true;
                        DialogResult res = MessageBox.Show($"해당 유저의 아이디는 {(string)mdr["id"]}입니다.", "아이디 찾기", MessageBoxButtons.OK);
                        if (res == DialogResult.OK)
                        {
                            this.Hide();
                        }
                    }
                }
                mdr.Close();

                if (!isfind)
                {
                    MessageBox.Show("아이디를 찾을 수 없습니다.", "Not Found");
                }
            }
        }

        // 비밀번호 찾기 버튼
        private void FindPasswordBtn_Click(object sender,EventArgs e)
        {
            int counter = 0;
            
            if (IdTxtBox.Text.Length ==0)
                IdLabelTxt.Text = "아이디를 입력하세요."; else { IdLabelTxt.Text = ""; counter++; }
            if (NameTxtBox.Text.Length == 0)
                NameLabelTxt.Text = "이름을 입력하세요."; else{ NameLabelTxt.Text = ""; counter++;}
            if (EmailTxtBox.Text.Length == 0)
                labelControl3.Text = "이메일을 입력하세요."; else { labelControl3.Text = ""; counter++;}

            if (counter == 3)
            {
                FindUserPassword(IdTxtBox.Text, NameTxtBox.Text, EmailTxtBox.Text);
            }
        }

        // DB에서 비밀번호 찾기 
        private void FindUserPassword(string userid, string username, string useremail)
        {
            bool isfind = false;
            string connectionstring = string.Format("Server={0};Database={1};Uid={2};Pwd={3}","NOVA","UserDB","nova","1954");
            // Id,이름,이메일이 동일한 계정의 비밀번호를 조회
            string sql = $"SELECT * FROM UserInfo WHERE id='{userid}' AND name='{username}' AND email='{useremail}'";

            using (SqlConnection conn = new SqlConnection(connectionstring))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql,conn);
                SqlDataReader wdr = cmd.ExecuteReader();

                while (wdr.Read())
                {
                    if (userid == (string)wdr["id"] && username == (string)wdr["name"] && useremail == (string)wdr["email"])
                    {
                        isfind = true;
                        DialogResult res = MessageBox.Show($"해당 아이디의 비밀번호는 {wdr["password"]}입니다.", "비밀번호 찾기", MessageBoxButtons.OK);

                        if (res == DialogResult.OK)
                            this.Hide();
                    }
                }
                wdr.Close();

                if (!isfind)
                {
                    MessageBox.Show("비밀번호를 찾을 수 없습니다.", "Not Found");
                }
            }
        }
    }
}