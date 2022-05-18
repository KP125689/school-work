using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerosQuest
{
    public class Ranger : Character
    {
        static Random rng = new Random();
        private int _CurrentArrows;
        private int _TotalArrows;

        public Ranger(string pType, string pName) : base(pType, pName)
        {
            _MaxHealth = rng.Next(10, 15);
            _MaxEnergy = rng.Next(4, 9);
            _EnergyPotions = rng.Next(1, 4);
            _HealthPotions = rng.Next(1, 4);
            _MaxNumberOfArrows = rng.Next(4, 9);
        }
    }

    if (_CharacterType == "ranger")
    {
        output += _NumberOfArrows + "/" + _MaxNumberOfArrows + " arrows.";
    }
    else if (_CharacterType == "barbarian")
    {
        output += _Rage + "/" + _MaxRage + " rage.";
    }

    public bool FireBow(Character pTarget)
    {
        // should never happen, so throw an exception
        if (_CharacterType != "ranger")
        {
            throw new Exception(_CharacterType + " cannot use a bow.");
        }

        // error string used to detect is anything is wrong
        string error = "";

        if (_NumberOfArrows == 0)
        {
            error += "You have no arrows to fire!\r\n";
        }

        if (_Energy < 1)
        {
            error += "You need at least 1 energy to use a bow.\r\n";
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
        _NumberOfArrows--;
        _Energy--;
        Console.WriteLine(_Name + " releases a deadly arrow towards the " + pTarget._Name);

        int roll = rng.Next(1, 21);

        if (roll < 4)
        {
            Console.WriteLine("The arrow misses " + pTarget._Name + " completely!");
        }
        else if (roll < 7)
        {
            Console.WriteLine("The arrow grazes " + pTarget._Name + "'s limb dealing 1 damage.");
            pTarget._Health -= 1;
        }
        else if (roll < 13)
        {
            Console.WriteLine("The arrow hits " + pTarget._Name + "'s  torso dealing 2 damage!");
            Console.WriteLine("You regain 1 energy.");
            pTarget._Health -= 2;
            _Energy++;
        }
        else
        {
            Console.WriteLine("The arrow hits " + pTarget._Name + "'s  head dealing 3 damage!");
            Console.WriteLine("You regain 2 energy.");
            _Energy += 2;
            pTarget._Health -= 3;
        }

        _Allied = null;
        return true;
    }

    public bool PickUpArrows()
    {
        // should never happen, so throw an exception
        if (_CharacterType != "ranger")
        {
            throw new Exception(_CharacterType + " cannot pick up arrows.");
        }

        // error string used to detect is anything is wrong
        string error = "";

        if (_Energy < 1)
        {
            error += "You need at least 1 energy to pick up arrows.";
        }

        // If anything is wrong output the error(s) and return false
        if (error.Length > 0)
        {
            Console.WriteLine(error);
            return false;
        }

        // nothing wrong, so do the action, output result and return true
        _Energy--;

        int minimumArrows = Math.Min(2, _MaxNumberOfArrows - _NumberOfArrows);
        int arrowsCollected = rng.Next(minimumArrows, _MaxNumberOfArrows - _NumberOfArrows);
        _NumberOfArrows += arrowsCollected;
        Console.WriteLine(_Name + " the ranger picked up " + arrowsCollected + " and now has " + _NumberOfArrows + "/" + _MaxNumberOfArrows);
        return true;
    }
}
