//namespace PaperTownConsole.Services
//{
//    internal static class Notification
//    {
//        public delegate void EventHandler(NotificationType nType);
//        public static event EventHandler Notify;

//        public static void SendNotification(NotificationType nType)
//        {
//            Notify?.Invoke(nType);
//        }
//        public static void Subscribe(EventHandler handler)
//        {
//            Notify += handler;
//        }
//        public static void Describe(EventHandler handler)
//        {
//            if (Notify != null)
//                Notify -= handler;
//        }
//    }
//}
