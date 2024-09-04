﻿namespace JunioHub.Application.Contracts.Persistence;

public interface IGenericRepository<T> where T : class
{
    Task<T> AddAsync(T entity);
    Task<T?> GetByIdAsync(int id);
    Task<TDto?> GetByIdAsyncProjectTo<TDto>(int id) where TDto : class;
    Task<IReadOnlyList<T>> GetAllAsync();
    Task<List<TDto?>> GetAllAsyncProjectTo<TDto>() where TDto : class;
    void Update(T entity);
    Task<bool> DeleteAsync(int id);
    Task SaveChangesAsync();
}