#pragma checksum "C:\Users\rapha\source\repos\MundoJix\MundoJix\Client\Shared\InputImg.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ae9f01c628c8e96db0a981cfb7f8417c6aa55a2f"
// <auto-generated/>
#pragma warning disable 1591
namespace MundoJix.Client.Shared
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
#line 16 "C:\Users\rapha\source\repos\MundoJix\MundoJix\Client\_Imports.razor"
using MundoJix.Shared.Models;

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
    public partial class InputImg : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.OpenElement(1, "label");
            __builder.AddContent(2, 
#nullable restore
#line 2 "C:\Users\rapha\source\repos\MundoJix\MundoJix\Client\Shared\InputImg.razor"
            Label

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(3, "\r\n    ");
            __builder.OpenElement(4, "div");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputFile>(5);
            __builder.AddAttribute(6, "accept", ".jpg,.jpeg,.png");
            __builder.AddAttribute(7, "OnChange", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.InputFileChangeEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.InputFileChangeEventArgs>(this, 
#nullable restore
#line 4 "C:\Users\rapha\source\repos\MundoJix\MundoJix\Client\Shared\InputImg.razor"
                                                      OnChange

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\r\n\r\n");
            __builder.OpenElement(9, "div");
#nullable restore
#line 9 "C:\Users\rapha\source\repos\MundoJix\MundoJix\Client\Shared\InputImg.razor"
     if (imageBase64 != null)
    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(10, "div");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "style", "margin:10px");
            __builder.OpenElement(13, "img");
            __builder.AddAttribute(14, "src", "data:image/jpeg;base64," + " " + (
#nullable restore
#line 13 "C:\Users\rapha\source\repos\MundoJix\MundoJix\Client\Shared\InputImg.razor"
                                                   imageBase64

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(15, "style", "width: 400px;");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 16 "C:\Users\rapha\source\repos\MundoJix\MundoJix\Client\Shared\InputImg.razor"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\rapha\source\repos\MundoJix\MundoJix\Client\Shared\InputImg.razor"
     if (ImageURL != null)
    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(16, "div");
            __builder.OpenElement(17, "div");
            __builder.AddAttribute(18, "style", "margin:10px");
            __builder.OpenElement(19, "img");
            __builder.AddAttribute(20, "src", 
#nullable restore
#line 21 "C:\Users\rapha\source\repos\MundoJix\MundoJix\Client\Shared\InputImg.razor"
                           ImageURL

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(21, "style", "width: 400px;");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 24 "C:\Users\rapha\source\repos\MundoJix\MundoJix\Client\Shared\InputImg.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 27 "C:\Users\rapha\source\repos\MundoJix\MundoJix\Client\Shared\InputImg.razor"
       
    [Parameter] public string Label { get; set; } = "Image";
    [Parameter] public EventCallback<string> OnSelectedImage { get; set; }
    [Parameter] public string ImageURL { get; set; }
    private string imageBase64;

    async Task OnChange(InputFileChangeEventArgs e)
    {
        var imagesFiles = e.GetMultipleFiles();

        foreach (var imageFile in imagesFiles)
        {
            var buffer = new byte[imageFile.Size];
            await imageFile.OpenReadStream().ReadAsync(buffer);
            imageBase64 = Convert.ToBase64String(buffer);
            await OnSelectedImage.InvokeAsync(imageBase64);
            ImageURL = null;
            StateHasChanged();
        }
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
