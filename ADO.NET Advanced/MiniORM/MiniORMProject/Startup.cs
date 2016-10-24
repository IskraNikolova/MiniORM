namespace MiniORMProject
{
    using System;

    public class Startup
    {
        public static void Main()
        {
            string connectionString = new ConnectionStringBuilder("MinionsDB").ConnectionString;
        }
    }
}
