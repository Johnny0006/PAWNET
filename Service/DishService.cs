using Microsoft.EntityFrameworkCore;
using PAWNET.Data;
using PAWNET.Model;

namespace PAWNET.Service
{
    public class DishService : IDishService
    {
        private readonly AppDbContext _appDbContext;

        public DishService(AppDbContext dbContext)
        {
            _appDbContext = dbContext;
        }

        public void Add(Dish dish)
        {
            _appDbContext.Dishes.Add(dish);
            _appDbContext.SaveChanges();
        }

        public void Delete(int id)
        {
            var dish = _appDbContext.Dishes.Find(id);
            if (dish != null)
            {
                _appDbContext.Dishes.Remove(dish);
                _appDbContext.SaveChanges();
            }
        }

        public IEnumerable<Dish> GetAll()
        {
            return _appDbContext.Dishes.ToList();
        }

        public Dish GetById(int id)
        {
            return _appDbContext.Dishes.FirstOrDefault(d => d.Id == id);
        }

        public void Update(Dish dish)
        {
            _appDbContext.Entry(dish).State = EntityState.Modified;
            _appDbContext.SaveChanges();
        }
    }
}
