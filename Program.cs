using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using System.Text;

namespace HomeWork2Task1
{ 
   class Program 
   {
        static void Main(string[] args)
        {
            string FIO = "Шилов Глеб Николаевич";
            int Age = 14;
            string Email = "gelb.shilov.07@bk.ru";
            double MathPoints = 75.23;
            double PhisicPoints = 85.12;
            double ProgrammingPoints = 99.99;
            double AllPoints = MathPoints + PhisicPoints + ProgrammingPoints;
            double AllPointsMiddle = AllPoints / 3;

            string newPattern = "ФИО: {0} \nВозраст: {1} \nEmail: {2} \nБаллы по математике: {3} \nБаллы по физике: {4} \nБаллы по программированию: {5}";
            Console.WriteLine(newPattern,
                                     FIO,
                                     Age,
                                     Email,
                                     MathPoints,
                                     PhisicPoints,
                                     ProgrammingPoints);
            Console.ReadKey();

            string SecondPattern = "Общее количество баллов: {0} \nСредний балл: {1}";
            Console.WriteLine(SecondPattern,
                              AllPoints,
                              AllPointsMiddle);
            Console.ReadKey();
        }
   }
}
