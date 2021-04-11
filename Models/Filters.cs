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
            FilterString = filterstring ?? "all-999-all-all-all";
            string[] filters = FilterString.Split('-');
            HeadDirection = filters[0];
            Depth = float.Parse(filters[1]);
            SexGE = filters[2];
            GenderBodCol = filters[3];
            Preservation = filters[4];

        }

        public string FilterString { get; }
        public string HeadDirection { get; }
        public float Depth { get; }
        public string SexGE { get; }
        public string GenderBodCol { get; }
        public string Preservation { get;}


        public bool HasDirection => HeadDirection.ToLower() != "all";
        public bool HasDepth => Depth != 999;
        public bool HasSexGe => SexGE.ToLower() != "all";
        public bool HasGenderBodCol => GenderBodCol.ToLower() != "all";
        public bool HasPreservation => Preservation.ToLower() != "all";

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
