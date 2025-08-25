using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ODSTVisualRandomizer1.RandomizedItems
{
    public partial class RandomizedItems
    {
        public class SquadSpecialCase
        {
            public List<string> SquadNames { get; set; } = new List<string>();
            public bool Skip { get; set; } = false;
            public bool RandomizeCharacters { get; set; } = true;
            public bool RandomizeWeapons { get; set; } = true;
            public bool RandomizeVehicles { get; set; } = true;
            public bool RandomizeEquipment { get; set; } = true;
            public List<string> AllowedCharacters { get; set; } = new List<string>();
            public List<string> AllowedWeapons { get; set; } = new List<string>();
            public List<string> AllowedVehicles { get; set; } = new List<string>();
            public List<string> AllowedVehicleVariants { get; set; } = new List<string>();

        }

        public static List<SquadSpecialCase> SquadSpecialCases { get; set; } = new List<SquadSpecialCase>()
        {
            new SquadSpecialCase()
            {
                SquadNames = new List<string>()
                {

                },
                RandomizeVehicles = false,
                AllowedCharacters = {"marine", "worker", "elite"}

            },
            new SquadSpecialCase()
            {
                SquadNames=new List<string>()
                {

                },
                AllowedVehicles = new List<string>() {"warthog"},
                AllowedVehicleVariants = new List<string>() {"default", "gauss", "troop", "no_turret"},
            },
            new SquadSpecialCase()
            {
                SquadNames=new List<string>()
                {

                },
                AllowedVehicles = new List<string>() {"warthog", "warthog_snow", "hornet", "hornet_lite", "mauler", "mongoose", "mongoose_snow", "ghost", "banshee"},
                AllowedVehicleVariants = new List<string>() {"default", "gauss", "troop", "no_turret",},
            },
            new SquadSpecialCase()
            {
                SquadNames = new List<string>()
                {
                    "sq_dc_jetpack_01",

                },
                RandomizeVehicles = false,
                AllowedCharacters = {"brute_jumppack", "floodcombat", "flood_combat"}

            },
            new SquadSpecialCase()
            {
                SquadNames = new List<string>()
                {
                    "banshee01",
                    "banshee02",
                    "banshee03",
                    "banshee04",
                    "banshee05",
                    "banshee06",
                    "sq_l100_phantom_01",
                    "sq_l100_phantom_02",
                    "sq_bsp_100_04a",
                    "sq_bsp_100_04b",
                    "sq_sur_a_phantom_01",
                    "sq_sur_b_phantom_01",
                    "sq_sur_a_phantom_02",
                    "sq_sur_a_phantom_03",
                    "sq_sur_remaining",
                    "sq_sur_b_phantom_02",
                    "sq_sur_b_phantom_03",
                    "sq_amb_phantom_01",
                    "sq_bsp_080_03a",
                    "sq_sr_phantom_01",
                    "sq_sur_phantom_01",
                    "sq_sur_phantom_02",
                    "sq_sur_phantom_03",
                    "sq_sur_bonus_phantom",
                    "Training01_Phantom01",
                    "Training05_Squad04",
                    "Training02_Phantom",
                    "sq_phantom_01",
                    "sq_phantom_02",
                    "sq_pod_04_phantom_01",
                    "sq_pod_04_phantom_02",
                    "sq_pod_04_phantom_03",
                    "sq_pod_04_phantom_04",
                    "sq_sur_phantom_01",
                    "sq_sur_phantom_02",
                    "sq_sur_phantom_03",
                    "sq_sur_phantom_04",
                    "sq_sur_phantom_bonus",
                    "sq_phantom_02",
                    "sq_phantom_01",
                    "sq_phantom_03",
                    "sq_phantom_04",
                    "sq_phantom_05",
                    "sq_100_phantom_01",
                    "sq_phantom_06",
                    "sq_phantom_07",
                    "sq_sur_phantom_01",
                    "sq_sur_phantom_02",
                    "sq_sur_phantom_03",
                    "sq_sur_bonus_phantom",
                    "sq_phantom_01",
                    "sq_phantom_02",
                    "sq_phantom_03",
                    "sq_phantom_04",
                    "sq_phantom_05",
                    "sq_phantom_06",
                    "sq_phantom_07",
                    "sq_sur_phantom_01",
                    "sq_sur_phantom_02",
                    "sq_sur_phantom_03",
                    "sq_sur_phantom_04",
                    "sq_sur_b_phantom_01",
                    "sq_sur_b_phantom_02",
                    "sq_sur_b_bonus_phantom",
                    "sq_sur_a_bonus_phantom",
                    "end_phantom01",
                    "end_phantom02",
                    "end_phantom06",
                    "2a_phantom01",
                    "1b_phantom",
                    "ambient_phantom01",
                    "1a_phantom01",
                    "end_phantom03",
                    "end_phantom04",
                    "end_phantom05",
                    "sq_sur_phantom_01",
                    "sq_sur_phantom_02",
                    "end_phantom02_5",
                    "end_phantom03_5",
                    "end_phantom01_5",
                    "end_phantom05_5",
                    "end_phantom04_5",
                    "ambient_phantom02",
                    "end_phantom_cin",
                    "sq_sur_bonus_phantom",
                    "sq_1a_phantom_02",
                    "sq_1a_phantom_03",
                    "sq_1a_phantom_shade_01",
                    "sq_1a_phantom_04",
                    "sq_1a_mickey_phantom_01",
                    "sq_1b_phantom_01",
                    "sq_1b_phantom_02",
                    "sq_1b_phantom_03",
                    "sq_1b_mickey_phantom_01",
                    "sq_2a_mickey_phantom_01",
                    "sq_2b_mickey_phantom_01",
                    "sq_2a_phantom_01",
                    "sq_2a_phantom_02",
                    "sq_2a_phantom_03",
                    "sq_2a_phantom_04",
                    "sq_2b_phantom_01",
                    "sq_2b_phantom_02",
                    "sq_2b_phantom_03",
                    "sq_2b_phantom_04",
                    "sq_1b_phantom_leaving_01",
                    "sq_dc_phantom_01_right",
                    "sq_dc_phantom_01_left",
                    "sq_dc_phantom_01_center",
                    "sq_dc_phantom_01_leaving",
                    "odst_phantom",
                    "cell9_phantom_squad01",
                    "cell_13_phantom_1",
                    "cell_13_phantom_2",
                    "cell_13_phantom_3",
                    "cell9_phantom_squad02",
                    "cell9_phantom_squad03",
                    "cell9_phantom_squad04",
                    "cell8_phantom_squad01",
                    "sq_sur_phantom_01",
                    "sq_sur_phantom_02",
                    "sq_sur_phantom_03",
                    "sq_sur_bonus_phantom",
                    "cell4_phantom01",
                    "cell4_phantom02",
                    "cell5_phantom01",
                    "cell5_phantom02",
                    "cell5_phantom03",
                    "cell6_phantom01",
                    "cell6_phantom02",
                    "cell6_phantom03",
                    "intro_phantom",
                },
                //RandomizeCharacters = false,
                RandomizeVehicles = false,
            },
            new SquadSpecialCase()
            {
                SquadNames = new List<string>()
                {

                },
                AllowedVehicles = new List<string>() {"wraith",},
            },
            //Must be able to be dropped by phantom
            new SquadSpecialCase()
            {
                SquadNames = new List<string>()
                {
                    "sq_l100_cov_01",
                    "sq_l100_cov_02",
                    "sq_l100_cov_03",
                    "sq_l100_cov_04",
                    "sq_phantom_01_cov_01",
                    "sq_phantom_01_cov_02",
                    "sq_phantom_01_jackal_01",
                    "sq_phantom_01_jackal_02",
                    "sq_phantom_02_cov_01",
                    "sq_phantom_02_jackal_01",
                    "sq_phantom_01_brute_01",
                    "sq_phantom_01_cov_01",
                    "sq_phantom_03_brute",
                    "sq_phantom_03_grunt",
                    "sq_phantom_03_jackal_sniper_01",
                    "sq_phantom_03_jackal_sniper_02",
                    "sq_phantom_04_cov_01",
                    "sq_phantom_04_jackal_01",
                    "sq_phantom_04_cov_02",
                    "sq_phantom_04_jackal_02",
                    "sq_phantom_06_cov_01",
                    "sq_phantom_06_cov_02",
                    "sq_phantom_06_jackal_sniper_01",
                    "sq_phantom_06_jackal_small",
                    "sq_phantom_06_jackal_large",
                    "sq_phantom_06_grunt",
                    "sq_phantom_07_cov_01",
                    "sq_phantom_07_cov_02",
                    "sq_phantom_07_jackal_sniper_01",
                    "sq_phantom_07_jackal_small",
                    "sq_phantom_07_jackal_large",
                    "sq_phantom_07_grunt",
                    "sq_phantom_cov_01",
                    "sq_phantom_cov_02",
                    "sq_phantom_cov_03",
                    "sq_phantom_02_hunter_01",
                    "sq_phantom_02_hunter_02",
                    "sq_phantom_02_jackal_01",
                    "sq_phantom_02_cov_01",
                    "sq_phantom_02_cov_02",
                    "sq_phantom_03_cov_01",
                    "sq_phantom_03_cov_02",
                    "sq_phantom_03_cov_03",
                    "sq_phantom_03_cov_04",
                    "sq_phantom_03_cov_05",
                    "sq_phantom_03_cov_06",
                    "sq_phantom_04_cov_01",
                    "sq_phantom_04_cov_02",
                    "sq_phantom_04_cov_03",
                    "sq_phantom_04_cov_04",
                    "sq_phantom_04_cov_05",
                    "sq_phantom_05_cov_01",
                    "sq_phantom_05_cov_02",
                    "sq_phantom_05_cov_03",
                    "sq_phantom_05_cov_04",
                    "sq_phantom_05_jackal_01",
                    "sq_phantom_05_jackal_02",
                    "sq_phantom_06_cov_01",
                    "sq_phantom_06_brute_01",
                    "sq_phantom_06_jackal_01",
                    "sq_phantom_06_brute_02",
                    "sq_phantom_07_jackal_01",
                    "sq_phantom_07_jackal_02",
                    "sq_phantom_07_grunt_01",
                    "sq_phantom_07_grunt_02",
                    "Wave06_Infantry01",
                    "Wave06_Infantry02",
                    "Wave02_Infantry01",
                    "Wave02_Infantry02",
                    "Wave04_Infantry01",
                    "chieftain",
                    "Wave06_Infantry03",
                    "Wave06_Infantry04",
                    "Wave02_Infantry03",
                    "Wave02_Infantry04",
                    "Wave04_Infantry02",
                    "Wave04_Infantry03",
                    "Wave04_Infantry04",
                    "Wave04_Infantry05",
                    "Wave04_Infantry06",
                    "sq_1a_grunt_01",
                    "sq_1a_brute_02",
                    "sq_1a_grunt_02",
                    "sq_1b_grunts_01",
                    "sq_dc_brute_jk_01",
                    "cell_13_squad_1a",
                    "cell_13_squad_1b",
                    "cell_13_squad_1c",
                    "cell_13_squad_2a",
                    "cell_13_squad_2b",
                    "cell_13_squad_3a",
                    "cell_13_squad_3b",
                    "cell_13_squad_3c",
                    "cell_13_squad_3d",
                    "cell_13_hunter_a",
                    "cell_13_hunter_b",
                    "cell_13_jetpack_a",
                    "cell_13_jetpack_b",
                    "cell_13_squad_1d",
                    "cell_13_squad_2c",
                    "cell_13_remaining",
                },
                RandomizeVehicles = false,
                AllowedCharacters = {"grunt", "jackal", "brute", "bugger", "elite"}
            },
            //must be able to walk to player reliably in the oni alpha site interior
            new SquadSpecialCase()
            {
                SquadNames = new List<string>()
                {
                    "sq_lobby_jackal_01",
                    "sq_lobby_jackal_sniper_01",
                    "sq_lobby_jackal_sniper_02",
                    "sq_lobby_jackal_sniper_03",
                    "sq_lobby_jackal_sniper_04",
                    "sq_lobby_jackal_02",
                    "sq_lobby_cov_01",
                    "sq_lobby_cov_02",
                    "sq_lobby_cov_03",
                    "sq_lobby_cov_04",
                    "sq_lobby_cov_05",
                    "sq_lobby_cov_06",
                    "sq_breach_grunt_3_left_start",
                    "sq_breach_grunt_2_left_start2",
                    "sq_breach_grunt_2_left_01",
                    "sq_breach_grunt_2_left_02",
                    "sq_breach_grunt_2_left_03",
                    "sq_breach_jackal_left",
                    "sq_breach_cov_left",
                    "sq_breach_brute_left",
                    "sq_breach_grunt_3_right_start",
                    "sq_breach_grunt_3_right_start",
                    "sq_breach_grunt_2_right_01",
                    "sq_breach_grunt_2_right_02",
                    "sq_breach_grunt_2_right_03",
                    "sq_breach_jackal_right",
                    "sq_breach_cov_right",
                    "sq_breach_brute_right",
                },
                RandomizeVehicles = false,
                AllowedCharacters = {"grunt", "jackal", "brute", "elite", "flood", "hunter", "marine", "worker", "civilian", "naval"}
            },
            //Never Randomize
            new SquadSpecialCase()
            {
                SquadNames = new List<string>()
                {
                    "sq_bridge_cop_01",
                    "sq_olifaunt",
                    "sq_1a_phantom_01",
                    "sq_engineer",
                },
                Skip = true
            }
        };

    }
}
