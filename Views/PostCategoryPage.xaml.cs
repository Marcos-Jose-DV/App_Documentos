using AppDocuments.Data;
using AppDocuments.Model;
using CommunityToolkit.Mvvm.Messaging;
using Microsoft.Maui.Animations;

namespace AppDocuments.Views;

public partial class PostCategoryPage : ContentPage
{
    private readonly ICategoryRepository _categoryRepository;
    public PostCategoryPage(ICategoryRepository categoryRepository)
    {
        InitializeComponent();
        _categoryRepository = categoryRepository;
    }

    private async void BackPage(object sender, EventArgs e)
    {
        bool alert = await DisplayAlert("Salvar", "Deseja salvar as Alterações?", "Sim", "Nâo");
     
        if (alert)
        {
            PostCategory();
        }

        await Navigation.PopModalAsync();
    }

    private void PostCategory()
    {
        Category category = new()
        {
            Id = Guid.NewGuid(),
            Name = CategoryName.Text,
        };
        category.Components = new()
            {
            new Component
                {
                    Id = Guid.NewGuid(),
                    Title = ComponentTitle.Text,
                    Description = ComponentDescription.Text,
                    CategoryId = category.Id
                }
            };

        _categoryRepository.PostCategories(category);

        WeakReferenceMessenger.Default.Send<string>(string.Empty);
    }
}