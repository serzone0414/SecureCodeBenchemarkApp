using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecureCodeBenchemarkApp
{
    class Creature
    {
        private string creatureName;
        private int age;
        private string owner;

        public override string ToString()
        {
            return CreatureName;
        }

        public Creature()
        {
            CreatureName = "NA";
            Age = 0;
            Owner = "NA";
        }

        public string CreatureName { get => creatureName; set => creatureName = value; }
        public int Age { get => age; set => age = value; }
        public string Owner { get => owner; set => owner = value; }
    }
}
