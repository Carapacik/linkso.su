﻿using System.Threading.Tasks;
using Domain;

namespace Infrastructure
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly LinkDbContext _context;

        public UnitOfWork(LinkDbContext context)
        {
            _context = context;
        }

        public async Task Commit()
        {
            await _context.SaveChangesAsync();
        }
    }
}