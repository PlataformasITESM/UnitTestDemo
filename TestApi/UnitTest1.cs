namespace TestApi
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            DemoApi.Controllers.MathController controller =  new DemoApi.Controllers.MathController();
            int sum = controller.suma(12, 4);
            Assert.Equal(16, sum);
            Assert.NotEqual(12, sum);
            Assert.True(sum > 0);
        }
    }
}