using System.Net.Http.Json;

using BlazorApp.Models;

using Microsoft.AspNetCore.Components;

namespace BlazorApp.Shared
{
    public partial class Footer
    {
        [Parameter, EditorRequired]
        public HttpClient Http { get; set; }

        [Parameter]
        public string PrimaryColor { get; set; } = string.Empty;
        [Parameter]
        public string SecondaryColor { get; set; } = string.Empty;
        private SiteProperties? property;
        private SocialIcons? icons;
        protected override async Task OnInitializedAsync()
        {
            property = await Http.GetFromJsonAsync<SiteProperties>("sample-data/siteproperties.json");
            icons = await Http.GetFromJsonAsync<SocialIcons>("sample-data/socialicons.json");
        }
    }
}