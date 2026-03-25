using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MILITARYLIBRARY
{
    public class Serviceman
    {
        public string Name { get; set; }// имя перед в конструктор
        public string Surname { get; set; }// фамилия перед в конструктор
        public readonly string MilitaryIDN;// номер воен билета перед  в конструктор
        public readonly TypeService Type;
        public string Rank { get; set; }
        public string MilUnitNumber { get; set; }
        public DateTime EnlistmentDate { get; set; }

        public int ServiceTime => DateTime.Now.Year - EnlistmentDate.Year;//считаем срок службы

        //создаем констуктор
        public Serviceman(string name, string surname, string militaryIDN, TypeService type)
        {
            Name = name;
            Surname = surname;
            MilitaryIDN = militaryIDN;
            Type = type;
        }
        public virtual string[] GetInfo()//получение инф-ции
        {
            var info = new string[2];//массив на 2 ячейки
            info[0] = $"{Name} {Surname}";

            string typeName;//переменная для типа службы
            if (Type == TypeService.Urgent)
                typeName = "срочная";
            else
                typeName = "по контракту";

            

            info[1] = $"Военный билет: {MilitaryIDN}. " +
                     $"Звание: {Rank}. " +
                     $"Часть: {MilUnitNumber}. " +
                     $"Поступил: {EnlistmentDate:d}. " + //d для даты
                     $"Срок службы: {ServiceTime} лет. " +
                     $"Тип службы: {typeName}.";

            return info;
        }
    }
}


