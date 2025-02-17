﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StardewModdingAPI;
using StardewModdingAPI.Events;
using StardewValley;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Survivalistic.Framework.Bars
{
    public class BarsWarnings
    {
        private static bool active_hunger_warning = false;
        private static bool active_thirst_warning = false;

        public static void VerifyStatus()
        {
            if (!Context.IsWorldReady) return;

            if (ModEntry.data.actual_hunger <= 15)
            {
                if (!active_hunger_warning)
                {
                    active_hunger_warning = true;
                    Game1.addHUDMessage(new HUDMessage($"You're hunger!", 2));
                }
            }
            else active_hunger_warning = false;

            if (ModEntry.data.actual_thirst <= 15)
            {
                if (!active_thirst_warning)
                {
                    active_thirst_warning = true;
                    Game1.addHUDMessage(new HUDMessage($"You're thirsty!", 2));
                }
            }
            else active_thirst_warning = false;
        }
    }
}
