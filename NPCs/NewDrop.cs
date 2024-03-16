﻿using Terraria.ID;
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
                npcLoot.Add(new CommonDrop(ModContent.ItemType<Items.Consumables.Flyingserpentfeather>(), chanceDenominator: 8, 1, 3, chanceNumerator: 3));
                // 3 / 8 = 37.5%的概率掉落1到3个
            }
        }
    }
}
