using WorkoutApp.Models;

namespace WorkoutApp.ViewModels;
public partial class HomeViewModel : BaseViewModel
{
    public override Task Initialize()
    {
        CategorySelectedValue = "All";
        Categories = Enum.GetNames(typeof(CoffeCategory)).Cast<string>().Select(x => x.ToString()).ToArray();
        Products = new ObservableCollection<Set>(ProductService.Instance.GetProducts());
        return Task.CompletedTask;
    }

    public override Task Stop()
    {
        return Task.CompletedTask;
    }
}