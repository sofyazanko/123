using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MILITARYLIBRARY
{
     public class CommandStaff : Serviceman
    {
        public string UnitName {get; set;}//название подразделения
        public string Position {get; set;}//должность

        public CommandStaff(string name, string surname, string militaryIDN, TypeService type, string unitName, string position)
            : base(name, surname, militaryIDN, type)
        {
            UnitName = unitName;
            Position = position;
        }
        public override string[] GetInfo()
        {
            var info = new string[3];//всего будет 4 строки
            var baseInfo = base.GetInfo();//прописали уже известную информацию

            info[0] = baseInfo[0];//имя и фамилия
            info[1] = baseInfo[1];//воен билет, звание,часть, поступил, срок службы, тип службы
            info[2] = $"Командный состав. Подразделение: {UnitName}; Должность: {Position}";//новая информ

            return info;
        }
    }
}
