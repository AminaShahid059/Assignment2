using System.ComponentModel.DataAnnotations;

namespace EveryHourEatsProject.Models
{
    public class Order
    {
        [Key]
        public int id { get; set; }
        public string name { get; set; }
        public int phone { get; set; }
        public string order { get ; set; }
        public string additional { get; set; }
        public string address { get; set; }



    }
}
