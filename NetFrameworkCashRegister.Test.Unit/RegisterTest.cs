using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace NetFrameworkCashRegister.Test.Unit
{
    [TestFixture]
    public class RegisterTest
    {
        private Register uut;

        [SetUp]
        public void Setup()
        {
            uut = new Register();
        }
        [Test]
        public void ctor_Nothingadded_Returns0Items()
        {
            Assert.That(uut.GetNItems(), Is.Zero);
        }

        [Test]
        public void ctor_NothingAdded_Returns0Total()
        {
            Assert.That(uut.GetTotal(), Is.Zero);
        }

        [Test]
        public void Add_AddItem_NumberCorrect()
        {
            uut.AddItem(11.22);
            Assert.That(uut.NoOfItems, Is.EqualTo(1));
        }

        [Test]
        public void Add_AddItem_TotalCorrect()
        {
            uut.AddItem(11.22);
            Assert.That(uut.GetTotal(), Is.EqualTo(11.22));
        }

        [Test]
        public void Add_Add2Item_NumberCorrect()
        {
            uut.AddItem(11.22);
            uut.AddItem(33.33);
            Assert.That(uut.NoOfItems, Is.EqualTo(2));
        }

        [Test]
        public void Add_NegativeItem_Throws()
        {
            Assert.That(() => uut.AddItem(-23.56), Throws.ArgumentException.With.Property("Message").EqualTo("Negativ item værdi"));
        }
    }
}
