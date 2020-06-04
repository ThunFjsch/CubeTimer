using System;
using System.Threading;
using System.Threading.Tasks;
using cubetimer.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;

namespace cubetimer.Database
{
    public class DbContext : Microsoft.EntityFrameworkCore.DbContext
    {
        public DbSet<User> Users { get; set; }
        
#nullable disable
        protected DbContext(DbContextOptions options)
            : base(options)
        {
        }
#nullable enable


        public async Task<T> GetAsync<T>(Guid id, CancellationToken cancellationToken)
            where T : class
        {
            var entity = await Set<T>().FindAsync(new object[] {id}, cancellationToken);

            return entity ?? throw new Exception(typeof(T).Name);
        }

        public Task<IDbContextTransaction> BeginTransactionAsync(CancellationToken cancellationToken)
        {
            return Database.BeginTransactionAsync(cancellationToken);
        }

        public new void Add<T>(T entity)
        {
            base.Add(entity);
        }

        public new void Remove<T>(T entity)
        {
            base.Remove(entity);
        }

        public new Task SaveChangesAsync(CancellationToken cancellationToken)
        {
            return base.SaveChangesAsync(cancellationToken);
        }
    }
}