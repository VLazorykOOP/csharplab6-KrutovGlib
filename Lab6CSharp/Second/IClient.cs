using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6CSharp.Second
{
    internal interface IClient
    {
        void DisplayInfo(); // Вивести інформацію про клієнта на екран
        bool MatchDate(DateTime date); // Визначити, чи відповідає дата критерію пошуку
    }
}
