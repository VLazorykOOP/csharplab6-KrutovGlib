using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6CSharp.Second
{
    abstract class Client : IClient
    {
        protected string lastName; // Прізвище клієнта

        public Client(string lastName)
        {
            this.lastName = lastName;
        }

        public abstract void DisplayInfo(); // Абстрактний метод для виведення інформації про клієнта

        public abstract bool MatchDate(DateTime date); // Абстрактний метод для визначення відповідності даті критерію пошуку
    }
}
