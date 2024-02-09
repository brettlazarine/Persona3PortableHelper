namespace UnitTests
{
    public class SchoolQuestionsViewModelTests
    {
        private readonly Mock<IProgressRepository> _mockProgressRepository;
        private readonly SchoolQuestionsViewModel _viewModel;

        public SchoolQuestionsViewModelTests()
        {
            _mockProgressRepository = new Mock<IProgressRepository>();
            _mockProgressRepository.Setup(repo => repo.GetSchoolQuestions()).Returns(new List<SchoolQuestion>
            {
                new SchoolQuestion { Id = 1, Question = "Test Question", IsCompleted = 0 }
            });

            _viewModel = new SchoolQuestionsViewModel(_mockProgressRepository.Object);
        }

        [Fact]
        public void SchoolQuestionsViewModel_Constructor_Test()
        {
            // Arrange
            var questions = _mockProgressRepository.Object.GetSchoolQuestions();

            // Assert
            Assert.NotNull(_viewModel.Incomplete);
            Assert.NotNull(_viewModel.Complete);
            Assert.NotNull(_viewModel.CurrentViewQuestions);
            Assert.NotNull(_viewModel.SchoolQuestionCheckedCommand);
            Assert.Equal(questions, _viewModel.Incomplete);
        }

        [Fact]
        public void HandleSchoolQuestionChecked_Test()
        {
            // Arrange
            var question = new SchoolQuestion
            {
                Id = 10,
                Question = "Test",
                IsCompleted = 0
            };

            // Act
            _viewModel.HandleSchoolQuestionChecked(question);

            // Assert
            _mockProgressRepository.Verify(repo => repo.UpdateSchoolQuestion(question.Id, question.IsCompleted));
        }
    }
}
