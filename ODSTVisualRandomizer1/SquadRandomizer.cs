using Bungie;
using Bungie.Tags;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Timers;
using System.Windows.Forms;
using System.Xml.Linq;
using static ODSTVisualRandomizer1.RandomizedItems.RandomizedItems;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace ODSTVisualRandomizer1
{
    public partial class Randomizer
    {
        private partial class LevelRandomizer
        {

            private class SquadRandomizer
            {
                TagElement Squad;
                Random Rand;
                RandomizerSettings Settings;

                RandomizedObjectDetails old_vehicle;
                bool HasVehicle = false;
                bool MakeHunter = false;
                bool GiveVehicle = false;
                TagFieldEnum TeamField;

                SquadSpecialCase specialCase;

                public SquadRandomizer(TagElement squad, Random rand, RandomizerSettings settings)
                {
                    Squad = squad;
                    Rand = rand;
                    Settings = settings;
                    TeamField = (TagFieldEnum)GetField(Squad, "team");
                    //squad header text contains the template name by default, so it has to be removed
                    string squad_name = Squad.ElementHeaderText.Split(' ')[0];
                    specialCase = SquadSpecialCases.Where(x => x.SquadNames.Contains(squad_name)).FirstOrDefault();
                    if (specialCase != null)
                    {
                        Debug.WriteLine("special case identified, Skip: " + specialCase.Skip + " Character: " + specialCase.RandomizeCharacters + " Vehicle: " + specialCase.RandomizeVehicles);
                    }


                    MakeHunter = rand.NextDouble() < settings.MakeHunterChance;
                    GiveVehicle = settings.RandomizeSquadVehicles && rand.NextDouble() < settings.GiveVehicleChance;
                }

                public void Randomize()
                {

                    if (specialCase != null && specialCase.Skip)
                    {
                        Debug.WriteLine("Skipping squad: " + Squad.ElementHeaderText);
                        return;
                    }
                    Debug.WriteLine("randomizing " + Squad.ElementHeaderText);
                    var cells_block = (TagFieldBlock)((TagFieldStruct)GetField(Squad, "designer")).Elements[0].Fields[0];

                    /*
                     var starting_locations_block = GetField(Squad, "spawn points");
                    foreach (TagFieldBlockElement starting_location in ((TagFieldBlock)starting_locations_block).Elements)
                    {
                        RandomizeTypes(starting_location);
                    }
                    */
                    List<int> spawn_cell_indexes = GetSpawnCellIndexes();
                    MoveTemplateCellsToDesignerCells();
                    RemoveTemplate();
                    ClearSpawnPointsOverrides();
                    ApplySpawnCellIndexes(spawn_cell_indexes);
                    foreach (TagFieldBlockElement cell in ((TagFieldBlock)cells_block).Elements)
                    {
                        var normal_diff_count_field = GetField(cell, "normal diff count");
                        ((TagFieldElementInteger)normal_diff_count_field).Data = (int)(((TagFieldElementInteger)normal_diff_count_field).Data * Settings.SquadSizeMultiplier);
                        RandomizeCellCharacters(cell);
                        RandomizeCellWeapons(cell);
                        RandomlyMakeHunter(cell);
                        RandomizeCellVehicle(cell);
                        RandomlyGiveVehicle(cell);
                    }
                }

                private void RandomizeCellCharacters(TagFieldBlockElement cell)
                {
                    TagFieldBlock characters = (TagFieldBlock)GetField(cell, "character type");
                    foreach (TagFieldBlockElement character in characters)
                    {
                        var character_field = GetField(character, "character type");
                        RandomizeCharacter(character_field);
                    }
                }

                private void RandomizeCellWeapons(TagFieldBlockElement cell)
                {
                    TagFieldBlock weapons = (TagFieldBlock)GetField(cell, "initial weapon");
                    foreach (TagFieldBlockElement weapon in weapons)
                    {
                        var weapon_field = GetField(weapon, "weapon type");
                        RandomizeWeapon(weapon_field);
                    }
                }

                private void RandomizeCellVehicle(TagFieldBlockElement cell)
                {
                    var vehicle_field = GetField(cell, "vehicle type");
                    var vehicle_variant_field = GetField(cell, "vehicle variant");
                    var normal_diff_count_field = GetField(cell, "normal diff count");
                    if (((TagFieldBlockIndex)vehicle_field).Value != -1 && (specialCase == null || specialCase.RandomizeVehicles) && Settings.RandomizeSquadVehicles)
                    {
                        HasVehicle = true;
                        var old_vehicle = vehicles.List.Where(x => x.PaletteIndex == ((TagFieldBlockIndex)vehicle_field).Value && ((TagFieldBlockIndex)vehicle_field).Value != -1).FirstOrDefault();
                        if (old_vehicle != null)
                        {
                            RandomizedObjectDetails new_vehicle;
                            new_vehicle = vehicles.GetRandomObjectWeighted(Rand, require_palette_index: true);
                            if (specialCase != null && specialCase.AllowedVehicles.Any())
                            {
                                new_vehicle = vehicles.GetRandomObjectWeighted(Rand, require_palette_index: true, name_starts_with: specialCase.AllowedVehicles);
                            }
                            else if (old_vehicle.SubCategory == SubCategory.Air)
                            {
                                new_vehicle = vehicles.GetRandomObjectWeighted(Rand, require_palette_index: true, subcategories: new List<SubCategory>() { SubCategory.Air });
                            }
                            if (new_vehicle != null)
                            {
                                ((TagFieldBlockIndex)vehicle_field).Value = new_vehicle.PaletteIndex;
                                ((TagFieldElementInteger)normal_diff_count_field).Data = (int)(new_vehicle.Seats * Settings.SquadSizeMultiplier);
                                var new_variant = new_vehicle.Variants.GetRandomObjectWeighted(Rand);
                                if (specialCase != null && specialCase.AllowedVehicleVariants.Any())
                                {
                                    new_variant = new_vehicle.Variants.GetRandomObjectWeighted(Rand, name_starts_with: specialCase.AllowedVehicleVariants);
                                }
                                if (new_variant != null)
                                {
                                    ((TagFieldElementStringID)vehicle_variant_field).Data = new_variant.Name;
                                }
                                else
                                {
                                    ((TagFieldElementStringID)vehicle_variant_field).Data = "";
                                }
                            }
                        }
                    }
                }

                private void RandomlyMakeHunter(TagFieldBlockElement cell)
                {
                    TagFieldBlock characters_block = (TagFieldBlock)GetField(cell, "character type");
                    foreach (TagFieldBlockElement character in characters_block)
                    {
                        var character_field = GetField(character, "character type");
                        var old_character = characters.GetObjectOfPaletteIndex(((TagFieldBlockIndex)character_field).Value);
                        if (old_character != null && (specialCase == null || specialCase.RandomizeCharacters) && Settings.RandomizeSquadCharacters && MakeHunter && TeamField.Value == (int)Faction.Covenant)
                        {
                            var new_character = characters.GetRandomObjectWeighted(Rand, name_starts_with: new List<string> {"hunter"});
                            ((TagFieldBlockIndex)character_field).Value = new_character.PaletteIndex;
                            TagFieldBlock weapons = (TagFieldBlock)GetField(cell, "initial weapon");
                            weapons.RemoveAllElements();
                        }
                    }
                    
                }

                private void RemoveTemplate()
                {
                    var template_index_field = GetField(((TagFieldBlockElement)Squad), "squad template index");
                    if (template_index_field != null)
                    {
                        TagFieldElementInteger tfr = (TagFieldElementInteger)template_index_field;
                        tfr.Data = -1;
                    }
                    var template_field = GetField(((TagFieldBlockElement)Squad), "template");
                    if (template_field != null)
                    {
                        TagFieldElementStringIDWithMenu tfr = (TagFieldElementStringIDWithMenu)template_field;
                        tfr.Data = "";
                    }
                }

                private void MoveTemplateCellsToDesignerCells()
                {

                    TagFieldBlock designer_cells = (TagFieldBlock)((TagFieldStruct)GetField(Squad, "designer")).Elements[0].Fields[0];
                    TagFieldBlock template_cells = (TagFieldBlock)((TagFieldStruct)GetField(Squad, "templated")).Elements[0].Fields[0]; ;
                    if (template_cells.Elements.Count > 0)
                    {
                        template_cells.CopyEntireTagBlock();
                        while (!template_cells.ClipboardContainsEntireBlock())
                        {
                            System.Threading.Thread.Sleep(50);
                        }
                        designer_cells.PasteReplaceEntireBlock();
                        template_cells.RemoveAllElements();
                    }
                }

                // Randomizes the types for a fireteam or starting location
                private void RandomizeTypes(TagFieldBlockElement element)
                {
                    var character_field = GetField(element, "character type");
                    var weapon_field = GetField(element, "initial weapon");
                    var vehicle_field = GetField(element, "vehicle type");
                    TagField seat_field;
                    TagField vehicle_variant_field;
                    TagField normal_diff_count;
                    if (FieldExists(element, "seat type"))
                    {
                        seat_field = GetField(element, "seat type");
                    }
                    else
                    {
                        seat_field = null;
                    }
                    // these have different names in fireteams and starting locations
                    if (FieldExists(element, "vehicle variant"))
                    {
                        vehicle_variant_field = GetField(element, "vehicle variant");
                    }
                    else
                    {
                        vehicle_variant_field = GetField(element, "vehicle variant name");
                    }
                    if (FieldExists(element, "normal diff count"))
                    {
                        normal_diff_count = GetField(element, "normal diff count");
                    }
                    else
                    {
                        normal_diff_count = null;
                    }
                    RandomizeCharacter(character_field);
                    RandomizeWeapon(weapon_field);
                    RandomizeSpawnpointVehicle(vehicle_field, vehicle_variant_field, normal_diff_count, seat_field, character_field);
                    //RandomlyGiveVehicle(vehicle_field, vehicle_variant_field, normal_diff_count, seat_field, character_field);
                }


                private void RandomizeCharacter(TagField character_field)
                {
                    var old_character = characters.GetObjectOfPaletteIndex(((TagFieldBlockIndex)character_field).Value);
                    if (old_character != null && (specialCase == null || specialCase.RandomizeCharacters) && Settings.RandomizeSquadCharacters)
                    {
                        var old_character_faction = old_character.Faction;
                        ((TagFieldEnum)TeamField).Value = (int)old_character_faction;
                        var new_character_factions = Settings.FactionCompatabilities.Where(x => x.Faction == old_character_faction).FirstOrDefault().CompatibleFactions;
                        RandomizedObjectDetails new_character;
                        if (specialCase != null && specialCase.AllowedCharacters.Any())
                        {
                            new_character = characters.GetRandomObjectWeighted(Rand, require_palette_index: true, factions: new_character_factions, name_starts_with: specialCase.AllowedCharacters);
                            if (new_character is null)
                            {
                                new_character = characters.GetRandomObjectWeighted(Rand, require_palette_index: true, name_starts_with: specialCase.AllowedCharacters);
                            }
                        }
                        else
                        {
                            new_character = characters.GetRandomObjectWeighted(Rand, require_palette_index: true, factions: new_character_factions);
                        }
                        ((TagFieldBlockIndex)character_field).Value = new_character.PaletteIndex;
                    }
                }

                private void RandomizeWeapon(TagField weapon_field)
                {
                    if (((TagFieldBlockIndex)weapon_field).Value != -1 && Settings.RandomizeSquadWeapons && (specialCase == null || specialCase.RandomizeWeapons))
                    {
                        ((TagFieldBlockIndex)weapon_field).Value = weapons.GetRandomObjectWeighted(Rand, require_palette_index: true).PaletteIndex;
                    }
                }

                private void RandomizeSpawnpointVehicle(TagField vehicle_field, TagField vehicle_variant_field, TagField normal_diff_count, TagField seat_field, TagField character_field)
                {
                    var old_character = characters.GetObjectOfPaletteIndex(((TagFieldBlockIndex)character_field).Value);
                    if (((TagFieldBlockIndex)vehicle_field).Value != -1 && (specialCase == null || specialCase.RandomizeVehicles) && Settings.RandomizeSquadVehicles)
                    {
                        HasVehicle = true;
                        var old_vehicle = vehicles.List.Where(x => x.PaletteIndex == ((TagFieldBlockIndex)vehicle_field).Value && ((TagFieldBlockIndex)vehicle_field).Value != -1).FirstOrDefault();
                        if (old_vehicle != null)
                        {
                            RandomizedObjectDetails new_vehicle;
                            new_vehicle = vehicles.GetRandomObjectWeighted(Rand, require_palette_index: true);
                            if (specialCase != null && specialCase.AllowedVehicles.Any())
                            {
                                new_vehicle = vehicles.GetRandomObjectWeighted(Rand, require_palette_index: true, name_starts_with: specialCase.AllowedVehicles);
                            }
                            else if (old_vehicle.SubCategory == SubCategory.Air)
                            {
                                new_vehicle = vehicles.GetRandomObjectWeighted(Rand, require_palette_index: true, subcategories: new List<SubCategory>() { SubCategory.Air });
                            }
                            if (new_vehicle != null)
                            {
                                ((TagFieldBlockIndex)vehicle_field).Value = new_vehicle.PaletteIndex;
                                if (normal_diff_count != null && old_character != null)
                                {
                                    //((TagFieldElementInteger)normal_diff_count).Data = (int)(new_vehicle.Seats * Settings.SquadSizeMultiplier);
                                }
                                var new_variant = new_vehicle.Variants.GetRandomObjectWeighted(Rand);
                                if (specialCase != null && specialCase.AllowedVehicleVariants.Any())
                                {
                                    new_variant = new_vehicle.Variants.GetRandomObjectWeighted(Rand, name_starts_with: specialCase.AllowedVehicleVariants);
                                }
                                if (new_variant != null)
                                {
                                    ((TagFieldElementStringID)vehicle_variant_field).Data = new_variant.Name;
                                }
                                else
                                {
                                    ((TagFieldElementStringID)vehicle_variant_field).Data = "";
                                }
                            }
                        }
                    }
                }

                private void RandomlyGiveVehicle(TagFieldBlockElement cell)
                {
                    var vehicle_field = GetField(cell, "vehicle type");
                    var vehicle_variant_field = GetField(cell, "vehicle variant");
                    var normal_diff_count_field = GetField(cell, "normal diff count");
                    if (GiveVehicle && old_vehicle == null)
                    {
                        var new_vehicle = vehicles.GetRandomObjectWeighted(Rand, require_palette_index: true);
                        ((TagFieldBlockIndex)vehicle_field).Value = new_vehicle.PaletteIndex;
                        if (normal_diff_count_field != null)
                        {
                            ((TagFieldElementInteger)normal_diff_count_field).Data = (int)(new_vehicle.Seats * Settings.SquadSizeMultiplier);
                            /*
                            if (seat_field != null)
                            {
                                ((TagFieldEnum)seat_field).Value = 0;
                            }
                            */
                        }
                        if (normal_diff_count_field != null)
                        {
                            ((TagFieldElementInteger)normal_diff_count_field).Data = (int)(new_vehicle.Seats * Settings.SquadSizeMultiplier);
                        }
                        var new_variant = new_vehicle.Variants.GetRandomObjectWeighted(Rand);
                        if (new_variant != null)
                        {
                            HasVehicle = true;
                            ((TagFieldBlockIndex)vehicle_field).Value = new_vehicle.PaletteIndex;
                            ((TagFieldElementStringID)vehicle_variant_field).Data = new_variant.Name;
                        }
                        else
                        {
                            ((TagFieldElementStringID)vehicle_variant_field).Data = "";
                        }
                    }
                }


                private void ClearSpawnPointsOverrides()
                {
                    var spawn_point_block = GetField(Squad, "spawn points");
                    foreach (TagFieldBlockElement spawn_point in ((TagFieldBlock)spawn_point_block).Elements)
                    {
                        var character_field = GetField(spawn_point, "character type");
                        ((TagFieldBlockIndex)character_field).Value = -1;
                        var weapon_field = GetField(spawn_point, "initial weapon");
                        ((TagFieldBlockIndex)weapon_field).Value = -1;
                        if (specialCase == null || specialCase.RandomizeVehicles)
                        {
                            var vehicle_field = GetField(spawn_point, "vehicle type");
                            if (vehicles.List.Any(x => x.PaletteIndex == ((TagFieldBlockIndex)vehicle_field).Value && ((TagFieldBlockIndex)vehicle_field).Value != -1))
                            {
                                old_vehicle = vehicles.List.Where(x => x.PaletteIndex == ((TagFieldBlockIndex)vehicle_field).Value).FirstOrDefault();
                                ((TagFieldBlockIndex)vehicle_field).Value = -1;
                            }
                            var seat_field = GetField(spawn_point, "seat type");
                            ((TagFieldEnum)seat_field).Value = 0;
                        }
                    }
                }

                private List<int> GetSpawnCellIndexes()
                {
                    List<int> cell_indexes = new List<int>();
                    var spawn_point_block = GetField(Squad, "spawn points");
                    foreach (TagFieldBlockElement spawn_point in ((TagFieldBlock)spawn_point_block).Elements)
                    {
                        var cell_field = GetField(spawn_point, "cell");
                        cell_indexes.Add(((TagFieldBlockIndex)cell_field).Value);
                    }
                    return cell_indexes;
                }

                private void ApplySpawnCellIndexes(List<int> cell_indexes)
                {
                    var spawn_point_block = GetField(Squad, "spawn points");
                    int current_index = 0;
                    foreach (TagFieldBlockElement spawn_point in ((TagFieldBlock)spawn_point_block).Elements)
                    {
                        var cell_field = GetField(spawn_point, "cell");
                        ((TagFieldBlockIndex)cell_field).Value = cell_indexes[current_index];
                        current_index++;
                    }
                }
            }
        }
    }

}
