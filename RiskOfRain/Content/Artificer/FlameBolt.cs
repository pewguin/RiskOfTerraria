using IL.Terraria;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria.ModLoader;
using Terraria;
using Terraria.ID;

namespace RiskOfRain.Content.Artificer {
    internal class FlameBolt : ModItem {
        override public void SetDefaults() {
            Item.width = 1;
            Item.height = 1;
            Item.maxStack = 1;
            Item.useStyle = ItemUseStyleID.Thrust;
            Item.useTime = 30;
            Item.useAnimation = 30;
            Item.autoReuse = true;
            Item.noMelee = true;
            Item.mana = 10;

            Item.DamageType = DamageClass.Melee;
            Item.damage = 80;
            Item.knockBack = 1f;
            Item.crit = 0;
            Item.rare = ItemRarityID.Master;
        }
    }
}
