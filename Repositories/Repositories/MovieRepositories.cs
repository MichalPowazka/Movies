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
            _context.Movies.Add(entity);
            _context.SaveChanges();
            return entity;
        }


        public Movie Delete(Movie entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Movie> GetAll()
        {
            throw new NotImplementedException();
        }

        public Movie Update(Movie entity)
        {
            throw new NotImplementedException();
        }

        public void DeleteMovieById(int id)
        {
            var movieToDelete = _context.Movies.FirstOrDefault(m => m.Id == id);

            _context.Movies.Remove(movieToDelete);

            _context.SaveChanges();
        }
    }
}
