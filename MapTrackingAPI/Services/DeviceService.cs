using MapTrackingAPI.DTOs;
using MapTrackingAPI.Models;
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

        public async Task<DeviceDto> AddDeviceAsync(DeviceDto dto)
        {
            var device = new Device
            {
                Name = dto.Name,
                Latitude = dto.Latitude,
                Longitude = dto.Longitude,
                AccessedAt = DateTime.Now
            };
            var result = await _repo.AddDeviceAsync(device);
            return new DeviceDto
            {
                Name = result.Name,
                Latitude = result.Latitude,
                Longitude = result.Longitude,
                AccessedAt = result.AccessedAt
            };
        }
    }
}
