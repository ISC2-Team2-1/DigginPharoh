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
                    {"west", "West" }
        };

        public static Dictionary<string, string> DepthFilterValues =>
        new Dictionary<string, string>
        {
                            {"0", "0-.49" },
                            {".5", ".50-.99" },
                            {"1", "1.00-1.49" },
                            {"1.5", "1.50-1.99" },
                            {"2", "2.00-2.49" },
                            {"2.5", "2.50 and Up" }
        };

        public static Dictionary<string, string> SexGeFilterValues =>
        new Dictionary<string, string>
        {
                            {"Female", "Female" },
                            {"Male", "Male" },                            
                            {"SubAdult", "SubAdult" },
                            {"Unknown", "Unknown" }
        };

        public static Dictionary<string, string> GenderFilterValues =>
        new Dictionary<string, string>
        {
                            {"Female", "Female" },
                            {"Male", "Male" },
                            {"Undetermined", "Undetermined" },
        };
        public static Dictionary<string, string> PreservFilterValues =>
        new Dictionary<string, string>
        {
                                    {"Excellent (V)", "Excellent (V)" },
                                    {"Good (IV)", "Good (IV)" },
                                    {"Average (III)", "Average (III)" },
                                    {"Fair (II)", "Fair (II)" },
                                    {"Poor (I)", "Poor (I)" },
                                    {"UnClassed", "UnClassed" },
        };

        public bool IsEast => HeadDirection.ToLower() == "east";
        public bool IsWest => HeadDirection.ToLower() == "west";


    }
}
