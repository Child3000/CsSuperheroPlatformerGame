using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatmanPlatform
{
    class EnemyProperties
    {
        private int health;

        private int moveSpeed;

        private int defaultSpeed;


        protected void InitializeProperties( int health, int moveSpeed )
        {
            Health = health;
            MoveSpeed = moveSpeed;
            defaultSpeed = moveSpeed;
        }

        protected int Health
        {
            set { health = value; }
            get { return health; }
        }

        public int MoveSpeed
        {
            set { moveSpeed = value; }
            get { return moveSpeed; }
        }

        public void SetDefaultMoveSpeed()
        {
            moveSpeed = defaultSpeed;
        }


    }
}
