using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Assignment3.Models;
using System.Net.Mime;
using AutoMapper;
using Assignment3.Models.DTOs.Movie;

namespace Assignment3.Controllers
{
    [ApiController]
    [Route("api/v1/movies")]
    [Produces(MediaTypeNames.Application.Json)]
    [Consumes(MediaTypeNames.Application.Json)]
    [ApiConventionType(typeof(DefaultApiConventions))]
    public class MoviesController : ControllerBase
    {
        private readonly MovieCharacterDbContext _context;
        private readonly IMapper _mapper;

        public MoviesController(MovieCharacterDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        /// <summary>
        /// Get all movies.
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<MovieReadDTO>>> GetMovies()
        {
            return _mapper.Map<List<MovieReadDTO>>(await _context.Movies
                .Include(m => m.MovieCharacter)
                .ThenInclude(mc => mc.Character) // not CharacterId, hmmm, beacuase Tolist... ?
                .ToListAsync());
        }

        /// <summary>
        /// Get specific movie by id.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public async Task<ActionResult<MovieReadDTO>> GetMovie(int id)
        {
            var movie = await _context.Movies.FindAsync(id);

            if (movie == null)
            {
                return NotFound();
            }

            return _mapper.Map<MovieReadDTO>(movie);
        }

        /// <summary>
        /// Update a movie.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="movie"></param>
        /// <returns></returns>
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMovie(int id, MovieEditDTO movie)
        {
            if (id != movie.Id)
            {
                return BadRequest();
            }

            // Map to dpmain
            Movie domainMovie = _mapper.Map<Movie>(movie);
            _context.Entry(domainMovie).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MovieExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        /// <summary>
        /// Add a new movie.
        /// </summary>
        /// <param name="movieCdto"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<ActionResult<Movie>> PostMovie(MovieCreateDTO movieCdto)
        {
            Movie domainMovie = _mapper.Map<Movie>(movieCdto);
            _context.Movies.Add(domainMovie);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetMovie",
                new { id = domainMovie.Id }
                , _mapper.Map<MovieReadDTO>(domainMovie));
        }

        /// <summary>
        /// Delete a movie.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMovie(int id)
        {
            var movie = await _context.Movies.FindAsync(id);
            if (movie == null)
            {
                return NotFound();
            }

            _context.Movies.Remove(movie);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool MovieExists(int id)
        {
            return _context.Movies.Any(e => e.Id == id);
        }

        //// Update Characters in a movie
        //// unfinished.

        //[HttpPut("{id}/characters")]
        //public async Task<IActionResult> UpdateCharactersInMovie(int id, List<int> characterIds)
        //{
        //    if (!MovieExists(id))
        //    {
        //        return NotFound();
        //    }

        //   // Loop over character ids, check if the exist
        //   // add them to movie if they do, else return some error message
        //}
    }
}
