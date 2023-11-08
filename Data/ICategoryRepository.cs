using AppDocuments.Model;

namespace AppDocuments.Data;

public interface ICategoryRepository
{
    List<Category> GetCategories();
    Category GetCategoryId(Guid id);
    void PostCategories(Category category);
    void PostAll(List<Category> categories);
    void PutCategories(Category category);
    void DeleteCategories(Category category);
    void DeleteAll();

    void PostComponents(Component component);
    void PutComponents(Component component);
    void DeleteComponent(Component component);


}
