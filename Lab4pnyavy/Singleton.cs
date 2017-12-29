using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4pnyavy
{
    class Singleton   //просто класс который гарантирует что будет создан всего 1 его экземпляр
    {
        private static Singleton instance;

        private Singleton()
        { }

        public static Singleton getInstance()
        {
            // для исключения возможности создания двух объектов 
            // при многопоточном приложении
            if (instance == null)
                lock (typeof(Singleton))
                {
                    if (instance == null)
                        instance = new Singleton();
                }
            return instance;
        }  
    }
}
