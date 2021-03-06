#pragma checksum "C:\Data\CuriousDrive\PublicProjects\BlazorApp\BlazorApp\Pages\AuthorDetail.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c60eb9ce71873b3cece9f280bcf596b69d4ac7c8"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazorApp.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Data\CuriousDrive\PublicProjects\BlazorApp\BlazorApp\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Data\CuriousDrive\PublicProjects\BlazorApp\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Data\CuriousDrive\PublicProjects\BlazorApp\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Data\CuriousDrive\PublicProjects\BlazorApp\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Data\CuriousDrive\PublicProjects\BlazorApp\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Data\CuriousDrive\PublicProjects\BlazorApp\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Data\CuriousDrive\PublicProjects\BlazorApp\BlazorApp\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Data\CuriousDrive\PublicProjects\BlazorApp\BlazorApp\_Imports.razor"
using BlazorApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Data\CuriousDrive\PublicProjects\BlazorApp\BlazorApp\_Imports.razor"
using BlazorApp.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Data\CuriousDrive\PublicProjects\BlazorApp\BlazorApp\_Imports.razor"
using MatBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Data\CuriousDrive\PublicProjects\BlazorApp\BlazorApp\_Imports.razor"
using CuriousDriveRazorLibrary;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Data\CuriousDrive\PublicProjects\BlazorApp\BlazorApp\Pages\AuthorDetail.razor"
using BlazorApp.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/authors/authordetail/{authorId:int}")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/authors/authordetail")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/author")]
    public class AuthorDetail : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 16 "C:\Data\CuriousDrive\PublicProjects\BlazorApp\BlazorApp\Pages\AuthorDetail.razor"
       

    [Parameter]
    public int AuthorId { get; set; }

    public Author AuthorDetails { get; set; }
    //public AuthorService authorService { get; set; }

    protected override async Task OnInitializedAsync()
    {
        //authorService = new AuthorService();
        AuthorDetails = await authorService.GetAuthorById(AuthorId);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IAuthorService authorService { get; set; }
    }
}
#pragma warning restore 1591
