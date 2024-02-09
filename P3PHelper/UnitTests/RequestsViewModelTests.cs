using Microsoft.Maui.Platform;

namespace UnitTests
{
    public class RequestsViewModelTests
    {
        private readonly Mock<IProgressRepository> _mockProgressRepository;
        RequestsViewModel _viewModel;

        public RequestsViewModelTests()
        {
            _mockProgressRepository = new Mock<IProgressRepository>();
            _mockProgressRepository.Setup(repo => repo.GetRequests()).Returns(new List<Request>
            {
                new Request { QuestNumber = 1, HowToComplete = "Test Complete", Reward = "Test Reward", IsCompleted = 0 }
            });

            _viewModel = new RequestsViewModel(_mockProgressRepository.Object);
        }

        [Fact]
        public void RequestsViewModel_Constructor_Test()
        {
            // Arrange
            var requests = _mockProgressRepository.Object.GetRequests();

            // Assert
            Assert.NotNull(_viewModel.OneTwenty);
            Assert.NotNull(_viewModel.TwentyOneFourty);
            Assert.NotNull(_viewModel.FourtyOneSixty);
            Assert.NotNull(_viewModel.SixtyOneEighty);
            Assert.NotNull(_viewModel.CurrentRequests);
            Assert.Equal(requests, _viewModel.OneTwenty);
        }

        [Fact]
        public void HandleRequestChecked_Test()
        {
            // Arrange
            var request = new Request
            {
                QuestNumber = 10,
                HowToComplete = "Test",
                Reward = "Test",
                IsCompleted = 0
            };

            // Act
            _viewModel.HandleRequestChecked(request);

            // Assert
            _mockProgressRepository.Verify(repo => repo.UpdateRequest(request.QuestNumber, request.IsCompleted));
        }
    }
}
