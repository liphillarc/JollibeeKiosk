// ============================================================
//  OrderItem.cs  —  Leader (Member 3)
//  Pairs a MenuItem with the quantity the customer ordered.
//  LineTotal is auto-computed — no setter needed.
// ============================================================
namespace JollibeeKiosk.Models
{
    /// <summary>
    /// A line item in the customer's order: one MenuItem + its quantity.
    /// </summary>
    public class OrderItem
    {
        // ── Properties ──────────────────────────────────────────
        public MenuItem Item     { get; set; }
        public int      Quantity { get; set; }

        /// <summary>
        /// Price × Quantity. Computed automatically — do not set manually.
        /// </summary>
        public decimal LineTotal => Item.Price * Quantity;

        // ── Constructor ──────────────────────────────────────────
        public OrderItem(MenuItem item, int quantity)
        {
            Item     = item;
            Quantity = quantity;
        }

        public override string ToString() =>
            $"{Item.Name} x{Quantity} = ₱{LineTotal:F2}";
    }
}
