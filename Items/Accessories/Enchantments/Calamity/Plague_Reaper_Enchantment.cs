﻿using Terraria;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using Terraria.ID;

namespace SoulsBetterDLC.Items.Accessories.Enchantments.Calamity
{
    [JITWhenModsEnabled("CalamityMod")]
    public class Plague_Reaper_Enchantment: BaseDLCEnchant
    {
        public override string ModName => "CalamityMod";
        public override string wizardEffect => "";
        protected override Color nameColor => new Color(118, 146, 147);
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Plague Reaper Enchantment");
            Tooltip.SetDefault("If you hit an enemy that hass less than or 60000 max HP,\nyour first attack has a 50% chance to instantly kill them.\nAlso applies to bosses.\n'May your foes be many, and their days few!'");
        }
        public override void SetDefaults() 
        {
            base.SetDefaults();
            /*if (ModLoader.TryGetMod("CalamityMod", out Mod mod))
                Item.rare = ModContent.RarityType<CalamityMod.Rarities.Turquoise>();
            else */Item.rare = ItemRarityID.Red;
        }
        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            SoulsBetterDLCPlayer SBDPlayer = player.GetModPlayer<SoulsBetterDLCPlayer>();
            SBDPlayer.ButterBeeKill = true;
        }
        public override void SafeAddRecipes()
        {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient<CalamityMod.Items.Armor.PlagueReaper.PlagueReaperMask>(1);
            recipe.AddIngredient<CalamityMod.Items.Armor.PlagueReaper.PlagueReaperVest>(1);
            recipe.AddIngredient<CalamityMod.Items.Armor.PlagueReaper.PlagueReaperStriders>(1);
            recipe.AddIngredient<CalamityMod.Items.Weapons.Rogue.AlphaVirus>(1);
            recipe.AddIngredient<CalamityMod.Items.Weapons.Magic.NanoPurge>(1);
            recipe.AddIngredient<CalamityMod.Items.Weapons.Melee.SoulHarvester>(1);
            recipe.AddTile(TileID.LunarCraftingStation);
            recipe.Register();
        }
    }
}