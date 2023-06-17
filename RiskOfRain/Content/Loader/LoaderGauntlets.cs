using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria.ModLoader;
using Terraria;
using Terraria.GameContent.Creative;
using Terraria.ID;

namespace RiskOfRain.Content.Loader {
    internal class LoaderGauntlets : ModItem {
        public override void SetStaticDefaults() {
            DisplayName.SetDefault("Loader's Gauntlets");
            Tooltip.SetDefault("Punch with the force of a loader!\nHeals on hit.");
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
        }
        public override void SetDefaults() {
            Item.width = 1;
            Item.height = 1;
            Item.value = Item.buyPrice(gold: 5);
            Item.maxStack = 1;
            Item.useStyle = ItemUseStyleID.Thrust;
            Item.useTime = 30;
            Item.useAnimation = 30;
            Item.autoReuse = true;

            Item.DamageType = DamageClass.Melee;
            Item.damage = 80;
            Item.knockBack = 1f;
            Item.crit = 0;
            Item.rare = ItemRarityID.Master;
        }

        public override void AddRecipes() {
            CreateRecipe()
                .AddRecipeGroup(RecipeGroupID.IronBar)
                .AddIngredient(ItemID.Cog)
                .AddTile(TileID.MythrilAnvil)
                .Register();
        }
    }
}
