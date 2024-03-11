namespace CreationalPatterns;

public abstract class BaseCar
{
    public void ShowCost()
    {
        throw new NotImplementedException("Method no implemented");
    }
}

public class MastodonCar : BaseCar
{
    public override void ShowCost()
    {
        Console.WriteLine("The cost of MastodonCar is: $1000");
    }
}

public class RhinoCar : BaseCar
{
    public override void ShowCost()
    {
        Console.WriteLine("The cost of RhinoCar is: $2000");
    }
}

public abstract class CarFactory
{
    public BaseCar MakeCar()
    {
        throw new NotImplementedException("Method no implemented");
    }
}

public class MastodonCarFactory : CarFactory
{
    public override BaseCar MakeCar()
    {
        return new MastodonCar();
    }
}

public class RhinoCarFactory : CarFactory
{
    public override BaseCar MakeCar()
    {
        return new RhinoCar();
    }
}
