using AppDocuments.Data;
using AppDocuments.Model;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Messaging;
using System.ComponentModel;
using Component = AppDocuments.Model.Component;

namespace AppDocuments.ViewModels;

public partial class MainViewModel : ObservableObject
{

    private readonly ICategoryRepository _categoryRepository;

    [ObservableProperty]
    List<Category> _categories;
    [ObservableProperty]
    List<Component> _components;
   
    [ObservableProperty]
    string _title, _description;
    [ObservableProperty]
    Guid _id;

    public MainViewModel(ICategoryRepository categoryRepository, IComponentRepositoty componentRepositoty)
    {
        _categoryRepository = categoryRepository;

        //_categoryRepository.DeleteAll();
        //_componentRepositoty.DeleteAll();

        //_categoryRepository.PostAll(categories);
        //_categoryRepository.PostCategories(categories);
        //_categoryRepository.PostCategories(categories2);

        Id = _categoryRepository.GetCategories().FirstOrDefault().Components.FirstOrDefault().Id;
        Title = _categoryRepository.GetCategories().FirstOrDefault().Components.FirstOrDefault().Title ;
        Description = _categoryRepository.GetCategories().FirstOrDefault().Components.FirstOrDefault().Description;
        ListCategories();
        WeakReferenceMessenger.Default.Register<string>(this, (e, msg) =>
        {
            ListCategories();
        });
    }
    private void ListCategories()
    {
        Categories =  _categoryRepository.GetCategories(); ;
    }
}
