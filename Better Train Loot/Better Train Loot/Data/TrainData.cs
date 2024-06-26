﻿using StardewValley;
using System.Collections.Generic;
using System.Linq;

namespace BetterTrainLoot.Data
{
    public enum TRAINS
    {
        RANDOM_TRAIN = 0,
        JOJA_TRAIN = 1,
        COAL_TRAIN = 2,
        PASSENGER_TRAIN =3,
        UNKNOWN = 4,
        PRISON_TRAIN = 5,
        PRESENT_TRAIN = 6
    }

    public class TrainData 
    {
        public TRAINS TrainCarID { get; set; }

        public List<TrainTreasure> treasureList { get; set; }

        public TrainData(TRAINS id)
        {
            this.TrainCarID = id;
        }

        public void UpdateTrainLootChances(double todayLuck)
        {                        
            double itemBaseChance = 0.0;
            foreach (TrainTreasure item in this.treasureList)
            {
                if (item.Id != "(O)434") // If not a Stardrop
                {
                    itemBaseChance = Game1.random.NextDouble() / 10.0;  // The bestcase is 10% (0.1)
                    itemBaseChance = itemBaseChance + (itemBaseChance * todayLuck);

                    item.Chance = itemBaseChance * (double)item.Rarity;
                }
                else
                {
                    itemBaseChance = Game1.random.NextDouble() / 100.0;  // The bestcase is 1% (0.01)
                    itemBaseChance = itemBaseChance + (itemBaseChance * todayLuck);

                    item.Chance = itemBaseChance * (double)item.Rarity;
                }               
            }           
        }

        internal bool HasItem(string id)
        {
            if (treasureList.Any(x => x.Id == id))
                return true;
            else
                return false;
        }
    }
}
