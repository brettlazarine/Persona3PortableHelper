﻿using P3PHelper.MVVM.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P3PHelper.Repositories
{
    public class RequestRepository
    {
        public List<Request> AllRequests { get; set; } = new();

        public RequestRepository()
        {
            AllRequests = new List<Request>()
            {
                #region 1-10
                new Request()
                {
                   QuestNumber = 1,
                   QuestName = "Retrieve 1 Beetle Shell",
                   Reward = "¥12,000",
                   Available = "4/30",
                   Deadline = "5/7",
                   HowToComplete = "Dropped by Grave Beetle on Floors 6 - 15"
                },
                new Request()
                {
                   QuestNumber = 2,
                   QuestName = "Retrieve the first old document",
                   Reward = "Bead Chain",
                   Available = "4/30",
                   Deadline = "5/7",
                   HowToComplete = "Reach the top of Thebel Block before the Full Moon"
                },
                new Request()
                {
                   QuestNumber = 3,
                   QuestName = "I'd like to sip a Muscle Drink",
                   Reward = "Dark Jacket (male)\n---\nAngora Sweater (female)",
                   Available = "4/30",
                   Deadline = "None",
                   HowToComplete = "Can be found in chests in Tartarus or bought from Pharmacy"
                },
                new Request()
                {
                   QuestNumber = 4,
                   QuestName = "Retrieve 3 Old Lanterns",
                   Reward = "Umugi Water x2",
                   Available = "5/10",
                   Deadline = "6/6",
                   HowToComplete = "Dropped by Phantom Mage on Floors 17 - 24"
                },
                new Request()
                {
                   QuestNumber = 5,
                   QuestName = "Retrieve the second old document",
                   Reward = "Recarm Card",
                   Available = "5/10",
                   Deadline = "6/6",
                   HowToComplete = "Reach the 40th Floor of Tartarus before the Full Moon"
                },
                new Request()
                {
                   QuestNumber = 6,
                   QuestName = "Create Jack Frost with Dia",
                   Reward = "Battle Panties",
                   Available = "5/10",
                   Deadline = "None",
                   HowToComplete = "Fuse Pixie (Lovers) and Unicorn (Priestess)"
                },
                new Request()
                {
                   QuestNumber = 7,
                   QuestName = "Retrieve 1 Lead Medal",
                   Reward = "Toy Bow",
                   Available = "5/10",
                   Deadline = "None",
                   HowToComplete = "Dropped by Gold Shadows in Thebel Block"
                },
                new Request()
                {
                   QuestNumber = 8,
                   QuestName = "Create Valkyrie with Tarukaja",
                   Reward = "Torn Black Cloth",
                   Available = "After Completing #6",
                   Deadline = "None",
                   HowToComplete = "Fuse Lilim (Devil) and Tam Lin (Lovers), inheriting Tarukaja"
                },
                new Request()
                {
                   QuestNumber = 9,
                   QuestName = "Retrieve 5 Bronze Figurines",
                   Reward = "Sigma Drive",
                   Available = "6/13",
                   Deadline = "7/5",
                   HowToComplete = "Dropped by Bronze Dice on Floors 41 - 46"
                },
                new Request()
                {
                   QuestNumber = 10,
                   QuestName = "Retrieve 3 Snake Scale",
                   Reward = "¥46,000",
                   Available = "6/13",
                   Deadline = "7/5",
                   HowToComplete = "Dropped by Lustful Snakes (Red Shadows) on Floors 41-63"
                },
                #endregion
                #region 11-20
                new Request()
                {
                   QuestNumber = 11,
                   QuestName = "Retrieve the third old document",
                   Reward = "¥50,000",
                   Available = "6/13",
                   Deadline = "7/5",
                   HowToComplete = "Reach the top of Arqa Block before the Full Moon"
                },
                new Request()
                {
                   QuestNumber = 12,
                   QuestName = "Retrieve 1 Goggle-eyed Idol",
                   Reward = "W.Outfit Mitsuru",
                   Available = "6/10",
                   Deadline = "None",
                   HowToComplete = "Trade in 2 Turquoise at Shinshoudo Antiques\n---\n" +
                                    "Turquoise can be found from enemies in Tartarus Block 2"
                },
                new Request()
                {
                   QuestNumber = 13,
                   QuestName = "Retrieve the shell of a man",
                   Reward = "Legendary Cleaver (male)\n---\nBeam Naginata (female)",
                   Available = "6/10",
                   Deadline = "None",
                   HowToComplete = "Go to the Laboratory in Gekkoukan High School after accepting the request"
                },
                new Request()
                {
                   QuestNumber = 14,
                   QuestName = "Retrieve 1 Steel Medal",
                   Reward = "Spiked Bat",
                   Available = "After Completing #7",
                   Deadline = "None",
                   HowToComplete = "Dropped by Gold Shadows in Arqa Block"
                },
                new Request()
                {
                   QuestNumber = 15,
                   QuestName = "Create Oberon (Lv. 17+)",
                   Reward = "W.Outfit Akihiko",
                   Available = "After Completing #8",
                   Deadline = "None",
                   HowToComplete = "Fuse Jack Frost (Magician) and Alp (Lovers) to create Oberon, then level him to 17"
                },
                new Request()
                {
                   QuestNumber = 16,
                   QuestName = "Bring me strong medicine",
                   Reward = "Balm of Life",
                   Available = "9/1",
                   Deadline = "None",
                   HowToComplete = "Accept the request, then visit Mr. Edogawa when Sick or Tired"
                },
                new Request()
                {
                   QuestNumber = 17,
                   QuestName = "I'd like some funky school music",
                   Reward = "S.Outfit Main (male)\n---\nOrange Cutsew (female)",
                   Available = "9/4",
                   Deadline = "None",
                   HowToComplete = "Go to the PA Room of Gekkoukan High School after accepting the request"
                },
                new Request()
                {
                   QuestNumber = 18,
                   QuestName = "Retrieve 5 Relic Fragments",
                   Reward = "Land Badge",
                   Available = "7/8",
                   Deadline = "8/4",
                   HowToComplete = "Dropped by Creation Relic on Floors 65 - 77"
                },
                new Request()
                {
                   QuestNumber = 19,
                   QuestName = "Retrieve 3 Greasy Gears",
                   Reward = "King of Wands",
                   Available = "7/8",
                   Deadline = "8/4",
                   HowToComplete = "Dropped by Wild Drives (Red Shadows) on Floors 65-88"
                },
                new Request()
                {
                   QuestNumber = 20,
                   QuestName = "Retrieve the fourth old document",
                   Reward = "Fast Retreat Skill Card",
                   Available = "7/8",
                   Deadline = "8/4",
                   HowToComplete = "Reach the 89th Floor before the Full Moon"
                },
                #endregion
                #region 21-30
                new Request()
                {
                   QuestNumber = 21,
                   QuestName = "Retrieve 1 Bronze Medal",
                   Reward = "Steel Pipe (male)\n---\nLacross Stick (female)",
                   Available = "After Completing #14",
                   Deadline = "None",
                   HowToComplete = "Dropped by Gold Shadows in Yabbashah Block"
                },
                new Request()
                {
                   QuestNumber = 22,
                   QuestName = "Create Vetala with Maragi",
                   Reward = "Sugar Key",
                   Available = "After Completing #15",
                   Deadline = "None",
                   HowToComplete = "Fuse Pyro Jack (Magician), Jack Frost (Magician), and Narcissus (Lovers) in a Triangle Fusion, " +
                                    "inheriting Maragi"
                },
                new Request()
                {
                   QuestNumber = 23,
                   QuestName = "Create Orthrus with Dodge Slash",
                   Reward = "W.Outfit Yukari",
                   Available = "After Completing #22",
                   Deadline = "None",
                   HowToComplete = "Fuse Valkyrie (Strength), Queen Mab (Lovers), and Ares (Chariot) in a Triangle Fusion, " +
                                    "inhering Dodge Slash"
                },
                new Request()
                {
                   QuestNumber = 24,
                   QuestName = "Retrieve 5 Tiara's Hair",
                   Reward = "Precious Egg",
                   Available = "8/7",
                   Deadline = "9/3",
                   HowToComplete = "Dropped by Shouting Tiara on Floors 102 - 113"
                },
                new Request()
                {
                   QuestNumber = 25,
                   QuestName = "Retrieve 4 Knight's Reins",
                   Reward = "Greaves of Dawn",
                   Available = "8/7",
                   Deadline = "9/3",
                   HowToComplete = "Dropped by Champion Knights (Red Shadows) on Floors 90-113"
                },
                new Request()
                {
                   QuestNumber = 26,
                   QuestName = "Retrieve fifth old document",
                   Reward = "¥120,000",
                   Available = "8/7",
                   Deadline = "9/3",
                   HowToComplete = "Reach the top of Yabbashah Block before the Full Moon"
                },
                new Request()
                {
                   QuestNumber = 27,
                   QuestName = "Retrieve 1 Platinum Watch",
                   Reward = "S.Outfit Mitsuru",
                   Available = "After Completing #16",
                   Deadline = "None",
                   HowToComplete = "Can be bought from the Police Station after accepting the request"
                },
                new Request()
                {
                   QuestNumber = 28,
                   QuestName = "I'd like a drink with my sister's name",
                   Reward = "S.Outfit Junpei",
                   Available = "9/8",
                   Deadline = "None",
                   HowToComplete = "Go to Port Island Station, then Station Outskirts, and get the Queen Elizabeth from Que Sera Sera"
                },
                new Request()
                {
                   QuestNumber = 29,
                   QuestName = "Create Oumitsunu (Lv. 33+)",
                   Reward = "Machine Core",
                   Available = "After Completing #23",
                   Deadline = "None",
                   HowToComplete = "Fuse Ares (Chariot), Chimera (Chariot), and Ara Mitama (Chariot) in a Triangle Fusion " +
                                    "to create Oumitsunu, then level him up to 33"
                },
                new Request()
                {
                   QuestNumber = 30,
                   QuestName = "Retrieve 1 Homunculus",
                   Reward = "W.Outfit Junpei",
                   Available = "After Completing #27",
                   Deadline = "None",
                   HowToComplete = "Can be found in rare chests throughout Tartarus, or bought at the " +
                                    "Antique Store in Paulownia Mall for 1 Diamond and 1 Sapphire"
                },
                #endregion
                #region 31-40
                new Request()
                {
                   QuestNumber = 31,
                   QuestName = "Find me a beautiful tile",
                   Reward = "S.Outfit Akihiko",
                   Available = "After Completing #28",
                   Deadline = "None",
                   HowToComplete = "Accept the request and then go to Port Island Station, then to Station Outskirts, " +
                                    "then enter Mahjong Club 'Red Hawk' and win the game of Rock-Paper-Scissors (try until you win)"
                },
                new Request()
                {
                   QuestNumber = 32,
                   QuestName = "Retrieve 1 Silver Medal",
                   Reward = "Bone",
                   Available = "After Completing #21",
                   Deadline = "None",
                   HowToComplete = "Dropped by Gold Shadows in Tziah Block"
                },
                new Request()
                {
                   QuestNumber = 33,
                   QuestName = "Retrieve 5 Empress's Mirrors",
                   Reward = "Quick Pumps",
                   Available = "9/6",
                   Deadline = "10/2",
                   HowToComplete = "Dropped by Elegant Mother on Floors 126 - 138"
                },
                new Request()
                {
                   QuestNumber = 34,
                   QuestName = "Retrieve 3 Gold Handguards",
                   Reward = "Bus Stop Sign",
                   Available = "9/6",
                   Deadline = "10/2",
                   HowToComplete = "Dropped by Hakurou Musha (Red Shadows) on Floors 115-138"
                },
                new Request()
                {
                   QuestNumber = 35,
                   QuestName = "Retrieve the sixth old document",
                   Reward = "Bead x5",
                   Available = "9/6",
                   Deadline = "10/3",
                   HowToComplete = "Reach Floor 139 before the Full Moon"
                },
                new Request()
                {
                   QuestNumber = 36,
                   QuestName = "Create Black Frost",
                   Reward = "Baseball Jersey",
                   Available = "After Completing #29",
                   Deadline = "None",
                   HowToComplete = "Fuse King Frost (Emperor), Jack Frost (Magician), Pyro Jack (Magician), " +
                                    "and Queen Mab (Lovers) in a Cross Fusion"
                },
                new Request()
                {
                   QuestNumber = 37,
                   QuestName = "Bring me 3 Jack Frost Dolls",
                   Reward = "Jack's Gloves",
                   Available = "6/10",
                   Deadline = "None",
                   HowToComplete = "Go to Paulownia Mall and play the Crane Game beside Game Parade"
                },
                new Request()
                {
                   QuestNumber = 38,
                   QuestName = "I'd like to try sushi",
                   Reward = "Scrub Brush\nDO NOT SELL THIS",
                   Available = "10/5",
                   Deadline = "None",
                   HowToComplete = "Go to Naganaki Shrine and interact with the Inari Shrine"
                },
                new Request()
                {
                   QuestNumber = 39,
                   QuestName = "Retrieve 3 Gold Rings",
                   Reward = "¥340,000",
                   Available = "10/5",
                   Deadline = "11/1",
                   HowToComplete = "Dropped by Wondrous Magus on Floors 151 - 159"
                },
                new Request()
                {
                   QuestNumber = 40,
                   QuestName = "Retrieve 2 Red Armor Plates",
                   Reward = "Spirit Bracers",
                   Available = "10/5",
                   Deadline = "11/1",
                   HowToComplete = "Dropped by Scarlet Turret (Red Shadows) on Floors 140-163"
                },
                #endregion
                #region 41-50
                new Request()
                {
                   QuestNumber = 41,
                   QuestName = "Retrieve the seventh old document",
                   Reward = "Megidolaon Gem",
                   Available = "10/5",
                   Deadline = "11/1",
                   HowToComplete = "Reach the top of Tziah Block before the Full Moon"
                },
                new Request()
                {
                   QuestNumber = 42,
                   QuestName = "Create Girimehkala",
                   Reward = "Marionette",
                   Available = "After Completing #36",
                   Deadline = "None",
                   HowToComplete = "Fuse Gurr (Moon), Rangda (Magician), Vetala (Devil), and Taraka (Hermit) in a Cross Fusion."
                },
                new Request()
                {
                   QuestNumber = 43,
                   QuestName = "Create Daisoujou",
                   Reward = "W.Outfit Ken",
                   Available = "After Completing #42",
                   Deadline = "None",
                   HowToComplete = "Fuse Mithra (Temperance), Ara Mitama (Chariot), Kusi Mitama (Fortune), " +
                                    "Saki Mitama (Lovers), and Nigi Mitama (Temperance) in a Pentagon fusion"
                },
                new Request()
                {
                   QuestNumber = 44,
                   QuestName = "Retrieve 6 Pink Feathers",
                   Reward = "Berserker's Seal",
                   Available = "11/5",
                   Deadline = "11/30",
                   HowToComplete = "Dropped by Gracious Cupid on Floors 181 - 190"
                },
                new Request()
                {
                   QuestNumber = 45,
                   QuestName = "Retrieve 3 Moon Tablets",
                   Reward = "Space Badge",
                   Available = "11/5",
                   Deadline = "11/30",
                   HowToComplete = "Dropped by Ruinous Idols (Red Shadows) on Floors 165-189"
                },
                new Request()
                {
                   QuestNumber = 46,
                   QuestName = "Retrieve the last old document",
                   Reward = "¥650,000",
                   Available = "11/5",
                   Deadline = "12/29",
                   HowToComplete = "Reach the top of Harabah Block before the Full Moon"
                },
                new Request()
                {
                   QuestNumber = 47,
                   QuestName = "Retrieve 2 Gold Medals",
                   Reward = "Rocket Punch",
                   Available = "After Completing #32",
                   Deadline = "None",
                   HowToComplete = "Dropped by Gold Shadows in Harabah Block"
                },
                new Request()
                {
                   QuestNumber = 48,
                   QuestName = "Create Alice with Megido",
                   Reward = "Lily Petal",
                   Available = "After Completing #47",
                   Deadline = "None",
                   HowToComplete = "Fuse Oberon (Emperor) and Decarabia (Fool) to make a  Nata Taishi, inheriting Megido" +
                                    "\n---\nFuse this Nata Taishi (Chariot) with Lilim (Devil), Pixie (Lovers), " +
                                    "and Narcissus (Lovers) in a Cross Fusion to make Alice, inheriting Megido"
                },
                new Request()
                {
                   QuestNumber = 49,
                   QuestName = "Retrieve 3 Sand of Time",
                   Reward = "Atlus Stick",
                   Available = "12/4",
                   Deadline = "12/29",
                   HowToComplete = "Dropped by Perpetual Sand on Floors 202 - 210"
                },
                new Request()
                {
                   QuestNumber = 50,
                   QuestName = "Retrieve 3 Rainbow Hairs",
                   Reward = "Omega Drive",
                   Available = "12/4",
                   Deadline = "12/29",
                   HowToComplete = "Dropped by Daring Gigas (Red Shadows) on Floors 191-213"
                },
                #endregion
                #region 51-60
                new Request()
                {
                   QuestNumber = 51,
                   QuestName = "",
                   Reward = "",
                   Available = "",
                   Deadline = "",
                   HowToComplete = ""
                },
                new Request()
                {
                   QuestNumber = 52,
                   QuestName = "",
                   Reward = "",
                   Available = "",
                   Deadline = "",
                   HowToComplete = ""
                },
                new Request()
                {
                   QuestNumber = 53,
                   QuestName = "",
                   Reward = "",
                   Available = "",
                   Deadline = "",
                   HowToComplete = ""
                },
                new Request()
                {
                   QuestNumber = 54,
                   QuestName = "",
                   Reward = "",
                   Available = "",
                   Deadline = "",
                   HowToComplete = ""
                },
                new Request()
                {
                   QuestNumber = 55,
                   QuestName = "",
                   Reward = "",
                   Available = "",
                   Deadline = "",
                   HowToComplete = ""
                },
                new Request()
                {
                   QuestNumber = 56,
                   QuestName = "",
                   Reward = "",
                   Available = "",
                   Deadline = "",
                   HowToComplete = ""
                },
                new Request()
                {
                   QuestNumber = 57,
                   QuestName = "",
                   Reward = "",
                   Available = "",
                   Deadline = "",
                   HowToComplete = ""
                },
                new Request()
                {
                   QuestNumber = 58,
                   QuestName = "",
                   Reward = "",
                   Available = "",
                   Deadline = "",
                   HowToComplete = ""
                },
                new Request()
                {
                   QuestNumber = 59,
                   QuestName = "",
                   Reward = "",
                   Available = "",
                   Deadline = "",
                   HowToComplete = ""
                },
                new Request()
                {
                   QuestNumber = 60,
                   QuestName = "",
                   Reward = "",
                   Available = "",
                   Deadline = "",
                   HowToComplete = ""
                },
                #endregion
                #region 61-70
                new Request()
                {
                   QuestNumber = 61,
                   QuestName = "",
                   Reward = "",
                   Available = "",
                   Deadline = "",
                   HowToComplete = ""
                },
                new Request()
                {
                   QuestNumber = 62,
                   QuestName = "",
                   Reward = "",
                   Available = "",
                   Deadline = "",
                   HowToComplete = ""
                },
                new Request()
                {
                   QuestNumber = 63,
                   QuestName = "",
                   Reward = "",
                   Available = "",
                   Deadline = "",
                   HowToComplete = ""
                },
                new Request()
                {
                   QuestNumber = 64,
                   QuestName = "",
                   Reward = "",
                   Available = "",
                   Deadline = "",
                   HowToComplete = ""
                },
                new Request()
                {
                   QuestNumber = 65,
                   QuestName = "",
                   Reward = "",
                   Available = "",
                   Deadline = "",
                   HowToComplete = ""
                },
                new Request()
                {
                   QuestNumber = 66,
                   QuestName = "",
                   Reward = "",
                   Available = "",
                   Deadline = "",
                   HowToComplete = ""
                },
                new Request()
                {
                   QuestNumber = 67,
                   QuestName = "",
                   Reward = "",
                   Available = "",
                   Deadline = "",
                   HowToComplete = ""
                },
                new Request()
                {
                   QuestNumber = 68,
                   QuestName = "",
                   Reward = "",
                   Available = "",
                   Deadline = "",
                   HowToComplete = ""
                },
                new Request()
                {
                   QuestNumber = 69,
                   QuestName = "",
                   Reward = "",
                   Available = "",
                   Deadline = "",
                   HowToComplete = ""
                },
                new Request()
                {
                   QuestNumber = 70,
                   QuestName = "",
                   Reward = "",
                   Available = "",
                   Deadline = "",
                   HowToComplete = ""
                },
                #endregion
                #region 71-80
                new Request()
                {
                   QuestNumber = 1,
                   QuestName = "",
                   Reward = "",
                   Available = "",
                   Deadline = "",
                   HowToComplete = ""
                },
                new Request()
                {
                   QuestNumber = 2,
                   QuestName = "",
                   Reward = "",
                   Available = "",
                   Deadline = "",
                   HowToComplete = ""
                },
                new Request()
                {
                   QuestNumber = 3,
                   QuestName = "",
                   Reward = "",
                   Available = "",
                   Deadline = "",
                   HowToComplete = ""
                },
                new Request()
                {
                   QuestNumber = 4,
                   QuestName = "",
                   Reward = "",
                   Available = "",
                   Deadline = "",
                   HowToComplete = ""
                },
                new Request()
                {
                   QuestNumber = 5,
                   QuestName = "",
                   Reward = "",
                   Available = "",
                   Deadline = "",
                   HowToComplete = ""
                },
                new Request()
                {
                   QuestNumber = 6,
                   QuestName = "",
                   Reward = "",
                   Available = "",
                   Deadline = "",
                   HowToComplete = ""
                },
                new Request()
                {
                   QuestNumber = 7,
                   QuestName = "",
                   Reward = "",
                   Available = "",
                   Deadline = "",
                   HowToComplete = ""
                },
                new Request()
                {
                   QuestNumber = 8,
                   QuestName = "",
                   Reward = "",
                   Available = "",
                   Deadline = "",
                   HowToComplete = ""
                },
                new Request()
                {
                   QuestNumber = 9,
                   QuestName = "",
                   Reward = "",
                   Available = "",
                   Deadline = "",
                   HowToComplete = ""
                },
                new Request()
                {
                   QuestNumber = 10,
                   QuestName = "",
                   Reward = "",
                   Available = "",
                   Deadline = "",
                   HowToComplete = ""
                },
                #endregion
            };

            if (App.ProgressRepo.GetRequests().Count == 0)
            {
                LoadRequestDb(AllRequests);
            }
        }

        public void LoadRequestDb(List<Request> requests)
        {
            try
            {
                if (App.ProgressRepo.GetRequests().Count == 0)
                {
                    foreach (var request in requests)
                    {
                        App.ProgressRepo.InsertRequest(request);
                    }
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine("*** LoadRequestDb: " + ex.Message + " ***");
                return;
            }
        }
    }
}
