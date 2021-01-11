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
    public partial class sell_tovar : Form
    {
        public sell_tovar()
        {
            InitializeComponent();
        }

        private void sell_tovar_Activated(object sender, EventArgs e)
        {
            this.price_hleb_text.Text = "Текущая цена за ед. хлеба: " + (Program.derevn.get_price_hleb()) + " руб.";
            this.price_skot_text.Text = "Текущая цена за голову скота: " + (Program.derevn.get_price_skot()) + " руб.";
        }
    }
}
