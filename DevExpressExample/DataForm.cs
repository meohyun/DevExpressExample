using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
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
using DevExpress.XtraGrid.Views.Base;

namespace DevExpressExample
{
    public partial class DataForm : DevExpress.XtraEditors.XtraForm
    {
        DataTable dt = new DataTable("donation");  
        MsSqlExample msSqlExample = new MsSqlExample();

        public DataForm()
        {
            InitializeComponent();
            // 데브폼 켜질때 이벤트 추가 
            this.Shown += DevForm_Shown;
            // 셀 값이 바뀔때 이벤트 추가
            this.gridView1.CellValueChanged += GridView1_CellValueChanged;
            SearchBtn.Enabled = false;
            DeleteBtn.Enabled = false;
        }

        // 셀이 수정됨을 감지하면 수정 버튼 활성화 
        private void GridView1_CellValueChanged(object sender, CellValueChangedEventArgs e)
        {
            UpdateBtn.Enabled = true;
        }

        // 초기값 설정
        private void DevForm_Shown(object sender, EventArgs e)
        {
            InitGridControl();
            SearchCoBox.Items.AddRange(new string[] { "Id", "Name", "Grade", "Amount" });
            SearchCoBox.SelectedIndex = -1;

            GradeCoBox.Items.AddRange(new string[] { "1", "2", "3" });
            GradeCoBox.SelectedIndex = -1;

            AmountCoBox.Items.AddRange(new string[] { "10", "20", "30", "40" });
            AmountCoBox.SelectedIndex = -1;

            ResetBtn.Enabled = false;
            SearchBtn.Enabled = false;
            UpdateBtn.Enabled = false;
        }

        // 데이터 로드 
        private void LoadBtn_Click(object sender, EventArgs e)
        {
            dt.Columns.Clear();
            dt.Rows.Clear();

            LoadBtn.Enabled = false;
            ResetBtn.Enabled = true;
            SearchBtn.Enabled = true;
            DeleteBtn.Enabled = true;

            // 데이터테이블에 데이터 추가
            dt.Columns.Add("Id", typeof(string));
            dt.Columns.Add("Name", typeof(string));
            dt.Columns.Add("Grade", typeof(string));
            dt.Columns.Add("Date", typeof(DateTime));
            dt.Columns.Add("Amount", typeof(string));

            msSqlExample.SelectDataDB(dt);

            gridControl1.DataSource = dt;
            
        }

        // 데이터 리셋 
        private void ResetBtn_Click(object sender, EventArgs e)
        {
            LoadBtn.Enabled = true;
            ResetBtn.Enabled = false;
            UpdateBtn.Enabled = false;

            gridControl1.DataSource = null;
        }

        // GridView 초기화 
        public void InitGridControl()
        {
            GridView gv = this.gridControl1.MainView as GridView;
            gv.OptionsView.ShowGroupPanel = false;
            gv.OptionsBehavior.Editable = true;
        }

        // 검색 방식을 선택해야 검색 버튼 활성화
        private void SearchCoBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SearchCoBox.SelectedIndex >= 0)
            {
                SearchBtn.Enabled = true;
            }
        }

        // 데이터 검색 
        private void SearchBtn_Click(object sender, EventArgs e)
        {
            dt.Rows.Clear();

            string searchText = SearchBox.Text;

            // 콤보박스로 검색어 카테고리 설정

            if (SearchCoBox.SelectedItem.ToString() == "Id")
            {
                msSqlExample.DataSearch("id", searchText, dt);
            }   
            if (SearchCoBox.SelectedItem.ToString() == "Name")
            {
                msSqlExample.DataSearch("name", searchText, dt);
            } 
            if (SearchCoBox.SelectedItem.ToString() == "Grade")
            {
                msSqlExample.DataSearch("grade", searchText, dt);
            }
            if (SearchCoBox.SelectedItem.ToString() == "Amount")
            {
                msSqlExample.DataSearch("amount", searchText, dt);
            }

        }

        // 데이터 삭제 
        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("선택된 데이터를 삭제하시겠습니까?", "삭제", MessageBoxButtons.YesNo);

            if(res == DialogResult.Yes)
            {
                // 선택된 열의 Id를 가져옴
                string Id = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Id").ToString();

                // DB에서 삭제
                msSqlExample.DataDelete(Id);

                // 그리드뷰에서 삭제
                gridView1.DeleteRow(gridView1.FocusedRowHandle);
                gridView1.RefreshData();
            }
        }

        // 데이터 저장
        private void SaveBtn_Click(object sender, EventArgs e)
        {
            int counter = 0;

            // counter로 조건 만족하는지 확인 
            if (IdBox.Text.Length == 0)
                labelControl1.Text = "아이디를 입력하세요.";
            else { labelControl1.Text = ""; counter++; }
            if (NameBox.Text.Length == 0)
                labelControl2.Text = "이름을 입력하세요.";
            else { labelControl2.Text = ""; counter++; }
            if (GradeCoBox.SelectedIndex == -1)
                labelControl3.Text = "학년을 선택하세요.";
            else { labelControl3.Text = ""; counter++; }
            if (AmountCoBox.SelectedIndex == -1)
                labelControl5.Text = "기부 금액을 선택하세요.";
            else { labelControl5.Text = ""; counter++; }

            string id = IdBox.Text;
            string name = NameBox.Text;
            string grade = "";
            string date = DateTime.Now.ToString("yyyy-MM-dd");
            string amount = "";

            if (GradeCoBox.SelectedIndex >= 0)
                grade = GradeCoBox.Items[GradeCoBox.SelectedIndex].ToString();

            if (AmountCoBox.SelectedIndex >= 0)
                amount = AmountCoBox.Items[AmountCoBox.SelectedIndex].ToString();


            // 모든 조건 만족시 데이터 저장
            if (counter == 4)
            {
                msSqlExample.DataInsertDB(id, name, grade, date, amount);

                MessageBox.Show("데이터 저장 완료!", "완료",MessageBoxButtons.OK);
            }
        }

        // 데이터 저장 폼 초기화
        private void ClearBtn_Click(object sender, EventArgs e)
        {
            IdBox.Text = "";
            NameBox.Text = "";
            GradeCoBox.SelectedIndex = -1;
            AmountCoBox.SelectedIndex = -1;

            labelControl1.Text = "";
            labelControl2.Text = "";
            labelControl3.Text = "";
            labelControl5.Text = "";
        }

        // 데이터 수정
        private void UpdateBtn_Click(object sender, EventArgs e)
        {

            DialogResult res = MessageBox.Show("데이터를 수정하시겠습니까?", "수정", MessageBoxButtons.YesNo);

            if (res == DialogResult.Yes)
            {
                // 수정 후 버튼 비활성화 > 수정된 데이터가 있을시에만 활성화됨
                UpdateBtn.Enabled = false;

                // 기존 테이블 삭제 후 수정된 테이블로 덮어쓰기
                msSqlExample.DataUpdate(gridView1);
                MessageBox.Show("수정 완료!", "성공", MessageBoxButtons.OK);
            }
        }

        // 로그아웃
        private void LogoutBtn_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("로그아웃 하시겠습니까?", "로그아웃", MessageBoxButtons.YesNo);

            if (res == DialogResult.Yes)
            {
                new Login().Show();
                this.Hide();
            }
        }
    }
}