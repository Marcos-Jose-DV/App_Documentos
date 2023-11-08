using AppDocuments.Model;
using LiteDB;

namespace AppDocuments.Data;

public class CategoryRepository : ICategoryRepository
{
    private readonly LiteDatabase _database;
    private readonly string CollectionName = "categories";
    public CategoryRepository()
    {
        _database = new LiteDatabase(AppSettings.DatabasePath);
    }

    public List<Category> GetCategories()
    {
        var catgories = _database
                 .GetCollection<Category>(CollectionName)
                 .Query()
                 .OrderBy(x => x.Id)
                 .ToList();

        return catgories;
    }
    public void PostCategories(Category category)
    {
        var categories = _database.GetCollection<Category>(CollectionName);
        categories.Insert(category);
        categories.EnsureIndex(x => x.Id);
    }
    public void PostAll(List<Category> categories)
    {
        _database.GetCollection<Category>(CollectionName).InsertBulk(categories);

    }
    public void PutCategories(Category category)
    {
        var categories = _database.GetCollection<Category>(CollectionName);
        categories.Update(category);
    }

    public void DeleteCategories(Category category)
    {
        var categories = _database.GetCollection<Category>(CollectionName);
        categories.Delete(category.Id);
    }
    public void DeleteAll()
    {
        var categories = _database.GetCollection<Category>(CollectionName);
        categories.DeleteAll();
    }

    public Category GetCategoryId(Guid id)
    {
        var categories = _database
            .GetCollection<Category>(CollectionName)
            .FindOne(x => x.Id == id);

        return categories;
    }

    public void PostComponents(Component component)
    {
        var categories = _database
            .GetCollection<Category>(CollectionName);

        var category = categories
            .FindById(component.CategoryId);

        if (component != null && categories != null && category != null)
        {
            category.Components.Add(component);
            categories.Update(category);
        }
    }
    public void PutComponents(Component component)
    {
        var categories = _database
            .GetCollection<Category>(CollectionName);
        var category = categories
            .FindById(component.CategoryId);

        if (component != null && categories != null && category != null)
        {
            var updateComponent = category.Components
                .Where(comp => comp.Id == component.Id)
                .FirstOrDefault();

            updateComponent.Id = component.Id;
            updateComponent.Title = component.Title;
            updateComponent.Description = component.Description;
            updateComponent.Image = component.Image;
            updateComponent.CategoryId = component.CategoryId;

            categories.Update(category);
        }
    }

    public void DeleteComponent(Component component)
    {

        if (component is not null)
        {
            var categories = _database
                .GetCollection<Category>(CollectionName);

            var category = categories.FindById(component.CategoryId);
            var delete = category.Components
                .Where(comp => comp.Id == component.Id)
                .FirstOrDefault();

            category.Components.Remove(delete);
            categories.Update(category);
        }
    }
}
