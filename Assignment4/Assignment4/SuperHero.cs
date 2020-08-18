using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    public class SuperHero
    {
        
        public string Name { get; set; }
        public ArrayList Skills { get; set; }
        public string OfficeLocation { get; set; }
        public string PreferredTravel { get; set; }
        public DateTime[] ImportantDates { get; set; }
        public decimal YearsExperience { get; set; }
        public string CapeColor { get; set; }
        public int VillainPotential { get; set; }
        public int[] StatsArray { get; set; }
        public string PortraitFileName { get; set; }

    public SuperHero(string name, ArrayList skills, string officeLocation, string preferredTravel, DateTime[] importantDatas, decimal yearsExperience,
            string capeColor, int villainPotential, int[] statsArray, string portraitFileName)
        {
            Name = name;
            Skills = skills;
            OfficeLocation = officeLocation;
            PreferredTravel = preferredTravel;
            ImportantDates = importantDatas;
            YearsExperience = yearsExperience;
            CapeColor = capeColor;
            VillainPotential = villainPotential;
            StatsArray = statsArray;
            PortraitFileName = portraitFileName;
        }

        public SuperHero()
        {
            Name = "";
            Skills = new ArrayList();
            OfficeLocation = "";
            PreferredTravel = "";
            ImportantDates = new DateTime[3];
            YearsExperience = 0;
            CapeColor = "";
            VillainPotential = 0;
            StatsArray = new int[3];
            PortraitFileName = "";
        }
    }
}
