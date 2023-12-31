﻿namespace Escola.Api.Data.Repositories.Interfaces;

public interface IRepository<TEntity>
{
    /// <summary>
    /// Irá adicionar o objeto no em memória
    /// OBS: PRA SALVAR NO BANCO, CHAME O MÉTODO Salvar()
    /// </summary>
    public void Adicionar(TEntity obj);

    /// <summary>
    /// Irá atualizar o objeto no em memória
    /// OBS: PRA SALVAR NO BANCO, CHAME O MÉTODO Salvar()
    /// </summary>
    public void Atualizar(TEntity obj);
    public TEntity BuscarPorId(int id);
    public IQueryable<TEntity> BuscarTodos();
    int Salvar();
    void Remover(int id);
}