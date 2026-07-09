// ============================================================
//  ReceiptService.cs
//  ╔══════════════════════════════════════════════════════╗
//  ║  OWNER: Member 2 — The Logic & Receipt Designer     ║
//  ╚══════════════════════════════════════════════════════╝
//
//  YOUR TASKS:
//    1. Format the receipt to look like a real Jollibee receipt:
//         - Header with store name, address, date, order type.
//         - Item rows with proper column alignment (name, qty, price, total).
//         - Subtotal, discount line, and final TOTAL.
//         - Footer with "Thank you!" message.
//    2. Use CenterText() and PadLeft/PadRight for alignment.
//    3. Keep ReceiptWidth = 48 so it fits neatly in the RichTextBox.
//
//  NOTE: GenerateReceipt() is called by Form1.cs (Leader).
//        Keep the method signature exactly as-is.
// ============================================================
using System.Text;

namespace JollibeeKiosk.Services
{
    /// <summary>
    /// Generates a formatted receipt string to display in the RichTextBox.
    /// </summary>
    public static class ReceiptService
    {
        private const int ReceiptWidth = 48;

        // ── Main Receipt Generator ────────────────────────────────────────

        /// <summary>
        /// Builds the full receipt text for the given <paramref name="order"/>.
        /// TODO (Member 2): Improve formatting — use string padding for columns.
        /// </summary>
        public static string GenerateReceipt(Order order)
        {
            // TODO (Member 2): Replace this working stub with your own
            //                  formatted version for the final submission.
            var sb = new StringBuilder();

            string line    = new string('=', ReceiptWidth);
            string dashLine = new string('-', ReceiptWidth);

            // ── HEADER ────────────────────────────────────────────────────
            sb.AppendLine(line);
            sb.AppendLine(CenterText("🐝  JOLLIBEE", ReceiptWidth));
            sb.AppendLine(CenterText("Bida ang Sarap!", ReceiptWidth));
            sb.AppendLine(CenterText("www.jollibee.com.ph", ReceiptWidth));
            sb.AppendLine(dashLine);
            sb.AppendLine($"Date      : {DateTime.Now:MM/dd/yyyy  hh:mm tt}");
            sb.AppendLine($"Order Type: {order.OrderType}");
            sb.AppendLine(line);

            // ── ITEMS ─────────────────────────────────────────────────────
            sb.AppendLine($"{"ITEM",-22} {"QTY",3} {"PRICE",7} {"TOTAL",8}");
            sb.AppendLine(dashLine);

            foreach (var oi in order.Items)
            {
                // Truncate long names so columns stay aligned
                string name = oi.Item.Name.Length > 20
                    ? oi.Item.Name[..20]
                    : oi.Item.Name;

                sb.AppendLine(
                    $"{name,-22} {oi.Quantity,3} {oi.Item.Price,7:F2} {oi.LineTotal,8:F2}");
            }

            sb.AppendLine(dashLine);

            // ── TOTALS ────────────────────────────────────────────────────
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

            // ── FOOTER ────────────────────────────────────────────────────
            sb.AppendLine();
            sb.AppendLine(CenterText("Thank you for your order!", ReceiptWidth));
            sb.AppendLine(CenterText("Please proceed to the counter.", ReceiptWidth));
            sb.AppendLine(CenterText("Enjoy your meal! 😊", ReceiptWidth));
            sb.AppendLine(line);

            return sb.ToString();
        }

        // ── Helpers ───────────────────────────────────────────────────────

        /// <summary>
        /// Centers <paramref name="text"/> within <paramref name="width"/> characters.
        /// TODO (Member 2): Use this throughout GenerateReceipt() for alignment.
        /// </summary>
        public static string CenterText(string text, int width)
        {
            if (text.Length >= width) return text;
            int totalPad = width - text.Length;
            int leftPad  = totalPad / 2;
            return text.PadLeft(leftPad + text.Length).PadRight(width);
        }
    }
}
