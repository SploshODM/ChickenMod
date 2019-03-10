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
			Tooltip.SetDefault("Fe Fi Fo Fum, did this just come from that chickens...");
		}

        public override void SetDefaults()
        {
            item.CloneDefaults(ItemID.RottenEgg);   //Copies the properties of another item
            item.damage = 1;
            item.height = 7;
            item.width = 7;
            /*
            item.accessory = false;
            item.ammo = AmmoID.None;
            item.autoReuse = false;
            item.bait = 0; 
            item.buffTime = 0;
            item.bufftype = 0;
            item.channel = true;
            item.CloneDefaults(ItemID.<ItemName>)
            item.consumable = false;
            item.createTile = -1;
            item.createWall = -1;
            item.crit = 0;
            item.damage = -1;
            item.defense = 0;
            item.expert = false;
            item.fishingPole = 0;
            item.healLife = 0;
            item.healMana = 0;
            item.height = 0;
            item.holdStyle = 0;
            item.knockBack = 0f;
            item.mana = 0;
            item.material = false;
            item.maxStack = 1;
            item.mech = false;
            item.noMelee = false;
            item.noUseGraphic = false;
            item.notAmmo = false;
            item.placeStyle = 0;
            item.potion = false;
            item.questItem = false;
            item.rare = 0;
            item.reuseDelay = 0;
            item.scale = 1f;
            item.shoot = 0;
            item.shootSpeed = 0f;
            item.useAmmo = AmmoID.None;
            item.useAnimation = 100;.
            item.useStyle = 0;
            item.UseSound = null;
            item.useTime = 100;
            item.useTurn = false;
            item.value = 0;
            item.width = 0;
            //*/
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.SetResult(this);
            recipe.AddRecipe();
        } //Remove recipe as this is a drop from ChickenNPC

    } //"ChickenGoldEgg", Pet summon item
}
