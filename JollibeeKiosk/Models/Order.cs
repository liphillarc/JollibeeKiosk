// ============================================================
//  Order.cs
//  ╔══════════════════════════════════════════════════════╗
//  ║  OWNER: Member 2 — The Logic & Receipt Designer     ║
//  ╚══════════════════════════════════════════════════════╝
//
//  YOUR TASKS:
//    1. AddItem    — add qty units; merge if item already exists.
//    2. RemoveItem — decrease qty by 1; remove entry if qty = 0.
//    3. CalculateSubtotal — sum of all OrderItem.LineTotal values.
//    4. ApplyDiscount — 15% off for SeniorCitizen or PWD.
//                       Store result in DiscountAmount & AppliedDiscount.
//    5. GetTotal   — subtotal minus discount.
//    6. Clear      — reset order for a new customer.
//
//  NOTE: The leader (Member 3) calls these methods from Form1.cs.
//        Keep method signatures exactly as they are so the form compiles.
// ============================================================
namespace JollibeeKiosk.Models
{
    /// <summary>
    /// Represents the current customer's order.
    /// Holds all ordered items, order type, and discount information.
    /// </summary>
    public class Order
    {
        // ── Properties ──────────────────────────────────────────────────
        public OrderType         OrderType       { get; set; } = OrderType.DineIn;
        public DiscountType      AppliedDiscount { get; private set; } = DiscountType.None;
        public decimal           DiscountAmount  { get; private set; } = 0m;
        public List<OrderItem>   Items           { get; private set; } = new List<OrderItem>();

        // ── CREATE ───────────────────────────────────────────────────────

        /// <summary>
        /// Adds <paramref name="quantity"/> units of <paramref name="item"/> to the order.
        /// If the item already exists, increase its quantity instead of adding a duplicate.
        /// TODO (Member 2): Review and improve this implementation.
        /// </summary>
        public void AddItem(MenuItem item, int quantity)
        {
            // TODO (Member 2): Replace stub with your own implementation if needed.
            var existing = Items.FirstOrDefault(o => o.Item.Id == item.Id);
            if (existing != null)
                existing.Quantity += quantity;
            else
                Items.Add(new OrderItem(item, quantity));
        }

        // ── DELETE (from cart) ────────────────────────────────────────────

        /// <summary>
        /// Removes one unit of the item with <paramref name="menuItemId"/>.
        /// Removes the OrderItem entirely when quantity reaches zero.
        /// TODO (Member 2): Review and improve this implementation.
        /// </summary>
        public void RemoveItem(int menuItemId)
        {
            // TODO (Member 2): Replace stub with your own implementation if needed.
            var existing = Items.FirstOrDefault(o => o.Item.Id == menuItemId);
            if (existing == null) return;

            existing.Quantity--;
            if (existing.Quantity <= 0)
                Items.Remove(existing);
        }

        // ── READ / CALCULATE ──────────────────────────────────────────────

        /// <summary>
        /// Calculates the order subtotal (before any discount).
        /// TODO (Member 2): Replace stub with your own implementation if needed.
        /// </summary>
        public decimal CalculateSubtotal()
        {
            // TODO (Member 2): Replace stub with your own implementation.
            return Items.Sum(o => o.LineTotal);
        }

        /// <summary>
        /// Applies the discount for the given <paramref name="discountType"/>.
        /// Rate: 15% for SeniorCitizen or PWD; 0% for None.
        /// Stores the result in <see cref="DiscountAmount"/> and <see cref="AppliedDiscount"/>.
        /// Returns the discount amount (not the final total).
        /// TODO (Member 2): Verify the discount logic is correct.
        /// </summary>
        public decimal ApplyDiscount(DiscountType discountType)
        {
            // TODO (Member 2): Replace stub with your own implementation.
            const decimal DiscountRate = 0.15m;

            AppliedDiscount = discountType;
            DiscountAmount  = (discountType == DiscountType.None)
                ? 0m
                : CalculateSubtotal() * DiscountRate;

            return DiscountAmount;
        }

        /// <summary>Returns the final amount after discount is applied.</summary>
        public decimal GetTotal() => CalculateSubtotal() - DiscountAmount;

        // ── UPDATE (reset for new order) ─────────────────────────────────

        /// <summary>
        /// Clears all items and resets the order to its initial state.
        /// Called by the leader when the customer starts a new order.
        /// </summary>
        public void Clear()
        {
            Items.Clear();
            AppliedDiscount = DiscountType.None;
            DiscountAmount  = 0m;
            OrderType       = OrderType.DineIn;
        }
    }
}
