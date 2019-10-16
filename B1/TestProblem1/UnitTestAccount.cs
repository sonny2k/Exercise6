using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using B1;

namespace TestProblem1
{
    [TestClass]
    public class UnitTestBankAccount
    {
        [TestMethod]
        public void TestMethodBankAccount()
        {
            BankAccount acc = new BankAccount(200000,0,0);

            Assert.IsNotNull(acc);
            Assert.IsInstanceOfType(acc, typeof(BankAccount));
            Assert.AreEqual(200000, acc.Balance(200000,0,0));
        }

        [TestMethod]
        public void TestMethodDeposit()
        {
            BankAccount acc1 = new BankAccount(200000,500000,0);
            acc1.Deposit();
            Assert.IsNotNull(acc1);
            Assert.IsInstanceOfType(acc1, typeof(BankAccount));
            Assert.AreEqual(700000, acc1.Balance(200000,500000,0));
        }

        [TestMethod]
        public void TestMethodWithdraw()
        {
             BankAccount acc2 = new BankAccount(200000,500000,300000);
             acc2.Deposit();
             acc2.Withdraw();
             Assert.IsNotNull(acc2);
             Assert.IsInstanceOfType(acc2, typeof(BankAccount));
             Assert.AreEqual(400000, acc2.Balance(200000,500000,300000));
        }

        [TestMethod]
        public void TestMethodWithdraw2()
        {
            BankAccount acc2 = new BankAccount(200000,0,200000);
            acc2.Withdraw();
            Assert.IsNotNull(acc2);
            Assert.IsInstanceOfType(acc2, typeof(BankAccount));
            Assert.AreEqual(0, acc2.Balance(200000,0,200000));
        }
    }
}
