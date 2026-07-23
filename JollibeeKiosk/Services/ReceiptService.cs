using System.Text;

namespace JollibeeKiosk.Services
{
    public static class ReceiptService
    {
        private const int ReceiptWidth = 48;

        public static string GenerateReceipt(Order order)
        {
            var sb = new StringBuilder();

            string line    = new string('=', ReceiptWidth);
            string dashLine = new string('-', ReceiptWidth);

            sb.AppendLine(line);
            sb.AppendLine(CenterText("🐝  HAPPYBEE", ReceiptWidth));
            sb.AppendLine(CenterText("Bida ang Sarap!", ReceiptWidth));
            sb.AppendLine(CenterText("www.happybee.com.ph", ReceiptWidth));
            sb.AppendLine(dashLine);
            sb.AppendLine($"Date      : {DateTime.Now:MM/dd/yyyy  hh:mm tt}");
            sb.AppendLine($"Order Type: {order.OrderType}");
            sb.AppendLine(line);

            sb.AppendLine($"{"ITEM",-22} {"QTY",3} {"PRICE",7} {"TOTAL",8}");
            sb.AppendLine(dashLine);

            foreach (var oi in order.Items)
            {
                string name = oi.Item.Name.Length > 20
                    ? oi.Item.Name[..20]
                    : oi.Item.Name;

                sb.AppendLine(
                    $"{name,-22} {oi.Quantity,3} {oi.Item.Price,7:F2} {oi.LineTotal,8:F2}");
            }

            sb.AppendLine(dashLine);

            decimal subtotal = order.CalculateSubtotal();
            decimal discount = order.DiscountAmount;
            decimal total    = order.GetTotal();

            sb.AppendLine($"{"Subtotal",-30} {subtotal,12:F2}");

            if (order.AppliedDiscount != DiscountType.None)
            {
                string discLabel = $"Discount ({order.AppliedDiscount} 15%)";
                sb.AppendLine($"{discLabel,-30}-{discount,11:F2}");
            }

            sb.AppendLine(line);
            sb.AppendLine($"{"TOTAL",-30} {total,12:F2}");
            sb.AppendLine(line);

            sb.AppendLine();
            sb.AppendLine(CenterText("Thank you for your order!", ReceiptWidth));
            sb.AppendLine(CenterText("Please proceed to the counter.", ReceiptWidth));
            sb.AppendLine(CenterText("Enjoy your meal! 😊", ReceiptWidth));
            sb.AppendLine(line);

            return sb.ToString();
        }

        public static string CenterText(string text, int width)
        {
            if (text.Length >= width) return text;
            int totalPad = width - text.Length;
            int leftPad  = totalPad / 2;
            return text.PadLeft(leftPad + text.Length).PadRight(width);
        }
    }
}
