using HMS.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.DAL
{
    public class UnitOfWork:IDisposable
    {
        private HMSContext dbContext;
        
        public GenericRepository<TEntityType> GetRepository<TEntityType>() where TEntityType : class
        {
            return new GenericRepository<TEntityType>(dbContext);
        }

        public UnitOfWork(HMSContext context)
        {
            this.dbContext = context;
            
        }

        public void Commit()
        {
            dbContext.SaveChanges();
        }

        public void Dispose()
        {
            this.dbContext.Dispose();
        }
    }
}
