namespace LastTestProject.Models;

public class EFDataRepository : IDataRepository
{
    public EFDatabaseContext context;

    public EFDataRepository(EFDatabaseContext context)
    {
        this.context = context;
    }

    public IEnumerable<Car> GetCars()
    {
        return context.Cars;
    }

    public void AddCar(Car car)
    {
        context.Cars.Add(car);
        context.SaveChanges();
    }

    public void DeleteCar(Car car)
    {
        context.Cars.Remove(car);
        context.SaveChanges();
    }

    public void UpdateCar(Car car)
    {
        context.Cars.Update(car);
        context.SaveChanges();
    }
}