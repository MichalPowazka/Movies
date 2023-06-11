using Movies.API.DTO.Movies;
using Movies.Services.Interfaces;
using Repositories.Entities;
using Repositories.Interfaces;
using Repositories.Repositories;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movies.Services.Services
{
    public class MoviesService : IMoviesService
    {

        private readonly IMovieRepository _movieRepository;

        public MoviesService(IMovieRepository movieRepository)
        {
            _movieRepository = movieRepository;
        }


        public Movie Add(AddMovie addMovie)
        {
            var movie = new Movie();
            movie.Title = addMovie.Title;
            movie.Author = addMovie.Author;
            movie.Description = addMovie.Description;
            movie.CreateDate = DateTime.Now;
            movie.ModifyDate = DateTime.Now;
            return _movieRepository.Add(movie);

        }

        public Movie GetById(int id)
        {
           
            return _movieRepository.GetMovie(id);
            
        }

        public Movie Update(UpdateMovie updateMovie)
        {
            // pobrac rekord z DB
            //_movieRepository.
            var entity = _movieRepository.GetMovie(updateMovie.ID);
            if (entity != null)
            {
                entity.Title = updateMovie.Title;
                entity.Author = updateMovie.Author;
                entity.Description = updateMovie.Description;
                entity.ModifyDate = DateTime.Now;

            }

         
            //_movieRepository.Update(entity);
            return entity;
        }

        public Movie DeleteById(int id)
        {
            return _movieRepository.GetMovie(id);
            
        }
    }
}
