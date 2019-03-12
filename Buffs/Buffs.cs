using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using ChickenMod.NPCs;

namespace ChickenMod.Buffs
{
    public class EggYolk : ModBuff
    {
        public override void SetDefaults()
        {
            DisplayName.SetDefault("Yolky Mess");
            Description.SetDefault("Ewwww, it's so gooey");
            Main.buffNoTimeDisplay[Type] = true;
            Main.buffNoSave[Type] = true;
            Main.debuff[Type] = true;
            this.canBeCleared = false;
            longerExpertDebuff = false;
        }

        public override void Update(Player player, ref int buffIndex)
        {
            player.GetModPlayer<MyPlayer>(mod).EggYolk = true;
        }

        public override void Update(NPC npc, ref int buffIndex)
        {
            npc.GetGlobalNPC<NPCsGLOBAL>(mod).EggYolk = true;
        }
    }

    public class ChickenPetBuff : ModBuff
    {
        public override void SetDefaults()
        {
            DisplayName.SetDefault("Friendly Chicken Buddy");
            Description.SetDefault("A nice little chicken follows you around");
            Main.buffNoTimeDisplay[Type] = true;
            Main.vanityPet[Type] = true;
        }

        public override void Update(Player player, ref int buffIndex)
        {
            player.buffTime[buffIndex] = 18000;
            player.GetModPlayer<MyPlayer>(mod).ChickenPetBuff = true;
            bool petProjectileNotSpawned = player.ownedProjectileCounts[mod.ProjectileType("ChickenPet")] <= 0;
            if (petProjectileNotSpawned && player.whoAmI == Main.myPlayer)
            {
                Projectile.NewProjectile(player.position.X + (float)(player.width / 2), player.position.Y + (float)(player.height / 2 + 10), 0f, 0f, mod.ProjectileType("PetName"), 0, 0f, player.whoAmI, 0f, 0f);
            }
        }
    }
}
 