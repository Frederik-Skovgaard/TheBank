using System;
using Bank4;
using System.Linq;
using Xunit;
using System.Collections.Generic;

namespace TestProject
{
    public class UnitTest1
    {
        public Bank bank = new Bank("Euc");

        public Account account;

        [Fact]
        public void AccountTest()
        {
            //Arrange
            bank.CreateAccount("yo", AccountType.CheckingAccount);

            //Act
            account = bank.FindAccount(1);
            //Account expected = bank.acList.Find(x => x.Name);

            //Assert
            Assert.Equal("yo", account.Name);



        }

        [Fact]
        public void DepositTest()
        {
            //arrange
            bank.CreateAccount("yo", AccountType.CheckingAccount);

            bank.Deposit(100, 1);

            //Act
            account = bank.FindAccount(1);

            //Assert
            Assert.Equal(100, account.Balance);
            
        }

        [Fact]
        public void BankSum()
        {
            //Arrange
            for (int i = 1; i <= 10;)
            {
                bank.CreateAccount($"{i}", AccountType.CheckingAccount);

                bank.Deposit(100, i);

                i++;
            }

            //Act
            decimal result = bank.BankSaldo;

            //Assert
            Assert.Equal(1000, result);
        }
    }
}
