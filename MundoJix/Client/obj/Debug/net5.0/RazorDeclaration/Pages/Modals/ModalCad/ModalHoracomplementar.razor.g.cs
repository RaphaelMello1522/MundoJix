// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace MundoJix.Client.Pages.Modals.ModalCad
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\rapha\source\repos\MundoJix\MundoJix\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\rapha\source\repos\MundoJix\MundoJix\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\rapha\source\repos\MundoJix\MundoJix\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\rapha\source\repos\MundoJix\MundoJix\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\rapha\source\repos\MundoJix\MundoJix\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\rapha\source\repos\MundoJix\MundoJix\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\rapha\source\repos\MundoJix\MundoJix\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\rapha\source\repos\MundoJix\MundoJix\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\rapha\source\repos\MundoJix\MundoJix\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\rapha\source\repos\MundoJix\MundoJix\Client\_Imports.razor"
using MundoJix.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\rapha\source\repos\MundoJix\MundoJix\Client\_Imports.razor"
using MundoJix.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\rapha\source\repos\MundoJix\MundoJix\Client\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\rapha\source\repos\MundoJix\MundoJix\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\rapha\source\repos\MundoJix\MundoJix\Client\_Imports.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\rapha\source\repos\MundoJix\MundoJix\Client\_Imports.razor"
using Microsoft.Extensions.Configuration;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\rapha\source\repos\MundoJix\MundoJix\Client\_Imports.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\rapha\source\repos\MundoJix\MundoJix\Client\_Imports.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 36 "C:\Users\rapha\source\repos\MundoJix\MundoJix\Client\Pages\Modals\ModalCad\ModalHoracomplementar.razor"
using MundoJix.Shared.Models;

#line default
#line hidden
#nullable disable
    public partial class ModalHoracomplementar : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 36 "C:\Users\rapha\source\repos\MundoJix\MundoJix\Client\Pages\Modals\ModalCad\ModalHoracomplementar.razor"
                                 
    private bool DisplayForm = false;
    [Parameter] public string Titulo { get; set; }
    [Parameter] public HorasComplementares horasComplementares { get; set; }
    [Parameter] public List<Aluno> alunos { get; set; }
    [Parameter] public RenderFragment BodyContent { get; set; }
    [Parameter] public EventCallback onConfirm { get; set; }
    [Parameter] public EventCallback onCancel { get; set; }

    public void Show()
    {
        DisplayForm = true;
    }

    public void Hide()
    {
        DisplayForm = false;
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
