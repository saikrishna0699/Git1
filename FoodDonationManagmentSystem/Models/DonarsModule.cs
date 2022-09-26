using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FoodDonationManagmentSystem.Models
{
    public class DonarsModule
    {
        [Key]
        public int DonarId { get; set; }
        public string DonarName { get; set; }
        public string DonarCity { get; set; }
        public int PhNo { get; set; }
        

    }
}
