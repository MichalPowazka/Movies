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
        public Movie Add(Movie entity);
        public Movie Update(Movie entity);
        public void Delete(int id);
        public IEnumerable<Movie> GetAll();
        public Task<Movie> GetMovie(int id);


    }
}
