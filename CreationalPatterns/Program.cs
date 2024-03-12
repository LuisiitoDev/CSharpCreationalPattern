var singleton1 = Singleton.getInstance("v1");
var singleton2 = Singleton.getInstance("v2");

Console.WriteLine(singleton1 == singleton2); 

Factory.CreateFactory(Factory.FactoryType.MASTODON).ShowCost();
Factory.CreateFactory(Factory.FactoryType.RHYNO).ShowCost();