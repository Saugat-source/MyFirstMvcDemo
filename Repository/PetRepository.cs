using System.Collections.Generic;
using System.Linq;
using mvcdemo.Data;
using mvcdemo.Models;

namespace mvcdemo.Repository{
    public class PetRepository : IPetRepository
    {
        private ApplicationDbContext _context;

        public PetRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public void Create(Pet pet)
        {
            _context.pets.Add(pet);
            _context.SaveChanges();
        }

      

        public void Delete(Pet pet)
        {
           _context.pets.Remove(pet);
           _context.SaveChanges();
        }

        public void Edit(Pet pet)
        {
            _context.pets.Update(pet);
            _context.SaveChanges();
        }

        public List<Pet> GetAllPets()
        {
             return _context.pets.ToList();
        }

        public Pet GetSinglePet(int id)
        {
            var pet = _context.pets.FirstOrDefault(p=>p.Id ==id);
            return pet;
        }
    }
}