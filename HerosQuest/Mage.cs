using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerosQuest
{
    public class mage : Character
    {
        Random rng = new Random();
        public mage(string pType, string pName) : base(pType, pName)
        {
            _MaxHealth = rng.Next(8, 11);
            _MaxEnergy = rng.Next(6, 13);
            _EnergyPotions = rng.Next(1, 3);
            _HealthPotions = rng.Next(2, 4);
        }
        public bool HealPlayer(Character pTarget)
        {
            // should never happen, so throw an exception
            if (_CharacterType != "mage")
            {
                throw new Exception(_CharacterType + " cannot heal a player.");
            }

            // error string used to detect is anything is wrong
            string error = "";

            if (pTarget._Health <= 0)
            {
                error += pTarget._Name + " is already dead.";
            }

            if (_Energy <= 0)
            {
                error += "You need at least 1 energy to heal a player.";
            }

            // If anything is wrong output the error(s) and return false
            if (error.Length > 0)
            {
                Console.WriteLine(error);
                return false;
            }

            // nothing wrong, so do the action, output result and return true
            pTarget._Health += rng.Next(3, 7);
            if (pTarget != this)
            {
                pTarget._Allied = this;
            }
            return true;
        }
        public bool ThrowFireball(Character pTarget)
        {
            // should never happen, so throw an exception
            if (_CharacterType != "mage")
            {
                throw new Exception(_CharacterType + " cannot throw a fireball.");
            }

            // error string used to detect is anything is wrong
            string error = "";

            if (pTarget._Health <= 0)
            {
                error += pTarget._Name + " is already dead.";
            }

            if (_Energy <= 0)
            {
                error += "You need at least 1 energy to throw a fireball.";
            }

            if (pTarget == _Allied)
            {
                error += "You cannot attack " + pTarget + " because you are allied with them this turn.";
            }

            // If anything is wrong output the error(s) and return false
            if (error.Length > 0)
            {
                Console.WriteLine(error);
                return false;
            }

            // nothing wrong, so do the action, output result and return true
            int roll = rng.Next(1, 21);

            if (roll == 3)
            {
                Console.WriteLine("The fireball misses " + pTarget._Name + " completely!");
            }
            else if (roll < 7)
            {
                Console.WriteLine("The fireball grazes " + pTarget._Name + "'s limb dealing 1 damage.");
                pTarget._Health -= 1;
            }
            else if (roll < 17)
            {
                Console.WriteLine("The fireball hits " + pTarget._Name + "'s  torso dealing 2 damage!");
                _Energy++;
            }
            else
            {
                Console.WriteLine("The fireball hits " + pTarget._Name + "'s  head dealing 3 damage!");
                pTarget._Health -= 3;
            }

            _Allied = null;
            return true;
        }
    }
}
