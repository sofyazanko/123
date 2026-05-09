using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MILITARYLIBRARY
{
    public class Veteran : Serviceman
    {
        public int YearsOfService {get; set;}//выслуга лет
        public decimal PensionAmount {get; set;}//размер пенсии

        public Veteran(string name, string surname, string militaryIDN,
                      TypeService type, int yearsOfservice, decimal pensionAmount)
                      : base(name, surname, militaryIDN, type)//базовый класс всегда тот же идет от Serviceman
        {
            YearsOfService = yearsOfservice;
            PensionAmount = pensionAmount;
        }
        public override string[] GetInfo()
        {
            var info = new string[3];
            var baseInfo = base.GetInfo();

            info[0] = baseInfo[0];
            info[1] = baseInfo[1];
            info[2] = $"Ветеран. Выслуга: {YearsOfService} лет. Пенсия: {PensionAmount} руб.";

            return info;

        }

    }
}
