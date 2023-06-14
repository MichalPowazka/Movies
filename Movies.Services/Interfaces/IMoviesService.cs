using Movies.API.DTO.Movies;
using Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movies.Services.Interfaces
{

    public interface IMoviesService
    {
        public Movie Add(AddMovie addMovie);
        public Task<Movie> Update(UpdateMovie updateMovie);
        public Task<Movie> GetById(int id);

        // tutaj ostatnio zmienialem
        public void Delete(int id);


    }



}
