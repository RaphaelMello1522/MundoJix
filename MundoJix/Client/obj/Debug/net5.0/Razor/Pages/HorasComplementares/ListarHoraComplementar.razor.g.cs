#pragma checksum "C:\Users\rapha\source\repos\MundoJix\MundoJix\Client\Pages\HorasComplementares\ListarHoraComplementar.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "07fec95406e26bce801b63d36ef523417e9f9d4c"
// <auto-generated/>
#pragma warning disable 1591
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
            __builder.OpenComponent<MundoJix.Client.Pages.Modals.ModalCad.ModalHoracomplementar>(0);
            __builder.AddAttribute(1, "horasComplementares", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MundoJix.Shared.Models.HorasComplementares>(
#nullable restore
#line 8 "C:\Users\rapha\source\repos\MundoJix\MundoJix\Client\Pages\HorasComplementares\ListarHoraComplementar.razor"
                                                                                   hora

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "alunos", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.List<MundoJix.Shared.Models.Aluno>>(
#nullable restore
#line 8 "C:\Users\rapha\source\repos\MundoJix\MundoJix\Client\Pages\HorasComplementares\ListarHoraComplementar.razor"
                                                                                                  alunos

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "onCancel", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 8 "C:\Users\rapha\source\repos\MundoJix\MundoJix\Client\Pages\HorasComplementares\ListarHoraComplementar.razor"
                                                                                                                                    onCancelCad

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(4, "onConfirm", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 8 "C:\Users\rapha\source\repos\MundoJix\MundoJix\Client\Pages\HorasComplementares\ListarHoraComplementar.razor"
                                                                                                                                                            onConfirmCad

#line default
#line hidden
#nullable disable
            )));
            __builder.AddComponentReferenceCapture(5, (__value) => {
#nullable restore
#line 8 "C:\Users\rapha\source\repos\MundoJix\MundoJix\Client\Pages\HorasComplementares\ListarHoraComplementar.razor"
                                                                                                                RefModal = (MundoJix.Client.Pages.Modals.ModalCad.ModalHoracomplementar)__value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.CloseComponent();
            __builder.AddMarkupContent(6, "\r\n\r\n");
            __builder.OpenComponent<MundoJix.Client.Pages.Modals.ModalEdit.ModalEditHoraComplementar>(7);
            __builder.AddAttribute(8, "horasComplementares", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MundoJix.Shared.Models.HorasComplementares>(
#nullable restore
#line 11 "C:\Users\rapha\source\repos\MundoJix\MundoJix\Client\Pages\HorasComplementares\ListarHoraComplementar.razor"
                                                                                        hora

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(9, "alunos", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.List<MundoJix.Shared.Models.Aluno>>(
#nullable restore
#line 11 "C:\Users\rapha\source\repos\MundoJix\MundoJix\Client\Pages\HorasComplementares\ListarHoraComplementar.razor"
                                                                                                       alunos

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(10, "Titulo", "Editar dados do Paciente/Doador");
            __builder.AddAttribute(11, "onCancel", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 11 "C:\Users\rapha\source\repos\MundoJix\MundoJix\Client\Pages\HorasComplementares\ListarHoraComplementar.razor"
                                                                                                                                                                                      onCancelEdit

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(12, "onConfirm", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 11 "C:\Users\rapha\source\repos\MundoJix\MundoJix\Client\Pages\HorasComplementares\ListarHoraComplementar.razor"
                                                                                                                                                                                                               onConfirmEdit

#line default
#line hidden
#nullable disable
            )));
            __builder.AddComponentReferenceCapture(13, (__value) => {
#nullable restore
#line 11 "C:\Users\rapha\source\repos\MundoJix\MundoJix\Client\Pages\HorasComplementares\ListarHoraComplementar.razor"
                                                                                                                                                              RefModalEdit = (MundoJix.Client.Pages.Modals.ModalEdit.ModalEditHoraComplementar)__value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.CloseComponent();
            __builder.AddMarkupContent(14, "\r\n\r\n");
            __builder.OpenComponent<MundoJix.Client.Shared.ModalForms>(15);
            __builder.AddAttribute(16, "Titulo", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 14 "C:\Users\rapha\source\repos\MundoJix\MundoJix\Client\Pages\HorasComplementares\ListarHoraComplementar.razor"
                     Titulo

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(17, "Subtitulo", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 14 "C:\Users\rapha\source\repos\MundoJix\MundoJix\Client\Pages\HorasComplementares\ListarHoraComplementar.razor"
                                         SubTitulo

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(18, "onCancel", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 14 "C:\Users\rapha\source\repos\MundoJix\MundoJix\Client\Pages\HorasComplementares\ListarHoraComplementar.razor"
                                                                               onCancel

#line default
#line hidden
#nullable disable
            )));
            __builder.AddComponentReferenceCapture(19, (__value) => {
#nullable restore
#line 14 "C:\Users\rapha\source\repos\MundoJix\MundoJix\Client\Pages\HorasComplementares\ListarHoraComplementar.razor"
                                                          RefModals = (MundoJix.Client.Shared.ModalForms)__value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.CloseComponent();
            __builder.AddMarkupContent(20, "\r\n\r\n");
            __builder.AddMarkupContent(21, "<h2 align=\"center\">Lista Para Inserção de Horas Complementares</h2>\r\n\r\n");
            __builder.OpenElement(22, "div");
#nullable restore
#line 20 "C:\Users\rapha\source\repos\MundoJix\MundoJix\Client\Pages\HorasComplementares\ListarHoraComplementar.razor"
     if (horas == null)
    {
        

#line default
#line hidden
#nullable disable
            __builder.AddContent(23, "Carregando...");
#nullable restore
#line 22 "C:\Users\rapha\source\repos\MundoJix\MundoJix\Client\Pages\HorasComplementares\ListarHoraComplementar.razor"
                                  
    }
    else if (horas.Count == 0)
    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(24, "table");
            __builder.AddAttribute(25, "class", "table table-borderless");
            __builder.AddAttribute(26, "align", "center");
            __builder.OpenElement(27, "thead");
            __builder.AddAttribute(28, "class", "thead-dark");
            __builder.OpenElement(29, "tr");
            __builder.AddAttribute(30, "align", "center");
            __builder.AddMarkupContent(31, "<th>Nome</th>\r\n                    ");
            __builder.AddMarkupContent(32, "<th>Tipo Atividade</th>\r\n                    ");
            __builder.AddMarkupContent(33, "<th>Horas</th>\r\n                    ");
            __builder.AddMarkupContent(34, "<th>Status</th>\r\n\r\n                    ");
            __builder.OpenElement(35, "th");
            __builder.OpenElement(36, "button");
            __builder.AddAttribute(37, "class", "btn btn-primary");
            __builder.AddAttribute(38, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 34 "C:\Users\rapha\source\repos\MundoJix\MundoJix\Client\Pages\HorasComplementares\ListarHoraComplementar.razor"
                                                                    () => CadNewHora()

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(39, "Nova Inserção");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n            ");
            __builder.AddMarkupContent(41, "<tbody><tr align=\"center\"><th align=\"center\" colspan=\"14\"><h3 align=\"center\">Não há nenhuma hora lançada em nosso sistema.</h3></th></tr></tbody>");
            __builder.CloseElement();
#nullable restore
#line 44 "C:\Users\rapha\source\repos\MundoJix\MundoJix\Client\Pages\HorasComplementares\ListarHoraComplementar.razor"
    }
    else
    {


#line default
#line hidden
#nullable disable
            __builder.OpenElement(42, "table");
            __builder.AddAttribute(43, "class", "table table-hover table-borderless");
            __builder.AddAttribute(44, "align", "center");
            __builder.OpenElement(45, "thead");
            __builder.AddAttribute(46, "class", "thead-dark");
            __builder.OpenElement(47, "tr");
            __builder.AddAttribute(48, "align", "center");
            __builder.AddMarkupContent(49, "<th>Nome</th>\r\n            ");
            __builder.AddMarkupContent(50, "<th>Tipo Atividade</th>\r\n            ");
            __builder.AddMarkupContent(51, "<th>Horas</th>\r\n            ");
            __builder.AddMarkupContent(52, "<th>Status</th>\r\n\r\n            ");
            __builder.OpenElement(53, "th");
            __builder.OpenElement(54, "button");
            __builder.AddAttribute(55, "class", "btn btn-primary");
            __builder.AddAttribute(56, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 56 "C:\Users\rapha\source\repos\MundoJix\MundoJix\Client\Pages\HorasComplementares\ListarHoraComplementar.razor"
                                                            () => CadNewHora()

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(57, "Nova Inserção");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(58, "\r\n    ");
            __builder.OpenElement(59, "tbody");
#nullable restore
#line 60 "C:\Users\rapha\source\repos\MundoJix\MundoJix\Client\Pages\HorasComplementares\ListarHoraComplementar.razor"
         foreach (var pessoa in horas)
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(60, "tr");
            __builder.AddAttribute(61, "align", "center");
            __builder.OpenElement(62, "td");
            __builder.AddContent(63, 
#nullable restore
#line 63 "C:\Users\rapha\source\repos\MundoJix\MundoJix\Client\Pages\HorasComplementares\ListarHoraComplementar.razor"
                     pessoa.AlunoID.ToString("")

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(64, "\r\n                ");
            __builder.OpenElement(65, "td");
            __builder.AddContent(66, 
#nullable restore
#line 64 "C:\Users\rapha\source\repos\MundoJix\MundoJix\Client\Pages\HorasComplementares\ListarHoraComplementar.razor"
                     pessoa.TipoAtividade

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(67, "\r\n                ");
            __builder.OpenElement(68, "td");
            __builder.AddContent(69, 
#nullable restore
#line 65 "C:\Users\rapha\source\repos\MundoJix\MundoJix\Client\Pages\HorasComplementares\ListarHoraComplementar.razor"
                     pessoa.QntHoras

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(70, "\r\n                ");
            __builder.OpenElement(71, "td");
            __builder.AddContent(72, 
#nullable restore
#line 66 "C:\Users\rapha\source\repos\MundoJix\MundoJix\Client\Pages\HorasComplementares\ListarHoraComplementar.razor"
                     pessoa.Status

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(73, "\r\n\r\n                ");
            __builder.OpenElement(74, "td");
            __builder.OpenElement(75, "button");
            __builder.AddAttribute(76, "class", "btn btn-success");
            __builder.AddAttribute(77, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 69 "C:\Users\rapha\source\repos\MundoJix\MundoJix\Client\Pages\HorasComplementares\ListarHoraComplementar.razor"
                                                                () => EditHora(pessoa)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(78, "Editar");
            __builder.CloseElement();
            __builder.AddMarkupContent(79, "\r\n                    ");
            __builder.OpenElement(80, "button");
            __builder.AddAttribute(81, "class", "btn btn-danger");
            __builder.AddAttribute(82, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 70 "C:\Users\rapha\source\repos\MundoJix\MundoJix\Client\Pages\HorasComplementares\ListarHoraComplementar.razor"
                                                               () => ExcluirHora(pessoa.Id)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(83, "Excluir");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 73 "C:\Users\rapha\source\repos\MundoJix\MundoJix\Client\Pages\HorasComplementares\ListarHoraComplementar.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 76 "C:\Users\rapha\source\repos\MundoJix\MundoJix\Client\Pages\HorasComplementares\ListarHoraComplementar.razor"

    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(84, "\r\n\r\n}\r\n\r\n");
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
