using Terraria.ModLoader;
using Terraria.WorldBuilding;
using System.Collections.Generic;
using matoosatron.Common.Systems.GenPasses;

namespace matoosatron.Common.Systems
{
    internal class WorldSystem : ModSystem
    {
        public override void ModifyWorldGenTasks(List<GenPass> tasks, ref float totalWeight)
        {
            int shiniesIndex = tasks.FindIndex(t => t.Name.Equals("Shinies"));
            if(shiniesIndex != -1)
            {
                tasks.Insert(shiniesIndex + 1, new ZincOreGenPass("Zinc Ore Pass", 300f));
            }
        }
    }
}