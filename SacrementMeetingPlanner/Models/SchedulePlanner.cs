using Microsoft.Extensions.Options;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;

namespace SacramentMeetingPlanner.Models
{
    public class SchedulePlanner
    {
        public int Id { get; set; }
        [DisplayName("Conducting")]
        
        public string? ConductingLeader { get; set; }

        [DataType(DataType.Date)]
        [DisplayName("Opening Song")]
        public string? OpeningSong { get; set; }

        [DisplayName("Sacrament Hymn")]
        public int SacramentHymn { get; set; }
        [DisplayName("Title")]
        public string? SacramentHymnTitle { get; set; }
        [DisplayName("Intermediate Number")]
        public int IntermediateNumber { get; set; }
        [DisplayName("Title")]
        public string? IntermediateNumberTitle { get; set; }
        [DisplayName("Opening Prayer")]
        public string? OpeningPrayer { get; set; }
        [DisplayName("Closing Hymn")]
        public int ClosingHymn { get; set; }
        [DisplayName("Title")]
        public string? ClosingHymnTitle { get; set; }
        [DisplayName("Closing Prayer")]
        public string? ClosingPrayer { get; set; }
        [DisplayName("Number of Speakers")]
        public int NumberOfSpeakers { get; set; }
        [DisplayName("Speaker Subjects")]
        public string? SpeakerSubjects { get; set; }
    }
}
