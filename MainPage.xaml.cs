using AppDocuments.Data;
using AppDocuments.Model;
using AppDocuments.ViewModels;
using AppDocuments.Views;
using CommunityToolkit.Mvvm.Messaging;
using System.Text.Json;

namespace AppDocuments;

public partial class MainPage : ContentPage
{
    private readonly ICategoryRepository _categoryRepository;
    private Category _category;
    private Component _component;
    public MainPage(MainViewModel viewModel, ICategoryRepository categoryRepository)
    {
        InitializeComponent();
        BindingContext = viewModel;
        _categoryRepository = categoryRepository;
    }

    /// <summary>
    /// Metodo que motrar o SubMenu da categorias
    /// chamando o metodo AnimetionImagem() que vai criar a animação
    /// </summary>
    /// <param name="sender">Objeto com dados da seleção</param>
    /// <param name="e">Captura eventos da seleção</param>
    private void ShowMenuIsVisible(object sender, EventArgs e)
    {
        var button = (Button)sender;
        var parentHorizontalStackLayout = (HorizontalStackLayout)button.Parent;
        var parentGrid2 = (Grid)parentHorizontalStackLayout.Parent;
        var ShowMenu = (Grid)parentHorizontalStackLayout.FindByName<VisualElement>("ShowMenu");
        var componentItem = parentGrid2.FindByName<VisualElement>("ComponentItem");

        AnimetionImagem(sender, button, ShowMenu, componentItem.IsVisible = componentItem.IsVisible == false);
    }

    /// <summary>
    /// Cria a animação de mostrar o component ao clicar
    /// na categoria 
    /// </summary>
    /// <param name="sender">Objeto com dados da seleção</param>
    /// <param name="button">Button que vai receber a animação</param>
    /// <param name="ShowMenu">Componentes da categoria que foi selecionada</param>
    /// <param name="animacao">Vai determinar se a animação vai acontecer recendo se o componente e visivel ou não</param>
    private async void AnimetionImagem(Object sender, Button button, Grid ShowMenu, bool animacao)
    {
        if (animacao)
        {
            ConvertObjectCategory(sender);
            var count = _category.Components.Count;
            ShowMenu.RowDefinitions[1] = new RowDefinition { Height = new GridLength(count * 42 + 50) };
            await button.RotateTo(90, 200);

            return;
        }

        ShowMenu.RowDefinitions[1] = new RowDefinition { Height = new GridLength(0) };
        await button.RotateTo(0, 200);
    }

    /// <summary>
    /// Faz a navegação para atualizar o component 
    /// passando o component e o repositorio na rota
    /// </summary>
    /// <param name="sender">Objeto com dados da seleção</param>
    /// <param name="e">Captura eventos da seleção</param>
    private async void UpdateComponent(object sender, EventArgs e)
    {
        if (_component != null)
        {
            ConvertObjectComponent(sender);
            await Navigation.PushModalAsync(new UpdateComponentPage(_component, _categoryRepository));

            return;
        }
    }

    /// <summary>
    /// Metodo que Converte objeto do context em json 
    /// depois comverte o json na class Category
    /// </summary>
    /// <param name="sender">Chama o metodo pasando do objeto com o context</param>
    private void ConvertObjectCategory(object sender)
    {
        var button = (Button)sender;
        var context = button.BindingContext;
        string json = JsonSerializer.Serialize(context);
        _category = JsonSerializer.Deserialize<Category>(json);
    }

    /// <summary>
    /// Metodo que Converte objeto do context em json 
    /// depois comverte o json na class Component
    /// </summary>
    /// <param name="sender">Chama o metodo pasando do objeto com o context</param>
    private void ConvertObjectComponent(object sender)
    {
        var result = sender is Button;

        if (result)
        {
            var button = (Button)sender;
            var bunttonContext = button.BindingContext;
            var buttonBindingContextJson = JsonSerializer.Serialize(bunttonContext);
            _component = JsonSerializer.Deserialize<Component>(buttonBindingContextJson);

            return;
        }

        var label = (Label)sender;
        var labelContext = label.BindingContext;
        var labelBindingContextJson = JsonSerializer.Serialize(labelContext);
        _component = JsonSerializer.Deserialize<Component>(labelBindingContextJson);
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
            ConvertObjectCategory(sender);
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
        ConvertObjectCategory(sender);
        await Navigation.PushModalAsync(new PostComponentPage(_category, _categoryRepository));
    }
    /// <summary>
    /// Motra na tela o intem selecionado
    /// Mostrando Titulo é Descrição
    /// </summary>
    /// <param name="sender">Objeto com dados da seleção</param>
    /// <param name="e">Captura todos os eventos relacionados com Tapped</param>
    private void ComponentSelect(object sender, TappedEventArgs e)
    {
        ConvertObjectComponent(sender);
        TitleItem.Text = _component.Title;
        DescriptionItem.Text = _component.Description;
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
            ConvertObjectComponent(sender);
            _categoryRepository.DeleteComponent(_component);
            WeakReferenceMessenger.Default.Send<string>(string.Empty);
        }

        return;
    }
}
