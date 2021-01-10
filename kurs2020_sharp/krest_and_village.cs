﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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

        public Krest[] krests; //крестьяне
    }
}
