namespace WorkoutApp.Services;
public class SetService
{
    static SetService _instance;
    public static SetService Instance
    {
        get
        {
            _instance = new SetService();
            return _instance;
        }
    }
    public List<Set> GetProducts()
    {
        return new List<Set> 
        { 
            new Set()
            {
                ProductId=1010, 
                ProductType="Coffee",
                ProductName="Chocolate Frappuccino", 
                ProductImgUrl="chocolate_frappuccino.png",
                ProductImgBackground=Color.FromHex("#F3F1ED"),
                ProductIsFav=true,
                ProductPrice=20.00,
                ProductBasePrice=20.00,
                ProductSizeType="Tall",
                ProductDescription="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Etiam at mi vitae augue feugiat scelerisque in a eros."
            },
            new Set()
            {
                ProductId=1011,
                ProductType="Tea",
                ProductName="Tea Frappuccino",
                ProductImgUrl="tea_frappuccino.png",
                ProductImgBackground= Color.FromHex("#F5F9E0"),
                ProductIsFav=false,
                ProductPrice=30.00,
                ProductBasePrice=30.00,
                ProductSizeType="Tall",
                ProductDescription="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Etiam at mi vitae augue feugiat scelerisque in a eros."
            }
        };
    }
}
