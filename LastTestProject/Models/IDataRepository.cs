namespace LastTestProject.Models;

public interface IDataRepository
{
    public IEnumerable<Car> GetCars();

    void AddCar(Car car);

    void DeleteCar (Car car);

    void UpdateCar(Car car);


}