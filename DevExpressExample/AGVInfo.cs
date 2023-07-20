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

namespace DevExpressExample
{

    public partial class AGVInfo : DevExpress.XtraEditors.XtraForm
    {

        public bool isSpeedSet = false;
        int agvSpeed = 10;

        public AGVInfo()
        {
            InitializeComponent();
        }

        private void AGVData_Load(object sender, EventArgs e)
        {
            agvNameBox.Text = "AGV_01";
        }

        // AGV 중지 버튼
        private void pauseBtn_Click(object sender, EventArgs e)
        {
            pauseBtn.Enabled = false;
            moveBtn.Enabled = true;

            Prograｍ.MainForm.timer1.Enabled = false;
            Prograｍ.MainForm.timer2.Enabled = false;
        }

        // AGV 재개 버튼
        private void moveBtn_Click(object sender, EventArgs e)
        {

            pauseBtn.Enabled = true;
            moveBtn.Enabled = false;

            Prograｍ.MainForm.timer1.Enabled = true;
            Prograｍ.MainForm.timer2.Enabled = true;
        }

        // 증속 
        private void spUpBtn_Click(object sender, EventArgs e)
        {
            if (Prograｍ.MainForm.timer1.Interval > 20)
            {
                agvSpeed += 1;
                Prograｍ.MainForm.timer1.Interval -= 20;
                agvSpeedLabel.Text = agvSpeed.ToString();
            }
            else
            {
                MessageBox.Show("이미 최대 속도입니다.", "에러", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        // 감속
        private void spDownBtn_Click(object sender, EventArgs e)
        {
            if (Prograｍ.MainForm.timer1.Interval < 380)
            {
                agvSpeed -= 1;
                Prograｍ.MainForm.timer1.Interval += 20;
                agvSpeedLabel.Text = agvSpeed.ToString();
            }
            else
            {
                MessageBox.Show("최소 속도 밑으로는 내릴 수 없습니다.", "에러", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}