#pragma checksum "D:\Repos\BlazorFormBuilder\BlazorFormBuilder\FormBuilder\Shared\NavMenu.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2cc6642ecc3c4a325b75aa5bf3d0d954e0691b70"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace FormBuilder.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\Repos\BlazorFormBuilder\BlazorFormBuilder\FormBuilder\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Repos\BlazorFormBuilder\BlazorFormBuilder\FormBuilder\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Repos\BlazorFormBuilder\BlazorFormBuilder\FormBuilder\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Repos\BlazorFormBuilder\BlazorFormBuilder\FormBuilder\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Repos\BlazorFormBuilder\BlazorFormBuilder\FormBuilder\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Repos\BlazorFormBuilder\BlazorFormBuilder\FormBuilder\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Repos\BlazorFormBuilder\BlazorFormBuilder\FormBuilder\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Repos\BlazorFormBuilder\BlazorFormBuilder\FormBuilder\_Imports.razor"
using FormBuilder;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Repos\BlazorFormBuilder\BlazorFormBuilder\FormBuilder\_Imports.razor"
using FormBuilder.Shared;

#line default
#line hidden
#nullable disable
    public class NavMenu : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 24 "D:\Repos\BlazorFormBuilder\BlazorFormBuilder\FormBuilder\Shared\NavMenu.razor"
       
    bool _collapseNavMenu = true;

    string NavMenuCssClass => _collapseNavMenu ? "collapse" : null;

    void ToggleNavMenu()
    {
        _collapseNavMenu = !_collapseNavMenu;
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
