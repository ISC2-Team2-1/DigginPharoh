using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DigginPharoh.Models
{
    public class Filters
    {
        public Filters(string filterstring)
        {
            FilterString = filterstring ?? "all";
            string[] filters = FilterString.Split('-');
            HeadDirection = filters[0];
        }

        public string FilterString { get; }
        public string HeadDirection { get; }

        public bool HasDirection => HeadDirection.ToLower() != "all";

        public static Dictionary<string, string> HeadDirFilterValues =>
        new Dictionary<string, string>
        {
                    {"east", "East" },
                    {"west", "West" },
        };

        public bool IsEast => HeadDirection.ToLower() == "east";
        public bool IsWest => HeadDirection.ToLower() == "west";


    }
}
