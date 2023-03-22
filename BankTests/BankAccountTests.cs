using BankAccountNS;

namespace BankTests
{
    [TestClass]
    public class BankAccountTests
    {
        [TestMethod]
        public void Debit_WithValidAmount_UpdatesBalance()
        {
            double beginningBalance = 12.99;
            double debitAmount = 5.55;
            double expected = 7.44;
            BankAccount account = new BankAccount("Mr. Walton", beginningBalance);

            //action
            account.Debit(debitAmount);

            //assert
            double actual = account.Balance;
            Assert.AreEqual(expected, actual, 0.001, "Account not debited correctly");
        }
        [TestMethod]
        public void Debit_WhenAmountIsLessThanZero_ShouldThrowException()
        {
            double beginningBalance = 12.99;
            double debitAmount = -100.00;
            BankAccount account = new BankAccount("Mr. Walton", beginningBalance);
            
            //act and assert
            Assert.ThrowsException<System.ArgumentOutOfRangeException>(() => account.Debit(debitAmount));
        }
        [TestMethod]
        public void Debit_WhenAmountIsGreaterThanBalance_ShouldThrowException()
        {
            double beginningBalance = 12.99;
            double debitAmount = 14.00;
            BankAccount account = new BankAccount("Mr. Walton", beginningBalance);

            //act and assert
            Assert.ThrowsException<System.ArgumentOutOfRangeException>(() => account.Debit(debitAmount));
        }
    }
}