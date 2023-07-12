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
        Rectangle rec;

        // 타이머 객체 생성
        Timer timer = new Timer();

        // 이동 값
        int x_value = 0;
        int y_value = 0;

        // 이동 속도
        int speed = 15;

        // 현재 위치
        int cur_position_x = 25;
        int cur_position_y = 25;

        // 진행 거리
        int x_distance = 1;
        int y_distance = 1;

        bool outRange = false;


        public DataForm()
        {
            InitializeComponent();
            // 데브폼 켜질때 이벤트 추가 
            this.Shown += DevForm_Shown;
            // 셀 값이 바뀔때 이벤트 추가
            this.gridView1.CellValueChanged += GridView1_CellValueChanged;
            SearchBtn.Enabled = false;
            DeleteBtn.Enabled = false;

            rec = new Rectangle(25, 25, 50, 50);

            pictureEdit1.Paint += new PaintEventHandler(pictureEdit1_Paint);
            pictureEdit1.Properties.NullText = "";

            // 주기 설정
            timer.Interval = 1000;
            timer.Tick += new EventHandler(timer_Tick);

        }

        // 직사각형 경로 그리기 
        private void pictureEdit1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen linePen = new Pen(Brushes.DeepSkyBlue);

            // 세로
            Point HeightLinePoint = new Point(50, 50);
            Point HeightLinePoint2 = new Point(50, 365);

            Point HeightLinePoint3 = new Point(905, 50);
            Point HeightLinePoint4 = new Point(905, 365);

            // 가로 
            Point WidthLinePoint = new Point(50, 50);
            Point WidthLinePoint2 = new Point(905, 50);

            Point WidthLinePoint3 = new Point(50, 365);
            Point WidthLinePoint4 = new Point(905, 365);


            // 시작 위치에 원 위치 
            
            g.FillEllipse(Brushes.Blue, rec);

            g.DrawLine(linePen, HeightLinePoint, HeightLinePoint2);
            g.DrawLine(linePen, HeightLinePoint3, HeightLinePoint4);
            g.DrawLine(linePen, WidthLinePoint, WidthLinePoint2);
            g.DrawLine(linePen, WidthLinePoint3, WidthLinePoint4);

            // 경로 선에 노드 표시 
            for (int i =0; i <20; i++)
            {
                // 가로 깔기
                g.FillEllipse(Brushes.Black, (HeightLinePoint.X-5) * (i+1), HeightLinePoint.Y-5,10,10);
                g.FillEllipse(Brushes.Black, (HeightLinePoint2.X-5) * (i+1), HeightLinePoint2.Y-5,10,10);
            }

            for (int i =1; i < 8; i++)
            {
                //세로 깔기 
                g.FillEllipse(Brushes.Black, WidthLinePoint.X - 5, (WidthLinePoint.Y - 5) * i,10,10);
                g.FillEllipse(Brushes.Black, WidthLinePoint2.X - 5, (WidthLinePoint2.Y - 5) * i, 10, 10);
            }
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

        /// 도형 움직이기 Tab
        /// 

        public void timer_Tick(object sender, EventArgs e)
        {
            x_distance = 45 * x_value;
            y_distance = 45 * y_value;

            // 현재위치에서 진행거리 만큼 왔을때 타이머 stop
            if (rec.X == cur_position_x + x_distance)
            {
                cur_position_x = rec.X;

                if(x_value !=0)
                    timer.Stop();
            }
            else if (outRange == false)
            {
                rec.X += speed; 
            }

            // 현재위치에서 진행거리 만큼 왔을때 타이머 stop
            if (rec.Y == cur_position_y + y_distance)
            {
                cur_position_y = rec.Y;

                if(y_value != 0)
                   timer.Stop();
            }
            else if (outRange == false)
            {
                rec.Y += speed; 
            }

            /// 예외처리
            /// 

            // 경로 안쪽으로는 이동 불가능
            if ((rec.X >= 30 && rec.X <= 805) && (rec.Y >= 30 && rec.Y <= 320) || (rec.X > 880 || rec.X < 25) || (rec.Y > 340 || rec.Y < 25))
            {
                outRange = true;
                timer.Stop();
                MessageBox.Show("경로가 아닌 곳으로 이동할 수 없습니다.", "에러", MessageBoxButtons.OK, MessageBoxIcon.Error);
                rec.X = cur_position_x;
                rec.Y = cur_position_y;
                
            }
            else
            {
                outRange = false;
            }
           
            pictureEdit1.Invalidate();

            // 타이머가 멈췄을때만 경로 지정 가능
            if (timer.Enabled == false)
            {
                setPointBtn.Enabled = true;
            }

        }

        // 경로 지정
        private void setPointBtn_Click(object sender, EventArgs e)
        {
            // 경로 지정시 이동이 끝날때 까지는 재지정 불가
            setPointBtn.Enabled = false;

            speed = 15;
            x_distance = 45 * x_value;
            y_distance = 45 * y_value;

            // 좌표값이 null일 경우
            if (xBox.Text.Length == 0 || yBox.Text.Length == 0)
            {
                MessageBox.Show("이동할 값을 설정하세요.", "에러", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (xBox.Text.Length > 0 && yBox.Text.Length > 0)
            {
                x_value = int.Parse(xBox.Text);
                y_value = int.Parse(yBox.Text);
            }

            // - 포함시 역방향으로 움직임.
            if (xBox.Text.Contains('-'))
            {
                speed *= -1;
            }
            if (yBox.Text.Contains('-'))
            {
                speed *= -1;
            }

            timer.Start();

            
        }
        // 출발지로 다시 리셋
        private void resetPathBtn_Click(object sender, EventArgs e)
        {
            xBox.Text = "0";
            yBox.Text = "0";

            rec.X = 25;
            rec.Y = 25;
            cur_position_x = rec.X;
            cur_position_y = rec.Y;
            setPointBtn.Enabled = true;

            pictureEdit1.Invalidate();
            timer.Stop();
        }

        // x,y 좌표는 int값만 받도록
        private void xBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '-') && ((sender as TextBox).Text.IndexOf('-') > -1))
            {
                e.Handled = true;
            }

        }

        private void yBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '-') && ((sender as TextBox).Text.IndexOf('-') > -1))
            {
                e.Handled = true;
            }
        }
    }
}