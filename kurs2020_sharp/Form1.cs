using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace kurs2020_sharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void quit_butt_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void spravk_butt_Click(object sender, EventArgs e)
        {
            Form spr = new spravk();
            spr.ShowDialog();
            spr.Controls.Clear();
        }

        private void new_game_butt_Click(object sender, EventArgs e)
        {
            Program.f_endgame = 0; //флаг конца игры (будет равен 1, когда игрок проиграет)
            Program.derevn.Init_new_game(); //инициализация деревни перед началом новой игры
            Form mg = new main_game();
            mg.ShowDialog();
            mg.Controls.Clear();
        }

        private void records_butt_Click(object sender, EventArgs e)
        {
            Form rectab = new record_tabl();
            rectab.ShowDialog();
            rectab.Controls.Clear();
        }
    }
}
