using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerosQuest
{
    class Barbarian : Character
    {
        private int _Rage;
        private int _MaxRage;

        public int Rage
        {
            get { return _Rage; }
            set { _Rage = value; }
        } 

        Random rng = new Random();

        public Barbarian(string pType, string pName) : base(pType, pName)
        {

            _MaxHealth = rng.Next(14, 19);
            _MaxEnergy = rng.Next(8, 13);
            _EnergyPotions = rng.Next(2, 4);
            _HealthPotions = rng.Next(1, 3);
            _MaxRage = rng.Next(4, 9);

        }
        public override bool SwingAxe(Character pTarget)
        {
            // should never happen, so throw an exception
            if (_CharacterType != "barbarian")
            {
                throw new Exception(_CharacterType + " cannot use an axe.");
            }

            // error string used to detect is anything is wrong
            string error = "";

            if (pTarget._Health <= 0)
            {
                error += pTarget._Name + " is already dead.";
            }

            if (_Energy <= 0)
            {
                error += "You need at least 1 energy to swing your axe.";
            }

            if (pTarget == _Allied)
            {
                error += "You cannot attack " + pTarget._Name + " because you are allied with them this turn.";
            }

            // If anything is wrong output the error(s) and return false
            if (error.Length > 0)
            {
                Console.WriteLine(error);
                return false;
            }

            // nothing wrong, so do the action, output result and return true

            Console.WriteLine(_Name + " swings his mighty axe at " + pTarget._Name);
            int damageMultiplier = 1;
            if (_Rage >= _MaxRage)
            {
                Console.WriteLine("RAGING STRIKE - THIS STRIKE WILL DEAL DOUBLE DAMAGE!");
                damageMultiplier = 2;
                _Rage = 0;
            }

            _Energy--;

            int roll = rng.Next(1, 21);
            if (roll < 4)
            {
                Console.WriteLine("The axe misses " + pTarget._Name + " completely!");
                _Rage += 4;
            }
            else if (roll < 9)
            {

                Console.WriteLine("The axe grazes " + pTarget._Name + "'s leg dealing " + (damageMultiplier * 2) + " damage!");
                pTarget._Health -= (damageMultiplier * 2);
                _Rage += 3;
            }
            else if (roll < 17)
            {

                Console.WriteLine("The axe crashed into " + pTarget._Name + "'s torso dealing " + (damageMultiplier * 3) + " damage.");
                pTarget._Health -= (damageMultiplier * 3);
                _Rage += 2;
            }
            else
            {
                _Rage += 1;
                Console.WriteLine("The axe smashes into " + pTarget._Name + "'s head dealing " + (damageMultiplier * 4) + " damage.");
                pTarget._Health -= (damageMultiplier * 4);
            }

            Console.WriteLine("Your rage increases to " + _Rage);
            return true;
        }
    }
}
