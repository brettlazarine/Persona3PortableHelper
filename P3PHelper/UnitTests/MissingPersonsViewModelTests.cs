namespace UnitTests
{
    public class MissingPersonsViewModelTests
    {
        private readonly Mock<IProgressRepository> _mockProgressRepository;
        private readonly MissingPersonsViewModel _viewModel;

        public MissingPersonsViewModelTests()
        {
            _mockProgressRepository = new Mock<IProgressRepository>();
            _mockProgressRepository.Setup(repo => repo.GetMissingPersons()).Returns(new List<MissingPerson>
            {
                new MissingPerson { Id = 1, Name = "Test", IsCompleted = 0, Info = "Test Info" }
            });

            _viewModel = new MissingPersonsViewModel(_mockProgressRepository.Object);
        }

        [Fact]
        public void MissingPersonsViewModel_Constructor_Test()
        {
            // Arrange
            var missingPersons = _mockProgressRepository.Object.GetMissingPersons();

            // Assert
            Assert.NotNull(_viewModel.MissingPeople);
            Assert.Equal(missingPersons, _viewModel.MissingPeople);
        }

        [Fact]
        public void HandleMissingPersonChecked_Test()
        {
            // Arrange
            var missingPerson = new MissingPerson
            {
                Id = 1,
                Name = "Test",
                IsCompleted = 0,
                Info = "Test Info"
            };

            // Act
            _viewModel.HandleMissingPersonChecked(missingPerson);

            // Assert
            _mockProgressRepository.Verify(repo => repo.UpdateMissingPerson(missingPerson.Id, missingPerson.IsCompleted));
        }
    }
}
