using AppDocuments.Data;
using AppDocuments.Model;
using CommunityToolkit.Mvvm.Messaging;

namespace AppDocuments.Views;

public partial class UpdateComponentPage : ContentPage
{
    private readonly ICategoryRepository _categoryRepository;
    private readonly Component _component;
    public UpdateComponentPage(Component component, ICategoryRepository categoryRepository)
    {
        InitializeComponent();
        _categoryRepository = categoryRepository;
        _component = component;
        LoadComponent();
    }

    private void LoadComponent()
    {
        Title.Text = _component.Title;
        Description.Text = _component.Description;
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
        _component.Title = Title.Text;
        _component.Description = Description.Text;
        _categoryRepository.PutComponents(_component);
        WeakReferenceMessenger.Default.Send<string>(string.Empty);
        
    }
}