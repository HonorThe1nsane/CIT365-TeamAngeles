using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace SaramentMeetingPlanner.Models
{
    public class Planner
    {
        public int Id { get; set; }

        [DataType(DataType.Date)]
        public DateTime Date { get; set; }

        [DisplayName("Conducting")]
        public string? ConductingLeader { get; set; }

        [DisplayName("Opening Hymn Title")]
        public string? OpeningSongTitle { get; set; }

        [DisplayName("Opening Hymn Number")]
        public string? OpeningSongNum { get; set; }

        [DisplayName("Opening Prayer")]
        public string? OpeningPrayer { get; set; }

        [DisplayName("Sacrament Hymn Title")]
        public string? SacramentHymnTitle { get; set; }

        [DisplayName("Sacrament Hymn Number")]
        public int SacramentHymn { get; set; }

        [DisplayName("Intermediate Hymn Title")]
        public string? IntermediateTitle { get; set; }

        [DisplayName("Intermediate Hymn Number")]
        public int IntermediateNum { get; set; }

        [DisplayName("Closing Hymn Title")]
        public string? ClosingHymnTitle { get; set; }

        [DisplayName("Closing Hymn Number")]
        public int ClosingHymnNum { get; set; }

        [DisplayName("Closing Prayer")]
        public string? ClosingPrayer { get; set; }

        [DisplayName("Number of Speakers")]
        public int NumberOfSpeakers { get; set; }

        [DisplayName("Speaker Subjects")]
        public string? SpeakerSubjects { get; set; }
    }
}