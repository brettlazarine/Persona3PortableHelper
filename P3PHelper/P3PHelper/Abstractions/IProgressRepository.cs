using P3PHelper.MVVM.Models;

namespace P3PHelper.Abstractions
{
    public interface IProgressRepository
    {
        List<SLink> GetSLinks();
        Task<List<SLink>> GetSLinksAsync();
        SLink GetSLink(string arcanaName);
        Task<SLink> GetSLinkAsync(string arcanaName);


        List<RankUp> GetRankUps();
        Task<List<RankUp>> GetRankUpsAsync();
        List<RankUp> GetRankUp(string arcana);
        Task<List<RankUp>> GetRankUpAsync(string arcana);
        void UpdateRankUp(int id, int isCompleted);
        Task<int> UpdateRankUpAsync(int id, int isCompleted);


        List<Request> GetRequests();
        Task<List<Request>> GetRequestsAsync();
        Request GetRequest(int questNumber);
        Task<Request> GetRequestAsync(int questNumber);
        void UpdateRequest(int questNumber, int isCompleted);
        Task<int> UpdateRequestAsync(int questNumber, int isCompleted);


        List<MissingPerson> GetMissingPersons();
        Task<List<MissingPerson>> GetMissingPersonsAsync();
        MissingPerson GetMissingPerson(int id);
        Task<MissingPerson> GetMissingPersonAsync(int id);
        void UpdateMissingPerson(int id, int isCompleted);
        Task<int> UpdateMissingPersonAsync(int id, int isCompleted);


        List<SchoolQuestion> GetSchoolQuestions();
        Task<List<SchoolQuestion>> GetSchoolQuestionsAsync();
        SchoolQuestion GetSchoolQuestion(int id);
        Task<SchoolQuestion> GetSchoolQuestionAsync(int id);
        void UpdateSchoolQuestion(int id, int isCompleted);
        Task<int> UpdateSchoolQuestionAsync(int id, int isCompleted);
    }
}
