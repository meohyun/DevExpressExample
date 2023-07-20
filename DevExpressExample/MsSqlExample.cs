using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

using DevExpress.XtraGrid.Views.Grid;

namespace DevExpressExample
{
    class MsSqlExample
    {

        // User Data Read
        public void SelectDB(string Database, string Table)
        {
            string connectionString = string.Format("Server={0};Database={1};Uid={2}; Pwd={3};", "NOVA", $"{Database}", "nova", "1954");
            string sql = $"select * from {Table}";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader dr = cmd.ExecuteReader();
                dr.Close();
            }
        }

        //User Data Insert 
        public void InsertDB(string id, string name, string email, string password, string date)
        {
            string connectionString = string.Format("Server={0};Database={1};Uid={2}; Pwd={3};", "NOVA", "UserDB", "nova", "1954");
            string sql = $"Insert Into UserInfo (id,name,email,password,date) values ('{id}','{name}','{email}','{password}','{date}')";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
            }
        }


        // Data Read
        public void SelectAGVDB(DataTable dt)
        {
            string connectionString = string.Format("Server={0};Database={1};Uid={2}; Pwd={3};", "NOVA", "AGVDB", "nova", "1954");
            string sql = "select * from AGVData";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader wdr = cmd.ExecuteReader();

                while (wdr.Read())
                {
                    dt.Rows.Add(wdr["이름"], wdr["상태"], wdr["이동경로"], wdr["출고화물"], wdr["운행시간"],wdr["출고시각"], wdr["출고횟수"]);
                }
                wdr.Close();
            }
        }

        //Data Insert 
        public void InsertAGVDB(string name, string path, string unloads, string worktime,string unloadtime,int unloadnum, string state)
        {
            string connectionString = string.Format("Server={0};Database={1};Uid={2}; Pwd={3};", "NOVA", "AGVDB", "nova", "1954");
            string sql = $"Insert Into AGVData (이름,이동경로,출고화물,운행시간,출고시각,출고횟수,상태) values ('{name}','{path}','{unloads}','{worktime}','{unloadtime}',{unloadnum},'{state}')";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
            }
        }

        //Data Search
        public void SearchAGVDB(string column,string searchText ,DataTable dt)
        {
            // 콤보박스에서 선택한 카테고리로 searchtext를 포함하는 열들 그리드뷰에 출력 
            string connectionString = string.Format("Server={0};Database={1};Uid={2}; Pwd={3};", "NOVA", "AGVDB", "nova", "1954");
            string sql = $"SELECT * FROM AGVData WHERE {column} LIKE '%{searchText}%'";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);

                // 데이터베이스에 있는 정보 읽기
                SqlDataReader wdr = cmd.ExecuteReader();

                while (wdr.Read())
                {
                    dt.Rows.Add(wdr["이름"], wdr["상태"], wdr["이동경로"],wdr["출고화물"], wdr["운행시간"] ,wdr["출고시각"],wdr["출고횟수"]);
                }
                wdr.Close();
            }
        }

        //Data Delete
        public void DeleteAGVDB(string selectTime)
        {
            // 선택된 행 삭제 
            string connectionString = string.Format("Server={0};Database={1};Uid={2}; Pwd={3};", "NOVA", "AGVDB", "nova", "1954");
            string sql = $"DELETE FROM AGVData WHERE 출고시각='{selectTime}'";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                // String으로 된 sql문을 데이터베이스에 Sql문 형식으로 변환해서 전달. 
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
