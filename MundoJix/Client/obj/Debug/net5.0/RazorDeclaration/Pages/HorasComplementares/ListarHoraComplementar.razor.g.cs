// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace MundoJix.Client.Pages.HorasComplementares
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
#line 4 "C:\Users\rapha\source\repos\MundoJix\MundoJix\Client\Pages\HorasComplementares\ListarHoraComplementar.razor"
using System.Text.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 81 "C:\Users\rapha\source\repos\MundoJix\MundoJix\Client\Pages\HorasComplementares\ListarHoraComplementar.razor"
using MundoJix.Shared.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 82 "C:\Users\rapha\source\repos\MundoJix\MundoJix\Client\Pages\HorasComplementares\ListarHoraComplementar.razor"
using MundoJix.Client.Pages.Modals.ModalCad;

#line default
#line hidden
#nullable disable
#nullable restore
#line 83 "C:\Users\rapha\source\repos\MundoJix\MundoJix\Client\Pages\HorasComplementares\ListarHoraComplementar.razor"
using MundoJix.Client.Pages.Modals.ModalEdit;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/hora/lista")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/hora")]
    public partial class ListarHoraComplementar : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 83 "C:\Users\rapha\source\repos\MundoJix\MundoJix\Client\Pages\HorasComplementares\ListarHoraComplementar.razor"
                                                 
    List<HorasComplementares> horas;

    List<Aluno> alunos;

    HorasComplementares hora = new HorasComplementares();

    ModalHoracomplementar RefModal;

    ModalEditHoraComplementar RefModalEdit;

    HorasComplementares horaEdit;

    ModalForms RefModals;

    string Titulo;
    string SubTitulo;

    protected override async Task OnInitializedAsync()
    {
        await LoadHora();
        await LoadAluno();
    }

    async Task LoadHora()
    {
        horas = await http.GetFromJsonAsync<List<HorasComplementares>>($"api/hora");
    }

    async Task LoadAluno()
    {
        alunos = await http.GetFromJsonAsync<List<Aluno>>($"api/aluno");

    }

    async Task CriarHora()
    {
        await http.PostAsJsonAsync("api/hora", hora);
    }

    async Task onConfirmCad()
    {
        await Uniques(hora, horas);
        RefModal.Hide();

    }

    public void onCancelCad()
    {
        RefModal.Hide();
    }

    public void onCancel()
    {
        RefModals.Hide();
    }

    async Task onConfirmEdit()
    {
        RefModalEdit.Hide();
        await EditUniques(hora, horas );
        await LoadHora();
    }

    public void onCancelEdit()
    {
        RefModalEdit.Hide();
    }

    public void ShowErrorModal()
    {
        RefModals.Show();
    }

    public void CadNewHora()
    {
        RefModal.Show();
    }

    public void EditHora(HorasComplementares hora)
    {
        horaEdit = hora;
        RefModalEdit.Show();
    }

    async Task EditarHora()
    {
        await http.PutAsJsonAsync($"api/hora", horaEdit);
        await LoadHora();
    }

    async Task ExcluirHora(int id)
    {
        await http.DeleteAsync($"api/hora/{id}");
        await LoadHora();
    }

    async Task Uniques(HorasComplementares hora, List<HorasComplementares> lista)
    {
        foreach (HorasComplementares s in lista)
        {
            if (hora.Id == s.Id)
            {

                Titulo = "Erro ao Editar";
                SubTitulo = "";

                ShowErrorModal();
                return;
            }
        }
        await CriarHora();
        await LoadHora();
    }

    async Task EditUniques(HorasComplementares hora, List<HorasComplementares> lista)
    {
        foreach (HorasComplementares s in lista)
        {
            if (hora.Status == s.Status)
            {
                Titulo = "Erro ao Editar";
                SubTitulo = "";

                ShowErrorModal();
                return;
            }
        }
        await EditarHora();
        await LoadHora();
    }

    

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient http { get; set; }
    }
}
#pragma warning restore 1591
