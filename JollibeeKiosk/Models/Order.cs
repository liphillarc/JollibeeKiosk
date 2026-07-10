using System.Collections.Generic;
using System.Linq;

namespace JollibeeKiosk.Models
{
    public class Order
    {
        public OrderType         OrderType       { get; set; } = OrderType.DineIn;
        public DiscountType      AppliedDiscount { get; private set; } = DiscountType.None;
        public decimal           DiscountAmount  { get; private set; } = 0m;
        public List<OrderItem>   Items           { get; private set; } = new List<OrderItem>();

        public void AddItem(MenuItem item, int quantity)
        {
            var existing = Items.FirstOrDefault(o => o.Item.Id == item.Id);
            if (existing != null)
                existing.Quantity += quantity;
            else
                Items.Add(new OrderItem(item, quantity));
        }

        public void RemoveItem(int menuItemId)
        {
            var existing = Items.FirstOrDefault(o => o.Item.Id == menuItemId);
            if (existing == null) return;

            existing.Quantity--;
            if (existing.Quantity <= 0)
                Items.Remove(existing);
        }

        public void DeleteItem(int menuItemId)
        {
            var existing = Items.FirstOrDefault(o => o.Item.Id == menuItemId);
            if (existing != null)
                Items.Remove(existing);
        }

        public decimal CalculateSubtotal()
        {
            return Items.Sum(o => o.LineTotal);
        }

        public decimal ApplyDiscount(DiscountType discountType)
        {
            AppliedDiscount = discountType;
            if (discountType == DiscountType.SeniorCitizen)
                DiscountAmount = CalculateSubtotal() * 0.20m;
            else if (discountType == DiscountType.PWD)
                DiscountAmount = CalculateSubtotal() * 0.15m;
            else
                DiscountAmount = 0m;

            return DiscountAmount;
        }

        public decimal GetTotal() => CalculateSubtotal() - DiscountAmount;

        public void Clear()
        {
            Items.Clear();
            AppliedDiscount = DiscountType.None;
            DiscountAmount  = 0m;
            OrderType       = OrderType.DineIn;
        }
    }
}
