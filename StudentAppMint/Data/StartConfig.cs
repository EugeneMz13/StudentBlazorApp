namespace StudentAppMint.Data
{
    public class StartConfig
    {
        public static IConfiguration config;
        public static DataBaseConnect _dbContext;
        public static void InitConfig()
        {
            var builder = new ConfigurationBuilder();
            builder
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);

            config = builder.Build();
            _dbContext = new DataBaseConnect(config);
        }
    }
}
