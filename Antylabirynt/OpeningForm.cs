using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Antylabirynt
{
    public partial class OpeningForm : Form
    {
        public OpeningForm()
        {
            InitializeComponent();
        }

        private void lvl1_click(object sender, EventArgs e)
        {
            openGame(1);
        }
        private void lvl2_click(object sender, EventArgs e)
        {
            openGame(2);
        }
        private void lvl3_click(object sender, EventArgs e)
        {
            openGame(3);
        }

        private void enableLvl(object sender, EventArgs e)
        {
            if (passwordBox.Text == "pleaseLvl2")
            {
                poziom2_button.Enabled = true;
            }

            else if (passwordBox.Text == "pleaseLvl3")
            {
                poziom2_button.Enabled = true;
                button3.Enabled = true;
            }

            else
            {
                MessageBox.Show("Error! Brak takiego hasła!", "Błędne hasło!");
                passwordBox.Clear();
            }
        }

        private void openGame(int level)
        {
            this.Hide();
            Form gameForm = new GameForm(level);
            gameForm.ShowDialog();
            gameForm = null;
            this.Close();
        }

    }
}
