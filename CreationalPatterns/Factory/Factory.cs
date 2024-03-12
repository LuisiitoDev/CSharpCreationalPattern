namespace CreationalPatterns;

public class Factory
{
    public static BaseCar CreateFactory(FactoryType type) => type switch
    {
        FactoryType.MASTODON => new MastodonCar(),
        FactoryType.RHYNO => new RhinoCar(),
        _ => throw new ArgumentException("Invalid factory type"),
    };

    public enum FactoryType
    {
        MASTODON,
        RHYNO
    }

}

public abstract class BaseCar
{
    public virtual void ShowCost()
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
    public virtual BaseCar MakeCar()
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
