using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankAccountTest;
using NUnit.Framework;

namespace BankAccountUnitTest.test
{
    [TestFixture]
    class AcccountUnitTest
    {
        private Account anAccount;
        [SetUp]
        public void Start()
        {
            
        }
        [Test]
        public void InitialBalance()
        {
            anAccount = new Account("009","Badol");
            Assert.AreEqual(0,anAccount.Balance);
        }
        [Test]
        public void BalanceDeposit()
        {
            anAccount = new Account();
            Assert.AreEqual(100,anAccount.Deposit(100));
        }
        [Test]
        public void BalanceWithdraw()
        {
            anAccount = new Account();
            Assert.AreEqual(-50,anAccount.WithDraw(50));
        }

        [TearDown]
        public void End()
        {
            
        }

    }
}
