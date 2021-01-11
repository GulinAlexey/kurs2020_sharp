using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace kurs2020_sharp
{
    class Krest
    {
        private string name; //Имя
        private string surname; //Фамилия
        private int proizv_hleb; //Кол-во производимого хлеба за Час Процветания
        private int proizv_skot; //Кол-во производимого домашнего скота за Час Процветания 
        private int eda_hleb; //Прожорливость: хлеб 
        private int eda_skot; //Прожорливость: домашний скот 
        private int money_trat; //Денежные расходы за один Час Процветания 
        private int naim; //Стоимость найма в рублях 
        private int otschet_hours_net_edi; //Отсчёт времени в Часах Процветания с момента, когда закончилась еда для этого крестьянина
    
        public Krest() //конструктор без параметров
        {
	        name="name"; 
	        surname="surname"; 
	        proizv_hleb=0; 
	        proizv_skot=0;
	        eda_hleb=0;
	        eda_skot=0; 
	        money_trat=0; 
	        naim=0; 
	        otschet_hours_net_edi=0; 
        }
    
        public void Init_rand() //инициализация полей случайно (в фиксированном диапазоне) для новых крестьян
        {
            string path= "names.txt";
            int kolvo_name=0; //начальное значение кол-ва слов в файле
            //ПОЛУЧИТЬ СЛУЧАЙНОЕ ИМЯ ИЗ ФАЙЛА
            using (StreamReader reader = new StreamReader(path)) //открытие файла для чтения
            {
                name="name";
                while(name!=null) //пока не прочитает весь файл
                {
                    name=reader.ReadLine(); //получить строку из файла
                    kolvo_name+=1; //увеличить кол-во слов на 1
                }
                reader.Close(); //закрыть файл
            }
            
            int num_name = Program.randk.Next(0, kolvo_name-1); //получить случайный номер слова из общего кол-ва

            using (StreamReader reader = new StreamReader(path)) //открытие файла для чтения
            {
                for (int i_n=0; ; i_n++)
	                {
		                name=reader.ReadLine(); //получить строку из файла
		                if (i_n==num_name) //если это искомое слово, остановить цикл
			                break;
	                }
                reader.Close(); //закрыть файл
            }

	        //ПОЛУЧИТЬ СЛУЧАЙНУЮ ФАМИЛИЮ ИЗ ФАЙЛА
            path= "surnames.txt";
            int kolvo_sur=0; //начальное значение кол-ва слов в файле
            using (StreamReader reader = new StreamReader(path)) //открытие файла для чтения
            {
                surname="surname";
                while(surname!=null) //пока не прочитает весь файл
                {
                    surname=reader.ReadLine(); //получить строку из файла
                    kolvo_sur+=1; //увеличить кол-во слов на 1
                }
                reader.Close(); //закрыть файл
            }

            int num_sur = Program.randk.Next(0, kolvo_name-1); //получить случайный номер слова из общего кол-ва

            using (StreamReader reader = new StreamReader(path)) //открытие файла для чтения
            {
                for (int i_nn=0; ; i_nn++)
	                {
		                surname=reader.ReadLine(); //получить строку из файла
		                if (i_nn==num_sur) //если это искомое слово, остановить цикл
			                break;
	                }
	                reader.Close(); //закрыть файл
            }

            proizv_hleb = Program.randk.Next(1, 11); //случайное число в интервале от 1 до 10 включительно
            proizv_skot = Program.randk.Next(0, 3); //случайное число в интервале от 0 до 2 включительно
            eda_hleb = Program.randk.Next(1, 4); //случайное число в интервале от 1 до 3 включительно
            eda_skot = Program.randk.Next(0, 2); //случайное число в интервале от 0 до 1 включительно
            money_trat = Program.randk.Next(10, 101); //случайное число в интервале от 10 до 100 включительно
            naim = Program.randk.Next(5, 51); //случайное число в интервале от 5 до 50 включительно
	        otschet_hours_net_edi=0;
        }


        //Получение и установление соответствующих полей для крестьянина
        public void set_name(string inn)
        {
	        name=inn;
        }
        public string get_name()
        {
	        return name;
        }
        /////
        public void set_surname(string inn)
        {
	        surname=inn;
        }
        public string get_surname()
        {
	        return surname;
        }
        /////
        public void set_proizv_hleb(int inn)
        {
	        proizv_hleb=inn;
        }
        public int get_proizv_hleb()
        {
	        return proizv_hleb;
        }
        /////
        public void set_proizv_skot(int inn)
        {
	        proizv_skot=inn;
        }
        public int get_proizv_skot()
        {
	        return proizv_skot;
        }
        /////
        public void set_eda_hleb(int inn)
        {
	        eda_hleb=inn;
        }
        public int get_eda_hleb()
        {
	        return eda_hleb;
        }
        /////
        public void set_eda_skot(int inn)
        {
	        eda_skot=inn;
        }
        public int get_eda_skot()
        {
	        return eda_skot;
        }
        /////
        public void set_money_trat(int inn)
        {
	        money_trat=inn;
        }
        public int get_money_trat()
        {
	        return money_trat;
        }
        /////
        public void set_naim(int inn)
        {
	        naim=inn;
        }
        public int get_naim()
        {
	        return naim;
        }
        /////
        public void set_otschet_hours_net_edi(int inn)
        {
	        otschet_hours_net_edi=inn;
        }
        public int get_otschet_hours_net_edi()
        {
	        return otschet_hours_net_edi;
        }
    }


    class Village
    {
        private int kolvo_krest; //Кол-во крестьян в деревне 
        private int hours_procv; //Кол-во Часов Процветания с момента начала игры 
        private int days_procv; //Кол-во Дней Процветания с момента начала игры (и финальный счёт)
        private int speed_life; //Текущий множитель «Скорость Жизни»
        private int flag_season; //Флаг текущего сезона (равен нулю Летом, равен единице Зимой)
        private int kolvo_hleb; //Общее кол-во хлеба в деревне 
        private int kolvo_skot; //Общее кол-во голов домашнего скота в деревне 
        private int budget_village; //Бюджет деревни в рублях 
        private int hours_from_begin_of_season; //Кол-во Часов Процветания в момент, когда текущее время года только началось 
        private int otschet_hours_net_krest; //Отсчёт времени в Часах Процветания с момента, когда ушли все крестьяне 
        private int price_hleb; //Текущая цена за ед. хлеба на Торговой бирже в рублях 
        private int price_skot; //Текущая цена за одну голову домашнего скота на Торговой бирже в рублях 

        public Krest[] krests = null; //крестьяне

        public Village() //конструктор без параметров
        {
	        kolvo_krest=0;
	        hours_procv=0;
	        days_procv=0;
	        speed_life=0;
	        flag_season=0;
	        kolvo_hleb=0;
	        kolvo_skot=0;
	        budget_village=0;
	        hours_from_begin_of_season=0;
	        otschet_hours_net_krest=0;
	        price_hleb=0;
	        price_skot=0;
	        krests=null;
        }

        public void Init_new_game() //инициализация при начале новой игры
        {
	        if(krests!=null)
	        {
		       krests = null;
	        }
	        kolvo_krest=3;
	        hours_procv=1;
	        days_procv=0;
	        speed_life=1;
	        flag_season=0;
	        kolvo_hleb=200;
	        kolvo_skot=20;
	        budget_village=1000;
	        hours_from_begin_of_season=0;
	        otschet_hours_net_krest=0;
	        price_hleb=30;
	        price_skot=200;
	        krests = new Krest [3];
            for (int kk = 0; kk < 3; kk++)
            {
                krests[kk] = new Krest();
            }
            for (int i = 0; i < 3; i++)
            {
                krests[i].Init_rand();
            }
        }


        public void Delete_krest(int number) //удаление крестьянина с выбранным номером (нумерация от единицы!)
        {
	        Krest[] kre_change = new Krest[kolvo_krest-1]; //временный массив крестьян
            for (int kk = 0; kk < (kolvo_krest - 1); kk++)
            {
                kre_change[kk] = new Krest();
            }
	        for(int j=0, k1=0; j<kolvo_krest; j++) //перебрать весь массив крестьян в деревне
	        {
		        if(j!=(number-1)) //если номер крестьянина не равен искомому, то скопировать его в новый массив
		        {
			        kre_change[k1]=this.krests[j];
			        k1++;
		        }
	        }
	        krests = null; //удалить старый массив
	        krests = kre_change; //теперь указатель указывает на новый массив
	        kolvo_krest=kolvo_krest-1; //теперь на 1 крестьянина меньше
        }

        //Получение и установление соответствующих полей для деревни
        public void set_kolvo_krest(int inn)
        {
	        kolvo_krest=inn;
        }
        public int get_kolvo_krest()
        {
	        return kolvo_krest;
        }
        /////
        public void set_hours_procv(int inn)
        {
	        hours_procv=inn;
        }
        public int get_hours_procv()
        {
	        return hours_procv;
        }
        /////
        public void set_days_procv(int inn)
        {
	        days_procv=inn;
        }
        public int get_days_procv()
        {
	        return days_procv;
        }
        /////
        public void set_speed_life(int inn)
        {
	        speed_life=inn;
        }
        public int get_speed_life()
        {
	        return speed_life;
        }
        /////
        public void set_flag_season(int inn)
        {
	        flag_season=inn;
        }
        public int get_flag_season()
        {
	        return flag_season;
        }
        /////
        public void set_kolvo_hleb(int inn)
        {
	        kolvo_hleb=inn;
        }
        public int get_kolvo_hleb()
        {
	        return kolvo_hleb;
        }
        /////
        public void set_kolvo_skot(int inn)
        {
	        kolvo_skot=inn;
        }
        public int get_kolvo_skot()
        {
	        return kolvo_skot;
        }
        /////
        public void set_budget_village(int inn)
        {
	        budget_village=inn;
        }
        public int get_budget_village()
        {
	        return budget_village;
        }
        /////
        public void set_hours_from_begin_of_season(int inn)
        {
        	hours_from_begin_of_season=inn;
        }
        public int get_hours_from_begin_of_season()
        {
	        return hours_from_begin_of_season;
        }
        /////
        public void set_otschet_hours_net_krest(int inn)
        {
	        otschet_hours_net_krest=inn;
        }
        public int get_otschet_hours_net_krest()
        {
	        return otschet_hours_net_krest;
        }
        /////
        public void set_price_hleb(int inn)
        {
	        price_hleb=inn;
        }
        public int get_price_hleb()
        {
	        return price_hleb;
        }
        /////
        public void set_price_skot(int inn)
        {
	        price_skot=inn;
        }
        public int get_price_skot()
        {
	        return price_skot;
        }
    }
}
