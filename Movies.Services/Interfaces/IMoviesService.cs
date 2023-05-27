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

    }
}
