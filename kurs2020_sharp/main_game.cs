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
    public partial class main_game : Form
    {
        public main_game()
        {
            InitializeComponent();
        }

        private void go_to_main_menu_butt_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void spravk_lent_butt_Click(object sender, EventArgs e)
        {
            Form sprv = new spravk();
            sprv.ShowDialog();
            sprv.Controls.Clear();
        }

        private void spisok_krest_butt_Click(object sender, EventArgs e)
        {
            Form tablk = new tabl_krest();
            tablk.ShowDialog();
            tablk.Controls.Clear();
        }

        private void birzha_butt_Click(object sender, EventArgs e)
        {
            Form sellt = new sell_tovar();
            sellt.ShowDialog();
            sellt.Controls.Clear();
        }
    }
}
