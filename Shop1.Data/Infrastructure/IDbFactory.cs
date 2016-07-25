using System;

namespace Shop1.Data.Infrastructure
{
    public interface IDbFactory : IDisposable
    {
        Shop1DbContext Init();
    }
}