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
    public partial class tabl_krest : Form
    {
        public tabl_krest()
        {
            InitializeComponent();
        }

        private void trud_butt_Click(object sender, EventArgs e)
        {
            Form tabnaim = new tabl_naim();
            tabnaim.ShowDialog();
            tabnaim.Controls.Clear();
        }

        private void tabl_krest_Activated(object sender, EventArgs e)
        {
            if(Program.f_endgame==1) //игра закончилась, закрыть все формы
				 this.Close();
		    else
		    {
			    //очистить все строки перед выводом
			    while (0 != spisok.RowCount)
				    spisok.Rows.RemoveAt(0);

			    int kolvo_str=Program.derevn.get_kolvo_krest(); //получить кол-во крестьян в списке
			    for(int num=0; num<kolvo_str; num++)
			    {
				    spisok.Rows.Add(); //добавить новую строку в таблицу
				    spisok.Rows[num].Cells[0].Value = (num+1); //записать порядковый номер крестьянина
				    spisok.Rows[num].Cells[1].Value = (Program.derevn.krests[num].get_name() + " " + Program.derevn.krests[num].get_surname()); //внести в ячейку таблицы
				    spisok.Rows[num].Cells[2].Value = (Program.derevn.krests[num].get_proizv_hleb()) + "/" + (Program.derevn.krests[num].get_proizv_skot());
				    spisok.Rows[num].Cells[3].Value = (Program.derevn.krests[num].get_eda_hleb()*Program.derevn.get_speed_life()) + "/" + (Program.derevn.krests[num].get_eda_skot()*Program.derevn.get_speed_life());
				    spisok.Rows[num].Cells[4].Value = (Program.derevn.krests[num].get_money_trat()*Program.derevn.get_speed_life());
			    }
		    }

        }
    }
}
