using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class MyClass
    {

        /// <summary>
        /// создание поля номера
        /// </summary>
        public static int number;


        
        /// <summary>
        /// создание конструктора по умолчанию
        /// </summary>
        public void Print()
        {
            Console.WriteLine(number);
        }

        public const int a = 125;


        /// <summary>
        ///  Статический конструктор выполняется только один раз независимо от количества созданных объектов 
        ///  Статический конструктор нельзя вызвать в ручную, он вызыввается автоматически
        ///  Статический конструктор не имеет модификатора доступа
        ///  В статическом конструкторе никогда не бывает параметров (скобки пустые)
        ///  В сттатическом конструкторе, как и в статическом методе нельзя использовать ключесвое слово this для ссылки на текущий объект и можно обращаться только к статическим членам класса  
        /// </summary>
        static MyClass()
        {
            Console.WriteLine("Статический конструктор");
            number = 1;
        }

        public MyClass()
        {
            Console.WriteLine("RR");
            number = 2;
        }



    }
}
