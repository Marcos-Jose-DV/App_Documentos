using AppDocuments.Model;
using System.Text.Json;

namespace AppDocuments.Helpers;

public class ConvertObject
{
    private Category _category;
    private Component _component;
    private Button _button;
    private Label _label;
    private object _value;
    private string _json;


    /// <summary>
    /// Metodo que Converte objeto do context em json 
    /// depois comverte o json na class Category
    /// </summary>
    /// <param name="sender">Chama o metodo pasando do objeto com o context</param>
    public Category ToCategory(object sender)
    {
        _button = (Button)sender;
        _value = _button.BindingContext;
        JsonSerializerCategory(_value);

        return _category;
    }
    private void JsonSerializerCategory(object value)
    {
        _json = JsonSerializer.Serialize(value);
        _category = JsonSerializer.Deserialize<Category>(_json);
    }

    /// <summary>
    /// Metodo que Converte objeto do context em json 
    /// depois comverte o json na class Component
    /// </summary>
    /// <param name="sender">Chama o metodo pasando do objeto com o context</param>
    public Component ToComponent(object sender)
    {
        if (sender is Button button)
        {
            _button = button;
            _value = _button.BindingContext;
        }
        else
        {
            _label = (Label)sender;
            _value = _label.BindingContext;
        }

        JsonSerializerComponent(_value);

        return _component;
    }
    private void JsonSerializerComponent(object value)
    {
        _json = JsonSerializer.Serialize(value);
        _component = JsonSerializer.Deserialize<Component>(_json);
    }
}

