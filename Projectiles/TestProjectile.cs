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
            projectile.damage = 1;                  //Damage recognised? Maybe damage=ZERO causing null interaction
            projectile.width = 7;
            projectile.height = 7;
        }

        public override void OnHitNPC(NPC target, int damage, float knockback, bool crit)
        {
            
            target.AddBuff(mod.BuffType("EggYolk"), 600);
        }

        /*        public override void AI()
        {
            Dust.NewDust(projectile.position + projectile.velocity, projectile.width, projectile.height, 127, projectile.velocity.X * -0.2f, projectile.velocity.Y * -0.2f);
        }
        */ //Need to add dust for when egg breaks on ground/NPC
    }
}