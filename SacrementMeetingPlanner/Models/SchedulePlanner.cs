using Microsoft.Extensions.Options;
using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;

namespace SacramentMeetingPlanner.Models
{
    public class SchedulePlanner
    {
        public int Id { get; set; }
        public string? ConductingLeader { get; set; }

        [DataType(DataType.Date)]
        public string? OpeningSong { get; set; }
        public int SacramentHymn { get; set; }
        public string? SacramentHymnTitle { get; set; }
        public int IntermediateNumber { get; set; }
        public string? IntermediateNumberTitle { get; set; }
        public string? OpeningPrayer { get; set; }
        public int ClosingHymn { get; set; }
        public string? ClosingHymnTitle { get; set; }
        public string? ClosingPrayer { get; set; }
        public int NumberOfSpeakers { get; set; }
        public string? SpeakerSubjects { get; set; }
    }
}
