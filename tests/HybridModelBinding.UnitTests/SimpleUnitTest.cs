using Xunit;

namespace HybridModelBinding.Tests
{
    public class SimpleUnitTest
    {
        [Fact]
        public void Test1()
        {
            var a = 1;
            a++;
            Assert.Equal(2,a);

        }
    }
}
