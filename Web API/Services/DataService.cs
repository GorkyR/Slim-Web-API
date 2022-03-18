using Core.Services;

namespace WebAPI.Services;

public class DataService : IDataService {
   public Task<T> Add<T>(T entity) where T : class {
      throw new NotImplementedException();
   }

   public Task AddRange<TEntity>(IEnumerable<TEntity> entities) where TEntity : class {
      throw new NotImplementedException();
   }

   public Task Atomic(Func<Task> operation) {
      throw new NotImplementedException();
   }

   public Task Delete<T>(T entity) where T : class {
      throw new NotImplementedException();
   }

   public Task DeleteRange<TEntity>(IEnumerable<TEntity> entities) where TEntity : class {
      throw new NotImplementedException();
   }

   public Task Update<T>(T entity) where T : class {
      throw new NotImplementedException();
   }
}