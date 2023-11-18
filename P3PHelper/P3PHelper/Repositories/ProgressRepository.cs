using P3PHelper.MVVM.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P3PHelper.Repositories
{
    public class ProgressRepository
    {
        SQLiteConnection connection;

        public ProgressRepository()
        {
            connection = new SQLiteConnection(Constants.DatabasePath, Constants.Flags);
            connection.CreateTable<SLink>();
            connection.CreateTable<RankUp>();
        }

        public List<SLink> GetSLinks()
        {
            try
            {

            return connection.Table<SLink>().ToList();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
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
                Debug.WriteLine(ex.Message);
                return null;
            }
        }

        public void InsertSlink(string arcanaName)
        {
            try
            {
                connection.Insert(new SLink { Arcana = arcanaName });
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
        }

        public List<RankUp> GetRankUps()
        {
            try
            {

            return connection.Table<RankUp>().ToList();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                return null;
            }
        }

        public RankUp GetRankUp(int rankUpId)
        {
            try
            {

            return connection.Table<RankUp>().Where(r => r.RankUpId == rankUpId).FirstOrDefault();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                return null;
            }
        }

        public void InsertRankUpMale(int id, string arcanaName, int rankNumber, bool isCompletedMale)
        {
            try
            {
                connection.Insert(new RankUp
                { 
                    RankUpId = id,
                    SLinkArcana = arcanaName,
                    RankNumber = rankNumber,
                    IsCompletedMale = isCompletedMale,
                });
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
        }

        public void InsertRankUpFemale(int id, string arcanaName, int rankNumber, bool isCompletedFemale)
        {
            try
            {
                connection.Insert(new RankUp
                {
                    RankUpId = id,
                    SLinkArcana = arcanaName,
                    RankNumber = rankNumber,
                    IsCompletedFemale = isCompletedFemale
                });
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
        }

        public void UpdateRankUp(int rankId, bool isCompleted, bool isMale)
        {
            try
            {
                string columnName = isMale ? "IsCompletedMale" : "IsCompletedFemale";

                string query = $"UPDATE RankUp SET {columnName} = @IsCompleted WHERE RankUpId = @RankId";
                Debug.WriteLine($"Executing query: {query}, IsCompleted: {isCompleted}, RankId: {rankId}");

                connection.Execute($"UPDATE RankUp SET {columnName} = @IsCompleted WHERE RankUpId = @RankId",
                    new { IsCompleted = isCompleted, RankId = rankId });
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
        }
    }
}
