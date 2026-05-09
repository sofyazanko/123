using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MILITARYLIBRARY;

namespace MILITARYLIBRARY.UnitTests
{
    [TestFixture]
    public class VeteranUnitTests
    {
        [Test]
        public void ConstructorTest()
        {
            var veteran = CreateTestVeteran();//созд ветерана

            Assert.That(veteran.Name, Is.EqualTo("Петр"));
            Assert.That(veteran.Surname, Is.EqualTo("Петров"));
            Assert.That(veteran.MilitaryIDN, Is.EqualTo("ОСА111"));
            Assert.That(veteran.Type, Is.EqualTo(TypeService.Urgent));
            Assert.That(veteran.YearsOfService, Is.EqualTo(25));
            Assert.That(veteran.PensionAmount, Is.EqualTo(35000m));
        }

        [Test]
        public void GetInfoTest()
        {
            var veteran = CreateTestVeteran();
            var info = veteran.GetInfo();

            Assert.That(info.Length, Is.EqualTo(3));
            Assert.That(info[0], Is.EqualTo("Петр Петров"));
            Assert.That(info[1], Does.Contain("ОСА111"));
            Assert.That(info[2], Does.Contain("Ветеран"));
            Assert.That(info[2], Does.Contain("25 лет"));
            Assert.That(info[2], Does.Contain("35000"));
        }

        private Veteran CreateTestVeteran()
        {
            return new Veteran("Петр", "Петров", "ОСА111",
                              TypeService.Urgent, 25, 35000m);
        }
    }
}