namespace Creational.AbstractFactory
{ 

    public interface ISuvCar
    {
        string GetCarModel();
    }

    public interface IClassicCar
    {
        string GetCarModel();
    }

    public interface ICarFactory
    {
        ISuvCar SuvCarInstance();
        IClassicCar ClassicCarInstance();
    }

    public class VW : ICarFactory
    {
        public IClassicCar ClassicCarInstance()
        {
            return new Polo();
        }

        public ISuvCar SuvCarInstance()
        {
            return new Tiguan();
        }
    }

    public class Mercedes : ICarFactory
    {
        public IClassicCar ClassicCarInstance()
        {
            return new C200();
        }

        public ISuvCar SuvCarInstance()
        {
            return new G63();
        }
    }

    public class C200 : IClassicCar
    {
        public string GetCarModel()
        {
            return "Mercedes marka C200 modeldir.";
        }
    }

    public class Tiguan : ISuvCar
    {
        public string GetCarModel()
        {
            return "VW marka Tiguan modeldir.";
        }
    }

    public class Polo : IClassicCar
    {
        public string GetCarModel()
        {
            return "VW marka Polo modeldir.";
        }
    }

    public class G63 : ISuvCar
    {
        public string GetCarModel()
        {
            return "Mercedes marka G63 modeldir.";
        }
    }

    
}