using System.ComponentModel.DataAnnotations.Schema;

namespace WOASS.Models
{
    [Table("WorkOrders")]
    public class Work
    {
        // Fields

        public int      WorkId          { get; set; }
        public string   OrderDate   { get; set; }
        public bool     Priority    { get; set; }
        public string   WorkType    { get; set; }
        public string   Notes       { get; set; }
        public bool     PayStatus   { get; set; }
        public int      PriceId     { get; set; }
        public int      GearId      { get; set; }
        public int      UserId      { get; set; }

        // Constructors

        // Methods
    }
}
