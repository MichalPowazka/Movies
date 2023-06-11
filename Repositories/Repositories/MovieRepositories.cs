using Repositories.Entities;
using Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Repositories
{
    public class MovieRepository : IMovieRepository
    {
        private readonly ApplicationDbContext _context;

        public MovieRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public Movie Add(Movie entity)
        {
            //entity odzwierciedlenie tablek w kodzie aplikacji
            _context.Movies.Add(entity);
            _context.SaveChanges();
            return entity;
        }

        public Movie Delete(int id)
        {

           var movieToDelete = _context.Movies.Find(id);
           
                _context.Movies.Remove(movieToDelete);
                _context.SaveChanges();
                return movieToDelete;

        }

        public IEnumerable<Movie> GetAll()
        {
            ///
            return _context.Movies.ToList();
        }

        public Movie GetMovie(int id)
        {
            return _context.Movies.First(_ => _.Id == id);
            
        }

        public Movie Update(Movie entity)
        {
            //// tutaj dodałem troche na czuja
            _context.Movies.Update(entity);
            _context.SaveChanges ();
            //////////////////
            throw new NotImplementedException();
        }
    }
}
