﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicDestroyers.Equipment.Armors.Light
{
    public class ClothRobe:Armor
    {
        private const int DEFAULT_ARMOR_POINTS = 10;

        public ClothRobe() : this(DEFAULT_ARMOR_POINTS)
        {

        }
        public ClothRobe(int armorPoints)
        {
            this.ArmorPoints = armorPoints;
        }
    }
}
