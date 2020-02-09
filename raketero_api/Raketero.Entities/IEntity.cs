using Management.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raketero.Entities
{

    public abstract class EntityBase : IEntity
    {
        public int Id { get; set; }
        public DateTime LastModified { get; set; }
    }
}
