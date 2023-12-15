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
    {
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
            connection.CreateTable<ArcanaRankUp>();
        }

        #region SLinks
        public List<SLink> GetSLinks()
        {
            return connection.Table<SLink>().ToList();
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



        //public List<SLink> GetSLinks()
        //{
        //    try
        //    {
        //        var SLinks = connection.Table<SLink>().ToList();
        //        foreach (var link in SLinks)
        //        {
        //            link.MaleRankUps = connection.Table<RankUp>().Where(r => r.Arcana == link.Arcana && r.IsMale == 1).ToList();
        //            link.FemaleRankUps = connection.Table<RankUp>().Where(r => r.Arcana == link.Arcana && r.IsMale == 0).ToList();
        //        }
        //        return SLinks;
        //    }
        //    catch (Exception ex)
        //    {
        //        Debug.WriteLine("*** GetSLinks: " + ex.Message + " ***");
        //        return null;
        //    }
        //}

        //public SLink GetSLink(string arcanaName)
        //{
        //    try
        //    {
        //        var link = connection.Table<SLink>().Where(s => s.Arcana == arcanaName).FirstOrDefault();
        //        link.MaleRankUps = connection.Table<RankUp>().Where(r => r.Arcana == link.Arcana && r.IsMale == 1).ToList();
        //        link.FemaleRankUps = connection.Table<RankUp>().Where(r => r.Arcana == link.Arcana && r.IsMale == 0).ToList();

        //        return link;
        //    }
        //    catch (Exception ex)
        //    {
        //        Debug.WriteLine("*** GetSLink: " + ex.Message + " ***");
        //        return null;
        //    }
        //}

        //public void InsertSLink(SLink link)
        //{
        //    try
        //    {
        //        connection.Insert(new SLink 
        //        { 
        //            Arcana = link.Arcana,
        //            MaleName = link.MaleName,
        //            FemaleName = link.FemaleName,
        //            MaleUnlockDate = link.MaleUnlockDate,
        //            FemaleUnlockDate = link.FemaleUnlockDate,
        //            MaleHowToUnlock = link.MaleHowToUnlock,
        //            FemaleHowToUnlock = link.FemaleHowToUnlock,
        //            MaleAvailability = link.MaleAvailability,
        //            FemaleAvailability = link.FemaleAvailability,
        //            MaleRequiresPersona = link.MaleRequiresPersona,
        //            FemaleRequiresPersona = link.FemaleRequiresPersona,
        //            MaleRankUps = link.MaleRankUps,
        //            FemaleRankUps = link.FemaleRankUps
        //        });
        //    }
        //    catch (Exception ex)
        //    {
        //        Debug.WriteLine("*** InsertSLink: " + ex.Message + " ***");
        //    }
        //}
        #endregion

        //#region RankUps
        //public List<RankUp> GetRankUps()
        //{
        //    try
        //    {
        //    return connection.Table<RankUp>().ToList();
        //    }
        //    catch (Exception ex)
        //    {
        //        Debug.WriteLine("*** GetRankUps: " + ex.Message + " ***");
        //        return null;
        //    }
        //}

        //public RankUp GetRankUp(int rankUpId)
        //{
        //    try
        //    {
        //    return connection.Table<RankUp>().Where(r => r.RankUpId == rankUpId).FirstOrDefault();
        //    }
        //    catch (Exception ex)
        //    {
        //        Debug.WriteLine("*** GetRankUp: " + ex.Message + " ***");
        //        return null;
        //    }
        //}

        //public void InsertMaleRankUp(RankUp rank)
        //{
        //    try
        //    {
        //        connection.Insert(new RankUp
        //        { 
        //            RankNumber = rank.RankNumber,
        //            Arcana = rank.Arcana,
        //            IsCompleted = rank.IsCompleted,
        //            RankInteractions = rank.RankInteractions,
        //            RankUpId = rank.RankUpId, 
        //            IsMale = rank.IsMale
        //        });
        //    }
        //    catch (Exception ex)
        //    {
        //        Debug.WriteLine("*** InsertMaleRankUp: " + ex.Message + " ***");
        //    }
        //}

        //// May be redundant, remove if so when refactorin
        //public void InsertFemaleRankUp(RankUp rank)
        //{
        //    try
        //    {
        //        connection.Insert(new RankUp
        //        {
        //            RankNumber = rank.RankNumber,
        //            Arcana = rank.Arcana,
        //            IsCompleted = rank.IsCompleted,
        //            RankInteractions = rank.RankInteractions,
        //            RankUpId = rank.RankUpId,
        //            IsMale = rank.IsMale
        //        });
        //    }
        //    catch (Exception ex)
        //    {
        //        Debug.WriteLine("*** InsertFemaleRankUp: " + ex.Message + " ***");
        //    }
        //}

        //public void UpdateRankUp(int rankId, int isCompleted)
        //{
        //    try
        //    {
        //        RankUp newData = new RankUp
        //        {
        //            RankUpId = rankId,
        //            IsCompleted = isCompleted
        //        };

        //        connection.Execute($"UPDATE RankUp SET IsCompleted = {newData.IsCompleted} WHERE RankUpId = {newData.RankUpId};");
        //    }
        //    catch (Exception ex)
        //    {
        //        Debug.WriteLine("*** UpdateRankUp: " + ex.Message + " ***");
        //    }
        //}
        //#endregion

        //#region Requests
        //public List<Request> GetRequests()
        //{
        //    try
        //    {
        //        return connection.Table<Request>().ToList();
        //    }
        //    catch (Exception ex)
        //    {
        //        Debug.WriteLine("*** GetRequests: " + ex.Message + " ***");
        //        return null;
        //    }
        //}

        //public Request GetRequest(int questNumber)
        //{
        //    try
        //    {
        //        return connection.Table<Request>().Where(r => r.QuestNumber == questNumber).FirstOrDefault();
        //    }
        //    catch (Exception ex)
        //    {
        //        Debug.WriteLine("*** GetRequest: " + ex.Message + " ***");
        //        return null;
        //    }
        //}

        //public void InsertRequest(Request request)
        //{
        //    try
        //    {
        //        connection.Insert(new Request
        //        {
        //            QuestNumber = request.QuestNumber,
        //            QuestName = request.QuestName,
        //            Reward = request.Reward,
        //            Available = request.Available,
        //            Deadline = request.Deadline,
        //            HowToComplete = request.HowToComplete
        //        });
        //    }
        //    catch (Exception ex)
        //    {
        //        Debug.WriteLine("*** InsertRequest: " + ex.Message + " ***");
        //    }
        //}

        //public void UpdateRequest(int questNumber, int isCompleted)
        //{
        //    try
        //    {
        //        connection.Execute($"UPDATE Request SET IsCompleted = {isCompleted} WHERE QuestNumber = {questNumber};");
        //    }
        //    catch (Exception ex)
        //    {
        //        Debug.WriteLine("*** UpdateRequest: " + ex.Message + " ***");
        //    }
        //}
        //#endregion
    }
}
