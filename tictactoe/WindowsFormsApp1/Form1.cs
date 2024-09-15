using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        char Player = 'X';
       
        public Form1()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Button playbutton = sender as Button;
            playbutton.Enabled = false;
            playbutton.BackColor = Color.Cyan;
            if (Player == 'X')
            {
                playbutton.Text = "X";
                if ((A1.Text == A2.Text && A2.Text == A3.Text && A1.Text != "") ||
                   (B1.Text == B2.Text && B2.Text == B3.Text && B1.Text != "") ||
                   (C1.Text == C2.Text && C2.Text == C3.Text && C1.Text != "") ||
                   (A1.Text == B1.Text && B1.Text == C1.Text && A1.Text != "") ||
                   (A2.Text == B2.Text && B2.Text == C2.Text && A2.Text != "") ||
                   (A3.Text == B3.Text && B3.Text == C3.Text && A3.Text != "") ||
                   (A1.Text == B2.Text && B2.Text == C3.Text && A1.Text != "") ||
                   (A3.Text == B2.Text && B2.Text == C1.Text && A3.Text != ""))
                {
                    MessageBox.Show(($" {Player.ToString()}  wins !!! :D"));
                    A1.Enabled = false;
                    A2.Enabled = false;
                    A3.Enabled = false;
                    B1.Enabled = false;
                    B3.Enabled = false;
                    B2.Enabled = false;
                    C1.Enabled = false;
                    C2.Enabled = false;
                    C3.Enabled = false;


                }
                else if (A1.Text!= "" && A2.Text != "" && A3.Text != "" &&
                    B1.Text !="" && B2.Text !="" && B3.Text !="" &&
                    C1.Text != "" && C2.Text != "" && C3.Text != "")
                {
                    MessageBox.Show("Game Over!!!");
                }
                Player = 'O';
            }
            else if (Player == 'O')
            {
                playbutton.Text = "O";
                if ((A1.Text == A2.Text && A2.Text == A3.Text && A1.Text != "") ||
                  (B1.Text == B2.Text && B2.Text == B3.Text && B1.Text != "") ||
                  (C1.Text == C2.Text && C2.Text == C3.Text && C1.Text != "") ||
                  (A1.Text == B1.Text && B1.Text == C1.Text && A1.Text != "") ||
                  (A2.Text == B2.Text && B2.Text == C2.Text && A2.Text != "") ||
                  (A3.Text == B3.Text && B3.Text == C3.Text && A3.Text != "") ||
                  (A1.Text == B2.Text && B2.Text == C3.Text && A1.Text != "") ||
                  (A3.Text == B2.Text && B2.Text == C1.Text && A3.Text != ""))
                {
                    MessageBox.Show(($" {Player.ToString()}  wins !!! :D"));
                    A1.Enabled = false;
                    A2.Enabled = false;
                    A3.Enabled = false;
                    B1.Enabled = false;
                    B3.Enabled = false;
                    B2.Enabled = false;
                    C1.Enabled = false;
                    C2.Enabled = false;
                    C3.Enabled = false;

                }
                else if (A1.Text != "" && A2.Text != "" && A3.Text != "" &&
                    B1.Text != "" && B2.Text != "" && B3.Text != "" &&
                    C1.Text != "" && C2.Text != "" && C3.Text != "")
                {
                    MessageBox.Show("Game Over!!!");
                }
                    Player = 'X';
            }
        }

        private void button_NewGame_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void button_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_NewGame_MouseEnter(object sender, EventArgs e)
        {
            button_NewGame.ForeColor = Color.Blue;
        }

        private void button_NewGame_MouseLeave(object sender, EventArgs e)
        {
            button_NewGame.ForeColor = Color.DarkBlue;
        }

        private void button_Exit_MouseEnter(object sender, EventArgs e)
        {
            button_Exit.ForeColor = Color.Blue;
        }

        private void button_Exit_MouseLeave(object sender, EventArgs e)
        {
            button_Exit.ForeColor = Color.DarkBlue;
        }

        private void buttonInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Done by Bita Saeed s9919314 - thanks for playing :D");
        }

        private void buttonInfo_MouseEnter(object sender, EventArgs e)
        {
            buttonInfo.ForeColor = Color.DeepPink;
        }

        private void buttonInfo_MouseLeave(object sender, EventArgs e)
        {
            buttonInfo.ForeColor = Color.Purple;
        }
    }
}
