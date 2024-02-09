using Newtonsoft.Json;
using P3PHelper.MVVM.Models;
using SQLite;
using System.Diagnostics;
using System.Reflection;

namespace P3PHelper.Repositories
{
    public class ProgressRepository
    { // Look into implementing yield returns for database calls
        SQLiteConnection connection;
        SQLiteAsyncConnection connectionAsync;
        public static string DbPath { get; } = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "persona3.db3");
        public const SQLiteOpenFlags Flags =
            SQLiteOpenFlags.ReadWrite |
            SQLiteOpenFlags.Create |
            SQLiteOpenFlags.SharedCache;

        public ProgressRepository()
        {
            connection = new SQLiteConnection(DbPath, Flags);
            connectionAsync = new SQLiteAsyncConnection(DbPath, Flags);
            connection.CreateTable<SLink>();
            connection.CreateTable<RankUp>();
            connection.CreateTable<Request>();
            connection.CreateTable<MissingPerson>();
            connection.CreateTable<SchoolQuestion>();
            // DON'T FORGET TO ADD NEW TABLES TO THIS LIST AS THEY ARE CREATED IN THE DATABASE
        }

        public static void InitializeDatabase()
        {
            var dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "persona3.db3");
            if (!File.Exists(dbPath))
            {
                var assembly = IntrospectionExtensions.GetTypeInfo(typeof(App)).Assembly;
                using (Stream stream = assembly.GetManifestResourceStream("P3PHelper.Resources.Raw.persona3.db3"))
                using (var fileStream = File.Create(dbPath))
                {
                    stream.CopyTo(fileStream);
                }
            }
        }

        #region SLinks
        public List<SLink> GetSLinks()
        {
            try
            {
                return connection.Table<SLink>().ToList();
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"*** GetSLinks: {ex.Message} ***");
                return null;
            }
        }
        public async Task<List<SLink>> GetSLinksAsync()
        {
            try
            {
                return await connectionAsync.Table<SLink>().ToListAsync();
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"*** GetSLinksAsync: {ex.Message} ***");
                return null;
            }
        }

        public SLink GetSLink(string arcanaName)
        {
            try
            {
                return connection.Table<SLink>().Where(s => s.Arcana == arcanaName).FirstOrDefault();
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"*** GetSLink: {ex.Message} ***");
                return null;
            }
        }
        public async Task<SLink> GetSLinkAsync(string arcanaName)
        {
            try
            {
                return await connectionAsync.Table<SLink>().Where(s => s.Arcana == arcanaName).FirstOrDefaultAsync();
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"*** GetSLinkAsync: {ex.Message} ***");
                return null;
            }
        }
        // MAY BE UNNECESSARY, CONSIDER REMOVING
        public void UpdateSLink(string arcana, int isCompleted)
        {
            var newData = new SLink
            {
                Arcana = arcana
            };
        }
        // NO LONGER USING THIS MODEL
        public List<ArcanaRankUp> GetArcanaRankUps()
        {
            var arcanaRankUpsData = connection.Table<ArcanaRankUp>().ToList();
            foreach (var item in arcanaRankUpsData)
            {
                item.RankUps = JsonConvert.DeserializeObject<Dictionary<string, RankInteractionDetails>>(item.SerializedRankUps);
            }
            return arcanaRankUpsData;
        }
        #endregion

        #region RankUps
        // NO LONGER USING THIS MODEL
        public ArcanaRankUp GetArcanaRankUp(string arcana)
        {
            var arcanaRankUpData = connection.Table<ArcanaRankUp>().Where(a => a.Arcana == arcana).FirstOrDefault();
            arcanaRankUpData.RankUps = JsonConvert.DeserializeObject<Dictionary<string, RankInteractionDetails>>(arcanaRankUpData.SerializedRankUps);
            return arcanaRankUpData;
        }

        public List<RankUp> GetRankUps()
        {
            try
            {
                return connection.Table<RankUp>().ToList();
            }
            catch (Exception ex)
            {
                Debug.WriteLine("*** GetRankUps: " + ex.Message + " ***");
                return null;
            }
        }
        public async Task<List<RankUp>> GetRankUpsAsync()
        {
            try
            {
                return await connectionAsync.Table<RankUp>().ToListAsync();
            }
            catch (Exception ex)
            {
                Debug.WriteLine("*** GetRankUpsAsync: " + ex.Message + " ***");
                return null;
            }
        }

        public List<RankUp> GetRankUp(string arcana)
        {
            try
            {
                return connection.Table<RankUp>().Where(r => r.Arcana == arcana).ToList();
            }
            catch (Exception ex)
            {
                Debug.WriteLine("*** GetRankUp: " + ex.Message + " ***");
                return null;
            }
        }
        public async Task<List<RankUp>> GetRankUpAsync(string arcana)
        {
            try
            {
                return await connectionAsync.Table<RankUp>().Where(r => r.Arcana == arcana).ToListAsync();
            }
            catch (Exception ex)
            {
                Debug.WriteLine("*** GetRankUpAsync: " + ex.Message + " ***");
                return null;
            }
        }

        public void UpdateRankUp(int id, int isCompleted)
        {
            try
            {
                connection.Execute("UPDATE RankUp SET IsCompleted = ? WHERE Id = ?", isCompleted, id);
            }
            catch (Exception ex)
            {
                Debug.WriteLine("*** UpdateRankUp: " + ex.Message + " ***");
            }
        }
        public async Task<int> UpdateRankUpAsync(int id, int isCompleted)
        {
            try
            {
                return await connectionAsync.ExecuteAsync("UPDATE RankUp SET IsCompleted = ? WHERE Id = ?", isCompleted, id);
            }
            catch (Exception ex)
            {
                Debug.WriteLine("*** UpdateRankUpAsync: " + ex.Message + " ***");
                return 0;
            }
        }
        #endregion

        #region Requests
        public List<Request> GetRequests()
        {
            try
            {
                return connection.Table<Request>().ToList();
            }
            catch (Exception ex)
            {
                Debug.WriteLine("*** GetRequests: " + ex.Message + " ***");
                return null;
            }
        }
        public async Task<List<Request>> GetRequestsAsync()
        {
            try
            {
                return await connectionAsync.Table<Request>().ToListAsync();
            }
            catch (Exception ex)
            {
                Debug.WriteLine("*** GetRequestsAsync: " + ex.Message + " ***");
                return null;
            }
        }

        public Request GetRequest(int questNumber)
        {
            try
            {
                return connection.Table<Request>().Where(r => r.QuestNumber == questNumber).FirstOrDefault();
            }
            catch (Exception ex)
            {
                Debug.WriteLine("*** GetRequest: " + ex.Message + " ***");
                return null;
            }
        }
        public async Task<Request> GetRequestAsync(int questNumber)
        {
            try
            {
                return await connectionAsync.Table<Request>().Where(r => r.QuestNumber == questNumber).FirstOrDefaultAsync();
            }
            catch (Exception ex)
            {
                Debug.WriteLine("*** GetRequestAsync: " + ex.Message + " ***");
                return null;
            }
        }

        public void UpdateRequest(int questNumber, int isCompleted)
        {
            try
            {
                connection.Execute("UPDATE Request SET IsCompleted = ? WHERE QuestNumber = ?", isCompleted, questNumber);
            }
            catch (Exception ex)
            {
                Debug.WriteLine("*** UpdateRequest: " + ex.Message + " ***");
            }
        }
        public async Task<int> UpdateRequestAsync(int questNumber, int isCompleted)
        {
            try
            {
                return await connectionAsync.ExecuteAsync("UPDATE Request SET IsCompleted = ? WHERE QuestNumber = ?", isCompleted, questNumber);
            }
            catch (Exception ex)
            {
                Debug.WriteLine("*** UpdateRequestAsync: " + ex.Message + " ***");
                return 0;
            }
        }
        #endregion

        #region MissingPersons
        public List<MissingPerson> GetMissingPersons()
        {
            try
            {
                return connection.Table<MissingPerson>().ToList();
            }
            catch (Exception ex)
            {
                Debug.WriteLine("*** GetMissingPersons: " + ex.Message + " ***");
                return null;
            }
        }
        public async Task<List<MissingPerson>> GetMissingPersonsAsync()
        {
            try
            {
                return await connectionAsync.Table<MissingPerson>().ToListAsync();
            }
            catch (Exception ex)
            {
                Debug.WriteLine("*** GetMissingPersonsAsync: " + ex.Message + " ***");
                return null;
            }
        }

        public MissingPerson GetMissingPerson(int id)
        {
            try
            {
                return connection.Table<MissingPerson>().Where(m => m.Id == id).FirstOrDefault();
            }
            catch (Exception ex)
            {
                Debug.WriteLine("*** GetMissingPerson: " + ex.Message + " ***");
                return null;
            }
        }
        public async Task<MissingPerson> GetMissingPersonAsync(int id)
        {
            try
            {
                return await connectionAsync.Table<MissingPerson>().Where(m => m.Id == id).FirstOrDefaultAsync();
            }
            catch (Exception ex)
            {
                Debug.WriteLine("*** GetMissingPersonAsync: " + ex.Message + " ***");
                return null;
            }
        }

        public void UpdateMissingPerson(int id, int isCompleted)
        {
            try
            {
                connection.Execute("UPDATE MissingPerson SET IsCompleted = ? WHERE Id = ?", isCompleted, id);
            }
            catch (Exception ex)
            {
                Debug.WriteLine("*** UpdateMissingPerson: " + ex.Message + " ***");
            }
        }
        public async Task<int> UpdateMissingPersonAsync(int id, int isCompleted)
        {
            try
            {
                return await connectionAsync.ExecuteAsync("UPDATE MissingPerson SET IsCompleted = ? WHERE Id = ?", isCompleted, id);
            }
            catch (Exception ex)
            {
                Debug.WriteLine("*** UpdateMissingPersonAsync: " + ex.Message + " ***");
                return 0;
            }
        }
        #endregion

        #region SchoolQuestions
        public List<SchoolQuestion> GetSchoolQuestions()
        {
            try
            {
                return connection.Table<SchoolQuestion>().ToList();
            }
            catch (Exception ex)
            {
                Debug.WriteLine("*** GetSchoolQuestions: " + ex.Message + " ***");
                return null;
            }
        }
        public async Task<List<SchoolQuestion>> GetSchoolQuestionsAsync()
        {
            try
            {
                return await connectionAsync.Table<SchoolQuestion>().ToListAsync();
            }
            catch (Exception ex)
            {
                Debug.WriteLine("*** GetSchoolQuestionsAsync: " + ex.Message + " ***");
                return null;
            }
        }

        public SchoolQuestion GetSchoolQuestion(int id)
        {
            try
            {
                return connection.Table<SchoolQuestion>().Where(s => s.Id == id).FirstOrDefault();
            }
            catch (Exception ex)
            {
                Debug.WriteLine("*** GetSchoolQuestion: " + ex.Message + " ***");
                return null;
            }
        }
        public async Task<SchoolQuestion> GetSchoolQuestionAsync(int id)
        {
            try
            {
                return await connectionAsync.Table<SchoolQuestion>().Where(s => s.Id == id).FirstOrDefaultAsync();
            }
            catch (Exception ex)
            {
                Debug.WriteLine("*** GetSchoolQuestionAsync: " + ex.Message + " ***");
                return null;
            }
        }

        public void UpdateSchoolQuestion(int id, int isCompleted)
        {
            try
            {
                connection.Execute("UPDATE SchoolQuestion SET IsCompleted = ? WHERE Id = ?", isCompleted, id);
            }
            catch (Exception ex)
            {
                Debug.WriteLine("*** UpdateSchoolQuestion: " + ex.Message + " ***");
            }
        }
        public async Task<int> UpdateSchoolQuestionAsync(int id, int isCompleted)
        {
            try
            {
                return await connectionAsync.ExecuteAsync("UPDATE SchoolQuestion SET IsCompleted = ? WHERE Id = ?", isCompleted, id);
            }
                catch (Exception ex)
            {
                Debug.WriteLine("*** UpdateSchoolQuestionAsync: " + ex.Message + " ***");
                return 0;
            }
        }
        #endregion
    }
}
