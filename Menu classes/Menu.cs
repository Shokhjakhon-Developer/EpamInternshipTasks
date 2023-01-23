using ObjectOrientedDesignPrinciples.Commands;
using ObjectOrientedDesignPrinciples.Data_class;

namespace ObjectOrientedDesignPrinciples.Menu_classes;

public class Menu : ICommands
{
    private readonly List<Data> _data;

    public Menu(List<Data> data) => _data = data;

    public void InitialMenu()
    {
        var brandName = EnterBrandName();
        var carModels = EnterModelOfCars();
        var numOfCars = EnterNumberOfCars();
        var price = EnterPriceForEachUnit();
        _data.Add(new Data(brandName, carModels, numOfCars, price));
    }

    public void MainMenu()
    {
        MenuOptions();
    }


    public int NumOfBrands() => _data.Count;

    public int TotalCarNum()
    {
        int total = 0;
        foreach (var data in _data)
        {
            total += data.Quantity;
        }

        return total;
    }

    public double AveragePrice()
    {
        List<double> prices = new List<double>();
        double total = 0;
        foreach (var data in _data)
        {
            foreach (var num in data.CostPerUnit)
            {
                prices.Add(num);
                total += num;
            }
        }

        return total / prices.Count;
    }

    public double AveragePriceByBrand(string brandName)
    {
        List<double> price = new List<double>();
        foreach (var data in _data)
        {
            if (data.BrandName.Equals(brandName))
            {
                foreach (var num in data.CostPerUnit)
                {
                    price.Add(num);
                }
            }
        }

        return price.Average();
    }

    public string EnterBrandName()
    {
        Console.WriteLine("Enter brand name:");
        var brandName = Convert.ToString(Console.ReadLine())!;
        return brandName;
    }

    public List<string> EnterModelOfCars()
    {
        List<string> models = new List<string>();
        if (models == null) throw new ArgumentNullException(nameof(models));
        Console.WriteLine("Enter models of cars, if you want to stop enter -1");
        while (true)
        {
            var model = Convert.ToString(Console.ReadLine())!;
            if (model.Equals("-1")) break;
            models.Add(model);
        }

        return models;
    }

    public int EnterNumberOfCars()
    {
        Console.WriteLine("Enter number of cars:");
        var quantity = Convert.ToInt32(Console.ReadLine());
        return quantity;
    }

    public List<double> EnterPriceForEachUnit()
    {
        List<double> price = new List<double>();
        Console.WriteLine("Enter price of one unit for each model, enter -1 to stop:");
        while (true)
        {
            var num = Convert.ToDouble(Console.ReadLine());
            if (num < 0) break;
            price.Add(num);
        }

        return price;
    }

    public void MenuOptions()
    {
        bool check = true;
        while (check)
        {
            int num = MenuTextInput();
            switch (num)
            {
                case 1:
                    Console.WriteLine($"Total number of car brand: {NumOfBrands()}");
                    break;
                case 2:
                    Console.WriteLine($"Total number of cars: {TotalCarNum()}");
                    break;
                case 3:
                    Console.WriteLine($"Average price of cars: {AveragePrice()}");
                    break;
                case 4:
                    Console.WriteLine("Enter brand name:");
                    string name = Convert.ToString(Console.ReadLine())!;
                    Console.WriteLine($"Average price of {name} cars: {AveragePriceByBrand(name)}");
                    break;
                case 5:
                    InitialMenu();
                    break;
                default:
                    check = false;
                    break;
            }
        }
    }

    public int MenuTextInput()
    {
        Console.WriteLine(
            "\nEnter 1 to get number of car brands." +
            "\nEnter 2 to get total number of cars." +
            "\nEnter 3 to see average price of cars." +
            "\nEnter 4 and then brand name to see average price in each brand." +
            "\nEnter 5 to add new car brand." +
            "\nEnter 0 to exit");
        var num = Convert.ToInt32(Console.ReadLine());
        return num;
    }
}