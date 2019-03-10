using System;
using System.Collections.Generic;
using System.IO;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.GameInput;

namespace ChickenMod
{
    //public class MyPlayer : ModPlayer
    //{
        //public bool customdebuff = false;

        //public override void ResetEffects()
        //{
        //    customdebuff = false;
        //}

        //public override void UpdateBadLifeRegen()
        //{
        //    if (customdebuff)  // make sure you add the right bool
        //    {
        //        player.lifeRegen -= 30; //this make so the player take damage, the highter is the value the more life losing.
        //    }
        //}
    public class MyPlayer : ModPlayer
    {
        public bool EggYolk = false;

        public override void ResetEffects()
        {
            EggYolk = false;
        }

        public override void UpdateDead()
        {
            EggYolk = false;
        }
    }


    //public override void DrawEffects(PlayerDrawInfo drawInfo, ref float r, ref float g, ref float b, ref float a, ref bool fullBright)
    //{
    //    if (CustomDebuff)
    //    {
    //        if (Main.rand.Next(4) == 0 && drawInfo.shadow == 0f)
    //        {
    //            int dust = Dust.NewDust(drawInfo.position - new Vector2(2f, 2f), player.width + 4, player.height + 4, mod.DustType("EtherealFlame"), player.velocity.X * 0.4f, player.velocity.Y * 0.4f, 100, default(Color), 3f);
    //            Main.dust[dust].noGravity = true;
    //            Main.dust[dust].velocity *= 1.8f;
    //            Main.dust[dust].velocity.Y -= 0.5f;
    //            Main.playerDrawDust.Add(dust);
    //        }
    //        r *= 0.1f;
    //        g *= 0.2f;
    //        b *= 0.7f;
    //        fullBright = true;
    //    }
    //}
}
