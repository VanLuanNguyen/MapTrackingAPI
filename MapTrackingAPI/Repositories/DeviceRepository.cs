using MapTrackingAPI.Data;
using MapTrackingAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace MapTrackingAPI.Repositories
{
    public class DeviceRepository
    {
        private readonly ApplicationDbContext _context;

        public DeviceRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<Device>> GetAllDevicesAsync()
        {
            return await _context.Devices.ToListAsync();
        }

        public async Task<List<Device>> GetDeviceLocationsByNameAsync(string name)
        {
            return await _context.Devices
                .Where(d => d.Name == name)
                .OrderBy(d => d.AccessedAt)
                .ToListAsync();
        }

        public async Task<Device> AddDeviceAsync(Device device)
        {
            _context.Devices.Add(device);
            await _context.SaveChangesAsync();
            return device;
        }
    }
}
