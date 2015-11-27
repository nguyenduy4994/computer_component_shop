namespace DAL
{
    public partial class QLDataContext
    {
        static QLDataContext Instance;
        public static QLDataContext GetInstance()
        {
            if (Instance == null)
                Instance = new QLDataContext();

            return Instance;
        }
    }
}
