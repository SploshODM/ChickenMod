using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ChickenMod.NPCs
{
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
                if (Main.rand.Next(41) == 0)
	                Item.NewItem(npc.getRect(), mod.ItemType("ChiItemGoldEgg"), 1);
            }
        }
    }
}