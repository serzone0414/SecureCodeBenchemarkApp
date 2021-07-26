using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecureCodeBenchemarkApp
{
    class Filter
    {
        public List<Creature> SortAZ(List<Creature> clist)
        {
            clist = clist.OrderBy(x => x.CreatureName).ToList();

            return clist;
        }

        public List<Creature> SortZA(List<Creature> clist)
        {
            clist = (from x in clist
                     orderby x.CreatureName descending
                     select x).ToList();

            return clist;
        }

        public List<Creature> Search (List<Creature> clist, string term)
        {
            List<Creature> results = new List<Creature>();

            foreach (Creature c in clist)
            {
                if (c.CreatureName.ToLower().Contains(term.ToLower()))
                {
                    results.Add(c);
                }
            }

            return results;
        }
    }
}
