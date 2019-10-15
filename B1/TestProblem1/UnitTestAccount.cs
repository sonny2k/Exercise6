using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using B1;

namespace TestProblem1
{
    [TestClass]
    public class UnitTestAccount
    {
        [TestMethod]
        public void TestMethodAccount()
        {
            Account acc = new Account(200000);

            Assert.IsNotNull(acc);
            Assert.IsInstanceOfType(acc, typeof(Account));
            Assert.AreEqual(200000, acc.Balance(money));
        }

         [TestMethod]
         public void TestMethodDeposit()
        {
            Account acc = new Account(500000);

            Assert.IsNotNull(acc);
            Assert.IsInstanceOfType(acc, typeof(Account));
            Assert.AreEqual(700000, acc.Balance(money));
        }

        [TestMethod]
         public void TestMethodWithdraw()
         {
             Account acc = new Account(300000);

             Assert.IsNotNull(acc);
             Assert.IsInstanceOfType(acc, typeof(Account));
             Assert.AreEqual(400000, acc.Balance(money));
         }
    }
}
