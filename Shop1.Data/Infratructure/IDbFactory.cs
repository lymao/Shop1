using System;

namespace Shop1.Data.Infratructure
{
    public interface IDbFactory : IDisposable
    {
        Shop1DbContext Init();
    }
}