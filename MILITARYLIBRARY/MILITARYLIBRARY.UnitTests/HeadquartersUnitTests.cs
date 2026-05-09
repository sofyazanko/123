using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MILITARYLIBRARY;

namespace MILITARYLIBRARY.UnitTests
{
    [TestFixture]
    public class HeadquartersUnitTests
    {
        [Test]
        public void ConstructorTest()
        {
            var head = CreateTestHeadquarters();//проверки конструктора

            Assert.That(head.Name, Is.EqualTo("Михаил"));
            Assert.That(head.Surname, Is.EqualTo("Михайлов"));
            Assert.That(head.MilitaryIDN, Is.EqualTo("ОМС333"));
            Assert.That(head.Type, Is.EqualTo(TypeService.UnderContract));
            Assert.That(head.DistrictName, Is.EqualTo("Западный округ"));
            Assert.That(head.Position, Is.EqualTo("Начальник штаба"));
        }

        [Test]
        public void GetInfoTest()
        {
            var head = CreateTestHeadquarters();
            var info = head.GetInfo();

            Assert.That(info.Length, Is.EqualTo(3));
            Assert.That(info[0], Is.EqualTo("Михаил Михайлов"));
            Assert.That(info[1], Does.Contain("ОМС333"));
            Assert.That(info[2], Does.Contain("Органы управления"));
            Assert.That(info[2], Does.Contain("Западный округ"));
            Assert.That(info[2], Does.Contain("Начальник штаба"));
        }

        private Headquarters CreateTestHeadquarters()
        {
            return new Headquarters("Михаил", "Михайлов", "ОМС333",
                                   TypeService.UnderContract, "Западный округ", "Начальник штаба");
        }
    }
}
