namespace UnitTests
{
    public class InteractionStoryTests
    {
        [Fact]
        public void ScrollRanks_Test()
        {
            //Arrange
            var vm = new InteractionStoryViewModel();
            //Act
            var count = vm.ScrollRanks.Count;
            //Assert
            Assert.Equal(3, count);
        }

        [Theory]
        [InlineData(0)]
        [InlineData(1)]
        [InlineData(1000)]
        public void AdjustY_Test(int y)
        {
            //Arrange
            var vm = new InteractionStoryViewModel();
            //Act
            var newY = vm.AdjustY(y);
            //Assert
            Assert.Equal(y + 1000, newY);
        }
    }
}
