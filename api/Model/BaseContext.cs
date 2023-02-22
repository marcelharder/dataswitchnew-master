using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace api.Model
{
    public abstract class BaseContext: DbContext
    {
        public BaseContext(DbContextOptions options): base(options){}


    }
}