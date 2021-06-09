using System.Threading.Tasks;
using GlitchTrace.Models;
using Microsoft.AspNetCore.Identity;

namespace GlitchTrace.Services
{
    public interface ITicketService
    {
        Task<Ticket[]> GetOpenTicketsAsync(IdentityUser user);
        Task<bool> AddItemAsync(Ticket ticket, IdentityUser user);
    }
}