using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SecureCodeBenchemarkApp
{
    public class FileManager
    {
        public List<Creature> LoadCreatures()
        {
            try
            {
                List<Creature> creaturesList = new List<Creature>();

                StreamReader sr = new StreamReader("Creatures.txt");

                while (!sr.EndOfStream)
                {
                    string temp = sr.ReadLine();
                    string[] values = temp.Split(',');

                    Creature c = new Creature();
                    c.CreatureName = values[0];
                    c.Age = int.Parse(values[1]);
                    c.Owner = values[2];

                    creaturesList.Add(c);
                }

                sr.Dispose();
                return creaturesList;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public bool SaveCreatures(Creature c, string fileName)
        {
            try
            {
                StreamWriter sw = new StreamWriter(fileName);

                sw.WriteLine("CREATUREDETAILS");
                sw.WriteLine("Creature Name: " + c.CreatureName);
                sw.WriteLine("Creature Age: " + c.Age);
                sw.WriteLine("Creature Owner: " + c.Owner);

                sw.Dispose();
                return true;
            }

            catch (Exception)
            {
                return false;
            }
        }
    }
}
