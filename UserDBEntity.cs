using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Core.Objects;
using System.Linq;

namespace WebApplication1
{
    public class NameDBEntity : DbContext
    {

        public NameDBEntity()
            : base("name=NameDBEntity")
        {
        }
    }
}