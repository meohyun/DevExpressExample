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
        Rectangle rack;

        // 타이머 객체 생성
        Timer racktimer = new Timer();

        // 이동 속도
        int x_speed = 15;
        int y_speed = 15;

        // 현재 위치
        int cur_position_x = 25;
        int cur_position_y = 25;

        // 범위를 벗어났는가?
        bool outRange = false;

        // x,y 좌표로 움직이는 중인가
        bool x_moving = true;
        bool y_moving = true;

        // 선반 번호
        int rackNum = 0;

        // 선반 위치 포인트 초기화
        Point rackPoint = new Point(25, 25);

        // 선반 라벨
        Label racklabel;

        // 선반 라벨 폰트
        Font font = new Font("Arial", 12);

        // load 중인가
        bool isLoad = false;

        // 입고점으로 다시 가는 중인가
        bool isReset = false;

        // 출고점으로 이동 중인가
        bool isRelease = false;

        // 적재한 화물 랙 번호 리스트 
        List<int> rackList = new List<int>();


        public DataForm()
        {
            InitializeComponent();
            // 데브폼 켜질때 이벤트 추가 
            this.Shown += DevForm_Shown;

            // 셀 값이 바뀔때 이벤트 추가
            this.gridView1.CellValueChanged += GridView1_CellValueChanged;
            SearchBtn.Enabled = false;
            DeleteBtn.Enabled = false;

            // 초기 위치 설정(도형,랙)
            rec = new Rectangle(25, 25, 50, 50);
            rack = new Rectangle(170,75,30,40);

            // pictureEdit 이벤트 
            pictureEdit1.Paint += new PaintEventHandler(PictureEdit1_Paint);

            // 선반으로 움직일때 사용하는 타이머
            racktimer.Interval = 200;
            racktimer.Tick += new EventHandler(RackTimer_Tick);

            
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

            RackLoadBtn.Enabled = false;
            RackUnLoadBtn.Enabled = false;
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
        // 경로 그리기 
        private void PictureEdit1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen linePen = new Pen(Brushes.DeepSkyBlue);

            // 세로
            Point HeightLinePoint = new Point(50, 50);
            Point HeightLinePoint2 = new Point(50, 365);

            Point HeightLinePoint3 = new Point(950, 50);
            Point HeightLinePoint4 = new Point(950, 365);

            // 가로 
            Point WidthLinePoint = new Point(50, 50);
            Point WidthLinePoint2 = new Point(950, 50);

            Point WidthLinePoint3 = new Point(50, 365);
            Point WidthLinePoint4 = new Point(950, 365);

            pictureEdit1.Properties.NullText = " ";

            // 시작 위치에 원 위치
            g.FillEllipse(Brushes.Blue, rec);

            // 경로 선 긋기
            g.DrawLine(linePen, HeightLinePoint, HeightLinePoint2);
            g.DrawLine(linePen, HeightLinePoint3, HeightLinePoint4);
            for (int i = 1; i < 5; i++)
            {
                g.DrawLine(linePen, new Point(50 + 180 * i, 50), new Point(50 + 180 * i, 365));

                // 선반 이동 경로 생성  (초록색 점)
                for (int j = 1; j < 8; j++)
                {
                    g.FillEllipse(Brushes.Green, 45 + 180 * i, 45 * j, 10, 10);
                }

            }
            g.DrawLine(linePen, WidthLinePoint, WidthLinePoint2);
            g.DrawLine(linePen, WidthLinePoint3, WidthLinePoint4);

            // 선에 노드 표시 
            for (int i = 0; i < 20; i++)
            {
                // 가로 깔기
                g.FillEllipse(Brushes.Black, (HeightLinePoint.X - 5) * (i + 1), HeightLinePoint.Y - 5, 10, 10);
                g.FillEllipse(Brushes.Black, (HeightLinePoint2.X - 5) * (i + 1), HeightLinePoint2.Y - 5, 10, 10);
            }

            for (int i = 1; i < 9; i++)
            {
                //세로 깔기 
                g.FillEllipse(Brushes.Black, WidthLinePoint.X - 5, (WidthLinePoint.Y - 5) * i, 10, 10);
                g.FillEllipse(Brushes.Black, WidthLinePoint2.X - 5, (WidthLinePoint2.Y - 5) * i, 10, 10);

            }

            List<Label> labels = new List<Label>();

            for (int i = 0; i<24; i++)
            {
                racklabel = new Label();
                labels.Add(racklabel);
            }

            
            // 랙 깔기
            for (int j = 0; j < 4; j++)
            {
                for (int i = 0; i < 6; i++)
                {
                    // 랙 깔기
                    g.DrawRectangle(Pens.Brown, rack.X +(180 *j), rack.Y + (45 * i), 30, 45);
                }
            }
        }

        // 선반으로 움직일때 사용하는 타이머
        private void RackTimer_Tick(object sender, EventArgs e)
        {

            // 움직일때는 이동 및 load,unload 불가
            RackLoadBtn.Enabled = false;
            RackUnLoadBtn.Enabled = false;
            ResetPathBtn.Enabled = false;
            ReleasePathBtn.Enabled = false;


            // 6으로 나눈 몫을 올림
            double ceilingvalue = Math.Ceiling((double)rackNum / 6);

            // 선반 위치 포인트
            rackPoint = new Point((int)(25 + 45 * (ceilingvalue * 4)), (int)((25 + 45 * (rackNum - (6 * (ceilingvalue-1))))));

            // 출고점으로 이동
            if (isRelease == true)
            {
                rackPoint = new Point(925, 340);
            }

            // 입고점(시작위치)으로 이동
            if(isReset == true)
            {
                rackPoint = new Point(25, 25);
            }

            // 해당 위치가 랙 위치 포인트보다 클때는 역방향(-) 아니면 정방향 (+)
            if (rec.X > rackPoint.X)
            {
                x_speed = -15;
            } 
            else 
            {
                x_speed = 15; 
            }
            if(rec.Y > rackPoint.Y && rec.X  == rackPoint.X)
            {
                y_speed = -15;
            }
            else
            {
                y_speed = 15;
            }

            // 현재위치에서 진행거리 만큼 왔을때 타이머 stop
            if (rec.X == rackPoint.X)
            {
                cur_position_x = rec.X;
                x_moving = false;
                if (y_moving == false)
                {
                    racktimer.Stop();
                }
            }
            else if (outRange == false && x_moving)
            {
                rec.X += x_speed;
            }

            // x좌표로 움직인 다음 y좌표로 이동 
            if (x_moving == false)
            {
                // 현재위치에서 진행거리 만큼 왔을때 타이머 stop
                if (rec.Y == rackPoint.Y)
                {
                    cur_position_y = rec.Y;
                    y_moving = false;
                    racktimer.Stop();
                }
                else if (outRange == false && y_moving)
                {
                    rec.Y += y_speed;
                }
            }

            // 경로 벗어나서는 이동 불가능
            if (((rec.X > 25 && rec.X < 205) || (rec.X > 205 && rec.X < 385) || (rec.X > 385 && rec.X < 565) || (rec.X > 565 && rec.X < 745) || (rec.X > 745 && rec.X < 925)) && (rec.Y > 25 && rec.Y < 320) || (rec.X > 925 || rec.X < 25) || (rec.Y > 340 || rec.Y < 25))
            {
                outRange = true;

                rec.X = cur_position_x;
                rec.Y = cur_position_y;

                startBtn.Enabled = true;
            }

            if (outRange == true)
            {
                // 랙 1~3 번까지는 위로 이동
                if (rec.Y < 195)
                {
                    rec.Y -= y_speed;
                }
                // 랙 4~6번까지는 밑으로 이동 
                else if (rec.Y >= 195)
                {
                    rec.Y += y_speed;
                }
            }

            if (rec.Y == 340 || rec.Y == 25)
            {
                outRange = false;
            }

            // 타이머가 멈췄을때 = 목적지 도착 버튼 활성화 및 boolean값 초기화
            if (racktimer.Enabled == false){
                // 현재 시간
                string now = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                startBtn.Enabled = true;
                RackLoadBtn.Enabled = true;
                RackUnLoadBtn.Enabled = true;
                ResetPathBtn.Enabled = true;
                ReleasePathBtn.Enabled = true;

                // 랙으로 이동 했을때
                if (isRelease == false && isReset ==  false)
                {
                    LogListBox.Items.Add(now + $"     목적지 도착");
                    RackLoadBtn.Enabled = true;
                    RackUnLoadBtn.Enabled = true;
                }
                // 출고점
                else if (isRelease == true)
                {
                    LogListBox.Items.Add(now + "     출고점 도착");
                    ReleasePathBtn.Enabled = false;
                    RackLoadBtn.Enabled = false;

                }
                // 입고점
                else if (isReset == true)
                {
                    LogListBox.Items.Add(now + "     입고점 도착");
                    ResetPathBtn.Enabled = false;
                    RackLoadBtn.Enabled = false;
                    RackUnLoadBtn.Enabled = false;
                }
                
                x_moving = true;
                y_moving = true;
                isLoad = false;

                // 로그가 생기면 스크롤바를 아래로 내림.
                LogListBox.MakeItemVisible(LogListBox.ItemCount);
            }

            pictureEdit1.Invalidate();

            xyPositionLabel.Text = string.Format("X : {0}   Y : {1}", rec.X, rec.Y);
        }

        // 랙 경로 지정
        private void SetRackPathBtn_Click(object sender, EventArgs e)
        {
            // 현재 시간
            string now = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

            // 이동 중 적재 불가
            RackLoadBtn.Enabled = false;
            RackUnLoadBtn.Enabled = false;

            // 초기화
            isRelease = false;
            isReset = false;

            // null값 허용 x 
            if (rackNumTxt.Text.Length != 0)
            {
                rackNum = int.Parse(rackNumTxt.Text);

                if (rackNum <= 0 || rackNum > 24)
                {
                    MessageBox.Show("선반 번호가 아닙니다.", "에러", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                MessageBox.Show("선반 번호를 지정해주세요.", "에러", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            LogListBox.Items.Add(now+ $"     {rackNum}번 선반으로 이동");
            startBtn.Enabled = false;
            outRange = false;

            racktimer.Start();
        }

        // 적재 버튼
        private void RackLoadBtn_Click(object sender, EventArgs e)
        {
            // 현재 시간
            string now = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

            
            // 해당 번호의 화물을 적재하지 않았다면 적재 가능.
            if (isLoad == false && !rackList.Contains(rackNum))
            {
                isLoad = true;
                RackNumBox.Text += rackNum;
                rackList.Add(rackNum);
                LogListBox.Items.Add(now + $"     {rackNum}번 화물 적재 완료!");
            }
            else
            {
                MessageBox.Show($"이미 {rackNum}번 화물을 적재했습니다.", "에러", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }  


            // 새로운 로그가 있을때 자동으로 스크롤바 내림.
            LogListBox.MakeItemVisible(LogListBox.ItemCount);
        }

        // 화물 unload
        private void RackUnloadBtn_Click(object sender, EventArgs e)
        { 

            // 현재 시간
            string now = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

            // 출고지에 있다면 unload 가능
            if (isRelease == true || rackList.Contains(rackNum))
            {
                // 화물이 있다면 unload ,없다면 unload x
                if (rackList.Count != 0)
                {
                    string a = "";

                    // 출고지에서는 하역시 모든 화물 unload
                    if (isRelease == true)
                    {
                        foreach (int num in rackList)
                        {
                            a += num.ToString() + "번 ";
                        }
                        LogListBox.Items.Add(now + $"     {a}랙의 화물을 Unload 하였습니다.");
                        rackList.Clear();
                        RackNumBox.Text = "";
                    }
                    // 랙에서는 해당 번호의 화물만 unload
                    else if (isRelease == false)
                    {
                        a += rackNum.ToString() + "번 ";
                        LogListBox.Items.Add(now + $"     {a}랙의 화물을 Unload 하였습니다.");
                        int idx = rackList.FindIndex(x => x == rackNum);
                        rackList.RemoveAt(idx);
                        isLoad = false;
                        string nums = "";
                        foreach (int num in rackList)
                        {
                            nums += num;
                        }
                        RackNumBox.Text = nums;
                    }
                }
                else
                {
                    MessageBox.Show("Unload할 화물이 없습니다.", "에러", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                MessageBox.Show("Unload 할 화물이 없습니다.", "에러", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 새로운 로그가 있을때 자동으로 스크롤바 내림.
            LogListBox.MakeItemVisible(LogListBox.ItemCount);
        }

        // 입고위치로 이동(초기 위치)
        private void ResetPathBtn_Click(object sender, EventArgs e)
        {
            // 현재 시간
            string now = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

            LogListBox.Items.Add(now+"     초기 위치로 돌아갑니다.");
            isReset = true;
            isRelease = false;
            rackNumTxt.Text = "";
            rackList.Clear();
            RackLoadBtn.Enabled = false;
            RackUnLoadBtn.Enabled = false;

            racktimer.Start();
        }

        // 출고위치로 이동
        private void ReleasePathBtn_Click(object sender, EventArgs e)
        {
            // 현재 시간
            string now = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

            LogListBox.Items.Add(now+"     출고점으로 이동합니다.");
            isReset = false;
            isRelease = true;
            racktimer.Start();

        }


        // 숫자만 받도록
        private void RackNumTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        // 랙 번호 놓기 
        private void XtraTabPage3_Paint(object sender, PaintEventArgs e)
        {
            int count = 0;

            // 프로그램의 GDI 개체가 10,000개를 넘으면 윈도우 핸들러 에러가 발생하기때문에 Dispose 해줘야 한다.
            while (pictureEdit1.Controls.Count > 0)
            {
                pictureEdit1.Controls[0].Dispose();
            }

            // 랙 깔기
            for (int j = 0; j < 4; j++)
            {
                for (int i = 0; i < 6; i++)
                {
                    count++;
                    // 랙 숫자 라벨 
                    racklabel = new Label();
                    racklabel.AutoSize = true;
                    racklabel.Size = new System.Drawing.Size(0, 0);
                    racklabel.Font = font;
                    racklabel.Visible = true;

                    racklabel.Location = new Point(rack.X + (180 * j) + 3, rack.Y + (45 * i) + 15);
                    racklabel.Text = count.ToString();
                    racklabel.Name = "Label" + racklabel.Text;
                    pictureEdit1.Controls.Add(racklabel);

                }
            }
        }
    }
}