namespace ObjectOrientedDesignPrinciples.Data_class;

public class Data
{
    public string BrandName { get; }
    public List<string> Models { get; }
    public int Quantity { get; }
    public List<double> CostPerUnit { get; }

    public Data(string brandName, List<string> models, int quantity, List<double> costPerUnit)
        => (BrandName, Models, Quantity, CostPerUnit) = (brandName, models, quantity, costPerUnit);
}