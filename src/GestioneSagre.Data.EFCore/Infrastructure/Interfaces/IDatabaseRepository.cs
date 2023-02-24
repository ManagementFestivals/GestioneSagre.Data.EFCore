namespace GestioneSagre.Data.EFCore.Infrastructure.Interfaces;

public interface IDatabaseRepository<TEntity, TKey> : IDatabase<TEntity, TKey> where TEntity : class, IEntity<TKey>, new()
{
}