using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4pnyavy
{
    class Program
    {
        static void Main(string[] args)
        {
            Singleton cfgManager1 = Singleton.getInstance();
            Singleton cfgManager2 = Singleton.getInstance();
            if (Object.ReferenceEquals(cfgManager1, cfgManager2))
                Console.WriteLine("Обе ссылки ссылаются на один объект");
            Console.ReadKey();
        }
    }
}


//+ гарантированный только один объект класса
//+ глобальный доступ
//+насследование
//+простота реализации
//-он сильно затрудняет юнит-тестировани
//-Потоконебезопасность потоки могут создавать несколько различных объектов.