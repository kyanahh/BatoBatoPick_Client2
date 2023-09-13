using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FernandezBatoBatoPick
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int num = random.Next(1, 4);
            string compChoice = "";

            if (num == 1)
            {
                compChoice = "Bato";
            }
            else if (num == 2)
            {
                compChoice = "Papel";
            }
            else if (num == 3)
            {
                compChoice = "Gunting";
            }

            txtResult.Text = compChoice;

            int pc = Convert.ToInt32(txtComp.Text);
            int user = Convert.ToInt32(txtUser.Text);

            while (!((pc == 3 && user < pc) || (user == 3 && pc < user)))
            {
                if (rdbBato.Checked == true && compChoice == "Bato" || rdbPapel.Checked == true && compChoice == "Papel" || rdbGunting.Checked == true && compChoice == "Gunting")
                {
                    txtResult.Text = "It's a tie! Computer's choice is " + compChoice;
                    rdbBato.Checked = false;
                    rdbGunting.Checked = false;
                    rdbPapel.Checked = false;
                    return;
                }
                else if (rdbBato.Checked == true && compChoice == "Papel" || rdbPapel.Checked == true && compChoice == "Gunting" || rdbGunting.Checked == true && compChoice == "Bato")
                {
                    txtResult.Text = "Computer Wins! Computer's choice is " + compChoice;
                    pc++;
                    txtComp.Text = pc.ToString();
                    rdbBato.Checked = false;
                    rdbGunting.Checked = false;
                    rdbPapel.Checked = false;
                    return;
                }
                else if (rdbBato.Checked == true && compChoice == "Gunting" || rdbPapel.Checked == true && compChoice == "Bato" || rdbGunting.Checked == true && compChoice == "Papel")
                {
                    txtResult.Text = "User Wins! Computer's choice is " + compChoice;
                    user++;
                    txtUser.Text = user.ToString();
                    rdbBato.Checked = false;
                    rdbGunting.Checked = false;
                    rdbPapel.Checked = false;
                    return;
                }
            }

            if (pc == 3 && user < pc)
            {
                MessageBox.Show("Winner : Computer", "Congrats!", MessageBoxButtons.OK);
                rdbBato.Checked = false;
                rdbGunting.Checked = false;
                rdbPapel.Checked = false;
                pc = 0;
                user = 0;
                txtUser.Text = user.ToString();
                txtComp.Text = pc.ToString();
            }
            else if (user == 3 && user > pc)
            {
                MessageBox.Show("Winner : User", "Congrats!", MessageBoxButtons.OK);
                rdbBato.Checked = false;
                rdbGunting.Checked = false;
                rdbPapel.Checked = false;
                pc = 0;
                user = 0;
                txtUser.Text = user.ToString();
                txtComp.Text = pc.ToString();
            }
        }
    }
}
