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
                    int dust = Dust.NewDust(npc.position - new Vector2(2f, 2f), npc.width + 4, npc.height + 4, 233, npc.velocity.X, npc.velocity.Y * 2.631578f, 184, new Color(255, 225, 171), 1.184211f);
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

    public class ChiNpcChicken : ModNPC
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Chicken");
        }

        public override void SetDefaults()
        {
            npc.width = 40;
            npc.height = 40;
            npc.damage = 0;
            npc.defense = 0;
            npc.lifeMax = 5;
            npc.HitSound = SoundID.NPCHit1;
            npc.DeathSound = SoundID.NPCDeath32;
            npc.value = 70f;
            npc.knockBackResist = 0.0f;
            npc.aiStyle = 7;
            Main.npcFrameCount[npc.type] = 3;
            aiType = NPCID.Squirrel;
            animationType = NPCID.Squirrel;
        }

        public override float SpawnChance(NPCSpawnInfo spawnInfo)
        {
            return spawnInfo.spawnTileY <= Main.worldSurface && Main.dayTime ? 0.09f : 0.0f;
        }

        public override void FindFrame(int frameHeight)
        {
            npc.frameCounter -= 0.1F;
            npc.frameCounter %= Main.npcFrameCount[npc.type];
            int frame = (int)npc.frameCounter;
            npc.frame.Y = frame * frameHeight;
            npc.spriteDirection = npc.direction;
        }

        public override void NPCLoot()
        {
            {
                Item.NewItem(npc.getRect(), mod.ItemType("ChiItemRaw"), 1 + Main.rand.Next(2));
                Item.NewItem(npc.getRect(), mod.ItemType("ChiItemEgg"), 4 + Main.rand.Next(9));
                if (Main.rand.Next(39) == 0)
	                Item.NewItem(npc.getRect(), mod.ItemType("ChiItemGoldEgg"), 1);
            }
        }
    }

}
