﻿using eTickets.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace eTickets.Data.Services
{
    public class ActorsServices : IActorsServices
    {
        private readonly AppDbContext _context;
        public ActorsServices(AppDbContext context)
        {
            _context = context;
        }

        public async Task AddAsync(Actor actor)
        {
            await _context.Actors.AddAsync(actor);
            await _context.SaveChangesAsync();
        }


        public void DeleteAsync(int id)
        {

            //var actor = _context.Actors.FirstOrDefault(n => n.ActorId == id);
            //if (actor == null) throw new KeyNotFoundException($"Actor with id {id} not found.");
            //_context.Actors.Remove(actor);
            //_context.SaveChanges();
        }


        public async Task<IEnumerable<Actor>> GetAllAsync()
        {
            var result = await _context.Actors.ToListAsync();
            return result ?? new List<Actor>();
        }

        public async Task<Actor> GetByIdAsync(int id)
        {
            var result = await _context.Actors.FirstOrDefaultAsync(n => n.ActorId == id);
            return result ?? throw new KeyNotFoundException($"Actor with id {id} not found.");
        }

             
        public async Task<Actor> UpdateAsync(int id, Actor newActor)
        {
           _context.Actors.Update(newActor);
            await _context.SaveChangesAsync();
            return newActor;
        }
    }
} 
