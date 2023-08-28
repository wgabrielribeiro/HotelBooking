using Domain.Entities;

namespace Domain.Ports
{
    public interface IGuestRepository
    {
        Task<Guest> GetGuestById(int id);
        Task<int> Save(Guest guest);
    }
}
