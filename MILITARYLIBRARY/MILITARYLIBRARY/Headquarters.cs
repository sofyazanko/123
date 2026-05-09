using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MILITARYLIBRARY
{
    public class Headquarters : Serviceman
    {
        public string DistrictName {get; set;}//название округа
        public string Position {get; set;}//должность
        public Headquarters(string name, string surname, string militaryIDN,
                           TypeService type, string districtName, string position)
                           : base(name, surname, militaryIDN, type)//эти 4 уходят в базовый класс
        {
            DistrictName = districtName;
            Position = position;
        }
        public override string[] GetInfo()
        {
            var info = new string[3];
            var baseInfo = base.GetInfo();

            info[0] = baseInfo[0];
            info[1] = baseInfo[1];
            info[2] = $"Органы управления. Округ: {DistrictName}. Должность: {Position}.";//фиксируем новую информ про округ и должность

            return info;
        }
    }
}
