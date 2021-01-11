﻿using System;
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

        private void num_sell_TextChanged(object sender, EventArgs e)
        {
             int zapas_hleb=Program.derevn.get_kolvo_hleb(); //получить кол-во хлеба в деревне
			 int zapas_skot=Program.derevn.get_kolvo_skot(); //получить кол-во скота в деревне
			 if (this.num_sell.Text!="") //если поле с номером строки не пустое
			 {
				 if(this.hleb_radio.Checked == true) //если выбран хлеб для продажи
				 {
                     if ((Convert.ToDouble(this.num_sell.Text) > Program.derevn.get_kolvo_hleb()) || (Convert.ToDouble(this.num_sell.Text) <= 0))
					 {
						 this.sell_butt.Enabled = false;
					 }
					 else
					 {
						 this.sell_butt.Enabled = true;
					 }
				 }
				 if(this.skot_radio.Checked == true) //если выбран скот для продажи
				 {
                     if ((Convert.ToDouble(this.num_sell.Text) > Program.derevn.get_kolvo_skot()) || (Convert.ToDouble(this.num_sell.Text) <= 0))
					 {
						 this.sell_butt.Enabled = false;
					 }
					 else
					 {
						 this.sell_butt.Enabled = true;
					 }
				 }
			 }
			 else
				 this.sell_butt.Enabled = false;
        }

        private void skot_radio_CheckedChanged(object sender, EventArgs e)
        {
            num_sell_TextChanged(sender, e);
        }
    }
}
