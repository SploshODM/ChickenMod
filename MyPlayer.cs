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
}
