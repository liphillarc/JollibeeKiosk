// ============================================================
//  DiscountType.cs  —  Leader (Member 3)
// ============================================================
namespace JollibeeKiosk.Enums
{
    /// <summary>
    /// The type of discount to apply to the order.
    /// 15% discount applies for SeniorCitizen and PWD.
    /// </summary>
    public enum DiscountType
    {
        /// <summary>No discount — pay full price.</summary>
        None,

        /// <summary>Senior Citizen — 15% off the subtotal.</summary>
        SeniorCitizen,

        /// <summary>Person with Disability (PWD) — 15% off the subtotal.</summary>
        PWD
    }
}
