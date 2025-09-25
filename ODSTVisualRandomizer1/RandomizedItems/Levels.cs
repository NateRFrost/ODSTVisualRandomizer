using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ODSTVisualRandomizer1.RandomizedItems
{
    public partial class RandomizedItems
    {
        public class Level
        {
            public string Name { get; set; }
            public string FancyName { get; set; } = "";
            public bool CutsceneOnly { get; set; } = false;
            public bool Randomize { get; set; } = true;
            public bool HasAiResources { get; set; } = false;
        }

        public static List<Level> Levels = new List<Level>()
        {
            new Level{Name = "c100", FancyName = "Prepare To Drop", CutsceneOnly = true},
            new Level{Name = "h100", FancyName = "Mombasa Streets"},
            new Level{Name = "sc100", FancyName = "Tayari Plaza"},
            new Level{Name = "sc110", FancyName = "Uplift Reserve", },
            new Level{Name = "sc120", FancyName = "Kizingo Blvd."},
            new Level{Name = "sc130", FancyName = "ONI Alpha Site"},
            new Level{Name = "sc140", FancyName = "NMPD HQ"},
            new Level{Name = "sc150", FancyName = "Kikowan Stn."},
            new Level{Name = "l200", FancyName = "Data Hive"},
            new Level{Name = "l300", FancyName = "Coastal Highway"},
            new Level{Name = "c200", FancyName = "Epilogue", CutsceneOnly = true },
        };
    }
}
