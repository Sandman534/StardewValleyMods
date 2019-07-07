﻿using BetterTrashCans.Data;
using SObject = StardewValley.Object;
using System.Collections.Generic;

namespace BetterTrashCans.Config
{
    public static class TrashcanDefaultConfig
    {
        public static Dictionary<TRASHCANS, Trashcan> CreateTrashcans(string file)
        {
            Dictionary<TRASHCANS, Trashcan> groups = new Dictionary<TRASHCANS, Trashcan>();
            groups.Add(TRASHCANS.JODI_SAM, CreateTrashcan(TRASHCANS.JODI_SAM));
            groups.Add(TRASHCANS.EMILY_HALEY, CreateTrashcan(TRASHCANS.EMILY_HALEY));
            groups.Add(TRASHCANS.MAYOR_LEWIS, CreateTrashcan(TRASHCANS.MAYOR_LEWIS));
            groups.Add(TRASHCANS.GUNTHER, CreateTrashcan(TRASHCANS.GUNTHER));
            groups.Add(TRASHCANS.CLINT, CreateTrashcan(TRASHCANS.CLINT));
            groups.Add(TRASHCANS.STARDROP_SALOON, CreateTrashcan(TRASHCANS.STARDROP_SALOON));
            groups.Add(TRASHCANS.EVELYN_GEORGE, CreateTrashcan(TRASHCANS.EVELYN_GEORGE));

            BetterTrashCansMod.Instance.Helper.Data.WriteJsonFile(file, groups);

            return groups;
        }

        private static Trashcan CreateTrashcan(TRASHCANS id)
        {
           Trashcan newGroup = new Trashcan(id);
            newGroup.treasureList = GetTreasureList(id);
            return newGroup;
        }

        private static List<TrashTreasure> GetTreasureList(TRASHCANS id)
        {
            switch (id)
            {
                case TRASHCANS.JODI_SAM:
                    return GetJodiSamTreasureList();    
                    
                case TRASHCANS.EMILY_HALEY:
                    return GetEmilyHaleyTreasureList();      
                    
                case TRASHCANS.MAYOR_LEWIS:
                    return GetMayorLewisTreasureList(); 
                    
                case TRASHCANS.GUNTHER:
                    return GetGuntherTreasureList();    
                    
                case TRASHCANS.CLINT:
                    return GetClintTreasureList();   
                    
                case TRASHCANS.STARDROP_SALOON:
                    return GetSaloonTreasureList();    
                    
                case TRASHCANS.EVELYN_GEORGE:
                    return GetEvelynGeorgeTreasureList();     
                    
                default:
                    return new List<TrashTreasure>();                    
            }
        }

        private static List<TrashTreasure> GetJodiSamTreasureList()
        {
            List<TrashTreasure> treasures = new List<TrashTreasure>();
            treasures.Add(CreateTreasure(72, "Diamond ", 0.005));
            treasures.Add(CreateTreasure(88, "Coconut", 0.0075));
            treasures.Add(CreateTreasure(90, "Cactus Fruit", 0.0075));
            treasures.Add(CreateTreasure(167, "Jojo Cola", 0.1));
            treasures.Add(CreateTreasure(168, "Trash", 0.3));
            treasures.Add(CreateTreasure(174, "Large Egg", 0.02));
            treasures.Add(CreateTreasure(200, "Vegetable Medley", 0.02));
            treasures.Add(CreateTreasure(206, "Pizza", 0.06));
            treasures.Add(CreateTreasure(211, "Pancake", 0.0375));
            treasures.Add(CreateTreasure(214, "Crispy Bass", 0.02));
            treasures.Add(CreateTreasure(216, "Bread", 0.04));
            treasures.Add(CreateTreasure(220, "Chocolate Cake", 0.03));
            treasures.Add(CreateTreasure(221, "Pink Cake", 0.025));
            treasures.Add(CreateTreasure(222, "Rhubarb Pie", 0.022));
            treasures.Add(CreateTreasure(225, "Fried Eel", 0.021));
            treasures.Add(CreateTreasure(231, "Eggplant Parmesan", 0.025));
            treasures.Add(CreateTreasure(266, "Red Cabbage", 0.0075));
            treasures.Add(CreateTreasure(286, "Cherry Bomb", 0.04));
            treasures.Add(CreateTreasure(287, "Bomb", 0.03));
            treasures.Add(CreateTreasure(348, "Wine ", 0.02));
            treasures.Add(CreateTreasure(398, "Grape", 0.02));
            treasures.Add(CreateTreasure(408, "Hazelnut", 0.025));
            treasures.Add(CreateTreasure(442, "Duck Egg", 0.01));
            treasures.Add(CreateTreasure(562, "Tigers Eye", 0.009));
            treasures.Add(CreateTreasure(607, "Roasted Hazelnut", 0.02));
            treasures.Add(CreateTreasure(612, "Cranberry Candy", 0.02));
            treasures.Add(CreateTreasure(649, "Fiddle Head Risotto", 0.02));
            treasures.Add(CreateTreasure(731, "Maple Bar", 0.03));
            treasures.Add(CreateTreasure(787, "Battery Pack", 0.008));

            return treasures;
        }

        private static List<TrashTreasure> GetEmilyHaleyTreasureList()
        {
            List<TrashTreasure> treasures = new List<TrashTreasure>();
            treasures.Add(CreateTreasure(18, "Daffodil", 0.06));
            treasures.Add(CreateTreasure(60, "Emerald", 0.01));
            treasures.Add(CreateTreasure(62, "Aquamarine", 0.01));
            treasures.Add(CreateTreasure(64, "Ruby", 0.01));
            treasures.Add(CreateTreasure(66, "Amethyst", 0.01));
            treasures.Add(CreateTreasure(68, "Topaz", 0.01));
            treasures.Add(CreateTreasure(70, "Jade", 0.01));
            treasures.Add(CreateTreasure(74, "Prismatic Shard", 0.001));
            treasures.Add(CreateTreasure(88, "Coconut", 0.025));
            treasures.Add(CreateTreasure(168, "Trash", 0.3));
            treasures.Add(CreateTreasure(221, "Pink Cake", 0.05));
            treasures.Add(CreateTreasure(241, "Survival Burger", 0.04));
            treasures.Add(CreateTreasure(309, "Acorn", 0.06));
            treasures.Add(CreateTreasure(310, "Maple Seed", 0.055));
            treasures.Add(CreateTreasure(340, "Honey", 0.04));
            treasures.Add(CreateTreasure(341, "Tea Set", 0.015));
            treasures.Add(CreateTreasure(348, "Wine", 0.045));
            treasures.Add(CreateTreasure(421, "Sunflower", 0.055));
            treasures.Add(CreateTreasure(428, "Cloth", 0.039));
            treasures.Add(CreateTreasure(440, "Wool", 0.065));
            treasures.Add(CreateTreasure(610, "Fruit Salad", 0.075));
            treasures.Add(CreateTreasure(725, "Oak Resin", 0.015));

            return treasures;
        }

        private static List<TrashTreasure> GetMayorLewisTreasureList()
        {
            List<TrashTreasure> treasures = new List<TrashTreasure>();
            treasures.Add(CreateTreasure(18, "Daffodil", 0.045));
            treasures.Add(CreateTreasure(72, "Diamond", 0.005));
            treasures.Add(CreateTreasure(74, "Prismatic Shard", 0.001));
            treasures.Add(CreateTreasure(88, "Coconut", 0.03));
            treasures.Add(CreateTreasure(90, "Cactus Fruit", 0.03));
            treasures.Add(CreateTreasure(128, "Puffer Fish", 0.01));
            treasures.Add(CreateTreasure(132, "Bream", 0.02));
            treasures.Add(CreateTreasure(136, "Largemouth Bass", 0.02));
            treasures.Add(CreateTreasure(142, "Carp", 0.015));
            treasures.Add(CreateTreasure(143, "Catfish", 0.025));
            treasures.Add(CreateTreasure(145, "Sunfish", 0.03));
            treasures.Add(CreateTreasure(150, "Red Snapper", 0.02));
            treasures.Add(CreateTreasure(168, "Trash", 0.3));
            treasures.Add(CreateTreasure(200, "Vegetable Medley", 0.03));
            treasures.Add(CreateTreasure(208, "Glazed Yams", 0.025));
            treasures.Add(CreateTreasure(221, "Pink Cake", 0.025));
            treasures.Add(CreateTreasure(235, "Autumn's Bounty", 0.025));
            treasures.Add(CreateTreasure(240, "Farmers Lunch", 0.025));
            treasures.Add(CreateTreasure(258, "Blueberry", 0.03));
            treasures.Add(CreateTreasure(260, "Hot Pepper", 0.03));
            treasures.Add(CreateTreasure(266, "Red Cabbage", 0.03));
            treasures.Add(CreateTreasure(276, "Pumpkin", 0.01));
            treasures.Add(CreateTreasure(340, "Honey", 0.03));
            treasures.Add(CreateTreasure(348, "Wine", 0.025));
            treasures.Add(CreateTreasure(444, "Duck Feather", 0.01));
            treasures.Add(CreateTreasure(446, "Rabits Foot", 0.01));
            treasures.Add(CreateTreasure(608, "Pumpkin Pie", 0.02));
            treasures.Add(CreateTreasure(637, "Pomegranate", 0.02));
            treasures.Add(CreateTreasure(698, "Sturgeon", 0.02));
            treasures.Add(CreateTreasure(699, "Tiger Trout", 0.03));
            treasures.Add(CreateTreasure(700, "Bullhead", 0.02));
            treasures.Add(CreateTreasure(701, "Tilapia", 0.01));
            treasures.Add(CreateTreasure(706, "Shad", 0.01));
            treasures.Add(CreateTreasure(724, "Maple Syrup", 0.01));
            treasures.Add(CreateTreasure(797, "Pearl", 0.004));

            return treasures;
        }

        private static List<TrashTreasure> GetGuntherTreasureList()
        {
            List<TrashTreasure> treasures = new List<TrashTreasure>();
            treasures.Add(CreateTreasure(72, "Diamond", 0.005));
            treasures.Add(CreateTreasure(74, "Prismatic Shard", 0.001));
            treasures.Add(CreateTreasure(84, "Frozen Tear", 0.0175));
            treasures.Add(CreateTreasure(96, "Dwarf Scroll I", 0.02));
            treasures.Add(CreateTreasure(97, "Dwarf Scroll Ii", 0.0175));
            treasures.Add(CreateTreasure(98, "Dwarf Scroll Iii", 0.015));
            treasures.Add(CreateTreasure(99, "Dwarf Scroll Iv", 0.0125));
            treasures.Add(CreateTreasure(100, "Chipped Amphora", 0.015));
            treasures.Add(CreateTreasure(101, "Arrowhead", 0.015));
            treasures.Add(CreateTreasure(103, "Ancient Doll", 0.01));
            treasures.Add(CreateTreasure(104, "Elvish Jewelry", 0.01));
            treasures.Add(CreateTreasure(105, "Chewing Stick", 0.04));
            treasures.Add(CreateTreasure(106, "Ornamental Fan", 0.015));
            treasures.Add(CreateTreasure(107, "Dinosour Egg", 0.01));
            treasures.Add(CreateTreasure(108, "Rare Disc", 0.01));
            treasures.Add(CreateTreasure(109, "Ancient Sword", 0.015));
            treasures.Add(CreateTreasure(110, "Rusty Spoon", 0.025));
            treasures.Add(CreateTreasure(111, "Rusty Spur", 0.025));
            treasures.Add(CreateTreasure(112, "Rusty Cog", 0.025));
            treasures.Add(CreateTreasure(113, "Chicken Statue", 0.03));
            treasures.Add(CreateTreasure(115, "Prehistoric Tool", 0.02));
            treasures.Add(CreateTreasure(116, "Dried Starfish", 0.02));
            treasures.Add(CreateTreasure(117, "Anchor", 0.01));
            treasures.Add(CreateTreasure(118, "Glass Shards", 0.02));
            treasures.Add(CreateTreasure(119, "Bone Flute", 0.01));
            treasures.Add(CreateTreasure(120, "Prehistoric Handaxe", 0.02));
            treasures.Add(CreateTreasure(121, "Dwarvish Helm", 0.01));
            treasures.Add(CreateTreasure(122, "Dwarf Gadget", 0.01));
            treasures.Add(CreateTreasure(123, "Ancient Drum", 0.01));
            treasures.Add(CreateTreasure(124, "Golden Mask", 0.005));
            treasures.Add(CreateTreasure(125, "Golden Relic", 0.005));
            treasures.Add(CreateTreasure(126, "Strange Doll", 0.01));
            treasures.Add(CreateTreasure(168, "Trash", 0.3));
            treasures.Add(CreateTreasure(433, "Coffee Bean", 0.0075));
            treasures.Add(CreateTreasure(446, "Rabbits Foot", 0.005));
            treasures.Add(CreateTreasure(499, "Ancient Seed Packet", 0.005));
            treasures.Add(CreateTreasure(535, "Geode", 0.02));
            treasures.Add(CreateTreasure(557, "Petrified Slime", 0.01));
            treasures.Add(CreateTreasure(558, "Thunder Egg", 0.01));
            treasures.Add(CreateTreasure(578, "Star Shards", 0.01));
            treasures.Add(CreateTreasure(579, "Prehistoric Scapula", 0.01));
            treasures.Add(CreateTreasure(580, "Prehistoric Tibia", 0.01));
            treasures.Add(CreateTreasure(581, "Prehistoric Skull", 0.01));
            treasures.Add(CreateTreasure(582, "Skeletal Hand", 0.01));
            treasures.Add(CreateTreasure(583, "Prehistoric Rib", 0.01));
            treasures.Add(CreateTreasure(584, "Prehistoric Vertebra", 0.01));
            treasures.Add(CreateTreasure(585, "Skeletal Tail", 0.01));
            treasures.Add(CreateTreasure(586, "Nautilus Fossil", 0.01));
            treasures.Add(CreateTreasure(587, "Amphibian Fossil", 0.0125));
            treasures.Add(CreateTreasure(588, "Palm Fossil", 0.0125));
            treasures.Add(CreateTreasure(589, "Trilobite", 0.0125));
            treasures.Add(CreateTreasure(687, "Dressed Spinner", 0.0075));
            treasures.Add(CreateTreasure(749, "Omni Geode", 0.009));
            treasures.Add(CreateTreasure(773, "Life Elixir", 0.01));
            treasures.Add(CreateTreasure(787, "Battery Pack", 0.005));

            return treasures;
        }

        private static List<TrashTreasure> GetClintTreasureList()
        {
            List<TrashTreasure> treasures = new List<TrashTreasure>();
            treasures.Add(CreateTreasure(60, "Emerald", 0.009));
            treasures.Add(CreateTreasure(62, "Aquamarine", 0.009));
            treasures.Add(CreateTreasure(64, "Ruby", 0.009));
            treasures.Add(CreateTreasure(66, "Amethyst", 0.009));
            treasures.Add(CreateTreasure(68, "Topaz", 0.009));
            treasures.Add(CreateTreasure(70, "Jade", 0.009));
            treasures.Add(CreateTreasure(72, "Diamond", 0.0075));
            treasures.Add(CreateTreasure(74, "Prismatic Shard", 0.001));
            treasures.Add(CreateTreasure(80, "Quartz", 0.0175));
            treasures.Add(CreateTreasure(82, "Fire Quartz", 0.015));
            treasures.Add(CreateTreasure(84, "Frozen Tear", 0.0125));
            treasures.Add(CreateTreasure(86, "Earth Chrystal", 0.0115));
            treasures.Add(CreateTreasure(168, "Trash", 0.3));
            treasures.Add(CreateTreasure(334, "Copper Bar", 0.0175));
            treasures.Add(CreateTreasure(337, "Iridium Bar", 0.005));
            treasures.Add(CreateTreasure(378, "Copper Ore", 0.02, 5, 10));
            treasures.Add(CreateTreasure(380, "Iron Ore", 0.0175, 4, 8));
            treasures.Add(CreateTreasure(380, "Iron Bar", 0.015));
            treasures.Add(CreateTreasure(382, "Coal", 0.0139));
            treasures.Add(CreateTreasure(384, "Gold Ore", 0.0125, 3, 6));
            treasures.Add(CreateTreasure(384, "Gold Bar", 0.01));
            treasures.Add(CreateTreasure(386, "Iridium Ore", 0.0075, 2, 4));
            treasures.Add(CreateTreasure(403, "Field Snack", 0.0306));
            treasures.Add(CreateTreasure(420, "Red Mushroom", 0.01));
            treasures.Add(CreateTreasure(422, "Purple Mushroom", 0.01));
            treasures.Add(CreateTreasure(517, "Glow Ring", 0.01));
            treasures.Add(CreateTreasure(518, "Small Megnic Ring", 0.01));
            treasures.Add(CreateTreasure(527, "Iridium Band", 0.0075));
            treasures.Add(CreateTreasure(535, "Geode", 0.014));
            treasures.Add(CreateTreasure(536, "Frozen Geode", 0.013));
            treasures.Add(CreateTreasure(537, "Magma Geode", 0.012));
            treasures.Add(CreateTreasure(538, "Alamite", 0.008));
            treasures.Add(CreateTreasure(539, "Bixite", 0.008));
            treasures.Add(CreateTreasure(540, "Baryte", 0.008));
            treasures.Add(CreateTreasure(541, "Aerinite", 0.008));
            treasures.Add(CreateTreasure(542, "Calcite", 0.008));
            treasures.Add(CreateTreasure(543, "Dolomite", 0.008));
            treasures.Add(CreateTreasure(544, "Esperite", 0.008));
            treasures.Add(CreateTreasure(545, "Fluorapatite", 0.008));
            treasures.Add(CreateTreasure(546, "Geminite", 0.008));
            treasures.Add(CreateTreasure(547, "Helvite", 0.008));
            treasures.Add(CreateTreasure(548, "Jamborite", 0.008));
            treasures.Add(CreateTreasure(549, "Jagoite", 0.008));
            treasures.Add(CreateTreasure(550, "Kyanite", 0.008));
            treasures.Add(CreateTreasure(551, "Lunarite", 0.008));
            treasures.Add(CreateTreasure(551, "Lunarite", 0.008));
            treasures.Add(CreateTreasure(552, "Malachite", 0.008));
            treasures.Add(CreateTreasure(553, "Neptunite", 0.008));
            treasures.Add(CreateTreasure(554, "Lemon Stone", 0.008));
            treasures.Add(CreateTreasure(555, "Nekoite", 0.008));
            treasures.Add(CreateTreasure(556, "Orpiment", 0.008));
            treasures.Add(CreateTreasure(559, "Pyrite", 0.008));
            treasures.Add(CreateTreasure(560, "Ocean Stone", 0.008));
            treasures.Add(CreateTreasure(562, "Tigers Eye", 0.008));
            treasures.Add(CreateTreasure(563, "Jasper", 0.008));
            treasures.Add(CreateTreasure(564, "Opal", 0.008));
            treasures.Add(CreateTreasure(565, "Fire Opal", 0.008));
            treasures.Add(CreateTreasure(566, "Celestine", 0.008));
            treasures.Add(CreateTreasure(567, "Marble", 0.008));
            treasures.Add(CreateTreasure(568, "Sandstone", 0.008));
            treasures.Add(CreateTreasure(569, "Granite", 0.008));
            treasures.Add(CreateTreasure(570, "Basalt", 0.008));
            treasures.Add(CreateTreasure(571, "Limestone", 0.008));
            treasures.Add(CreateTreasure(572, "Soapstone", 0.008));
            treasures.Add(CreateTreasure(573, "Hematite", 0.008));
            treasures.Add(CreateTreasure(574, "Mudstone", 0.008));
            treasures.Add(CreateTreasure(575, "Obsidian", 0.008));
            treasures.Add(CreateTreasure(576, "Slate", 0.008));
            treasures.Add(CreateTreasure(577, "Fairy Stone", 0.008));
            treasures.Add(CreateTreasure(605, "Artichoke Dip", 0.016));
            treasures.Add(CreateTreasure(649, "Fiddle Head Risotto", 0.014));
            treasures.Add(CreateTreasure(749, "Omni Geode", 0.011));
            treasures.Add(CreateTreasure(797, "Pearl", 0.004));

            return treasures;
        }

        private static List<TrashTreasure> GetSaloonTreasureList()
        {
            List<TrashTreasure> treasures = new List<TrashTreasure>();
            treasures.Add(CreateTreasure(72, "Diamond", 0.004));
            treasures.Add(CreateTreasure(130, "Tuna", 0.005));
            treasures.Add(CreateTreasure(136, "Largemouth Bass", 0.005));
            treasures.Add(CreateTreasure(140, "Walleye", 0.005));
            treasures.Add(CreateTreasure(143, "Catfish", 0.005));
            treasures.Add(CreateTreasure(148, "Eel", 0.005));
            treasures.Add(CreateTreasure(168, "Trash", 0.3));
            treasures.Add(CreateTreasure(186, "Large Milk", 0.005));
            treasures.Add(CreateTreasure(194, "Fried Egg", 0.015));
            treasures.Add(CreateTreasure(201, "Complete Breakfast", 0.015));
            treasures.Add(CreateTreasure(202, "Fried Calamari", 0.015));
            treasures.Add(CreateTreasure(204, "Lucky Lunch", 0.015));
            treasures.Add(CreateTreasure(206, "Pizza", 0.015));
            treasures.Add(CreateTreasure(207, "Bean Hotpot", 0.015));
            treasures.Add(CreateTreasure(212, "Salmon Dinner", 0.015));
            treasures.Add(CreateTreasure(213, "Fish Taco", 0.015));
            treasures.Add(CreateTreasure(214, "Crispy Bass", 0.015));
            treasures.Add(CreateTreasure(215, "Pepper Poppers", 0.015));
            treasures.Add(CreateTreasure(218, "Tom Kha Soup", 0.015));
            treasures.Add(CreateTreasure(220, "Chocolate Cake", 0.015));
            treasures.Add(CreateTreasure(224, "Spaghetti", 0.015));
            treasures.Add(CreateTreasure(227, "Sashimi", 0.015));
            treasures.Add(CreateTreasure(233, "Ice Cream", 0.015));
            treasures.Add(CreateTreasure(234, "Blueberry Tart", 0.015));
            treasures.Add(CreateTreasure(236, "Pumpkin Soup", 0.015));
            treasures.Add(CreateTreasure(276, "Pumpkin", 0.005));
            treasures.Add(CreateTreasure(303, "Pale Ale", 0.04));
            treasures.Add(CreateTreasure(342, "Pickles", 0.02));
            treasures.Add(CreateTreasure(346, "Beer", 0.04));
            treasures.Add(CreateTreasure(348, "Wine", 0.04));
            treasures.Add(CreateTreasure(395, "Coffee", 0.05));
            treasures.Add(CreateTreasure(408, "Hazelnut", 0.01));
            treasures.Add(CreateTreasure(426, "Goat Cheese", 0.005));
            treasures.Add(CreateTreasure(430, "Truffle", 0.005));
            treasures.Add(CreateTreasure(432, "Truffle Oil", 0.005));
            treasures.Add(CreateTreasure(438, "Large Goats Milk", 0.005));
            treasures.Add(CreateTreasure(459, "Mead", 0.021));
            treasures.Add(CreateTreasure(604, "Plum Pudding", 0.015));
            treasures.Add(CreateTreasure(607, "Roasted Hazelnuts", 0.015));
            treasures.Add(CreateTreasure(611, "Blackberry Cobbler", 0.015));
            treasures.Add(CreateTreasure(635, "Orange", 0.005));
            treasures.Add(CreateTreasure(636, "Peach", 0.005));
            treasures.Add(CreateTreasure(649, "Fiddle Head Risotto", 0.015));
            treasures.Add(CreateTreasure(651, "Poppy Seed Muffin", 0.015));
            treasures.Add(CreateTreasure(698, "Sturgeon", 0.005));
            treasures.Add(CreateTreasure(715, "Lobster", 0.005));
            treasures.Add(CreateTreasure(717, "Crab ", 0.005));
            treasures.Add(CreateTreasure(720, "Shrimp", 0.005));
            treasures.Add(CreateTreasure(721, "Snail", 0.005));
            treasures.Add(CreateTreasure(723, "Oyster", 0.005));
            treasures.Add(CreateTreasure(724, "Maple Syrup", 0.005));
            treasures.Add(CreateTreasure(729, "Escargot", 0.015));
            treasures.Add(CreateTreasure(731, "Maple Bar", 0.015));
            treasures.Add(CreateTreasure(732, "Crab Cakes", 0.015));

            return treasures;
        }

        private static List<TrashTreasure> GetEvelynGeorgeTreasureList()
        {
            List<TrashTreasure> treasures = new List<TrashTreasure>();
            treasures.Add(CreateTreasure(18, "Daffodil", 0.045));
            treasures.Add(CreateTreasure(20, "Leek", 0.045));
            treasures.Add(CreateTreasure(24, "Parsnip", 0.02));
            treasures.Add(CreateTreasure(72, "Diamond", 0.005));
            treasures.Add(CreateTreasure(90, "Cactus Fruit", 0.0075));
            treasures.Add(CreateTreasure(168, "Trash", 0.3));
            treasures.Add(CreateTreasure(201, "Complete Breakfast", 0.02));
            treasures.Add(CreateTreasure(205, "Fried Mushroom", 0.02));
            treasures.Add(CreateTreasure(216, "Bread", 0.02));
            treasures.Add(CreateTreasure(220, "Chocolate Cake", 0.025));
            treasures.Add(CreateTreasure(221, "Pink Cake", 0.025));
            treasures.Add(CreateTreasure(223, "Cookies", 0.038));
            treasures.Add(CreateTreasure(233, "Ice Cream", 0.02));
            treasures.Add(CreateTreasure(239, "Stuffing", 0.02));
            treasures.Add(CreateTreasure(266, "Red Cabbage", 0.01));
            treasures.Add(CreateTreasure(284, "Beet", 0.01));
            treasures.Add(CreateTreasure(348, "Wine", 0.01));
            treasures.Add(CreateTreasure(376, "Poppy", 0.02));
            treasures.Add(CreateTreasure(425, "Fairy Seeds", 0.015, 1, 3));
            treasures.Add(CreateTreasure(427, "Tulip Bulb", 0.015, 1, 3));
            treasures.Add(CreateTreasure(431, "Sunflower Seeds", 0.015, 1, 3));
            treasures.Add(CreateTreasure(446, "Rabits Foot", 0.005));
            treasures.Add(CreateTreasure(453, "Poppy Seeds", 0.015, 1, 3));
            treasures.Add(CreateTreasure(466, "Deluxe Speed Grow", 0.015));
            treasures.Add(CreateTreasure(472, "Parsnip Seeds", 0.015, 1, 3));
            treasures.Add(CreateTreasure(485, "Red Cabbage Seeds", 0.015, 1, 3));
            treasures.Add(CreateTreasure(486, "Starfruit Seed", 0.015));
            treasures.Add(CreateTreasure(490, "Pumpkin Seeds", 0.015, 1, 3));
            treasures.Add(CreateTreasure(495, "Spring Seeds", 0.015, 1, 3));
            treasures.Add(CreateTreasure(496, "Summer Seeds", 0.015, 1, 3));
            treasures.Add(CreateTreasure(497, "Fall Seeds", 0.015, 1, 3));
            treasures.Add(CreateTreasure(498, "Winter Seeds", 0.015, 1, 3));
            treasures.Add(CreateTreasure(499, "Ancient Fruit Seed", 0.015));
            treasures.Add(CreateTreasure(591, "Tulip", 0.015));
            treasures.Add(CreateTreasure(593, "Summer Spangle", 0.015));
            treasures.Add(CreateTreasure(595, "Fairy Rose", 0.015));
            treasures.Add(CreateTreasure(621, "Quality Spinkler", 0.0075));
            treasures.Add(CreateTreasure(628, "Cherry Sapling", 0.009));
            treasures.Add(CreateTreasure(630, "Orange Sapling", 0.009));
            treasures.Add(CreateTreasure(631, "Peach Sapling", 0.009));
            treasures.Add(CreateTreasure(632, "Pomegranate Sapling", 0.009));
            treasures.Add(CreateTreasure(633, "Apple Sapling", 0.009));
            treasures.Add(CreateTreasure(724, "Maple Syrup", 0.015));
            treasures.Add(CreateTreasure(745, "Strawberry Seeds", 0.008, 1, 2));
            treasures.Add(CreateTreasure(797, "Pearl", 0.004));

            return treasures;
        }

        private static TrashTreasure CreateTreasure(int id, string name, double chance, int minAmount, int maxAmount)
        {
            return new TrashTreasure(id, name, chance, minAmount, maxAmount, true);
        }

        private static TrashTreasure CreateTreasure(int id, string name, double chance)
        {
            return new TrashTreasure(id, name, chance, 1, 1, true);
        }
    }
}
