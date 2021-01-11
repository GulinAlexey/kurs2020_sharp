using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace kurs2020_sharp
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

        //Обявления переменных
        public Village derevn; //объект, в котором хранится вся информация о деревне (глобальн.)
        public Village birzh_trud; //объект, в котором хранятся крестьяне для найма (глобальн.)
        public int f_endgame = 0; //флаг о том, что игра окончена (игрок проиграл) (глобальн.)
    }
}
