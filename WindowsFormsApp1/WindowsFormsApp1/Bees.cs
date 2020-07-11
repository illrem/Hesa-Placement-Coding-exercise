using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace WindowsFormsApp1
{
    class Bees
    {
        protected float health = 100.0f;
        protected bool isDead = false;
        protected float deadPercent;
        protected string beeType;
        public void damage(int dmg)
        {
            if (dmg < 0)
            {
                Console.WriteLine("Damage input too low, please put between 0-100");
            }
            else if (dmg > 100)
            {
                Console.WriteLine("Damage input too high, please put between 0-100");
            }
            else if (!isDead)
            {
            health = (((100f - (float)dmg) / (float)100f) * (float)health);
                checkdeath();
            }
        }

        public string getIsDead()
        {
            if (isDead)
            {
                return "Dead";
            }
            else
            {
                return "alive";
            }
        }

        public float getHealth()
        {
            return health;
        }

        public string getBeeType()
        {
            return beeType;
        }

        private void checkdeath()
        {
            if (health < deadPercent)
            {
                isDead = true;
            }
        }

    }


    class Worker : Bees
    {
        public Worker()
        {
            deadPercent = 70f;
            beeType = "Worker";
        }
    }

    class Queen : Bees
    {
        public Queen()
        {
            deadPercent = 20f;
            beeType = "Queen";
        }
    }

    class Drone : Bees
    {
        public Drone()
        {
            deadPercent = 50f;
            beeType = "Drone";
        }
    }
}
