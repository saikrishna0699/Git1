using FoodDonationManagmentSystem.Data.Interface;
using FoodDonationManagmentSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodDonationManagmentSystem.Data.Repositories
{
    public class SchoolModuleRepository : ISchoolModuleRepository
    {
        private readonly DonarDbContext _context;
        public SchoolModuleRepository(DonarDbContext context)
        {
            _context = context;
        }
        public List<DonarsModule> Get()
        {
            var list = _context.Donars.ToList();
            return list;
        }
        public DonarsModule Post(DonarsModule schoolmodule)
        {
            _context.Donars.AddAsync(schoolmodule);
            _context.SaveChangesAsync();
            return schoolmodule;

        }
        public DonarsModule Put(DonarsModule schoolmodule)
        {
            var DonarToEdit = _context.Donars.Where(x =>x.DonarId == schoolmodule.DonarId).FirstOrDefault();
            DonarToEdit.DonarName = schoolmodule.DonarName;
            DonarToEdit.DonarCity = schoolmodule.DonarCity;
            DonarToEdit.PhNo = schoolmodule.PhNo;
            _context.SaveChanges();
            return DonarToEdit;
        }
        public DonarsModule Delete(int id)
        {
            var Donar = _context.Donars.Where(x => x.DonarId == id).FirstOrDefault();
            _context.Donars.Remove(Donar);
            _context.SaveChanges();
            return Donar;
               
        }

    }
}
