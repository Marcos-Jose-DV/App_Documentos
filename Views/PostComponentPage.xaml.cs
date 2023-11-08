using AppDocuments.Data;
using AppDocuments.Model;
using CommunityToolkit.Mvvm.Messaging;

namespace AppDocuments.Views;

public partial class PostComponentPage : ContentPage
{
    private readonly ICategoryRepository _categoryRepository;
    private readonly Category _category;

    public PostComponentPage(Category category, ICategoryRepository categoryRepository)
    {
        InitializeComponent();
        _category = category;
        _categoryRepository = categoryRepository;

    }

    private async void BackPage(object sender, EventArgs e)
    {
        bool alert = await DisplayAlert("Autalizar", "Deseja salvar as Alterações?", "Sim", "Nâo");

        if (alert)
        {
            UpdateComponent();
        }
        await Navigation.PopModalAsync();
    }
    private void UpdateComponent()
    {
        Component component = new()
        {
            Id = Guid.NewGuid(),
            Title = Title.Text,
            Description = Description.Text,
            CategoryId = _category.Id,
        };

        _categoryRepository.PostComponents(component);
        WeakReferenceMessenger.Default.Send<string>(string.Empty);
    }
}