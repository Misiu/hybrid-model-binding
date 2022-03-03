using Xunit;

namespace HybridModelBinding.UnitTests
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
