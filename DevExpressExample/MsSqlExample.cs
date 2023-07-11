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
        public void SelectDB()
        {
            string connectionString = string.Format("Server={0};Database={1};Uid={2}; Pwd={3};", "NOVA", "UserDB", "nova", "1954");
            string sql = "select * from UserInfo";

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
        public void SelectDataDB(DataTable dt)
        {
            string connectionString = string.Format("Server={0};Database={1};Uid={2}; Pwd={3};", "NOVA", "DataDB", "nova", "1954");
            string sql = "select * from DataInfo";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader wdr = cmd.ExecuteReader();

                while (wdr.Read())
                {
                    dt.Rows.Add(wdr["id"], wdr["name"], wdr["grade"], wdr["date"], wdr["amount"]);
                }
                wdr.Close();
            }
        }

        //Data Insert 
        public void DataInsertDB(string id, string name, string grade, string date, string amount)
        {
            string connectionString = string.Format("Server={0};Database={1};Uid={2}; Pwd={3};", "NOVA", "DataDB", "nova", "1954");
            string sql = $"Insert Into DataInfo (id,name,grade,date,amount) values ('{id}','{name}','{grade}','{date}','{amount}')";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
            }
        }

        //Data Search
        public void DataSearch(string column,string searchText ,DataTable dt)
        {
            // 콤보박스에서 선택한 카테고리로 searchtext를 포함하는 열들 그리드뷰에 출력 
            string connectionString = string.Format("Server={0};Database={1};Uid={2}; Pwd={3};", "NOVA", "DataDB", "nova", "1954");
            string sql = $"SELECT * FROM DataInfo WHERE {column} LIKE '%{searchText}%'";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);

                // 데이터베이스에 있는 정보 읽기
                SqlDataReader wdr = cmd.ExecuteReader();

                while (wdr.Read())
                {
                    dt.Rows.Add(wdr["id"], wdr["name"], wdr["grade"], wdr["date"], wdr["amount"]);
                }
                wdr.Close();
            }
        }

        //Data Delete
        public void DataDelete(string selectedId)
        {
            // 선택된 행 삭제 
            string connectionString = string.Format("Server={0};Database={1};Uid={2}; Pwd={3};", "NOVA", "DataDB", "nova", "1954");
            string sql = $"DELETE FROM DataInfo WHERE id='{selectedId}'";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                // String으로 된 sql문을 데이터베이스에 Sql문 형식으로 변환해서 전달. 
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
            }
        }

        //Data Update > gridcontrol의 변경된 데이터를 새로운 데이터 테이블에 덮어쓰기
        public void DataUpdate(GridView gridView)
        {
            string connectionString = string.Format("Server={0};Database={1};Uid={2}; Pwd={3};", "NOVA", "DataDB", "nova", "1954");

            // DB에서 테이블 형식은 유지하고 데이터만 삭제 
            string sql_delete = "TRUNCATE TABLE DataInfo";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql_delete, conn);
                cmd.ExecuteNonQuery();
            }

            // 그리드뷰에서 수정된 데이터를 테이블에 INSERT 
            for (int i = 0; i < gridView.RowCount; i++)
            {
                string id = gridView.GetRowCellValue(gridView.GetRowHandle(i), "Id").ToString();
                string name = gridView.GetRowCellValue(gridView.GetRowHandle(i), "Name").ToString();
                string grade = gridView.GetRowCellValue(gridView.GetRowHandle(i), "Grade").ToString();
                string date = ((DateTime)gridView.GetRowCellValue(gridView.GetRowHandle(i), "Date")).ToString("yyyy-MM-dd");
                string amount = gridView.GetRowCellValue(gridView.GetRowHandle(i), "Amount").ToString();

                DataInsertDB(id, name, grade, date, amount);
            }
        }
    }
}
