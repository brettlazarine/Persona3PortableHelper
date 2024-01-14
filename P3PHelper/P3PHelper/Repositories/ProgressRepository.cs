using Newtonsoft.Json;
using P3PHelper.MVVM.Models;
using SQLite;
using SQLiteNetExtensions.Extensions;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace P3PHelper.Repositories
{
    public class ProgressRepository
    { // Look into implementing yield returns for database calls
        SQLiteConnection connection;
        public static string DbPath { get; } = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "persona3.db3");
        public const SQLiteOpenFlags Flags =
            SQLiteOpenFlags.ReadWrite |
            SQLiteOpenFlags.Create |
            SQLiteOpenFlags.SharedCache;

        public ProgressRepository()
        {
            //connection = new SQLiteConnection(Constants.DatabasePath, Constants.Flags);
           // connection.CreateTable<SLink>();
            //connection.CreateTable<RankUp>();
            //connection.CreateTable<Request>();



            connection = new SQLiteConnection(DbPath, Flags);
            connection.CreateTable<SLink>();
            //connection.CreateTable<ArcanaRankUp>();
            connection.CreateTable<RankUp>();
            connection.CreateTable<Request>();
            connection.CreateTable<MissingPerson>();
            connection.CreateTable<SchoolQuestion>();
            // DON'T FORGET TO ADD NEW TABLES TO THIS LIST AS THEY ARE CREATED IN THE DATABASE
        }

        #region SLinks
        public List<SLink> GetSLinks()
        {
            return connection.Table<SLink>().ToList();
        }
        public async Task<List<SLink>> GetSLinksAsync()
        {
            return await Task.Run(() => connection.Table<SLink>().ToList());
        }

        public SLink GetSLink(string arcanaName)
        {
            // ... previous checks ...

            var result = connection.Table<SLink>().Where(s => s.Arcana == arcanaName).FirstOrDefault();

            //var links = connection.Table<SLink>().ToList();
            //var result = links.Where(s => s.Arcana == arcanaName).FirstOrDefault();
            if (result == null)
            {
                Debug.WriteLine($"*** No SLink found for ArcanaName: {arcanaName} ***");
            }
            return result;
        }
        public async Task<SLink> GetSLinkAsync(string arcanaName)
        {
            return await Task.Run(() =>
            {
                var result = connection.Table<SLink>().FirstOrDefault(s => s.Arcana == arcanaName);
                if (result == null)
                {
                    Debug.WriteLine($"*** No SLink found for ArcanaName: {arcanaName} ***");
                }
                return result;
            });
        }


        public void UpdateSLink(string arcana, int isCompleted)
        {
            var newData = new SLink
            {
                Arcana = arcana,
                //MaleRequiresPersona = isCompleted
            };
            //connection.Execute($"UPDATE RankUp SET IsCompleted = {newData.IsCompleted} WHERE RankUpId = {newData.RankUpId};");
            //connection.Execute($"UPDATE SLink SET MaleRequiresPersona = {link.MaleRequiresPersona} WHERE Arcana = {link.Arcana};");
            //connection.Execute("UPDATE SLink SET MaleRequiresPersona = ? WHERE Arcana = ?", isCompleted, arcana);
            //connection.Execute($"UPDATE SLink SET MaleRequiresPersona = {newData.MaleRequiresPersona} WHERE Arcana = '{newData.Arcana}';");
        }

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
                Debug.WriteLine("*** GETRANKUPS CONNECTION ***");
                var r = connection.Table<RankUp>().ToList();
                Debug.WriteLine("*** GETRANKUPS AFTER CONNECTION ***");
                return r;
            }
            catch (Exception ex)
            {
                Debug.WriteLine("*** GetRankUps: " + ex.Message + " ***");
                return null;
            }
        }

        public List<RankUp> GetRankUp(string arcana)
        {
            try
            {
                Debug.WriteLine("*** GETRANKUP CONNECTION ***");
                var r = connection.Table<RankUp>().Where(r => r.Arcana == arcana).ToList();
                Debug.WriteLine("*** GETRANKUP AFTER CONNECTION ***");
                return r;
            }
            catch (Exception ex)
            {
                Debug.WriteLine("*** GetRankUp: " + ex.Message + " ***");
                return null;
            }
        }
        public async Task<List<RankUp>> GetRankUpAsync(string arcana)
        {
            return await Task.Run(() =>
            {
                try
                {
                    //Debug.WriteLine("*** GETRANKUP CONNECTION ***");
                    var rankUps = connection.Table<RankUp>().Where(r => r.Arcana == arcana).ToList();
                    //Debug.WriteLine("*** GETRANKUP AFTER CONNECTION ***");
                    return rankUps;
                }
                catch (Exception ex)
                {
                    Debug.WriteLine("*** GetRankUpAsync: " + ex.Message + " ***");
                    return null;
                }
            });
        }


        public void UpdateRankUp(int id, int isCompleted)
        {
            try
            {
                connection.Execute("UPDATE RankUp SET IsCompleted = ? WHERE Id = ?", isCompleted, id);
                //connection.Execute($"UPDATE RankUp SET IsCompleted = {newData.IsCompleted} WHERE RankUpId = {newData.RankUpId};");
            }
            catch (Exception ex)
            {
                Debug.WriteLine("*** UpdateRankUp: " + ex.Message + " ***");
            }
        }
        #endregion

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

        #region Requests
        public List<Request> GetRequests()
        {
            return connection.Table<Request>().ToList();
        }
        public async Task<List<Request>> GetRequestsAsync()
        {
            return await Task.Run(() => connection.Table<Request>().ToList());
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
        #endregion

        #region MissingPersons
        public List<MissingPerson> GetMissingPersons()
        {
            return connection.Table<MissingPerson>().ToList();
        }
        public async Task<List<MissingPerson>> GetMissingPersonsAsync()
        {
            return await Task.Run(() => connection.Table<MissingPerson>().ToList());
        }

        public MissingPerson GetMissingPerson(int id)
        {
            return connection.Table<MissingPerson>().Where(m => m.Id == id).FirstOrDefault();
        }
        public async Task<MissingPerson> GetMissingPersonAsync(int id)
        {
            return await Task.Run(() => connection.Table<MissingPerson>().Where(m => m.Id == id).FirstOrDefault());
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
        #endregion

        #region SchoolQuestions
        public List<SchoolQuestion> GetSchoolQuestions()
        {
            return connection.Table<SchoolQuestion>().ToList();
        }
        public async Task<List<SchoolQuestion>> GetSchoolQuestionsAsync()
        {
            return await Task.Run(() => connection.Table<SchoolQuestion>().ToList());
        }

        public SchoolQuestion GetSchoolQuestion(int id)
        {
            return connection.Table<SchoolQuestion>().Where(s => s.Id == id).FirstOrDefault();
        }
        public async Task<SchoolQuestion> GetSchoolQuestionAsync(int id)
        {
            return await Task.Run(() => connection.Table<SchoolQuestion>().Where(s => s.Id == id).FirstOrDefault());
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
        public async Task<SchoolQuestion> UpdateSchoolQuestionAsync(int id, int isCompleted)
        {
            return await Task.Run(() =>
            {
                try
                {
                    connection.Execute("UPDATE SchoolQuestion SET IsCompleted = ? WHERE Id = ?", isCompleted, id);
                    return connection.Table<SchoolQuestion>().Where(s => s.Id == id).FirstOrDefault();
                }
                catch (Exception ex)
                {
                    Debug.WriteLine("*** UpdateSchoolQuestion: " + ex.Message + " ***");
                    return null;
                }
            });
        }
        #endregion
    }
}
