using System.Net.Http.Json;

using BlazorApp.Models;
using BlazorApp.Services;

using Microsoft.AspNetCore.Components;

namespace BlazorApp.Components
{
    public partial class Portfolio
    {
        [Parameter, EditorRequired]
        public HttpClient Http { get; set; }

        [Parameter, EditorRequired]
        public HeroImageService HeroImageService { get; set; }

        private List<Project>? projects;
        private HeroImage? hero;

        protected override async Task OnInitializedAsync()
        {
            projects = await Http.GetFromJsonAsync<List<Project>>("sample-data/projects.json");
            hero = await HeroImageService.GetHeroAsync(img => img.Name is "portfolio");
        }
    }
}