using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ChickenMod.Items
{
    ///*
	public class ChiItemEgg : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Chicken Egg");
			Tooltip.SetDefault("Hmm, this looks like it would be fun to throw at the Guide");
		}
        public override void SetDefaults()
        {
            item.CloneDefaults(ItemID.RottenEgg);   //Copies the properties of another item
            item.consumable = true;
            item.damage = 1;
            item.height = 7;
            item.maxStack = 12;
            item.noMelee = true;
            item.noUseGraphic = true;
            item.shoot = mod.ProjectileType("ChiProEgg");           //Now shoots custom projectile
            item.shootSpeed = 9f;                                   //Projectile Speed
            item.useAnimation = 19;
            item.useStyle = 1;
            item.UseSound = SoundID.Item19;
            item.useTime = 19;
            item.value = 50;
            item.width = 7;
            item.thrown = true;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.SetResult(this);
            recipe.AddRecipe();
        } //Remove recipe as this is a drop from ChickenNPC
	} //End of Item
    //*/ //"ChickenEgg", throwing item

    public class ChiItemRaw : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Chicken");
			Tooltip.SetDefault("Eat to restore health");
		}

        public override void SetDefaults()
        {
            item.consumable = true;
            item.healLife = 10;
            item.height = 18;
            item.material = true;
            item.maxStack = 99;
            item.noMelee = true;
            item.potion = true;
            item.useAnimation = 17;
            item.useStyle = 2;
            item.UseSound = SoundID.Item2;
            item.useTime = 17;
            item.value = 100;
            item.width = 18;
        }
	} //"ChickenRaw", uncooked food item
    //Finished

    public class ChiItemCooked : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Cooked Chicken");
			Tooltip.SetDefault("Eat to restore health\n" + "This looks much tastier");
		}
        public override void SetDefaults()
        {
            item.consumable = true;
            item.healLife = 60;
            item.height = 18;
            item.maxStack = 99;
            item.noMelee = true;
            item.potion = true;
            item.useAnimation = 17;
            item.useStyle = 2;
            item.UseSound = SoundID.Item2;
            item.useTime = 17;
            item.value = 150;
            item.width = 18;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod.ItemType("ChickenRaw"), 1);
            recipe.AddTile(TileID.Campfire);
            recipe.SetResult(this);
            recipe.AddRecipe();

            recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod.ItemType("ChickenRaw"), 1);
            recipe.AddTile(17);
            recipe.SetResult(this);
            recipe.AddRecipe();
        } 
    }  //"ChickenCooked", cooked food item

    public class ChiItemGoldEgg : ModItem
    {
        public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Golden Egg");
			Tooltip.SetDefault("Summons a friendly chicken to follow you");
		}

        public override void SetDefaults()
        {
            item.CloneDefaults(ItemID.ZephyrFish);
            item.shoot = mod.ProjectileType("ChickenPetNPC");
            item.buffType = mod.BuffType("ChickenPetBuff");
        }
 
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
 
        public override void UseStyle(Player player)
        {
            if (player.whoAmI == Main.myPlayer && player.itemTime == 0)
            {
                player.AddBuff(item.buffType, 3600, true);
            }
        }
    } //"ChickenGoldEgg", Pet summon item
}
