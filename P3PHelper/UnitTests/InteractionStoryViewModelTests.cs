namespace UnitTests
{
    public class InteractionStoryViewModelTests
    {
        private readonly Mock<IProgressRepository> _mockProgressRepository;
        private readonly InteractionStoryViewModel _mockViewModel;

        public InteractionStoryViewModelTests()
        {
            _mockProgressRepository = new Mock<IProgressRepository>();
            _mockViewModel = new InteractionStoryViewModel("Aeon", _mockProgressRepository.Object);
        }

        [Fact]
        public async Task EnsureInitializedAsync_GetsInfo_Test()
        {
            // Arrange
            _mockProgressRepository.Setup(repo => repo.GetSLinkAsync(It.IsAny<string>()))
                .ReturnsAsync(new SLink());

            // Act
            await _mockViewModel.GetSLinkInfo("Aeon");

            // Assert
            _mockProgressRepository.Verify(repo => repo.GetSLinkAsync("Aeon"));
        }

        #region Male Events
        [Fact]
        public void MaleDateTapped_Test()
        {
            // Arrange
            Assert.False(_mockViewModel.MaleDateVisible);
            Assert.Equal(0, _mockViewModel.MaleHowArrowRotation);

            // Act
            _mockViewModel.MaleDateTapped();

            // Assert
            Assert.True(_mockViewModel.MaleDateVisible);
            Assert.Equal(180, _mockViewModel.MaleDateArrowRotation);
        }
        [Fact]
        public void MaleHowTapped_Test()
        {
            // Arrange
            Assert.False(_mockViewModel.MaleHowVisible);
            Assert.Equal(0, _mockViewModel.MaleHowArrowRotation);

            // Act
            _mockViewModel.MaleHowTapped();

            // Assert
            Assert.True(_mockViewModel.MaleHowVisible);
            Assert.Equal(180, _mockViewModel.MaleHowArrowRotation);
        }
        [Fact]
        public void MaleAvailabilityTapped_Test()
        {
            // Arrange
            Assert.False(_mockViewModel.MaleAvailabilityVisible);
            Assert.Equal(0, _mockViewModel.MaleAvailabilityArrowRotation);

            // Act
            _mockViewModel.MaleAvailabilityTapped();

            // Assert
            Assert.True(_mockViewModel.MaleAvailabilityVisible);
            Assert.Equal(180, _mockViewModel.MaleAvailabilityArrowRotation);
        }
        #endregion

        #region Female Events
        [Fact]
        public void FemaleDateTapped_Test()
        {
            // Arrange
            Assert.False(_mockViewModel.FemaleDateVisible);
            Assert.Equal(0, _mockViewModel.FemaleDateArrowRotation);

            // Act
            _mockViewModel.FemaleDateTapped();

            // Assert
            Assert.True(_mockViewModel.FemaleDateVisible);
            Assert.Equal(180, _mockViewModel.FemaleDateArrowRotation);
        }
        [Fact]
        public void FemaleHowTapped_Test()
        {
            // Arrange
            Assert.False(_mockViewModel.FemaleHowVisible);
            Assert.Equal(0, _mockViewModel.FemaleHowArrowRotation);

            // Act
            _mockViewModel.FemaleHowTapped();

            // Assert
            Assert.True(_mockViewModel.FemaleHowVisible);
            Assert.Equal(180, _mockViewModel.FemaleHowArrowRotation);
        }
        [Fact]
        public void FemaleAvailabilityTapped_Test()
        {
            // Arrange
            Assert.False(_mockViewModel.FemaleAvailabilityVisible);
            Assert.Equal(0, _mockViewModel.FemaleAvailabilityArrowRotation);

            // Act
            _mockViewModel.FemaleAvailabilityTapped();

            // Assert
            Assert.True(_mockViewModel.FemaleAvailabilityVisible);
            Assert.Equal(180, _mockViewModel.FemaleAvailabilityArrowRotation);
        }
        #endregion

        [Fact]
        public void HandleRankChecked_Test()
        {
            // Arrange
            var rank = new RankUp
            {
                Id = 1,
                IsCompleted = 1
            };

            // Act
            _mockViewModel.HandleRankChecked(rank);

            // Assert
            _mockProgressRepository.Verify(repo => repo.UpdateRankUp(rank.Id, rank.IsCompleted), Times.Once);
        }
    }
}
