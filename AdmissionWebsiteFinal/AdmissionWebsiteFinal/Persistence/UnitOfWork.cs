﻿using AdmissionWebsiteFinal.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdmissionWebsiteFinal.Persistence
{
    public class UnitOfWork : IDisposable
    {
        private readonly ApplicationDbContext context;
        public IAdmissionEntryRepository AdmissionEntries { get; private set; }
        public IContestantRepository Contestants { get; private set; }
        public IDepartmentRepository Departments { get; private set; }
        public UnitOfWork(ApplicationDbContext context)
        {
            this.context = context;
            AdmissionEntries = new AdmissionEntryRepository(this.context);
            Contestants = new ContestantRepository(this.context);
            Departments = new DepartmentRepository(this.context);
        }
        public int Complete()
        {
            return context.SaveChanges();
        }
        public void Dispose()
        {
            context.Dispose();
        }
    }
}