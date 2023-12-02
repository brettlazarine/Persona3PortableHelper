namespace UnitTests
{
    public class SocialLinksViewTests
    {
        [Fact]
        public void TapInfo_Test()
        {
            //Arrange
            var vm = new SocialLinksViewModel();
            //Act
            var count = vm.TapInfo.Count;
            //Assert
            Assert.Equal(22, count);
        }

        [Fact]
        public void StoryLinks_Test()
        {
            //Arrange
            var vm = new SocialLinksViewModel();
            //Act
            var count = vm.StorySLinks.Count;
            //Assert
            Assert.Equal(3, count);
        }
    }
}