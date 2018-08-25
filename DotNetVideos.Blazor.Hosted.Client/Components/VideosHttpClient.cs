using Microsoft.AspNetCore.Blazor.Components;
using System.Net.Http;

namespace DotNetVideos.Blazor.Hosted.Client.Components
{
    public class VideosHttpClient
    {
        private HttpClient _client;

        public VideosHttpClient(HttpClient client)
        {
            _client = client;
        }

        public HttpClient VidHttp => _client;
    }
}