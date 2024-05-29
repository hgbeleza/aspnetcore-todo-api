﻿using Api.Entities;

namespace Api.Repositories.Contracts
{
    public interface ITodoTaskRepository
    {
        Task<IEnumerable<TodoTask>> GetItems();
    }
}
