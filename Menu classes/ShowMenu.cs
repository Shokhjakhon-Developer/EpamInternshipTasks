using ObjectOrientedDesignPrinciples.Data_class;

namespace ObjectOrientedDesignPrinciples.Menu_classes;

public class ShowMenu
{
    private List<Data> _data;
    private  Menu _menu;

    private ShowMenu (){}

    private static ShowMenu _instance = null!;

    public static ShowMenu GetInstance()
    {
        if (_instance == null)
        {
            _instance = new ShowMenu();
        }

        return _instance;
    }
    
    
    public void Init()
    {
        _data = new List<Data>();
        _menu = new Menu(_data);
        _menu.InitialMenu();
        _menu.MainMenu();
    }
}