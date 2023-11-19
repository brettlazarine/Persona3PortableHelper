﻿using P3PHelper.MVVM.Models;
using SQLite;
using SQLiteNetExtensions.Extensions;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
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
                //return connection.GetAllWithChildren<SLink>(recursive: true);
                var SLinks = connection.Table<SLink>().ToList();
                foreach (var link in SLinks)
                {
                    link.MaleRankUps = connection.Table<RankUp>().Where(r => r.Arcana == link.Arcana).ToList();
                    link.FemaleRankUps = connection.Table<RankUp>().Where(r => r.Arcana == link.Arcana).ToList();
                }
                return SLinks;
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
                TextInfo textInfo = CultureInfo.CurrentCulture.TextInfo;
                arcanaName = textInfo.ToTitleCase(arcanaName);
                //return connection.Table<SLink>().Where(s => s.Arcana == arcanaName).FirstOrDefault();
                var link = connection.GetWithChildren<SLink>(arcanaName, true);
                foreach (var rank in link.MaleRankUps)
                {
                    rank.RankInteractions = connection.Table<RankUp>().Where(r => r.RankUpId == rank.RankUpId).FirstOrDefault().RankInteractions;
                }
                foreach (var rank in link.FemaleRankUps)
                {
                    rank.RankInteractions = connection.Table<RankUp>().Where(r => r.RankUpId == rank.RankUpId).FirstOrDefault().RankInteractions;
                }
                return link;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                return null;
            }
        }

        public void InsertSlink(SLink link)
        {
            try
            {
                connection.Insert(new SLink 
                { 
                    Arcana = link.Arcana,
                    MaleName = link.MaleName,
                    FemaleName = link.FemaleName,
                    MaleUnlockDate = link.MaleUnlockDate,
                    FemaleUnlockDate = link.FemaleUnlockDate,
                    MaleHowToUnlock = link.MaleHowToUnlock,
                    FemaleHowToUnlock = link.FemaleHowToUnlock,
                    MaleAvailability = link.MaleAvailability,
                    FemaleAvailability = link.FemaleAvailability,
                    MaleRequiresPersona = link.MaleRequiresPersona,
                    FemaleRequiresPersona = link.FemaleRequiresPersona,
                    MaleRankUps = link.MaleRankUps,
                    FemaleRankUps = link.FemaleRankUps
                });
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

        public void InsertRankUp(RankUp rank)
        {
            try
            {
                connection.Insert(new RankUp
                { 
                    RankNumber = rank.RankNumber,
                    Arcana = rank.Arcana,
                    IsCompleted = rank.IsCompleted,
                    RankInteractions = rank.RankInteractions,
                    RankUpId = rank.RankUpId
                });
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
        }

        public void InsertRankUpFemale(string arcanaName, int rankNumber, int isCompleted)
        {
            try
            {
                connection.Insert(new RankUp
                {
                    //RankUpId = id,
                    Arcana = arcanaName,
                    RankNumber = rankNumber,
                    IsCompleted = isCompleted
                });
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
        }
        // NO LONGER USING MALE/FEMALE, NEED TO UPDATE THIS
        public void UpdateRankUp(int rankId, int isCompleted)
        {
            try
            {
                RankUp newData = new RankUp
                {
                    RankUpId = rankId,
                    IsCompleted = isCompleted
                };

                string query = $"UPDATE RankUp SET IsCompleted = @IsCompleted WHERE RankUpId = @RankId";
                Debug.WriteLine($"Executing query: {query}, IsCompleted: {isCompleted}, RankId: {rankId}");

                //connection.Execute($"UPDATE RankUp SET IsCompleted = @IsCompleted WHERE RankUpId = @RankId",
                //    new { IsCompleted = newData.IsCompleted, RankUpId = newData.RankUpId });

                connection.Execute($"UPDATE RankUp SET IsCompleted = {newData.IsCompleted} WHERE RankUpId = {newData.RankUpId};");
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
        }
    }
}
