using Flower.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using Task5_EF.Context;

namespace Flower.DAL.UnitOfWork
{
    public class UnitOfWork : IDisposable
    {
        private FlowerContext db = new FlowerContext();
        private FlowerRepository flowerRepository;

        public void Save()
        {
            db.SaveChanges();
        }

        private bool disposed = false;

        public virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    db.Dispose();
                }
                this.disposed = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
