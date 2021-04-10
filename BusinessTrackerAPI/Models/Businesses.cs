using System.ComponentModel.DataAnnotations;

namespace BusinessTrackerAPI.Models
{
    public class Business
    {
        public int BusinessId { get; set; }

        public string BusinessName { get; set; }

        public string BusinessType { get; set; }

        public int BusinessAge { get; set; }

        public string BusinessSeating { get; set; }
    }
}