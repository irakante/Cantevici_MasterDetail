namespace Cantevici_MasterDetail.Models
{
    public enum MenuItemType
    {
        About,
        MyLabs,
        Projects        
    }

    public class HomeMenuItem
    {
        public MenuItemType Id { get; set; }

        public string Title { get; set; }
    }
}
