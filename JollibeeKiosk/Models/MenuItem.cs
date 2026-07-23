namespace JollibeeKiosk.Models
{
    public class MenuItem
    {
        public int    Id       { get; set; }
        public string Name     { get; set; } = string.Empty;
        public decimal Price   { get; set; }
        public string Category { get; set; } = string.Empty;
        public string ImagePath { get; set; } = string.Empty;

        public MenuItem() { }

        public MenuItem(int id, string name, decimal price, string category, string imagePath = "Resources/mascot.jpg")
        {
            Id        = id;
            Name      = name;
            Price     = price;
            Category  = category;
            ImagePath = imagePath;
        }

        public override string ToString() => $"{Name} — ₱{Price:F2}";
    }
}
