using System;
using NUnit.Framework;
using MILITARYLIBRARY;

namespace MILITARYLIBRARY.UnitTests
{
    [TestFixture]
    public class ServicemanUnitTests
    {
        [Test]
        public void ConstructorTest()//тестируем конструктор это будет первый тест
        {
            var soldier = CreateTestServiceman();// создаем тест военнослуж
            Assert.That(soldier.Name, Is.EqualTo("Иван"));
            Assert.That(soldier.Surname, Is.EqualTo("Петров"));
            Assert.That(soldier.MilitaryIDN, Is.EqualTo("АБ123456"));
            Assert.That(soldier.Type, Is.EqualTo(TypeService.Urgent));
        }

        [Test]
        public void GetInfoTest()//это тест 2
        {
            var soldier = CreateTestServiceman();
            soldier.Rank = "Сержант";
            soldier.MilUnitNumber = "54321";
            soldier.EnlistmentDate = new DateTime(2020, 5, 25);

            var info = soldier.GetInfo();
            Assert.That(info.Length, Is.EqualTo(2));
            Assert.That(info[0], Is.EqualTo("Иван Петров"));
            Assert.That(info[1], Is.EqualTo($"Военный билет: АБ123456. Звание: Сержант. Часть: 54321. Поступил: 25.05.2020. Срок службы: {DateTime.Now.Year - 2020} лет. Тип службы: срочная."));
        }

        private Serviceman CreateTestServiceman()//вспомогательный метод
        {
            return new Serviceman("Иван", "Петров", "АБ123456", TypeService.Urgent);
        }
    }
}