﻿namespace BetterTrainLoot.Config
{
    public class ModConfig
    {
        public bool enableMod { get; set; }
        public bool useCustomTrainTreasure { get; set; }
        public bool enableNoLimitTreasurePerTrain { get; set; }
        public bool showTrainIsComingMessage { get; set; }
        public bool showDesertTrainIsComingMessage { get; set; }
        public bool showIslandTrainIsComingMessage { get; set; }
        public bool enableTrainWhistle { get; set; }
        public bool enableDesertTrainWhistle { get; set; }
        public bool enableIslandTrainWhistle { get; set; }
        public float baseChancePercent { get; set; }
        public float basePctChanceOfTrain { get; set; }
        public int trainCreateDelay { get; set; }
        public int maxTrainsPerDay { get; set; }
        public int maxNumberOfItemsPerTrain { get; set; }
        public bool enableForceCreateTrain { get; set; }
        public bool enableMultiplayerChatMessage { get; set; }
        public int configVersion { get; set; }
    }
}
