using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Family_Feud
{
    public partial class form1 : Form
    {
        int score, lives = 3, win = 0;
        int totalseconds = 60;
        int dmin, dsec;
        public form1()
        {
            InitializeComponent();
        }

        private void lblQuestion_Click(object sender, EventArgs e)
        {

        }

        private void btnEnter_Click(object sender, EventArgs e)
        {

        }

        private void lbl60_Click(object sender, EventArgs e)
        {

        }

        private void txtAnswer_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {


        }

        private void form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void dfsf(object sender, KeyEventArgs e)
        {

        }

        private void dfsf(object sender, KeyPressEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            dmin = totalseconds / 60;
            dsec = totalseconds % 60;
            if (dsec > 9)
            {
                LBLTIME.Text = dmin + ":" + dsec;
            }
            else
            {
                LBLTIME.Text = dmin + ":0" + dsec;
            }

            totalseconds = totalseconds - 1;

            if (totalseconds == -1)
            {
                timer1.Stop();
                MessageBox.Show("You are all out of time, better luck next time");
                this.Close();
            }
        }

        private void btnEnter_Click_1(object sender, EventArgs e)
        {
            string answer = txtAnswer.Text.ToUpper();
            if (txtAnswer.SelectionLength == 0)
            {

            }
            if (answer == "NO")
            {
                win = win + 1;
                score = score + 60;
                lblScore.Text = score.ToString();
                lblNo.Visible = true;
                lbl60.Visible = true;
                picNoBack2.Visible = true;
                picNoBack1.Visible = true;
            }

            else if (answer == "SIT")
            {
                win = win + 1;
                score = score + 45;
                lblScore.Text = score.ToString();
                lblSit.Visible = true;
                lbl45.Visible = true;
                picSitBack2.Visible = true;
                picSitBack1.Visible = true;
            }

            else if (answer == "STOP")
            {
                win = win + 1;
                score = score + 25;
                lblScore.Text = score.ToString();
                lblStop.Visible = true;
                lbl25.Visible = true;
                picStopBack2.Visible = true;
                picStopBack1.Visible = true;
            }

            else if (answer == "DOWN")
            {
                win = win + 1;
                score = score + 16;
                lblScore.Text = score.ToString();
                lblDown.Visible = true;
                lbl16.Visible = true;
                picDownBack2.Visible = true;
                picDownBack1.Visible = true;
            }

            else if (answer == "FETCH")
            {
                win = win + 1;
                score = score + 10;
                lblScore.Text = score.ToString();
                lblFetch.Visible = true;
                lbl10.Visible = true;
                picFetchBack2.Visible = true;
                picFetchBack1.Visible = true;
            }

            else if (answer == "BAD")
            {
                win = win + 1;
                score = score + 5;
                lblScore.Text = score.ToString();
                lblBad.Visible = true;
                lbl5.Visible = true;
                picBadBack2.Visible = true;
                picBadBack1.Visible = true;
            }
            else
            {

                lives = lives - 1;
                if (lives == 2)
                {
                    MessageBox.Show("That is incorrect you have 2 lives left");
                }
                if (lives == 1)
                {
                    MessageBox.Show("That is incorrect you have 1 life left");
                }
                if (lives == 0)
                {
                    MessageBox.Show("That is incorrect, sorry you lose");
                    this.Close();
                }

            
                   
                
            }
                if (win == 6)
                    {
                        MessageBox.Show("Good job you found all the words! You Win!");
                        this.Close();
                    }

            txtAnswer.Clear();
            Focus();
            // 1 digit
            if ((lblScore.Text.Length < 2) && (lblScore.Text.Length > 0))
            {
                lblScore.Location = new Point(414, 12);
                lblScore.Size = new Size(60, 59);
            }
            // 2 digits
            if ((lblScore.Text.Length < 3) && (lblScore.Text.Length > 1))
            {
                lblScore.Location = new Point(398, 20);
                lblScore.Size = new Size(95, 59);
            }
            // 3 digits
            if ((lblScore.Text.Length < 4) && (lblScore.Text.Length > 2))
            {
                lblScore.Location = new Point(380, 21);
                lblScore.Size = new Size(130, 59);
            }
        }


        private void lblScore_Click(object sender, EventArgs e)
        {

        }
    } 
}
