// ============================================================
//  KioskSession.cs  —  Leader (Member 3)
//  A static "shared memory" class that all Forms can read/write.
//  Because every form is a separate class, they need one common
//  place to share the current order. That is this class.
//
//  HOW IT WORKS:
//    - KioskSession.CurrentOrder holds the active Order object.
//    - Every form (FormMenu, FormCheckout, etc.) reads and writes
//      to KioskSession.CurrentOrder — no passing data manually.
//    - Call StartNewOrder() to reset everything for a fresh start.
// ============================================================
namespace JollibeeKiosk
{
    /// <summary>
    /// Holds all shared data for the current kiosk session.
    /// Any Form can access KioskSession.CurrentOrder directly.
    /// </summary>
    public static class KioskSession
    {
        /// <summary>The active customer order for this session.</summary>
        public static Order CurrentOrder { get; private set; } = new Order();

        /// <summary>
        /// Resets the order so the next customer starts fresh.
        /// Called when the customer taps "TAP TO ORDER" or "START NEW ORDER".
        /// </summary>
        public static void StartNewOrder()
        {
            CurrentOrder = new Order();
        }
    }
}
