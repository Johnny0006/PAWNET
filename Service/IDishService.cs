using PAWNET.Model;

namespace PAWNET.Service
{
    public interface IDishService
    {
        IEnumerable<Dish> GetAll();
        Dish GetById(int id);
        void Add(Dish dish);
        void Update(Dish dish);
        void Delete(int id);
    }
}
