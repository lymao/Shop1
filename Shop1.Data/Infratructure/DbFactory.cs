namespace Shop1.Data.Infratructure
{
    public class DbFactory : Disposable, IDbFactory
    {
        private Shop1DbContext dbContext;

        public Shop1DbContext Init()
        {
            return dbContext ?? (dbContext = new Shop1DbContext());
        }

        protected override void DisposeCore()
        {
            if (dbContext != null)
            {
                dbContext.Dispose();
            }
        }
    }
}