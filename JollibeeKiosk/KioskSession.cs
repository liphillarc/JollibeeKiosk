namespace JollibeeKiosk
{
    public static class KioskSession
    {
        public static Order CurrentOrder { get; private set; } = new Order();

        public static void StartNewOrder()
        {
            CurrentOrder = new Order();
        }
    }
}

