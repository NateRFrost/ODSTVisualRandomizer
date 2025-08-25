﻿using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using static ODSTVisualRandomizer1.RandomizedItems.RandomizedItems;

namespace ODSTVisualRandomizer1
{
    public class RandomizerSettings
    {
        public int Seed { get; private set; } = 0;
        private string _SeedString = "";
        public string SeedString
        {
            get
            {
                return _SeedString;
            }
            set
            {
                _SeedString = value;
                foreach (char c in _SeedString)
                {
                    Seed += c;
                }
            }
        }
        public string EkPath { get; set; } = @"C:\Program Files (x86)\Steam\steamapps\common\H3ODSTEK";
        public string MCCPath { get; set; } = @"C:\Program Files (x86)\Steam\steamapps\common\Halo The Master Chief Collection";


        public bool RandomizeCutscenes { get; set; } = true;
        public bool RandomizeWeapons { get; set; } = true;
        public bool RandomizeEquipments { get; set; } = true;
        public bool RandomizeVehicles { get; set; } = true;
        public bool RandomizeEnvironmentalObjects { get; set; } = true;
        public bool RandomizeWeaponStashTypes { get; set; } = false;

        public bool RandomizeStartingProfiles { get; set; } = true;
        public bool RandomizeSquads { get; set; } = true;
        public bool RandomizeSquadCharacters { get; set; } = true;
        public bool RandomizeSquadWeapons { get; set; } = true;
        public bool RandomizeSquadVehicles { get; set; } = true;
        public float GiveVehicleChance { get; set; } = 0.02f;
        public float MakeHunterChance { get; set; } = 0.01f;
        public float SquadSizeMultiplier { get; set; } = 1.00f;

        //public bool SquadCharactersFactionUnchanged { get; set; } = true;
        //public bool SquadWeaponsFactionUnchanged { get; set; } = true;
        //public bool SquadVehiclesFactionUnchanged { get; set; } = true;

        public class FactionCompatability
        {
            public Faction Faction { get; set; }
            public List<Faction> CompatibleFactions { get; set; }

            public void AddCompatibleFaction(Faction faction)
            {
                if (!CompatibleFactions.Contains(faction))
                {
                    CompatibleFactions.Add(faction);
                }
            }

            public void RemoveCompatibleFaction(Faction faction)
            {
                if (CompatibleFactions.Contains(faction))
                {
                    CompatibleFactions.Remove(faction);
                }
            }

            public void RemoveAllCompatibleFactions()
            {
                if (CompatibleFactions.Count > 0)
                {
                    CompatibleFactions.Clear();
                }
            }


        }

        public static FactionCompatability HumanCompatability = new FactionCompatability() { Faction = Faction.Human, CompatibleFactions = new List<Faction>() { Faction.Human, Faction.Covenant, Faction.Elite, Faction.Flood, Faction.Forerunner } };
        public static FactionCompatability CovenantCompatability = new FactionCompatability() { Faction = Faction.Covenant, CompatibleFactions = new List<Faction>() { Faction.Human, Faction.Covenant, Faction.Elite, Faction.Flood, Faction.Forerunner } };
        public static FactionCompatability EliteCompatability = new FactionCompatability() { Faction = Faction.Elite, CompatibleFactions = new List<Faction>() { Faction.Human, Faction.Covenant, Faction.Elite, Faction.Flood, Faction.Forerunner } };
        public static FactionCompatability FloodCompatability = new FactionCompatability() { Faction = Faction.Flood, CompatibleFactions = new List<Faction>() { Faction.Human, Faction.Covenant, Faction.Elite, Faction.Flood, Faction.Forerunner } };
        public static FactionCompatability ForerunnerCompatability = new FactionCompatability() { Faction = Faction.Forerunner, CompatibleFactions = new List<Faction>() { Faction.Human, Faction.Covenant, Faction.Elite, Faction.Flood, Faction.Forerunner } };
        public List<FactionCompatability> FactionCompatabilities { get; set; } = new List<FactionCompatability>()
        {
            HumanCompatability,CovenantCompatability, EliteCompatability, FloodCompatability,ForerunnerCompatability
        };
    }

}