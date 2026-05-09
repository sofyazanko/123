using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MILITARYLIBRARY;

namespace MILITARYLIBRARY.UnitTests
{
        [TestFixture]             
        public class CommandStaffUnitTests
        {
            [Test]
            public void ConstructorTest()
            {
                var staff = CreateTestCommandStaff();//создаем военнослуж

                Assert.That(staff.Name, Is.EqualTo("Алексей"));
                Assert.That(staff.Surname, Is.EqualTo("Алексеев"));
                Assert.That(staff.UnitName, Is.EqualTo("1я рота"));
                Assert.That(staff.Position, Is.EqualTo("Командир роты"));
            }

            [Test]
            public void GetInfoTest()
            {
                var staff = CreateTestCommandStaff();
                var info = staff.GetInfo();

                
                Assert.That(info.Length, Is.EqualTo(3));//проверяем кол-во строк
                Assert.That(info[0], Is.EqualTo("Алексей Алексеев"));//проверяем построчно
                Assert.That(info[1], Does.Contain("АБВ123"));
                Assert.That(info[2], Does.Contain("Командный состав"));
                Assert.That(info[2], Does.Contain("1я рота"));
                Assert.That(info[2], Does.Contain("Командир роты"));
            }

            private CommandStaff CreateTestCommandStaff()//создаем заготовку
            {
                return new CommandStaff("Алексей", "Алексеев", "АБВ123",
                                       TypeService.UnderContract, "1я рота", "Командир роты");
            }
        }
    }