public sealed class Singleton_builder //паттерн одиночка
{
  public string name;
  private Singleton_builder() { name = "Строитель"; }

  private static readonly object locker = new object();
  private static Singleton_builder instance = null;

  public static Singleton_builder Instance
  {
    get
    {
      lock (locker)
      {
        if (instance == null)
        {
          instance = new Singleton_builder();
        }
        else
        {
          Console.Write("Строитель уже существует: ");
        }
        return instance;
      }
    }
  }
}

public class Facade //паттерн фасад
{
  Design Design;
  Construction Construction;
  Finish Finishing;

  public Facade()
  {
    Design = new Design();
    Construction = new Construction();
    Finishing = new Finish();
  }

  public void Var1()
  {
    Console.WriteLine("Вариант 1: Полный процесс строительства");
    Design.Designing();
    Construction.Constructioning();
    Finishing.Finishing();
  }
  public void Var2()
  {
    Console.WriteLine("Вариант 2: Частичный процесс строительства");
    Construction.Constructioning();
    Finishing.Finishing();
  }
}

class Design
{
  public void Designing()
  {
    Console.WriteLine("Проектирование");
  }
}

class Construction
{
  public void Constructioning()
  {
    Console.WriteLine("Строительство");
  }
}

class Finish
{
  public void Finishing()
  {
    Console.WriteLine("Отделка");
  }
}

abstract class Worker //паттерн шаблонный метод
{
  public void Work()
  {
    Begin();
    Works();
    End();
  }
  public abstract void Begin();
  public abstract void Works();
  public abstract void End();
}

class Painter : Worker
{
  public override void Begin()
  {
    Console.WriteLine("Начинает покраску");
  }

  public override void Works()
  {
    Console.WriteLine("Красит");
  }

  public override void End()
  {
    Console.WriteLine("Закончил покраску");
  }
}

class Installer : Worker
{
  public override void Begin()
  {
    Console.WriteLine("Начинает монтаж");
  }

  public override void Works()
  {
    Console.WriteLine("Монтирует");
  }

  public override void End()
  {
    Console.WriteLine("Заканчивает монтаж");
  }
}

class House
{
  public void House_build()
  {
    Console.WriteLine("\t\tПаттерн: Одиночка");
    Singleton_builder builder = Singleton_builder.Instance;
    Console.WriteLine(builder.name);
    Singleton_builder builder1 = Singleton_builder.Instance;
    Console.WriteLine(builder1.name);

    Console.WriteLine("\n\t\tПаттерн: Фасад");
    Facade facade = new Facade();
    facade.Var1();
    facade.Var2();

    Console.WriteLine("\n\t\tПаттерн: Шаблонный метод");
    Painter painter = new Painter();
    painter.Work();
    Installer installer = new Installer();
    installer.Work();
  }
}

class Program
{
  static void Main(string[] args)
  {
    House house = new House();
    house.House_build();
  }
}