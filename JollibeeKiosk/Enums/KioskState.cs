// ============================================================
//  KioskState.cs  —  Leader (Member 3)
//  Tracks which screen of the kiosk is currently active.
//  Used by NavigateTo() in Form1.cs to drive the state machine.
// ============================================================
namespace JollibeeKiosk.Enums
{
    /// <summary>
    /// Represents each screen (state) of the kiosk ordering flow.
    /// </summary>
    public enum KioskState
    {
        /// <summary>Screen 1: Welcome / "Tap to Order" splash.</summary>
        Welcome,

        /// <summary>Screen 2: Dine In vs. Take Out selection.</summary>
        OrderType,

        /// <summary>Screen 3: Food menu grid with +/– controls.</summary>
        Menu,

        /// <summary>Screen 4: Cart review / checkout summary.</summary>
        Checkout,

        /// <summary>Screen 5: PWD / Senior Citizen discount selection.</summary>
        Discount,

        /// <summary>Screen 6: Final receipt displayed in RichTextBox.</summary>
        Receipt
    }
}
