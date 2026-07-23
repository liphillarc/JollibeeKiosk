namespace JollibeeKiosk.Services
{
    public static class MenuRepository
    {
        private static readonly List<MenuItem> _items = new List<MenuItem>
        {
            new MenuItem( 1, "Chickenjoy (1 pc)",       99.00m,  "Chicken"),
            new MenuItem( 2, "Chickenjoy (2 pcs)",      179.00m, "Chicken"),
            new MenuItem( 3, "Chickenjoy (6 pcs Bucket)",499.00m,"Chicken"),
            new MenuItem( 4, "Burger Steak",             89.00m, "Rice Meals"),
            new MenuItem( 5, "Jolly Spaghetti",          89.00m, "Pasta"),
            new MenuItem( 6, "Beefy Spaghetti",          99.00m, "Pasta"),
            new MenuItem( 7, "Hapiburger",               49.00m, "Burgers"),
            new MenuItem( 8, "Cheesy Hapiburger",        69.00m, "Burgers"),
            new MenuItem( 9, "Hapi Hotdog Classic",      79.00m, "Hotdog"),
            new MenuItem(10, "Peach Mango Pie",          49.00m, "Desserts"),
            new MenuItem(11, "French Fries (Reg)",       59.00m, "Sides"),
            new MenuItem(12, "Coca-Cola (Regular)",      45.00m, "Drinks")
        };

        private static int _nextId = 13;

        public static List<MenuItem> GetAll()
        {
            return new List<MenuItem>(_items);
        }

        public static MenuItem? GetById(int id)
        {
            return _items.FirstOrDefault(m => m.Id == id);
        }

        public static bool Add(MenuItem item)
        {
            if (string.IsNullOrWhiteSpace(item.Name)) return false;
            if (item.Price <= 0) return false;

            item.Id = _nextId++;
            _items.Add(item);
            return true;
        }

        public static bool Update(MenuItem updated)
        {
            if (string.IsNullOrWhiteSpace(updated.Name)) return false;
            if (updated.Price <= 0) return false;

            var existing = _items.FirstOrDefault(m => m.Id == updated.Id);
            if (existing == null) return false;

            existing.Name     = updated.Name;
            existing.Price    = updated.Price;
            existing.Category = updated.Category;
            return true;
        }

        public static bool Delete(int id)
        {
            var item = _items.FirstOrDefault(m => m.Id == id);
            if (item == null) return false;

            _items.Remove(item);
            return true;
        }
    }
}
