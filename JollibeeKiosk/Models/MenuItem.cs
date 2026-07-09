// ============================================================
//  MenuItem.cs
//  ╔══════════════════════════════════════════════════╗
//  ║  OWNER: Member 1 — The Data & Menu Manager      ║
//  ╚══════════════════════════════════════════════════╝
//
//  YOUR TASKS:
//    1. Verify the properties below — add any extras you need
//       (e.g., Description, IsAvailable, ImagePath).
//    2. The actual Jollibee prices live in MenuRepository.cs.
//    3. Add input validation in the constructor if needed.
// ============================================================
namespace JollibeeKiosk.Models
{
    /// <summary>
    /// Represents a single item available on the Jollibee menu.
    /// </summary>
    public class MenuItem
    {
        // ── Properties ──────────────────────────────────────────
        public int    Id       { get; set; }
        public string Name     { get; set; } = string.Empty;
        public decimal Price   { get; set; }
        public string Category { get; set; } = string.Empty;

        // TODO (Member 1): Add more properties if needed, e.g.:
        // public string Description { get; set; } = string.Empty;
        // public bool IsAvailable { get; set; } = true;

        // ── Constructors ─────────────────────────────────────────
        /// <summary>Parameterless constructor (required for collections).</summary>
        public MenuItem() { }

        /// <summary>Main constructor — use this to create menu items.</summary>
        public MenuItem(int id, string name, decimal price, string category)
        {
            Id       = id;
            Name     = name;
            Price    = price;
            Category = category;
        }

        // ── Utilities ────────────────────────────────────────────
        public override string ToString() => $"{Name} — ₱{Price:F2}";
    }
}
