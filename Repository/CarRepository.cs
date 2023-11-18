using Autoservice_Back;
using Autoservice_Back.Interfaces;
using Autoservice_Back.Models;

namespace Autoservice_Back.Repository
{
    public class CarRepository : ICars
    {
        private readonly AppDBContext _dbContext;

        public CarRepository(AppDBContext dbContext)
        {
            _dbContext = dbContext;
        }
        public void AddCar(Car car)
        {
            _dbContext.Cars.Add(car);
          _dbContext.SaveChanges();
        }

        //public  Car GetCar(int id)
        //{
        //    return _dbContext.Cars.Where(car => car.Id == id).FirstOrDefault();
        //}
    }
}
