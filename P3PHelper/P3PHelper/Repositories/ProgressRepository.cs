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

        public RankUp GetRankUp(string arcanaName)
        {
            try
            {

            return connection.Table<RankUp>().Where(r => r.SLinkArcana == arcanaName).FirstOrDefault();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                return null;
            }
        }

        public void InsertRankUp(string arcanaName, int rankNumber, bool isCompletedMale, bool isCompletedFemale)
        {
            try
            {
                connection.Insert(new RankUp
                { 
                    SLinkArcana = arcanaName,
                    RankNumber = rankNumber,
                    IsCompletedMale = isCompletedMale,
                    IsCompletedFemale = isCompletedFemale
                });
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
        }

        public void InsertSLinkAndRankUp(string arcana, string arcanaName, int rankNumber, bool isCompletedMale, bool isCompletedFemale)
        {
            try
            {
                var existingSLink = connection.Table<SLink>().Where(s => s.Arcana == arcana).FirstOrDefault();
                if (existingSLink == null)
                {
                    connection.Insert(new SLink { Arcana = arcana });
                }
                
                var existingRankUp = connection.Table<RankUp>().Where(r => r.SLinkArcana == arcanaName).FirstOrDefault();
                if (existingRankUp == null)
                {
                    connection.Insert(new RankUp
                    {
                        SLinkArcana = arcanaName,
                        RankNumber = rankNumber,
                        IsCompletedMale = isCompletedMale,
                        IsCompletedFemale = isCompletedFemale
                    });
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
        }
    }
}
