using System.Net.Http.Json;

using BlazorApp.Models;
using BlazorApp.Services;

using Microsoft.AspNetCore.Components;

namespace BlazorApp.Components
{
    public partial class Home
    {
        [Parameter, EditorRequired]
        public HttpClient Http { get; set; }

        [Parameter, EditorRequired]
        public HeroImageService HeroImageService { get; set; }

        private SiteProperties? property;
        private HeroImage? hero;
        protected override async Task OnInitializedAsync()
        {
            property = await Http.GetFromJsonAsync<SiteProperties>("sample-data/siteproperties.json");
            hero = await HeroImageService.GetHeroAsync(img => img.Name is "home");
        }
    }
}