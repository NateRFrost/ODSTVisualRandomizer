﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ODSTVisualRandomizer1.RandomizedItems.RandomizedItems;

namespace ODSTVisualRandomizer1.RandomizedItems
{
    public partial class RandomizedItems
    {
        public static RandomizedObjectList characters = new RandomizedObjectList()
        {
            Name = "characters",
            Type = "char",
            PaletteName = "character palette",
            PaletteNameAiResources = "character palette",
            ResourceFileExtension = "scenario_ai_resource",
            ResourcesFolder = "ai_resources",
            List = new List<RandomizedObjectDetails>()
            {
                new RandomizedObjectDetails{FancyName = "Brute Minor", Name = "brute", Path =  @"objects\characters\brute\ai\brute", Weight = 5, Faction = Faction.Covenant},
                new RandomizedObjectDetails{FancyName = "Brute Major", Name = "brute_major", Path =  @"objects\characters\brute\ai\brute_major", Weight = 5, Faction = Faction.Covenant},
                new RandomizedObjectDetails{FancyName = "Brute Ultra", Name = "brute_ultra", Path =  @"objects\characters\brute\ai\brute_ultra", Weight = 5, Faction = Faction.Covenant},
                new RandomizedObjectDetails{FancyName = "Brute Captain", Name = "brute_captain", Path =   @"objects\characters\brute\ai\brute_captain", Weight = 5, Faction = Faction.Covenant},
                new RandomizedObjectDetails{FancyName = "Brute Captain Major", Name = "brute_captain_major", Path =   @"objects\characters\brute\ai\brute_captain_major", Weight = 5, Faction = Faction.Covenant},
                new RandomizedObjectDetails{FancyName = "Brute Captain Ultra", Name = "brute_captain_ultra", Path =   @"objects\characters\brute\ai\brute_captain_ultra", Weight = 5, Faction = Faction.Covenant},
                new RandomizedObjectDetails{FancyName = "Brute Chieftan Red", Name = "brute_chieftain_armor",  Path =  @"objects\characters\brute\ai\brute_chieftain_armor", Weight = 1, Faction = Faction.Covenant},
                new RandomizedObjectDetails{FancyName = "Brute Chieftan Gold", Name = "brute_chieftain_weapon", Path =   @"objects\characters\brute\ai\brute_chieftain_weapon", Weight = 2, Faction = Faction.Covenant},
                new RandomizedObjectDetails{FancyName = "Brute Bodyguard", Name = "brute_bodyguard", Path =  @"objects\characters\brute\ai\brute_bodyguard", Weight = 5, Faction = Faction.Covenant},
                new RandomizedObjectDetails{FancyName = "Brute Jumppack", Name = "brute_jumppack",  Path =  @"objects\characters\brute\ai\brute_jumppack", Weight = 5, Faction = Faction.Covenant},
                new RandomizedObjectDetails{FancyName = "Brute Jumppack Major", Name = "brute_jumppack_major",  Path =  @"objects\characters\brute\ai\brute_jumppack_major", Weight = 5, Faction = Faction.Covenant},
                new RandomizedObjectDetails{FancyName = "Brute Jumppack Ultra", Name = "brute_jumppack_ultra",  Path =  @"objects\characters\brute\ai\brute_jumppack_ultra", Weight = 5, Faction = Faction.Covenant},
                new RandomizedObjectDetails{FancyName = "Brute Stalker", Name = "brute_stalker",  Path =  @"objects\characters\brute\ai\brute_stalker", Weight = 5, Faction = Faction.Covenant},
                new RandomizedObjectDetails{FancyName = "Brute Pilot No Bomb", Name = "brute_pilot_no_bomb", Path =  @"objects\characters\brute\ai\brute_pilot_no_bomb", Weight = 5, Faction = Faction.Covenant},
                new RandomizedObjectDetails{FancyName = "Brute Tracker", Name = "brute_tracker", Path =  @"objects\characters\brute\ai\brute_tracker", Weight = 10, Faction = Faction.Covenant},
                
                new RandomizedObjectDetails{FancyName = "Grunt Minor", Name = "grunt", Path = @"objects\characters\grunt\ai\grunt", Faction = Faction.Covenant},
                new RandomizedObjectDetails{FancyName = "Grunt Major", Name = "grunt_major", Path =   @"objects\characters\grunt\ai\grunt_major", Faction = Faction.Covenant},
                new RandomizedObjectDetails{FancyName = "Grunt Ultra", Name = "grunt_ultra", Path = @"objects\characters\grunt\ai\grunt_ultra", Faction = Faction.Covenant},
                new RandomizedObjectDetails{FancyName = "Grunt Heavy", Name = "grunt_heavy", Path =   @"objects\characters\grunt\ai\grunt_heavy", Faction = Faction.Covenant},
                new RandomizedObjectDetails{FancyName = "Grunt Specops", Name = "grunt_specops", Path =  @"objects\characters\grunt\ai\grunt_specops", Weight = 5, Faction = Faction.Covenant},

                new RandomizedObjectDetails{FancyName = "Jackal Sniper", Name = "jackal_sniper", Path =  @"objects\characters\jackal\ai\jackal_sniper", Faction = Faction.Covenant},
                new RandomizedObjectDetails{FancyName = "Jackal Sniper Far", Name = "jackal_sniper_far", Path =  @"objects\characters\jackal\ai\jackal_sniper_far", Weight = 5, Faction = Faction.Covenant},

                new RandomizedObjectDetails{FancyName = "Jackal", Name = "jackal", Path =   @"objects\characters\jackal\ai\jackal", Faction = Faction.Covenant},
                new RandomizedObjectDetails{FancyName = "Jackal Major", Name = "jackal_major", Path =   @"objects\characters\jackal\ai\jackal_major", Faction = Faction.Covenant},
                
                new RandomizedObjectDetails{FancyName = "Hunter", Name = "hunter", Path =   @"objects\characters\hunter\ai\hunter", Weight = 3, Faction = Faction.Covenant},
                new RandomizedObjectDetails{FancyName = "Hunter Classic", Name = "hunter_classic", Path =  @"objects\characters\hunter\ai\hunter_classic", Weight = 5, Faction = Faction.Covenant},
                new RandomizedObjectDetails{FancyName = "Hunter Shielded", Name = "hunter_shielded", Path =  @"objects\characters\hunter\ai\hunter_shielded", Weight = 5, Faction = Faction.Covenant},

                new RandomizedObjectDetails{FancyName = "Drone", Name = "bugger",  Path =  @"objects\characters\bugger\ai\bugger", Faction = Faction.Covenant},
                new RandomizedObjectDetails{FancyName = "Drone Major", Name = "bugger_major",  Path =  @"objects\characters\bugger\ai\bugger_major", Faction = Faction.Covenant},
                new RandomizedObjectDetails{FancyName = "Drone Ultra", Name = "bugger_ultra",  Path =  @"objects\characters\bugger\ai\bugger_ultra", Faction = Faction.Covenant},
                new RandomizedObjectDetails{FancyName = "Drone Captain", Name = "bugger_captain",  Path =  @"objects\characters\bugger\ai\bugger_captain", Faction = Faction.Covenant},
                new RandomizedObjectDetails{FancyName = "Drone Captain Major", Name = "bugger_captain_major",  Path =  @"objects\characters\bugger\ai\bugger_captain_major", Faction = Faction.Covenant},
                new RandomizedObjectDetails{FancyName = "Drone Pupa", Name = "bugger_pupa",  Path =  @"objects\characters\bugger\ai\bugger_pupa", Faction = Faction.Covenant},

                new RandomizedObjectDetails{FancyName = "Engineer", Name = "engineer", Path =  @"objects\characters\engineer\ai\engineer", Weight = 5, Faction = Faction.Covenant},
                //new RandomizedObjectDetails{FancyName = "Engineer Freeform", Name = "engineer_freeform", Path =  @"objects\characters\engineer\ai\engineer_freeform", Weight = 5, Faction = Faction.Covenant},
                new RandomizedObjectDetails{FancyName = "Engineer Slaveform", Name = "engineer_slaveform", Path =  @"objects\characters\engineer\ai\engineer_slaveform", Weight = 5, Faction = Faction.Covenant},
                //new RandomizedObjectDetails{FancyName = "Engineer Slaveform Cin", Name = "engineer_slaveform_cin", Path =  @"objects\characters\engineer\ai\engineer_slaveform_cin", Weight = 5, Faction = Faction.Covenant},

                new RandomizedObjectDetails{FancyName = "Elite Minor", Name = "elite", Path = @"objects\characters\elite\ai\elite", Weight = 5, Faction = Faction.Elite},
                new RandomizedObjectDetails{FancyName = "Elite Major", Name = "elite_major", Path =   @"objects\characters\elite\ai\elite_major", Weight = 5, Faction = Faction.Elite},
                new RandomizedObjectDetails{FancyName = "Elite Specops", Name = "elite_specops",  Path =  @"objects\characters\elite\ai\elite_specops", Weight = 5, Faction = Faction.Elite},
                new RandomizedObjectDetails{FancyName = "Elite Specops Commander", Name = "elite_specops_commander", Path =   @"objects\characters\elite\ai\elite_specops_commander", Weight = 5, Faction = Faction.Elite},
                
                new RandomizedObjectDetails{FancyName = "Worker", Name = "worker", Path =   @"objects\characters\civilians\worker\ai\worker", Weight = 5, Faction = Faction.Human},
                new RandomizedObjectDetails{FancyName = "Worker Wounded", Name = "worker_wounded", Path =   @"objects\characters\civilians\worker\ai\worker_wounded", Weight = 5, Faction = Faction.Human},
                new RandomizedObjectDetails{FancyName = "Marine", Name = "marine", Path =   @"objects\characters\marine\ai\marine", Weight = 5, Faction = Faction.Human},
                new RandomizedObjectDetails{FancyName = "Marine Female", Name = "marine_female", Path =   @"objects\characters\marine\ai\marine_female", Weight = 5, Faction = Faction.Human},
                new RandomizedObjectDetails{FancyName = "Marine ODST", Name = "marine_odst", Path =   @"objects\characters\marine\ai\marine_odst", Weight = 5, Faction = Faction.Human},
                //new RandomizedObjectDetails{FancyName = "Marine ODST Seargent", Name = "marine_odst_sgt", Path =   @"objects\characters\marine\ai\marine_odst_sgt", Weight = 5, Faction = Faction.Human},
                new RandomizedObjectDetails{FancyName = "Marine Seargent", Name = "marine_sgt", Path =   @"objects\characters\marine\ai\marine_sgt", Weight = 5, Faction = Faction.Human},
                new RandomizedObjectDetails{FancyName = "Marine Pilot", Name = "marine_pilot", Path =   @"objects\characters\marine\ai\marine_pilot", Weight = 5, Faction = Faction.Human},
                new RandomizedObjectDetails{FancyName = "Marine Wounded", Name = "marine_wounded", Path =   @"objects\characters\marine\ai\marine_wounded", Weight = 5, Faction = Faction.Human},
                new RandomizedObjectDetails{FancyName = "Naval Officer", Name = "naval_officer", Path =   @"objects\characters\marine\ai\naval_officer", Weight = 5, Faction = Faction.Human},
                new RandomizedObjectDetails{FancyName = "Civilain Police Sarge Survival", Name = "civilain_police_sarge_survival", Path =  @"objects\characters\civilians\civilian_police\ai\civilain_police_sarge_survival", Weight = 5, Faction = Faction.Human},
                new RandomizedObjectDetails{FancyName = "Civilian Police", Name = "civilian_police", Path =  @"objects\characters\civilians\civilian_police\ai\civilian_police", Weight = 5, Faction = Faction.Human},
                //new RandomizedObjectDetails{FancyName = "Civilian Police (Data Hive)", Name = "civilian_police_l200", Path =  @"objects\characters\civilians\civilian_police\ai\civilian_police_l200", Weight = 5, Faction = Faction.Human},
                new RandomizedObjectDetails{FancyName = "Civilian Police Sarge", Name = "civilian_police_sarge", Path =  @"objects\characters\civilians\civilian_police\ai\civilian_police_sarge", Weight = 5, Faction = Faction.Human},
                new RandomizedObjectDetails{FancyName = "Civilian Police Survival", Name = "civilian_police_survival", Path =  @"objects\characters\civilians\civilian_police\ai\civilian_police_survival", Weight = 5, Faction = Faction.Human},

                new RandomizedObjectDetails{FancyName = "Flood Infection", Name = "flood_infection", Path =   @"objects\characters\flood_infection\ai\flood_infection", Weight = 0, Faction = Faction.Flood, SubCategory = SubCategory.Creature},
                new RandomizedObjectDetails{FancyName = "Flood Pure Form Ranged", Name = "flood_pureform_ranged", Path =   @"objects\characters\flood_ranged\ai\flood_pureform_ranged", Weight = 3, Faction = Faction.Flood},
                new RandomizedObjectDetails{FancyName = "Flood Pure Form Stalker", Name = "flood_pureform_stalker", Path =   @"objects\characters\flood_stalker\ai\flood_pureform_stalker", Weight = 3, Faction = Faction.Flood},
                new RandomizedObjectDetails{FancyName = "Flood Pure Form Tank", Name = "flood_pureform_tank", Path =   @"objects\characters\flood_tank\ai\flood_pureform_tank", Weight = 3, Faction = Faction.Flood},
                new RandomizedObjectDetails{FancyName = "Flood Carrier Form", Name = "flood_carrier", Path =   @"objects\characters\floodcarrier\ai\flood_carrier", Weight = 5, Faction = Faction.Flood},
                new RandomizedObjectDetails{FancyName = "Flood Combat Form Brute", Name = "floodcombat_brute", Path =   @"objects\characters\floodcombat_brute\ai\floodcombat_brute", Faction = Faction.Flood},
                new RandomizedObjectDetails{FancyName = "Flood Combat Form Elite", Name = "floodcombat_elite", Path =   @"objects\characters\floodcombat_elite\ai\floodcombat_elite", Faction = Faction.Flood},
                new RandomizedObjectDetails{FancyName = "Flood Combat Form Elite (shielded)", Name = "floodcombat_elite", Path =   @"objects\characters\floodcombat_elite\ai\floodcombat_elite_shielded", Faction = Faction.Flood},
                new RandomizedObjectDetails{FancyName = "Flood Combat Form Human", Name = "flood_combat_human", Path =   @"objects\characters\floodcombat_human\ai\flood_combat_human", Faction = Faction.Flood},
                new RandomizedObjectDetails{FancyName = "Flood Combat Civilian", Name = "flood_combat_civilian", Path =  @"objects\characters\floodcombat_civilian\ai\flood_combat_civilian", Weight = 5, Faction = Faction.Flood},
                new RandomizedObjectDetails{FancyName = "Flood Combat Odst", Name = "flood_combat_odst", Path =  @"objects\characters\floodcombat_human\ai\flood_combat_odst", Weight = 5, Faction = Faction.Flood},
                new RandomizedObjectDetails{FancyName = "Floodcombat Brute Heavy", Name = "floodcombat_brute_heavy", Path =  @"objects\characters\floodcombat_brute\ai\floodcombat_brute_heavy", Weight = 5, Faction = Faction.Flood},
                new RandomizedObjectDetails{FancyName = "Floodcombat Brute Stealth", Name = "floodcombat_brute_stealth", Path =  @"objects\characters\floodcombat_brute\ai\floodcombat_brute_stealth", Weight = 5, Faction = Faction.Flood},

                new RandomizedObjectDetails{FancyName = "Sentinel Aggressor", Name = "sentinel_aggressor", Path =   @"objects\characters\sentinel_aggressor\ai\sentinel_aggressor", Faction = Faction.Forerunner},
                new RandomizedObjectDetails{FancyName = "Sentinel Aggressor Major", Name = "sentinel_aggressor_major", Path =   @"objects\characters\sentinel_aggressor\ai\sentinel_aggressor_major", Faction = Faction.Forerunner},
                new RandomizedObjectDetails{FancyName = "Sentinel Aggressor Captian", Name = "sentinel_aggressor_captain", Path =   @"objects\characters\sentinel_aggressor\ai\sentinel_aggressor_captain", Faction = Faction.Forerunner},
                
                //new RandomizedObjectDetails{Name = "truth", Path = @"objects\characters\truth\ai\truth", Weight = 0, Faction = Faction.Covenant},
                //new RandomizedObjectDetails{Name = "miranda", Path = @"objects\characters\miranda\ai\miranda", Weight = 0, Faction = Faction.Human},
                //new RandomizedObjectDetails{FancyName = "343 Guilty Spark", Name = "monitor", Path = @"objects\characters\monitor\ai\monitor", Weight = 0, Faction = Faction.Forerunner, Editable  = false},
            }
        };
    }
}
