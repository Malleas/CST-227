using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    public class SuperHeroList
    {
        public List<SuperHero> listOfHeros { get; set; }

        public SuperHeroList (SuperHero hero)
        {
            listOfHeros.Add(hero);
        }

        public SuperHeroList()
        {
            listOfHeros = new List<SuperHero>();
        }
    }
}
