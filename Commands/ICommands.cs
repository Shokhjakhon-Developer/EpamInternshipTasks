namespace ObjectOrientedDesignPrinciples.Commands;

public interface ICommands
{
    //This method will return total number of brands
    public int NumOfBrands();
    //This method will return total number of cars in all brands combined
    public int TotalCarNum();
    //This method will return average price of cars within all brands
    public double AveragePrice();
    //This method will return average price of cars by brand
    public double AveragePriceByBrand(string str);
}