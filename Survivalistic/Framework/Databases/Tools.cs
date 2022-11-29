﻿using System.Collections.Generic;

namespace Survivalistic.Framework.Databases
{
    public class Tools
    {
        public static Dictionary<string, string> GetToolDatabase()
        {
            Dictionary<string, string> holder = new Dictionary<string, string>();

            holder.Add("Axe", "0.0/0.0");
            holder.Add("Pickaxe", "0.0/0.0");
            holder.Add("Hoe", "0.0/0.0");
            holder.Add("Scythe", "0.0/0.0");
            holder.Add("Fishing Rod", "0.0/0.0");
            holder.Add("Watering Can", "0.0/0.0");
            holder.Add("Shears", "0.0/0.0");
            holder.Add("Milk Pail", "0.0/0.0");

            return holder;
        }
    }
}
