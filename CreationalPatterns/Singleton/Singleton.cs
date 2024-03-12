namespace CreationalPatterns;

public class Singleton
{
    private static Singleton? instance;

    private string version;

    public Singleton(string version)
    {
        this.version = version;
    }

    public static Singleton getInstance(string version) => instance ??= new(version);

    public string GetVersion() => version;
}