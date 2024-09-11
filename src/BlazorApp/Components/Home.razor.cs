using BlazorApp.Models;
using BlazorApp.Services;
using Microsoft.AspNetCore.Components;
using System.Net.Http.Json;

namespace BlazorApp.Components;
public partial class Home
{
    [Parameter, EditorRequired]
    public required HttpClient Http { get; init; }

    [Parameter, EditorRequired]
    public required HeroImageService HeroImageService { get; set; }

    private SiteProperties? property;
    private HeroImage? hero;

    protected override async Task OnInitializedAsync()
    {
        property = await Http.GetFromJsonAsync<SiteProperties>("sample-data/siteproperties.json");
        hero = await HeroImageService.GetHeroAsync(img => img.Name is "home");
    }
}