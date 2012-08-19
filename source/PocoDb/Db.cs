﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PocoDb.Interfaces;

namespace PocoDb
{
    public static class Db
    {
        public static IDbContext Connect(string connectionStringName)
        {
            return new DbContext(connectionStringName);
        }

        public static ISelectQuery<TTable> Select<TTable>(this IDbContext dbContext, string tableName = null)
        {
            return new SelectQuery<TTable>(dbContext, tableName);
        }
    }
}
