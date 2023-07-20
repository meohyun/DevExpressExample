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
    public partial class AGVForm : DevExpress.XtraEditors.XtraForm
    {
        DataTable dt = new DataTable("donation");
        MsSqlExample msSqlExample = new MsSqlExample();

        Rectangle rec;
        Rectangle rack;

        // 이동 속도
        int x_speed = 15;
        int y_speed = 15;

        // 현재 위치
        int cur_position_x = 25;
        int cur_position_y = 25;

        // 범위를 벗어났는가?
        bool outRange = false;

        // x좌표로 움직이는 중인가
        bool x_moving = true;

        // 선반 번호
        public int rackNum = 0;

        // 선반 위치 포인트 초기화
        Point rackPoint = new Point(25, 25);

        // 선반 라벨
        Label racklabel;

        // 선반 라벨 폰트
        private readonly Font font = new Font("Arial", 12);

        // load 중인가
        bool isLoad = false;

        // 입고점으로 다시 가는 중인가
        bool isReceive = false;

        // 출고점으로 이동 중인가
        bool isRelease = false;

        // 적재한 화물 랙 번호 리스트 
        private readonly List<int> rackList = new List<int>();

        // 적재한 화물 text
        string loadfreightText = "";

        // 출고한 횟수
        int releaseCount = 0;

        // AGV 상태
        string state;

        // 출고한 화물 
        private readonly List<string> releaseFreightList = new List<string>();

        // 이동 경로
        string movingPath = "";

        // agvdata 폼 객체 생
        AGVInfo agv = new AGVInfo();

        // 랙 포인트 리스트
        List<Point> rackPointList = new List<Point>();

        // 모든 경로 리스트 
        List<Point> backgroundPointList = new List<Point>();

        public class link
        {
            // 하나의 노드
            public Point node1 = new Point(0,0);
            // 이어진 노드
            public Point node2 = new Point(0,0);

            // 삼방향 노드인가
            public bool isThreeNode = false;

            public bool isLeftWay = false;
            public bool isRightWay = false;
            public bool isUnderWay = false;
        }

        // 링크 리스트 
        List<link> racklinklist = new List<link>();
        List<link> backgroundlinklist = new List<link>();

        // 시간
        int time = 0;

        // 이전의 랙 넘버를 저장하는 리스트
        private readonly List<int> beforenum = new List<int> { 0 };

        public AGVForm()
        {
            InitializeComponent();
            // 데브폼 켜질때 이벤트 추가 
            this.Shown += DevForm_Shown;

            // 셀 값이 바뀔때 이벤트 추가
            SearchBtn.Enabled = false;
            DeleteBtn.Enabled = false;

            // 초기 위치 설정(도형,랙)
            rec = new Rectangle(25, 25, 50, 50);
            rack = new Rectangle(170,75,30,40);

            // pictureEdit 이벤트 
            pictureEdit1.Paint += new PaintEventHandler(PictureEdit1_Paint);
            pictureEdit1.MouseDown += new MouseEventHandler(PictureEdit1_MouseDown);

            // 랙으로 움직일때 사용하는 타이머
            timer1.Tick += new EventHandler(RackTimer_Tick);

            // 시간 측정 타이머
            timer2.Tick += new EventHandler(Timer_Tick);

            agv.FormClosing += new FormClosingEventHandler(Agv_FormClosing);
            this.FormClosing += new FormClosingEventHandler(this_FormClosing);
            this.FormClosed += new FormClosedEventHandler(this_FormClosed);

            // 초기 위치 상태
            state = "입고지 정차";

            // 6으로 나눈 몫을 올림
            double ceilingvalue = Math.Ceiling((double)rackNum / 6);

            // 랙 위치 포인트
            for (int i=1; i < 5; i++)
            {
                for (int j=1; j < 7; j++)
                {
                    rackPointList.Add(new Point(25 + 45 * (i*4), 25 + (45 * j)));
                }
            }

            // 백그라운드 노드 포인트 생성
            for (int i = 0; i<20; i++)
            {
                backgroundPointList.Add(new Point(25 + 45 * i, 25));
            }

            for (int i =0; i < 7; i++)
            {
                backgroundPointList.Add(new Point(925, 25+45*i));
            }

            for (int i=0; i < 20; i++)
            {
                backgroundPointList.Add(new Point(925-45*i,340));
            }

            for (int i =0; i<7; i++)
            {
                backgroundPointList.Add(new Point(25,340-45*i));
            }

            // 링크 리스트 생성
             CreateLink(rackPointList,racklinklist);

             CreateLink(backgroundPointList,backgroundlinklist);


            // 링크리스트 마지막 부분 예외처리 
            for (int i =0; i < racklinklist.Count; i++)
            {
                if (i % 5 == 0 && i != 0 )
                {
                    racklinklist.RemoveAt(i);
                }
            }

            // 랙으로 향하는 노드는 삼방향 노드 
            for (int i=0; i< 16; i++)
            {
                if (i % 4 == 0 && i != 0)
                {
                    racklinklist[i].isThreeNode = true;
                }
            }
            for (int i=31; i < 43; i++)
            {
                if (i% 4 == 3)
                {
                    racklinklist[i].isThreeNode = true;
                }
            }
        }

        // 링크 생성 
        public void CreateLink(List<Point> nodelist,List<link> linklist)
        {
            for (int i = 0; i < nodelist.Count; i++)
            {
                // 링크 객체 생성
                link newlink = new link();

               // 이전 노드의 Point
                newlink.node1 = nodelist[i];

               // 만약 마지막 노드 전이면 노드 리스트의 첫번째와 이어짐.
                if (i == nodelist.Count - 1)
                   newlink.node2 = nodelist[0];

              // 그렇지 않다면 계속해서 다음 노드를 추가해 나간다.
                else
                  newlink.node2 = nodelist[i + 1];

              // 링크 리스트에 링크를 추가한다.
                  linklist.Add(newlink); 
            }
        }

        // AGV 운행시간
        private void Timer_Tick(object sender, EventArgs e)
        {
            time += 1;
            agv.moveTimeLabel.Text = (time / 60) + ":" + (time % 60);
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

        // 초기값 설정
        private void DevForm_Shown(object sender, EventArgs e)
        {
            InitGridControl();
            SearchCoBox.Items.AddRange(new string[] { "이름","출고횟수","상태" });
            SearchCoBox.SelectedIndex = -1;

            ResetBtn.Enabled = false;
            SearchBtn.Enabled = false;

            RackLoadBtn.Enabled = false;
            RackUnLoadBtn.Enabled = false;

            ReceivePathBtn.Enabled = false;
            ResetPathBtn.Enabled = false;
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
            dt.Columns.Add("이름", typeof(string));
            dt.Columns.Add("상태", typeof(string));
            dt.Columns.Add("이동경로", typeof(string));
            dt.Columns.Add("출고화물", typeof(string));
            dt.Columns.Add("운행시간", typeof(string));
            dt.Columns.Add("출고시각", typeof(string));
            dt.Columns.Add("출고횟수", typeof(int)); 
           
            msSqlExample.SelectAGVDB(dt);

            gridControl1.DataSource = dt;
        }      

        // 데이터 리셋 
        private void ResetBtn_Click(object sender, EventArgs e)
        {
            LoadBtn.Enabled = true;
            ResetBtn.Enabled = false;

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

            if (SearchCoBox.SelectedItem.ToString() == "이름")
            {
                msSqlExample.SearchAGVDB("이름", searchText, dt);
            }
            if (SearchCoBox.SelectedItem.ToString() == "출고횟수")
            {
                msSqlExample.SearchAGVDB("출고횟수", searchText, dt);
            }
            if (SearchCoBox.SelectedItem.ToString() == "상태")
            {
                msSqlExample.SearchAGVDB("상태", searchText, dt);
            }

        }

        // 데이터 삭제 
        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("선택된 데이터를 삭제하시겠습니까?", "삭제", MessageBoxButtons.YesNo);

            if(res == DialogResult.Yes)
            {
                // 선택된 열의 시간을 가져옴
                DateTime time = (DateTime)gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "출고시각");
                string timetext = time.ToString("yyyy-MM-dd HH:mm:ss");

                // DB에서 삭제
                msSqlExample.DeleteAGVDB(timetext);

                // 그리드뷰에서 삭제
                gridView1.DeleteRow(gridView1.FocusedRowHandle);
                gridView1.RefreshData();
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

                // 랙 이동 경로 생성  (초록색 점)
                for (int j = 1; j < 8; j++)
                {
                    g.FillEllipse(Brushes.Green, 45 + 180 * i, 45 * j, 10, 10);
                }
            }
            g.DrawLine(linePen, WidthLinePoint, WidthLinePoint2);
            g.DrawLine(linePen, WidthLinePoint3, WidthLinePoint4);

            // 선에 노드 표시 
            for (int i = 1; i < 20; i++)
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

        // AGV 클릭시 agv 팝업창 뜸.
        private void PictureEdit1_MouseDown(object sender, MouseEventArgs e)
        {
            if (rec.Contains(e.Location))
            {
                agv.Owner = this;
                agv.Show();
            }
        }

        // 선반으로 움직일때 사용하는 타이머
        private void RackTimer_Tick(object sender, EventArgs e)
        {

            state = "이동 중";

            // 움직일때는 이동 및 load,unload 불가
            RackLoadBtn.Enabled = false;
            RackUnLoadBtn.Enabled = false;
            ReceivePathBtn.Enabled = false;
            ReleasePathBtn.Enabled = false;

            // 랙 위치 포인트
            rackPoint = rackPointList[rackNum-1];

            // 출고점으로 이동
            if (isRelease == true)
            {
                rackPoint = new Point(925, 340);
            }

            // 입고점(시작위치)으로 이동
            if(isReceive == true)
            {
                rackPoint = new Point(25, 25);
            }

            // 해당 위치가 랙 위치 포인트보다 클때는 역방향(-) 아니면 정방향 (+)
            if (rec.X > rackPoint.X)
            {
                x_speed = -5;
            } 
            else 
            {
                x_speed = 5;
            }
            if(rec.Y > rackPoint.Y && rec.X  == rackPoint.X)
            {
                y_speed = -5;
            }
            else
            {
                y_speed = 5;
            }

            /// x축 이동
            // 목적지의 x좌표 만큼 왔을때 타이머 stop
            if (rec.X == rackPoint.X)
            {
                cur_position_x = rec.X;
                x_moving = false;
            }

            // 범위를 벗어나지 않았고, 도착하지 않았고, x_moving이 true이면 x축으로 움직이기.
            else if (outRange == false && x_moving)
            {
                rec.X += x_speed;
            }

            /// y축 이동
            // x좌표로 움직인 다음 y좌표로 이동 
            if (x_moving == false)
            {
                // 목적지의 y좌표 만큼 왔을때 타이머 stop
                if (rec.Y == rackPoint.Y)
                {
                    cur_position_y = rec.Y;
                    timer1.Stop();
                }
                // 범위를 벗어나지 않았고 도착하지 않았다면 y축으로 움직이기.
                else if (outRange == false)
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
                // 위와 아래 경로 중  y 거리가 짧은 경로로 이동
                if (rec.Y-25 + rackPoint.Y-25  > 340-rec.Y + 340 - rackPoint.Y)
                {
                    rec.Y += y_speed;
                }
                else
                {
                    rec.Y -= y_speed;
                }
            }

            // 해당 라인을 벗어나면 다시 x축으로 이동할 수있도록 함.
            if (rec.Y == 340 || rec.Y == 25)
            {
                outRange = false;
            }

            // 타이머가 멈췄을때 = 목적지 도착 버튼 활성화 및 boolean값 초기화
            if (timer1.Enabled == false){
                // 현재 시간
                string now = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                startBtn.Enabled = true;
                RackLoadBtn.Enabled = true;
                RackUnLoadBtn.Enabled = true;
                ReceivePathBtn.Enabled = true;
                ReleasePathBtn.Enabled = true;
                ResetPathBtn.Enabled = true;

                agv.moveBtn.Enabled = false;
                agv.pauseBtn.Enabled = false;


                // 랙에 도착
                if (isRelease == false && isReceive ==  false)
                {
                    LogListBox.Items.Add(now + $"     목적지 도착");
                    RackLoadBtn.Enabled = true;
                    RackUnLoadBtn.Enabled = true;
                    state = $"{rackNum}번랙 정차";
                    movingPath += $"{rackNum} > ";
                    agv.timer1.Enabled = false;
                    timer2.Stop();
                }

                // 출고점
                else if (isRelease == true)
                {
                    LogListBox.Items.Add(now + "     출고지 도착");
                    ReleasePathBtn.Enabled = false;
                    RackLoadBtn.Enabled = false;
                    state = "출고지 정차";
                    movingPath += "출고지 ";
                    agv.timer1.Enabled = false;
                    timer2.Stop();
                }

                // 입고점
                else if (isReceive == true)
                {
                    LogListBox.Items.Add(now + "     입고지 도착");
                    ReceivePathBtn.Enabled = false;
                    RackLoadBtn.Enabled = false;
                    RackUnLoadBtn.Enabled = false;
                    state = "입고지 정차";
                    movingPath += "입고지 ";
                    agv.timer1.Enabled = false;
                    timer2.Stop();
                }

                x_moving = true;

                // 다른 랙으로 이동시 load가 안되는 것을 초기화하여 해결.
                isLoad = false;

                // 팝업창에 이동경로 추가
                agv.movingPathBox.Text = movingPath;

                // 로그가 생기면 스크롤바를 아래로 내림.
                LogListBox.MakeItemVisible(LogListBox.ItemCount);
            }
            agv.stateLabel.Text = state;
            pictureEdit1.Invalidate();

            agv.agvPosLabel.Text = string.Format("X : {0}   Y : {1}", rec.X, rec.Y);
        }

        // 랙 경로 지정
        private void SetRackPathBtn_Click(object sender, EventArgs e)
        {
            // 현재 시간
            string now = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

            // 이동 중 적재 불가
            RackLoadBtn.Enabled = false;
            RackUnLoadBtn.Enabled = false;

            // 움직이기 시작하면 중지버튼 활성화
            agv.pauseBtn.Enabled = true;

            // 초기화
            isRelease = false;
            isReceive = false;

            // null값 허용 x 
            if (rackNumTxt.Text.Length != 0)
            {
                rackNum = int.Parse(rackNumTxt.Text);

                if (rackNum <= 0 || rackNum > 24)
                {
                    MessageBox.Show("랙 번호가 아닙니다.", "에러", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                MessageBox.Show("랙 번호를 지정해주세요.", "에러", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 현재 위치한 랙 번호와 같은 번호로는 경로지정 불가 
            beforenum.Add(rackNum);

            if (beforenum[0] == beforenum[1])
            {
                MessageBox.Show("이미 해당 랙에 위치해 있습니다.", "에러", MessageBoxButtons.OK, MessageBoxIcon.Error);
                beforenum.RemoveAt(beforenum.Count-1);
                return;
            }
            else
            {
                beforenum.RemoveAt(0);
            }

            LogListBox.Items.Add(now+ $"     {rackNum}번 랙으로 이동");
            startBtn.Enabled = false;
            outRange = false;

            timer1.Start();
            timer2.Start();
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
                loadfreightText += rackNum + " ";
                rackList.Add(rackNum);
                LogListBox.Items.Add(now + $"     {rackNum}번 화물 적재 완료!");
                agv.freightListBox.Text = loadfreightText;
            }
            else
            {
                MessageBox.Show($"이미 {rackNum}번 화물을 Load했습니다.", "에러", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

            // AGV 이름과 경로 그리고 운행시간
            string name = agv.agvNameBox.Text;
            string path = agv.movingPathBox.Text;
            string worktime = agv.moveTimeLabel.Text;

            // 출고지에 있다면 unload 가능
            if (isRelease == true || rackList.Contains(rackNum))
            {
                // 화물이 있다면 unload ,없다면 unload x
                if (rackList.Count != 0)
                {
                    string racknums = "";

                    // 출고지에서는 하역시 모든 화물 unload
                    if (isRelease == true)
                    {
                        releaseCount++;
                        foreach (int num in rackList)
                        {
                            racknums += num.ToString() + "번 ";
                            releaseFreightList.Add(num.ToString());
                        }
                        LogListBox.Items.Add(now + $"     {racknums}랙의 화물을 Unload 하였습니다.");
                        
                        string unloads = racknums;
                        string unloadtime = now;
                        int unloadnum = releaseCount;

                        state = "출고 완료";

                        rackList.Clear();
                        loadfreightText = "";

                        // 팝업창에 데이터 추가
                        agv.releaseNumLabel.Text = releaseCount.ToString();
                        agv.freightListBox.Text = "";
                        agv.releaseFreightBox.Items.AddRange(releaseFreightList.ToArray());

                        releaseFreightList.Clear();

                        // AGV DB에 데이터 추가
                        msSqlExample.InsertAGVDB(name, path,unloads, worktime, unloadtime,unloadnum,state);


                    }
                    // 랙에서는 해당 번호의 화물만 unload
                    else if (isRelease == false)
                    {
                        racknums += rackNum.ToString() + "번 ";
                        LogListBox.Items.Add(now + $"     {racknums}랙의 화물을 Unload 하였습니다.");
                        int idx = rackList.FindIndex(x => x == rackNum);
                        rackList.RemoveAt(idx);
                        isLoad = false;
                        string nums = "";
                        foreach (int num in rackList)
                        {
                            nums += num + " ";
                        }
                        loadfreightText = nums;
                        agv.freightListBox.Text = loadfreightText;
                    }
                }
                else
                {
                    MessageBox.Show("Unload할 화물이 없습니다.", "에러", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    state = "에러";
                    msSqlExample.InsertAGVDB(name,path,"",worktime,now,releaseCount,state);

                    return;
                }
            }
            else
            {
                MessageBox.Show("Unload 할 화물이 없습니다.", "에러", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            agv.stateLabel.Text = state;
            // 새로운 로그가 있을때 자동으로 스크롤바 내림.
            LogListBox.MakeItemVisible(LogListBox.ItemCount);
        }

        // 입고위치로 이동(초기 위치)
        private void ReceivePathBtn_Click(object sender, EventArgs e)
        {
            // 현재 시간
            string now = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

            LogListBox.Items.Add(now+"     초기 위치로 돌아갑니다.");
            isReceive = true;
            isRelease = false;
            rackNumTxt.Text = "";
            RackLoadBtn.Enabled = false;
            RackUnLoadBtn.Enabled = false;

            timer1.Start();
            timer2.Start();
        }

        // 출고위치로 이동
        private void ReleasePathBtn_Click(object sender, EventArgs e)
        {
            // 현재 시간
            string now = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

            LogListBox.Items.Add(now+"     출고점으로 이동합니다.");
            isReceive = false;
            isRelease = true;
            timer1.Start();
            timer2.Start();
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

        // 초기 위치로 초기화
        private void ResetPathBtn_Click(object sender, EventArgs e)
        {

            agv.Hide();
            time = 0;
            agv.moveTimeLabel.Text = time + ":" + time;
            rec.X = 25;
            rec.Y = 25;

            timer2.Stop();

            string now = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

            LogListBox.Items.Add(now + "     초기화");

            // 새로운 로그가 있을때 자동으로 스크롤바 내림.
            LogListBox.MakeItemVisible(LogListBox.ItemCount);

            rackNumTxt.Text = "";
            isReceive = false;
            isRelease = false;

            // 버튼 비활성화
            ResetPathBtn.Enabled = false;
            ReceivePathBtn.Enabled = false;
            ReleasePathBtn.Enabled = true;
            RackLoadBtn.Enabled = false;
            RackUnLoadBtn.Enabled = false;

            // 보유 화물 클리어
            rackList.Clear();
            loadfreightText = "";

            //로그 텍스트 클리어
            LogListBox.Items.Clear();

            // 이동경로 클리어
            movingPath = "";

            agv.stateLabel.Text = "입고지 정차";
            agv.agvPosLabel.Text = string.Format("X : {0} Y : {1}", rec.X, rec.Y);
            agv.agvSpeedLabel.Text = "10";
            agv.movingPathBox.Text = "";
            agv.freightListBox.Clear();
            agv.releaseNumLabel.Text = "0";
            agv.releaseFreightBox.Items.Clear();

            timer1.Interval = 201;

        }

        // Form Closing Event
        private void this_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = false;
        }

        // 폼이 닫힌 후에 모든 프로그램 종료
        private void this_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Agv_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            agv.Hide();
        }

    }

}