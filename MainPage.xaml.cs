using AppDocuments.Data;
using AppDocuments.Helpers;
using AppDocuments.Model;
using AppDocuments.ViewModels;
using AppDocuments.Views;
using CommunityToolkit.Mvvm.Messaging;

namespace AppDocuments;

public partial class MainPage : ContentPage
{
    private readonly ICategoryRepository _categoryRepository;
    private readonly ConvertObject _convertObject;
    private Category _category;
    private Component _component;
    public MainPage(MainViewModel viewModel, ICategoryRepository categoryRepository, ConvertObject convert)
    {
        InitializeComponent();
        BindingContext = viewModel;
        _categoryRepository = categoryRepository;
        _convertObject = convert;
    }

    private void ShowMenuIsVisible(object sender, EventArgs e)
    {
        _category = _convertObject.ToCategory(sender);
        int count = _category.Components.Count;
        Helpers.Animation.ShowMenu(sender, count);
    }

    /// <summary>
    /// Motra na tela o intem selecionado
    /// Mostrando Titulo é Descrição
    /// </summary>
    /// <param name="sender">Objeto com dados da seleção</param>
    /// <param name="e">Captura todos os eventos relacionados com Tapped</param>
    private void ComponentSelect(object sender, TappedEventArgs e)
    {
        _component = _convertObject.ToComponent(sender);
        TitleItem.Text = _component.Title;
        DescriptionItem.Text = _component.Description;
    }

   

    /// <summary>
    /// Navega para pagina para adicionar um novo 
    /// component passando o repositorio na rota
    /// </summary>
    /// <param name="sender">Objeto com dados da seleção</param>
    /// <param name="e">Captura eventos da seleção</param>
    private async void PostCategory(object sender, EventArgs e)
    {
        await Navigation.PushModalAsync(new PostCategoryPage(_categoryRepository));
    }

    /// <summary>
    /// Metodo que remove um categoria selecionada
    /// chamando metodo que vai atualizar o
    /// _category, depois chamo o repositorio para deletar a categoria
    /// </summary>
    /// /// <param name="WeakReferenceMessenger">Class que comunica ao LiteDB que uma nova alteração foi feita</param>
    /// <param name="sender">Objeto com dados da seleção</param>
    /// <param name="e">Captura eventos da seleção</param>
    private async void DeteteCategory(object sender, EventArgs e)
    {
        bool result = await DisplayAlert("Apagar", "Deseja apagar essa categoria? (Todos os dados serão pedidos)", "Ok", "Cancelar");

        if (result)
        {
            _component = _convertObject.ToComponent(sender);
            _categoryRepository.DeleteCategories(_category);
            WeakReferenceMessenger.Default.Send<string>(string.Empty);
        }

        return;
    }
    /// <summary>
    /// Faz a Navegação do para pagina
    /// para adicionar o novo componente
    /// </summary>
    /// <param name="sender">Objeto com dados da seleção</param>
    /// <param name="e">Captura eventos da seleção</param>
    private async void PostComponent(object sender, EventArgs e)
    {
        _component = _convertObject.ToComponent(sender);
        await Navigation.PushModalAsync(new PostComponentPage(_category, _categoryRepository));
    }

    /// <summary>
    /// Faz a navegação para atualizar o component 
    /// passando o component e o repositorio na rota
    /// </summary>
    /// <param name="sender">Objeto com dados da seleção</param>
    /// <param name="e">Captura eventos da seleção</param>
    private async void PutComponent(object sender, EventArgs e)
    {
        if (_component != null)
        {
            _component = _convertObject.ToComponent(sender);
            await Navigation.PushModalAsync(new UpdateComponentPage(_component, _categoryRepository));

            return;
        }
    }

    /// <summary>
    /// Metodo que remove um componente selecionada
    /// chamando metodo que vai atualizar o
    /// _component, depois chamo o repositorio para deletar a component
    /// </summary>
    /// /// <param name="WeakReferenceMessenger">Class que comunica ao LiteDB que uma nova alteração foi feita</param>
    /// <param name="sender">Objeto com dados da seleção</param>
    /// <param name="e">Captura eventos da seleção</param>
    private async void DeleteComponent(object sender, EventArgs e)
    {
        bool result = await DisplayAlert("Apagar", "Deseja apagar essa SubCategoria? (Todos os dados serão pedidos)", "Ok", "Cancelar");

        if (result)
        {
            _component = _convertObject.ToComponent(sender);
            _categoryRepository.DeleteComponent(_component);
            WeakReferenceMessenger.Default.Send<string>(string.Empty);
        }

        return;
    }
}
