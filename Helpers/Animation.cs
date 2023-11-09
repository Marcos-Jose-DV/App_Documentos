namespace AppDocuments.Helpers;

public static  class Animation
{
   
    /// <summary>
    /// Metodo que motrar o SubMenu da categorias
    /// chamando o metodo AnimetionImagem() que vai criar a animação
    /// </summary>
    /// <param name="sender">Objeto com dados da seleção</param>
    /// <param name="e">Captura eventos da seleção</param>
    public static void ShowMenu(object sender, int count)
    {
        var button = (Button)sender;
        var parentHorizontalStackLayout = (HorizontalStackLayout)button.Parent;
        var parentGrid2 = (Grid)parentHorizontalStackLayout.Parent;
        var ShowMenu = (Grid)parentHorizontalStackLayout.FindByName<VisualElement>("ShowMenu");
        var componentItem = parentGrid2.FindByName<VisualElement>("ComponentItem");

        AnimetionImagem(count, button, ShowMenu, componentItem.IsVisible = componentItem.IsVisible == false);
    }

    /// <summary>
    /// Cria a animação de mostrar o component ao clicar
    /// na categoria 
    /// </summary>
    /// <param name="sender">Objeto com dados da seleção</param>
    /// <param name="button">Button que vai receber a animação</param>
    /// <param name="ShowMenu">Componentes da categoria que foi selecionada</param>
    /// <param name="animacao">Vai determinar se a animação vai acontecer recendo se o componente e visivel ou não</param>
    private static async void AnimetionImagem(int count, Button button, Grid ShowMenu, bool animacao)
    {
        if (animacao)
        {
            ShowMenu.RowDefinitions[1] = new RowDefinition { Height = new GridLength(count * 42 + 50) };
            await button.RotateTo(90, 200);

            return;
        }

        ShowMenu.RowDefinitions[1] = new RowDefinition { Height = new GridLength(0) };
        await button.RotateTo(0, 200);
    }
}
