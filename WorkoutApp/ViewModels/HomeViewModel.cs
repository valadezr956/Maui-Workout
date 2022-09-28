using WorkoutApp.Models;

namespace WorkoutApp.ViewModels;

[INotifyPropertyChanged]
public partial class HomeViewModel : BaseViewModel
{
    [ObservableProperty]
    private ObservableCollection<Product> _products;


    public string[] Categories { get; set; }

    public override Task Initialize()
    {
        Products = new ObservableCollection<Product>(ProductService.Instance.GetProducts());
        return Task.CompletedTask;
    }

    public override Task Stop()
    {
        return Task.CompletedTask;
    }
}