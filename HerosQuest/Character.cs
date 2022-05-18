using System;


namespace HerosQuest
{


    public class Character
    {
        static Random rng = new Random();

        public string _Name;
        public int _Health;
        protected int _MaxHealth;
        protected int _Energy;
        protected int _MaxEnergy;
        protected int _EnergyPotions;
        protected int _HealthPotions;
        protected string _CharacterType;
        protected int _NumberOfArrows;
        public Character _Allied;

        public int Health
        {
            get { return _Health; }
            set { _Health = value; }
        }

        public int Energy
        {
            get { return _Energy; }
            set { _Energy = value; }
        }

        public int MaxEnergy
        {
            get { return _MaxEnergy; }
            protected set { _MaxEnergy = value; }
        }

        public int MaxHealth
        {
            get { return _MaxHealth; }
            protected set { _MaxHealth = value; }
        }

        public int HealthPotions
        {
            get { return _HealthPotions; }

        }

        public int EnergyPotions
        {
            get { return _EnergyPotions; }

        }

        public string Name
        {
            get { return _Name; }
            protected set { _Name = value; }
         

        }

        public string CharacterType
        {
            get { return _CharacterType; }
        }
        public Character Allied
        {
            get { return _Allied; }
        }


        public Character(string pType, string pName)
        {
            _Name = pName;
            _CharacterType = pType;
        }

        public bool TakeEnergyPotion()
        {
            // error string used to detect is anything is wrong
            string error = "";

            if (_EnergyPotions < 1)
            {
                error += "You do not have any energy potions left.\r\n";
            }

            if (_Energy < 1)
            {
                error += "You need at least 1 energy to use a potion.\r\n";
            }

            // If anything is wrong output the error(s) and return false
            if (error.Length > 0)
            {
                Console.WriteLine(error);
                return false;
            }

            // nothing wrong, so do the action, output result and return true
            _Energy--;
            _Energy += _MaxEnergy / 2;
            Console.WriteLine("You take an energy potion.");
            Console.WriteLine("Your energy is now " + _Energy);
            return true;
        }

        public bool TakeHealthPotion()
        {
            // error string used to detect is anything is wrong
            string error = "";

            if (_HealthPotions < 1)
            {
                error += "You do not have any health potions left.\r\n";
            }

            if (_Energy < 1)
            {
                error += "You need at least 1 energy to use a potion.\r\n";
            }

            // If anything is wrong output the error(s) and return false
            if (error.Length > 0)
            {
                Console.WriteLine(error);
                return false;
            }

            // nothing wrong, so do the action, output result and return true
            _Energy--;
            _Health += _MaxHealth / 2;
            Console.WriteLine("You take a health potion.");
            Console.WriteLine("Your health is now " + _Health);
            return true;
        }

        public void Rest()
        {
            int energy = 3 + rng.Next(4);
            int health = 3 + rng.Next(4);
            _Energy += (energy);
            _Health += (health);
            // !! use an if statement to make sure energy is never greater than max energy
            // !! if it is more then set it to max and display message saying your health is at max

            Console.WriteLine("You are well rested.");
            Console.WriteLine("Your energy has increased by {0} to {1} / {2}.", energy, _Energy, _MaxEnergy);
            Console.WriteLine("Your health has increased by {0} to {1} / {2}.", health, _Health, _MaxHealth);
        }

        // Ranger stuff used to be here !!!

       
        // Swing axe used to be here !!!

        // mage stuff used to be here !!!

  

        /// <summary>
        /// Outputs the state of this instance of character to the console
        /// </summary>
        public void OutputState()
        {
            string output = _Name + " the " + _CharacterType + ":" + _Health + "/" + _MaxHealth + " Health. " + _Energy + "/" + _MaxEnergy + " Energy. ";
            if (_CharacterType == "ranger")
            {
                output += _NumberOfArrows + "/" + _MaxNumberOfArrows + " arrows.";
            }
            else if (_CharacterType == "barbarian")
            {
                output += _Rage + "/" + _MaxRage + " rage.";
            }

            output += "\r\n" + _Name + " has " + _HealthPotions + " health potions and " + _EnergyPotions + " energy potions.\r\n";

            if (_Allied != null)
            {
                output += _Name + " is currently allied with " + _Allied._Name;
            }

            Console.WriteLine(output);
        }

        public virtual bool FireBow(Character Barbarian)
        {
            return false;
        }

        public virtual bool SwingAxe(Character Mage)
        {
            return false;
        }

        public virtual bool FireBall(Character Ranger)
        {
            return false;
        }

    } 
}
