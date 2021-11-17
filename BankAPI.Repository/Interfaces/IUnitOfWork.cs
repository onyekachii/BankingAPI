﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAPI.Repository.Interfaces
{
    public interface IUnitofWork
    {
        IRepository<TEntity> GetRepository<TEntity>() where TEntity : class;

        int SaveChanges();
        Task<int> SaveChangesAsync();
    }

    public interface IUnitofWork<TContext> : IUnitofWork
    {
    }

}
