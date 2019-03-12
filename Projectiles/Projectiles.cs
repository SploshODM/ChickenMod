using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ChickenMod.Projectiles
{
    public class ChiProEgg : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Chicken Egg");
        }

        public override void SetDefaults()
        {
            projectile.CloneDefaults(ProjectileID.RottenEgg);
            aiType = ProjectileID.RottenEgg;
            projectile.damage = 1;
            projectile.width = 7;
            projectile.height = 7;
        }

        public override void OnHitNPC(NPC target, int damage, float knockback, bool crit)
        {
            target.AddBuff(mod.BuffType("EggYolk"), 600);
        }

        public override bool OnTileCollide(Vector2 oldVelocity)
        {
            projectile.Kill();
            return false;
        }

        public override void Kill(int timeLeft)
        {
            Collision.HitTiles(projectile.position + projectile.velocity, projectile.velocity, projectile.width, projectile.height);
            Main.PlaySound(SoundID.Item10, projectile.position);
        }

    }

    public class ChickenPetNPC : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Little Chicken Buddy");
        }


        public override void SetDefaults()
        {
            projectile.CloneDefaults(ProjectileID.Penguin);
            aiType = ProjectileID.Bunny;
            Main.projFrames[projectile.type] = 18;
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