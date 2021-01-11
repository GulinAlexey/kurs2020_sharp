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

        private void main_game_Load(object sender, EventArgs e)
        {
             this.kolvo_krest_text.Text = "Крестьяне: " + (Program.derevn.get_kolvo_krest())+ " чел.";;
			 this.skorost_zhiz_text.Text = "Скорость жизни: " + (Program.derevn.get_speed_life());
			 this.den_procv_text.Text = "Дни Процветания: " + (Program.derevn.get_days_procv());
			 this.budget_text.Text = "Бюджет: " + (Program.derevn.get_budget_village()) + " руб.";
			 this.hleb_text.Text = "Хлеб: " + (Program.derevn.get_kolvo_hleb()) + " ед.";
			 this.skot_text.Text = "Домашний скот: " + (Program.derevn.get_kolvo_skot()) + " ед.";
			 if(Program.derevn.get_flag_season()==0)
				this.time_helper.Text = "До конца Лета осталось " + (40 -(Program.derevn.get_hours_procv() - Program.derevn.get_hours_from_begin_of_season())) + " Часов Процветания.";
			 if(Program.derevn.get_flag_season()==1)
			 {
				this.time_helper.Text = "До конца Зимы осталось " + (20 -(Program.derevn.get_hours_procv() - Program.derevn.get_hours_from_begin_of_season())) + " Часов Процветания.";
				this.BackgroundImage = Image.FromFile("zima.jpg"); //изменить фон на зимний
			 }
        }
    }
}
