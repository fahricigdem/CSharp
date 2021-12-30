using Xunit;
using BankyStuffLibrary;
using System;

namespace BankingTests
{
    public class BasicTests
    {
        [Fact]
        public void TruelsTrue() => Assert.True(true);

        [Fact]
        public void CantOverDraw()
        {
            BankAccount account = new("TestPerson", 3000);
            Assert.Throws<InvalidOperationException>(
                () => account.MakeWithdrawal(4000, DateTime.Now, "Attempt to overdraw")
                );
        }

        [Fact]
        public void NeedMoneyToStart() => Assert.Throws<ArgumentOutOfRangeException>(() => new BankAccount("TestPerson", -200));
    }
}
