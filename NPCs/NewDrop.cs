using Terraria.ID;
using Terraria;
using Terraria.ModLoader;
using Terraria.GameContent.ItemDropRules;

namespace kunwu.NPCs
{
    public class NewDrop : GlobalNPC
    {
        public override void ModifyNPCLoot(NPC npc, NPCLoot npcLoot)
        {
            if (npc.type == NPCID.FlyingSnake)
            {
                npcLoot.Add(new CommonDrop(ModContent.ItemType<Items.Consumables.Flyingserpentfeather>(), chanceDenominator: 5, 2, 4, chanceNumerator: 4));
                // 4/5=80%的概率掉落2到4个
            }
        }
    }
}
