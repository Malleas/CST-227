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
        
        private string Name { get; set; }
        private ArrayList Skills { get; set; }
        private string OfficeLocation { get; set; }
        private ArrayList PreferredTravel { get; set; }
        private ArrayList ImportantDates { get; set; }
        private decimal YearsExperience { get; set; }
        private string CapeColor { get; set; }
        private int VillainPotential { get; set; }
        private int[] StatsArray { get; set; }
        private string PortraitFileName { get; set; }

    public SuperHero(string name, ArrayList skills, string officeLocation, ArrayList preferredTravel, ArrayList importantDatas, decimal yearsExperience,
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
            PreferredTravel = new ArrayList();
            ImportantDates = new ArrayList();
            YearsExperience = 0;
            CapeColor = "";
            VillainPotential = 0;
            StatsArray = new int[3];
            PortraitFileName = "";
        }
    }
}
