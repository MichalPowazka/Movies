using Microsoft.EntityFrameworkCore;
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

        public void Delete(int id)
        {
            var movieToDelete = _context.Movies.Find(id);
            _context.Movies.Remove(movieToDelete);
            _context.SaveChanges();
        }

        public IEnumerable<Movie> GetAll()
        {
            ///
            return _context.Movies.ToList();
        }

        public async Task<Movie> GetMovie(int id)
        {
            try
            {
                return await _context.Movies.FirstAsync(m => m.Id == id);
            }
            catch (Exception)
            {

                throw;
            }

        }

        public Movie Update(Movie entity)
        {
            _context.Movies.Update(entity);
            _context.SaveChanges();
            return entity;
        }
    }
}
