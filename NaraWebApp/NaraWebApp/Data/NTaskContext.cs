﻿using System;
using Microsoft.EntityFrameworkCore;

namespace NaraWebApp.Data
{
    public class NTaskContext : DbContext
    { 
        public NTaskContext(DbContextOptions<NTaskContext> options) : base(options)
        {
        }
    }
}
