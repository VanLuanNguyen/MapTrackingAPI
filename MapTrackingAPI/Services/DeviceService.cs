using MapTrackingAPI.DTOs;
using MapTrackingAPI.Repositories;

namespace MapTrackingAPI.Services
{
    public class DeviceService
    {
        private readonly DeviceRepository _repo;

        public DeviceService(DeviceRepository repo)
        {
            _repo = repo;
        }

        public async Task<List<DeviceDto>> GetDevicesAsync()
        {
            var devices = await _repo.GetAllDevicesAsync();
            return devices.Select(d => new DeviceDto
            {
                Name = d.Name,
                Latitude = d.Latitude,
                Longitude = d.Longitude,
                AccessedAt = d.AccessedAt
            }).ToList();
        }

        public async Task<List<DeviceDto>> GetDeviceLocationsByNameAsync(string name)
        {
            var devices = await _repo.GetDeviceLocationsByNameAsync(name);
            return devices.Select(d => new DeviceDto
            {
                Name = d.Name,
                Latitude = d.Latitude,
                Longitude = d.Longitude,
                AccessedAt = d.AccessedAt
            }).ToList();
        }
    }
}
