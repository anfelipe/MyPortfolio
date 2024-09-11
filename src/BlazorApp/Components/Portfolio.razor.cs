using BlazorApp.Models;
using BlazorApp.Services;
using Microsoft.AspNetCore.Components;
using System.Net.Http.Json;

namespace BlazorApp.Components;

public partial class Portfolio
{
    [Parameter, EditorRequired]
    public required HttpClient Http { get; init; }

    [Parameter, EditorRequired]
    public required HeroImageService HeroImageService { get; set; }

    private List<Project>? projects;
    private HeroImage? hero;

    protected override async Task OnInitializedAsync()
    {
        projects = await Http.GetFromJsonAsync<List<Project>>("sample-data/projects.json");
        hero = await HeroImageService.GetHeroAsync(img => img.Name is "portfolio");
    }
}