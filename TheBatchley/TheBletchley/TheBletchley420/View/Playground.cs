using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheBletchley420.View
{
    public partial class Playground : Form
    {
        List<int> termsList = new List<int>();

        public Playground()
        {
            InitializeComponent();
            Random rnd = new Random();
            termsList.Add(rnd.Next(0, 8));
            while(termsList.Count != 4)
            {
                int i = rnd.Next(0, 8);
                foreach (var item in termsList)
                {
                    if (item == i)
                    {
                        i = -1;
                        break; 
                    }
                }
                if (-1 == i)
                {
                    continue;
                }
                termsList.Add(i);
            }
           // lblPlayer1.Text = termsList[0]+"/"+ termsList[1]+"/"+ termsList[2]+"/"+ termsList[3];
        }
        List<int> Player1 = new List<int>();
        List<int> Player2 = new List<int>();
        int Turn = 1;
        int hod = 0;
        int all = 0;
        private void Playground_Load(object sender, EventArgs e)
        {

        }
        private void enable()
        {
            all++;
            if (all == 13)
            {
                MessageBox.Show("Out of turns :(");
                this.Close();
            }
            Btn0.Enabled = true;
            Btn01.Enabled = true;
            Btn1.Enabled = true;
            Btn2.Enabled = true;
            Btn3.Enabled = true;
            Btn4.Enabled = true;
            Btn5.Enabled = true;
            Btn6.Enabled = true;
            Btn7.Enabled = true;
            Btn8.Enabled = true;
            Btn9.Enabled = true;
            Btn10.Enabled = true;
            Btn11.Enabled = true;
            Btn12.Enabled = true;
            Btn13.Enabled = true;
            Btn14.Enabled = true;
            Player1.Clear();
            Player2.Clear();
        }
        private void move(int btn)
        {
            if (Turn == 1)
            {
                if (termsList[hod] == btn)
                {
                    Player1.Add(btn);
                    lblNumbers1.Text += termsList[hod] + ", ";
                    hod++;
                    if (hod == 4)
                    {
                        MessageBox.Show("YOU WIN!!!");
                    }
                }
                else
                {
                    lblNumbers1.Text = "Your coordinates:";
                    Turn = 2;
                    hod = 0;
                    enable();
                }
            }
            else
            {
                if (termsList[hod] == btn)
                {
                    Player2.Add(btn);
                    lblNumbers2.Text += termsList[hod] + ", ";
                    hod++;
                    if(hod == 4)
                    {
                        MessageBox.Show("YOU WIN!!!");
                    }
                }
                else
                {
                    lblNumbers2.Text = "Your coordinates:";
                    hod = 0;
                    Turn = 1;
                    enable();
                }
            }
        }
        private void Btn0_Click(object sender, EventArgs e)
        {
            int local = 0;//номер на бутона
            
            if (Turn == 1)
            {
                foreach (var item in Player1)
                {
                    if (item == local)
                    {
                        local = -1;
                    }
                }
            }
            else
            {
                foreach (var item in Player2)
                {
                    if (item == local)
                    {
                        local = -1;
                    }
                }
            }
            if (local != -1)
            {
                Btn0.Enabled = false;
                move(local);
            }
        }

        private void lblPlayer1_Click(object sender, EventArgs e)
        {

        }

        private void Btn1_Click(object sender, EventArgs e)
        {//1
            int local = 1;//номер на бутона

            if (Turn == 1)
            {
                foreach (var item in Player1)
                {
                    if (item == local)
                    {
                        local = -1;
                    }
                }
            }
            else
            {
                foreach (var item in Player2)
                {
                    if (item == local)
                    {
                        local = -1;
                    }
                }
            }
            if (local != -1)
            {
                Btn1.Enabled = false;
                move(local);
            }
        }

        private void Btn8_Click(object sender, EventArgs e)
        {//4
            int local = 4;//номер на бутона

            if (Turn == 1)
            {
                foreach (var item in Player1)
                {
                    if (item == local)
                    {
                        local = -1;
                    }
                }
            }
            else
            {
                foreach (var item in Player2)
                {
                    if (item == local)
                    {
                        local = -1;
                    }
                }
            }
            if (local != -1)
            {
                Btn8.Enabled = false;
                move(local);
            }
        }

        private void Btn6_Click(object sender, EventArgs e)
        {//3
            int local = 3;//номер на бутона

            if (Turn == 1)
            {
                foreach (var item in Player1)
                {
                    if (item == local)
                    {
                        local = -1;
                    }
                }
            }
            else
            {
                foreach (var item in Player2)
                {
                    if (item == local)
                    {
                        local = -1;
                    }
                }
            }
            if (local != -1)
            {
                Btn6.Enabled = false;
                move(local);
            }
        }

        private void Btn14_Click(object sender, EventArgs e)
        {//7
            int local = 7;//номер на бутона

            if (Turn == 1)
            {
                foreach (var item in Player1)
                {
                    if (item == local)
                    {
                        local = -1;
                    }
                }
            }
            else
            {
                foreach (var item in Player2)
                {
                    if (item == local)
                    {
                        local = -1;
                    }
                }
            }
            if (local != -1)
            {
                Btn14.Enabled = false;
                move(local);
            }
        }

        private void Btn5_Click(object sender, EventArgs e)
        {//3
            int local = 3;//номер на бутона

            if (Turn == 1)
            {
                foreach (var item in Player1)
                {
                    if (item == local)
                    {
                        local = -1;
                    }
                }
            }
            else
            {
                foreach (var item in Player2)
                {
                    if (item == local)
                    {
                        local = -1;
                    }
                }
            }
            if (local != -1)
            {
                Btn5.Enabled = false;
                move(local);
            }
        }

        private void Btn3_Click(object sender, EventArgs e)
        {//2
            int local = 2;//номер на бутона

            if (Turn == 1)
            {
                foreach (var item in Player1)
                {
                    if (item == local)
                    {
                        local = -1;
                    }
                }
            }
            else
            {
                foreach (var item in Player2)
                {
                    if (item == local)
                    {
                        local = -1;
                    }
                }
            }
            if (local != -1)
            {
                Btn3.Enabled = false;
                move(local);
            }
        }

        private void Btn7_Click(object sender, EventArgs e)
        {//4
            int local = 4;//номер на бутона

            if (Turn == 1)
            {
                foreach (var item in Player1)
                {
                    if (item == local)
                    {
                        local = -1;
                    }
                }
            }
            else
            {
                foreach (var item in Player2)
                {
                    if (item == local)
                    {
                        local = -1;
                    }
                }
            }
            if (local != -1)
            {
                Btn7.Enabled = false;
                move(local);
            }
        }

        private void Btn13_Click(object sender, EventArgs e)
        {//7
            int local = 7;//номер на бутона

            if (Turn == 1)
            {
                foreach (var item in Player1)
                {
                    if (item == local)
                    {
                        local = -1;
                    }
                }
            }
            else
            {
                foreach (var item in Player2)
                {
                    if (item == local)
                    {
                        local = -1;
                    }
                }
            }
            if (local != -1)
            {
                Btn13.Enabled = false;
                move(local);
            }
        }

        private void Btn9_Click(object sender, EventArgs e)
        {//5
            int local = 5;//номер на бутона

            if (Turn == 1)
            {
                foreach (var item in Player1)
                {
                    if (item == local)
                    {
                        local = -1;
                    }
                }
            }
            else
            {
                foreach (var item in Player2)
                {
                    if (item == local)
                    {
                        local = -1;
                    }
                }
            }
            if (local != -1)
            {
                Btn9.Enabled = false;
                move(local);
            }
        }

        private void Btn11_Click(object sender, EventArgs e)
        {//6
            int local = 6;//номер на бутона

            if (Turn == 1)
            {
                foreach (var item in Player1)
                {
                    if (item == local)
                    {
                        local = -1;
                    }
                }
            }
            else
            {
                foreach (var item in Player2)
                {
                    if (item == local)
                    {
                        local = -1;
                    }
                }
            }
            if (local != -1)
            {
                Btn11.Enabled = false;
                move(local);
            }
        }

        private void Btn2_Click(object sender, EventArgs e)
        {//1
            int local = 1;//номер на бутона

            if (Turn == 1)
            {
                foreach (var item in Player1)
                {
                    if (item == local)
                    {
                        local = -1;
                    }
                }
            }
            else
            {
                foreach (var item in Player2)
                {
                    if (item == local)
                    {
                        local = -1;
                    }
                }
            }
            if (local != -1)
            {
                Btn2.Enabled = false;
                move(local);
            }
        }

        private void Btn12_Click(object sender, EventArgs e)
        {//6
            int local = 6;//номер на бутона

            if (Turn == 1)
            {
                foreach (var item in Player1)
                {
                    if (item == local)
                    {
                        local = -1;
                    }
                }
            }
            else
            {
                foreach (var item in Player2)
                {
                    if (item == local)
                    {
                        local = -1;
                    }
                }
            }
            if (local != -1)
            {
                Btn12.Enabled = false;
                move(local);
            }
        }

        private void Btn10_Click(object sender, EventArgs e)
        {//5
            int local = 5;//номер на бутона

            if (Turn == 1)
            {
                foreach (var item in Player1)
                {
                    if (item == local)
                    {
                        local = -1;
                    }
                }
            }
            else
            {
                foreach (var item in Player2)
                {
                    if (item == local)
                    {
                        local = -1;
                    }
                }
            }
            if (local != -1)
            {
                Btn10.Enabled = false;
                move(local);
            }
        }

        private void Btn4_Click(object sender, EventArgs e)
        {//2
            int local = 2;//номер на бутона

            if (Turn == 1)
            {
                foreach (var item in Player1)
                {
                    if (item == local)
                    {
                        local = -1;
                    }
                }
            }
            else
            {
                foreach (var item in Player2)
                {
                    if (item == local)
                    {
                        local = -1;
                    }
                }
            }
            if (local != -1)
            {
                Btn4.Enabled = false;
                move(local);
            }
        }

        private void Btn01_Click(object sender, EventArgs e)
        {
            int local = 0;//номер на бутона

            if (Turn == 1)
            {
                foreach (var item in Player1)
                {
                    if (item == local)
                    {
                        local = -1;
                    }
                }
            }
            else
            {
                foreach (var item in Player2)
                {
                    if (item == local)
                    {
                        local = -1;
                    }
                }
            }
            if (local != -1)
            {
                Btn01.Enabled = false;
                move(local);
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = "Player " + Turn + "'s turn";
            label2.Text = all + " iterations";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lblNumbers1_Click(object sender, EventArgs e)
        {

        }

        private void txtBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
