using System;
using System.Linq;
using System.Threading.Tasks;
using GlitchTrace.Data;
using GlitchTrace.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace GlitchTrace.Services
{
    public class TicketService : ITicketService
    {
        private readonly ApplicationDbContext _context;

        public TicketService(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<Ticket[]> GetOpenTicketsAsync(IdentityUser user)
        {
            return await _context.Tickets
                .Where(x => x.IsOpen == true && x.CreatedBy == user.UserName)
                .ToArrayAsync();
        }

        public async Task<bool> AddItemAsync(Ticket ticket, IdentityUser user)
        {
            ticket.IsOpen = true;
            ticket.CreatedBy = user.Id;
            _context.Tickets.Add(ticket);
            var saveResult = await _context.SaveChangesAsync();
            return saveResult == 1;
        }
    }
}