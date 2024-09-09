using BlazorApp.Services;

using Microsoft.AspNetCore.Components;

public partial class HeroComponent
{
    [Parameter, EditorRequired]
    public HttpClient _http { get; set; }

    [Parameter, EditorRequired]
    public HeroImageService _heroImageService { get; set; }
}