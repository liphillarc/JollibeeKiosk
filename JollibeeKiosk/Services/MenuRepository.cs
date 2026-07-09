// ============================================================
//  MenuRepository.cs
//  ╔══════════════════════════════════════════════════════╗
//  ║  OWNER: Member 1 — The Data & Menu Manager          ║
//  ╚══════════════════════════════════════════════════════╝
//
//  YOUR TASKS:
//    1. Replace the SAMPLE DATA below with real Jollibee items
//       and their actual prices. Add more items to cover:
//       Chicken, Burgers, Pasta, Breakfast, Drinks, Desserts.
//    2. Add input validation in Add() and Update():
//         - Name must not be empty or whitespace.
//         - Price must be greater than zero.
//         - Category must not be empty.
//    3. You may expand GetAll() to filter by category if needed.
//
//  CRUD:
//    Create → Add()
//    Read   → GetAll(), GetById()
//    Update → Update()
//    Delete → Delete()
// ============================================================
namespace JollibeeKiosk.Services
{
    /// <summary>
    /// In-memory repository for Jollibee menu items.
    /// Implements full CRUD: Create, Read, Update, Delete.
    /// </summary>
    public static class MenuRepository
    {
        // ── Internal Data Store ──────────────────────────────────────────
        private static readonly List<MenuItem> _items = new List<MenuItem>
        {
            // ── SAMPLE DATA ──────────────────────────────────────────────
            // TODO (Member 1): Replace with real Jollibee menu & prices.
            // ─────────────────────────────────────────────────────────────
            new MenuItem( 1, "Chickenjoy (1 pc)",       99.00m,  "Chicken"),
            new MenuItem( 2, "Chickenjoy (2 pcs)",      179.00m, "Chicken"),
            new MenuItem( 3, "Chickenjoy (6 pcs Bucket)",499.00m,"Chicken"),
            new MenuItem( 4, "Jolly Spaghetti",          89.00m, "Pasta"),
            new MenuItem( 5, "Beefy Spaghetti",          99.00m, "Pasta"),
            new MenuItem( 6, "Yumburger",                49.00m, "Burgers"),
            new MenuItem( 7, "Big Yumburger",            89.00m, "Burgers"),
            new MenuItem( 8, "Cheesy Yumburger",         69.00m, "Burgers"),
            new MenuItem( 9, "Jolly Hotdog Classic",     79.00m, "Hotdog"),
            new MenuItem(10, "Jolly Hotdog Cheesy",      89.00m, "Hotdog"),
            new MenuItem(11, "Peach Mango Pie",          49.00m, "Desserts"),
            new MenuItem(12, "Pineapple Sundae",         45.00m, "Desserts"),
            new MenuItem(13, "French Fries (Regular)",   59.00m, "Sides"),
            new MenuItem(14, "French Fries (Large)",     79.00m, "Sides"),
            new MenuItem(15, "Coca-Cola (Regular)",      45.00m, "Drinks"),
            new MenuItem(16, "Coca-Cola (Large)",        55.00m, "Drinks"),
            new MenuItem(17, "Pineapple Juice",          49.00m, "Drinks"),
            new MenuItem(18, "Burger Steak",             89.00m, "Rice Meals"),
            new MenuItem(19, "Jolly Crispy Fries Chicken",129.00m,"Rice Meals"),
        };

        private static int _nextId = 20; // Auto-increment ID counter

        // ── READ ─────────────────────────────────────────────────────────

        /// <summary>
        /// Returns a copy of all available menu items.
        /// TODO (Member 1): Optionally filter by IsAvailable if you add that property.
        /// </summary>
        public static List<MenuItem> GetAll()
        {
            return new List<MenuItem>(_items);
        }

        /// <summary>
        /// Returns a single item by its ID, or null if not found.
        /// </summary>
        public static MenuItem? GetById(int id)
        {
            return _items.FirstOrDefault(m => m.Id == id);
        }

        // ── CREATE ───────────────────────────────────────────────────────

        /// <summary>
        /// Adds a new menu item to the repository.
        /// TODO (Member 1): Add validation — name not empty, price > 0.
        /// </summary>
        /// <returns>True if added successfully; false if validation fails.</returns>
        public static bool Add(MenuItem item)
        {
            // TODO (Member 1): Add proper input validation here.
            if (string.IsNullOrWhiteSpace(item.Name)) return false;
            if (item.Price <= 0) return false;

            item.Id = _nextId++;
            _items.Add(item);
            return true;
        }

        // ── UPDATE ───────────────────────────────────────────────────────

        /// <summary>
        /// Updates an existing menu item matched by ID.
        /// TODO (Member 1): Add validation before updating.
        /// </summary>
        /// <returns>True if found and updated; false if not found or invalid.</returns>
        public static bool Update(MenuItem updated)
        {
            // TODO (Member 1): Add proper input validation here.
            if (string.IsNullOrWhiteSpace(updated.Name)) return false;
            if (updated.Price <= 0) return false;

            var existing = _items.FirstOrDefault(m => m.Id == updated.Id);
            if (existing == null) return false;

            existing.Name     = updated.Name;
            existing.Price    = updated.Price;
            existing.Category = updated.Category;
            return true;
        }

        // ── DELETE ───────────────────────────────────────────────────────

        /// <summary>
        /// Removes the menu item with the given ID.
        /// </summary>
        /// <returns>True if removed; false if not found.</returns>
        public static bool Delete(int id)
        {
            var item = _items.FirstOrDefault(m => m.Id == id);
            if (item == null) return false;

            _items.Remove(item);
            return true;
        }
    }
}
