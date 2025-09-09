namespace MinimalWebAPI
{
    public class DataCollection
    {

        public List<string> Items { get; set; } = new List<string>();
    
        public void AddItem(string item)
        {
            Items.Add(item);
        }
        public void RemoveItem(string item)
        {
            Items.Remove(item);
        }

        public List<string> GetAllItems()
        {
            return Items;
        }


    }

    
}
