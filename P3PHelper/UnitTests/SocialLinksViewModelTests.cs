using P3PHelper.MVVM.Models;

namespace UnitTests
{
    public class SocialLinksViewModelTests
    {
        private readonly Mock<IProgressRepository> _mockProgressRepository;
        private readonly SocialLinksViewModel _mockViewModel;

        public SocialLinksViewModelTests()
        {
            _mockProgressRepository = new Mock<IProgressRepository>();
            _mockViewModel = new SocialLinksViewModel(_mockProgressRepository.Object);
        }

        [Fact]
        public void ViewModel_Initializes_Test()
        {
            Assert.NotNull(_mockViewModel.TapInfo);

            Assert.Contains("death", _mockViewModel.StorySLinks);
            Assert.Contains("fool", _mockViewModel.StorySLinks);
            Assert.Contains("judgment", _mockViewModel.StorySLinks);
        }
    }
}