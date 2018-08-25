using DotNetVideos.Blazor.Hosted.Client.Components;
using DotNetVideos.Blazor.Hosted.Shared.Entities.Dtos;
using Microsoft.AspNetCore.Blazor;
using Microsoft.AspNetCore.Blazor.Components;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DotNetVideos.Blazor.Hosted.Client.Pages
{
    public class VideosListPage : BaseComponent
    {   
        protected IEnumerable<VideoDto> Videos { get; set; }

        protected void Navigate(string href)
        {
            UriHelper.NavigateTo(href);
        }

        protected override async Task OnInitAsync()
        {
            Videos = await Http.GetJsonAsync<VideoDto[]>("/api/videos");
            Console.WriteLine($"OnInitAsync after getting videos");
        }
    }
}
