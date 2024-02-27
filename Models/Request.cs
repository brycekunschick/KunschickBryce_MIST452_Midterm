using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace KunschickMidterm452.Models
{
    public class Request
    {
        [Key]
        public int RequestId { get; set; }

        public string VIN { get; set; }

        public string PlateNum { get; set; }
        public string VehicleMake { get; set; }
        public string VehicleModel { get; set; }
        public int Mileage { get; set; }
        public string Description { get; set; }

        public int OfficerId { get; set; }
        [ForeignKey("OfficerId")]
        public Officer? Officer { get; set; } //navigational property
    }
}
