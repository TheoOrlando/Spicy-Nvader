﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    abstract public class EntityWithLife : Entity
    {
        private int lifePoints;
        private int maxLife;

        protected EntityWithLife( int maxLife, int columnPosition, int rowPosition, Game game) : base( columnPosition, rowPosition, game)
        {
            MaxLife = maxLife;
            ColumnPosition = columnPosition;
            RowPosition = rowPosition;
            Game = game;
        }

        public int LifePoints
        {
            get => lifePoints;
            set
            {
                if (value < 0)
                    lifePoints = 0;
                else if (value > maxLife)
                    lifePoints = maxLife;
                else
                    lifePoints = value;
            }
        }
        public int MaxLife
        {
            get => maxLife;
            set => maxLife = value;
        }
    }
}
