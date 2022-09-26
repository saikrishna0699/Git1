using FoodDonationManagmentSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodDonationManagmentSystem.Data.Interface
{
   public  interface ISchoolModuleRepository  
    {
        List<DonarsModule> Get();
    DonarsModule Post(DonarsModule donar);
        DonarsModule Put(DonarsModule donar);
        DonarsModule Delete(int DonarId);


    }
}
