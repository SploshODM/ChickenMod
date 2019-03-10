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

namespace ChickenMod.NPCs
{
    public class NPCsGLOBAL : GlobalNPC
    {
        public bool EggYolk = false;

        public override bool InstancePerEntity
        {
            get
            {
                return true;
            }
        }

        public override void ResetEffects(NPC npc)
        {
            EggYolk = false;
        }

        public override void DrawEffects(NPC npc, ref Color drawColor)
        {
            if (EggYolk)
            {
                if (Main.rand.Next(4) < 3)
                {
                    int dust = Dust.NewDust(npc.position - new Vector2(2f, 2f), npc.width + 4, npc.height + 4, 88, npc.velocity.X, npc.velocity.Y * 2.631578f, 184, new Color(229, 203, 71), 1.184211f);
                    Main.dust[dust].noGravity = true;
                    Main.dust[dust].velocity *= 1f;
                    Main.dust[dust].velocity.Y -= 0.0f;
                    if (Main.rand.Next(4) == 0)
                    {
                        Main.dust[dust].noGravity = false;
                        Main.dust[dust].scale *= 0.5f;
                    }
                }
            }
        }
    }
}
