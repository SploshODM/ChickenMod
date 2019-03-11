using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ChickenMod.Projectiles
{
    public class ChickenPetNPC : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Little Chicken Buddy");
        }


        public override void SetDefaults()
        {
            projectile.CloneDefaults(ProjectileID.Bunny);
            aiType = ProjectileID.Bunny;
            Main.projFrames[projectile.type] = 4;
            Main.projPet[projectile.type] = true;
        }

        public override bool PreAI()
        {
            Player player = Main.player[projectile.owner];
            player.bunny = false;
            return true;
        }

        public override void AI()
        {
            Player player = Main.player[projectile.owner];
            MyPlayer modPlayer = player.GetModPlayer<MyPlayer>(mod);
            if (player.dead)
            {
                modPlayer.ChickenPetBuff = false;
            }
            if (modPlayer.ChickenPetBuff)
            {
                projectile.timeLeft = 2;
            }
        }
    }
}