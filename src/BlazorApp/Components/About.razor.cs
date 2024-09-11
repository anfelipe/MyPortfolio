using BlazorApp.Models;
using BlazorApp.Services;

using Microsoft.AspNetCore.Components;

using System.Net.Http.Json;

namespace BlazorApp.Components;

public partial class About
{
    [Parameter, EditorRequired]
    public required HttpClient Http { get; init; }

    [Parameter, EditorRequired]
    public required HeroImageService HeroImageService { get; set; }

    private AboutMe? aboutme;
    private HeroImage? hero;

    protected override async Task OnInitializedAsync()
    {
        aboutme = await Http.GetFromJsonAsync<AboutMe>("sample-data/aboutme.json");
        hero = await HeroImageService.GetHeroAsync(img => img.Name is "about");
    }
}
