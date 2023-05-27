using Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Interfaces
{
    public interface IMovieRepository
    {
        // CRUD
        public Movie Add(Movie entity);
        public Movie Update(Movie entity);
        public Movie Delete(Movie entity);
        public IEnumerable<Movie> GetAll();


    }
}
