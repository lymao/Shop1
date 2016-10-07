namespace Shop1.Data.Infrastructure
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