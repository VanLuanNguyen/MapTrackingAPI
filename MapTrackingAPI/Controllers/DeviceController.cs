using MapTrackingAPI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MapTrackingAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DeviceController : ControllerBase
    {
        private readonly DeviceService _service;

        public DeviceController(DeviceService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> GetDevices()
        {
            var devices = await _service.GetDevicesAsync();
            return Ok(devices);
        }

        [HttpGet("locations/{name}")]
        public async Task<IActionResult> GetDeviceLocationsByName(string name)
        {
            var locations = await _service.GetDeviceLocationsByNameAsync(name);
            return Ok(locations);
        }
    }
}
