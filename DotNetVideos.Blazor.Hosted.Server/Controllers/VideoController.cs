
using DotNetVideos.Blazor.Hosted.Client.Components;
using DotNetVideos.Blazor.Hosted.Shared.Entities.Dtos;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace DotNetVideos.Blazor.Hosted.Server.Controllers
{
    [Route("api/[controller]")]
    public class VideosController : Controller
    {
        private readonly VideosHttpClient _httpClient;
        public VideosController(VideosHttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        [HttpGet()]
        public async Task<IActionResult> Videos()
        {
            return Ok(await _httpClient.VidHttp.GetStringAsync("/api/videos"));
        }

    }
}
