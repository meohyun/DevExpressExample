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
using System.Text.RegularExpressions;

namespace DevExpressExample
{
    public partial class UserCreate : DevExpress.XtraEditors.XtraForm
    {
        MsSqlExample mssqlExample = new MsSqlExample();

        public UserCreate()
        {
            InitializeComponent();
        }

        private void UserCreate_Load(object sender, EventArgs e)
        {
            clearBtn.Enabled = false;
        }

        // 회원 가입 버튼
        private void UserCreateBtn_Click(object sender, EventArgs e)
        {
            string name = nameBox.Text;
            string email = emailBox.Text;
            string id = idBox.Text;
            string password = passwordBox.Text;
            string date = DateTime.Now.ToString("yyyy-MM-dd");
            bool idDuplicate = false;
            bool emailDuplicate = false;
            bool isSame = false;
            int counter = 0;

            // 아이디, 이메일 중복 체크
            string connectionstring = string.Format("Server={0}; Database={1}; Uid={2};Pwd={3};", "NOVA", "UserDB", "nova", "1954");
            string sql = $"SELECT * FROM UserInfo WHERE id='{id}' OR email ='{email}'";

            using (SqlConnection conn = new SqlConnection(connectionstring))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader wdr = cmd.ExecuteReader();

                while (wdr.Read())
                {
                    if (id == (string)wdr["id"])
                    {
                        idDuplicate = true;
                    }
                    else
                    {
                        idDuplicate = false;
                    }
                    if (email == (string)wdr["email"])
                    {
                        emailDuplicate = true;
                    }
                    else
                    {
                        emailDuplicate = false;
                    }
                }
                wdr.Close();
            }

            // 데이터 null 허용 x 
            if (nameBox.Text.Length == 0) NameLabel.Text = "이름을 입력해주세요.";
            else { NameLabel.Text = ""; counter++; }
            if (emailBox.Text.Length == 0) EmailLabel.Text = "이메일을 입력해주세요.";
            else { EmailLabel.Text = ""; counter++; }
            if (idBox.Text.Length == 0) IdLabel.Text = "아이디를 입력해주세요.";
            else { IdLabel.Text = "";  counter++; }
            if (passwordBox.Text.Length == 0) PasswordLabel.Text = "비밀번호를 입력해주세요.";
            else { PasswordLabel.Text = ""; counter++; }
            if (repasswordBox.Text.Length == 0) repasswordLabel.Text = "비밀번호를 재입력해주세요.";
            else { repasswordLabel.Text = ""; counter++; }

            // 이름에 숫자 포함되면 가입 불가
            Regex r = new Regex("[0-9]");
            bool containNum = r.IsMatch(nameBox.Text);

            if (!containNum)
            {
                NameLabel.Text = "";
                counter++;
            } else { NameLabel.Text = "이름에 숫자가 포함되어 있습니다."; }


            // 이메일 형식이 아니면 가입 불가
            Regex er = new Regex("@");
            bool isEmail = er.IsMatch(emailBox.Text);

            if (isEmail)
            {
                EmailLabel.Text = "";
                counter++;
            } else { EmailLabel.Text = "이메일 형식이 아닙니다."; }



            // 비밀번호와 재입력 비밀번호가 같아야 함.
            if (passwordBox.Text == repasswordBox.Text)
            {
                isSame = true;
                repasswordLabel.Text = "";
            }
            else
            {
                repasswordLabel.Text = "비밀번호가 일치하지 않습니다.";
            }

            // id,email 중복시 에러메세지 출력.
            if (idDuplicate == true)
            {
                IdLabel.Text = "아이디가 중복되었습니다";
            }

            if (emailDuplicate == true)
            {
                EmailLabel.Text = "해당 이메일로 가입된 아이디가 있습니다.";
            }


            // 위의 조건을 모두 만족했을시에만 가입 가능
            if (counter == 7 && isSame == true && idDuplicate == false && emailDuplicate == false)
            {
                // DB에 넣기
                mssqlExample.InsertDB(id, name, email, password,date);


                DialogResult res = MessageBox.Show("회원가입이 완료되었습니다", "완료", MessageBoxButtons.OK);

                if (res == DialogResult.OK)
                {
                    this.Hide();
                }
            }
        }
        // 초기화 버튼
        private void ClearBtn_Click(object sender, EventArgs e)
        {
            nameBox.Text = "";
            emailBox.Text = "";
            idBox.Text = "";
            passwordBox.Text = "";
            repasswordBox.Text = "";
        }

        // 비밀번호 입력시 숨김 기능 

        private void PasswordTxt_TextChanged(object sender, EventArgs e)
        {
            clearBtn.Enabled = true;
            if (passwordBox.PasswordChar == (char)0)
            {
                passwordBox.PasswordChar = '*';
            }
        }
        private void RePasswordTxt_TextChanged(object sender, EventArgs e)
        {
            clearBtn.Enabled = true;
            if (repasswordBox.PasswordChar == (char)0)
            {
                repasswordBox.PasswordChar = '*';
            }
        }


        // 텍스트가 들어있을때만 클리어 버튼 활성화

        private void NameBox_TextChanged(object sender, EventArgs e)
        {
            clearBtn.Enabled = true;
        }

        private void EmailBox_TextChanged(object sender, EventArgs e)
        {
            clearBtn.Enabled = true;
        }

        private void IdBox_TextChanged(object sender, EventArgs e)
        {
            clearBtn.Enabled = true;
        }
    }
}