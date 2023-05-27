using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Entities
{
    public class Movie : EntityBase<int>
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Author { get; set; }
    }
}
