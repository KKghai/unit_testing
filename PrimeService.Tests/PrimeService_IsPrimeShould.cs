using System;
using Xunit;
using PrimeService;

namespace PrimeService.Tests
{
    public class PrimeService_IsPrimeShould
    {
        private readonly PrimeService _primeService;

        public PrimeService_IsPrimeShould()
        {
            _primeService = new PrimeService();
        }

        /*[Fact]
        public void ReturnFalseGivenValueOf10()
        {
            var result = _primeService.IsPrime(10);
            Assert.False(result, "10 should not be prime - This One has Passed");
        }

        [Fact]
        public void ReturnTrueGivenValueOf7()
        {
            var result = _primeService.IsPrime(7);
            Assert.True(result, "7 should not be prime - This one has failed");
        }*/

        [Theory]
		[InlineData(4)]
		[InlineData(6)]
		[InlineData(18)]
		public void ThisFunctionShouldAllReturnFalse(int value)
		{
    		var result = _primeService.IsPrime(value);
    
    		Assert.False(result, $"{value} should BE prime");
		}
    
        [Theory]
		[InlineData(3)]
		[InlineData(61)]
		[InlineData(19)]
		public void ThisFunctionShouldAllReturnTrue(int value)
		{
    		var result = _primeService.IsPrime(value);
    
    		Assert.True(result, $"{value} should NOT be prime");
		}
    }
}
