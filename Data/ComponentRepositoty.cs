using AppDocuments.Model;
using LiteDB;

namespace AppDocuments.Data
{
    public class ComponentRepositoty : IComponentRepositoty
    {
        //private readonly LiteDatabase _database;
        //private readonly string CollectionName = "components";
        //public ComponentRepositoty()
        //{

        //    _database = new LiteDatabase(GetPath());
        //}
        //private string GetPath()
        //{
        //    string DatabaseName = "database2.db";
        //    string DatabaseDirectory = FileSystem.Current.AppDataDirectory;
        //    string DatabasePath = Path.Combine(DatabaseDirectory, DatabaseName);
        //    return DatabasePath;

        //}
        //public void PutComponents(Component component)
        //{
        //    var categories = _database.GetCollection<Component>(CollectionName);
        //    categories.Update(component);
        //}
        //public Component GetComponetId(Guid id)
        //{
        //    var Component = _database
        //        .GetCollection<Component>(CollectionName)
        //        .FindOne(x => x.Id == id);


        //    return Component;
        //}

        //public List<Component> GetComponents()
        //{
        //    var Component = _database
        //       .GetCollection<Component>(CollectionName)
        //       .Query()
        //       .OrderByDescending(x => x.Id)
        //       .ToList();

        //    return Component;
        //}

        //public void PostComponents(Component component)
        //{
        //    var components = _database.GetCollection<Component>(CollectionName);
        //    components.Insert(component);
        //    components.EnsureIndex(x => x.Id);
        //}

        //public void DeleteAll()
        //{
        //    _database.GetCollection(CollectionName).DeleteAll();
        //}

       
    }
}
