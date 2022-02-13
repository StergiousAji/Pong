using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pong
{
    public partial class UcSettings : UserControl
    {
        public UcSettings()
        {
            InitializeComponent();

            chbRallyCounter.Top -= 50;
        }

        private void NupPaddleSpeed_ValueChanged(object sender, EventArgs e)
        {
            FrmPong.paddle_speed = (int)nupPaddleSpeed.Value;
        }

        private void NupBallSpeed_ValueChanged(object sender, EventArgs e)
        {
            FrmPong.ball_speed = (int)nupBallSpeed.Value;
        }

        private void ChbMaxScore_CheckStateChanged(object sender, EventArgs e)
        {
            if (chbMaxScore.Checked)
            {
                FrmPong.maxScoreB = true;
                chbRallyCounter.Top += 50;
                lblMaxScore.Show();
                nupMaxScore.Show();
            }
            else
            {
                FrmPong.maxScoreB = false;
                lblMaxScore.Hide();
                nupMaxScore.Hide();
                chbRallyCounter.Top -= 50;
            }
        }

        private void NupMaxScore_ValueChanged(object sender, EventArgs e)
        {
            FrmPong.maxScore = (int)nupMaxScore.Value;
        }

        private void ChbRallyCounter_CheckStateChanged(object sender, EventArgs e)
        {
            FrmPong.rallyB = chbRallyCounter.Checked;
        }

        private void NUPSinglePlayerRNG_ValueChanged(object sender, EventArgs e)
        {
            FrmPong.singlePlayerRNG = (int)nupSinglePlayerRNG.Value;
        }
    }
}
