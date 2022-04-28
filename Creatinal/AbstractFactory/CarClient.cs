
namespace Creational.AbstractFactory
{
	public class CarClient
	{
        private readonly ISuvCar suvCar;
        private readonly IClassicCar classicCar;

        public CarClient(ICarFactory factory)
        {
			suvCar = factory.SuvCarInstance();
			classicCar = factory.ClassicCarInstance();
		}

        public string GetSuvCarModel()
        {
            return suvCar.GetCarModel();
        }

        public string GetClassicCarModel()
        {
            return classicCar.GetCarModel();
        }
    }


}

