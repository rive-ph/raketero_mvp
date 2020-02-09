using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raketero.Entities
{
    public interface IEntity
    {
        int Id { get; set; }

        DateTime LastModified { get; set; }
    }
    public abstract class EntityBase : IEntity
    {
        public int Id { get; set; }
        public DateTime LastModified { get; set; }
    }
}
