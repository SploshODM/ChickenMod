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
}
 