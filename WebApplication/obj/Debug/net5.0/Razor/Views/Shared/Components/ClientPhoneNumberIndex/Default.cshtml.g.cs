#pragma checksum "C:\Users\Rafaella Alves Silva\source\repos\WebApplicationTeste\WebApplication\Views\Shared\Components\ClientPhoneNumberIndex\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4ec3d9dd8329032875371940178fa3889f44e1b6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_ClientPhoneNumberIndex_Default), @"mvc.1.0.view", @"/Views/Shared/Components/ClientPhoneNumberIndex/Default.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\Rafaella Alves Silva\source\repos\WebApplicationTeste\WebApplication\Views\_ViewImports.cshtml"
using WebApplication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Rafaella Alves Silva\source\repos\WebApplicationTeste\WebApplication\Views\_ViewImports.cshtml"
using WebApplication.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4ec3d9dd8329032875371940178fa3889f44e1b6", @"/Views/Shared/Components/ClientPhoneNumberIndex/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fa0ef8da47a84ffb33e8bc853509aa4fa5703a26", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_ClientPhoneNumberIndex_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div class=""row"">
    <div class=""col-md-auto form-group"">
        <a href=""javascript: openClientPhoneEditModal();"" class=""btn btn-primary w-100 float-right text-nowrap""><i class=""simple-icon-plus""></i>&nbsp;Adicionar</a>
    </div>
</div>
<hr />
<div id=""success-area-client-phone""></div>
<div class=""row"">
    <div class=""col-md-12"">
        <div class=""table-responsive"">
            <table id=""client-address-table"" class=""display nowrap table table-striped table-bordered table-condensed w-100"" style=""border-collapse: collapse !important;"">
                <thead>
                    <tr>
                        <th>Telefone/Celular</th>                      
                        <th>&nbsp;</th>
                    </tr>
                </thead>
                <tbody></tbody>
            </table>
        </div>
    </div>
</div>
<div class=""modal fade"" id=""client-phone-modal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""client-phone-modal-title"" aria-hidden=""true"">
    <div class=""modal-dialog"" role=""doc");
            WriteLiteral(@"ument"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title tx-14 mg-b-0 tx-uppercase tx-inverse tx-bold"" id=""client-phone-modal-title""></h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body"">
                ");
#nullable restore
#line 33 "C:\Users\Rafaella Alves Silva\source\repos\WebApplicationTeste\WebApplication\Views\Shared\Components\ClientPhoneNumberIndex\Default.cshtml"
            Write(await Component.InvokeAsync("ClientPhoneNumberManage", new { id = Model.Model }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
            </div>
            <div class=""modal-footer"">
                <div class=""col-md-6"">
                    <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal""><i class=""simple-icon-close""></i>&nbsp;Fechar</button>
                </div>
                <div class=""col-md-6"">
                    <button type=""button"" class=""btn btn-success float-right"" id=""client-phone-modal-save-button""><i class=""simple-icon-cloud-upload""></i>&nbsp;Salvar</button>
                </div>
            </div>
        </div>
    </div>
</div>
<script type=""text/javascript"">
 var clientPhoneDatatables;
    $(document).ready(function () {
        clientPhoneDatatables = $('#client-phone-table').DataTable({
            serverSide: false,
            proccessing: true,
            searching: true,
            lengthChange: false,
            //dom: 'tip',
            scrollX: true,
            ajax: {
                url: '");
#nullable restore
#line 57 "C:\Users\Rafaella Alves Silva\source\repos\WebApplicationTeste\WebApplication\Views\Shared\Components\ClientPhoneNumberIndex\Default.cshtml"
                 Write(Url.Action("List", "ClientPhoneNumber"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\',\n                data: function (d) {\n                d.clientId = \'");
#nullable restore
#line 59 "C:\Users\Rafaella Alves Silva\source\repos\WebApplicationTeste\WebApplication\Views\Shared\Components\ClientPhoneNumberIndex\Default.cshtml"
                         Write(Model.Model);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"'
                },
                type: 'POST'
                },
                columns: [
                    { render: function (data, type, row) { return '<div class=""cep"">' + row.phoneNumber + '</div>'; } },
                    {
                        render: function (data, type, row)
                        {

                            return '<div class=\""text-nowrap text-center\"">' +
                                '&nbsp;<a href=\'javascript:openClientPhoneEditModal(' + JSON.stringify(row) + ')\' title=\""Editar\""><span class=\""badge badge-pill badge-success\""><i class=\""simple-icon-note\""></i></span></a>' +
                                '&nbsp;<a href=\'javascript:removeClientPhone(' + JSON.stringify(row) + ')\' title=\""Excluir\""><span class=\""badge badge-pill badge-danger\""><i class=\""simple-icon-trash\""></i></span></a>' +
                                '</div>';

                        }
                    }
                ]
         });
         initSearchDataTable();
     });

    ");
            WriteLiteral("function removeClientPhone(clientCollectionAddress) {\n        bootboxConfirm(\"Deseja realmente excluir o contato \\\"\" + clientPhone.phoneNumber + \"\\\"?\", function (result) {\n                if (!result) return;\n\n                $.post(\'");
#nullable restore
#line 85 "C:\Users\Rafaella Alves Silva\source\repos\WebApplicationTeste\WebApplication\Views\Shared\Components\ClientPhoneNumberIndex\Default.cshtml"
                   Write(Url.Action("DeletePhone", "ClientPhoneNumber"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"', { id: clientPhone.clientId }, function (d) {
                bootbox.alert(d.message);

                if(!d.hasError)
                clientPhoneDatatables.ajax.reload();
                });
                });
                }

                function openClientPhoneEditModal(data) {
                $(""#main-address-area"").appendTo(""#form-client-collection-address .row:first"");

                    $('#form-client-phone [name=\'PhoneNumber\']').val(data == null ? '' : $('.cep').masked(data.phoneNumber));
                    $('#form-client-phone [name=\'TypePhoneNumber\']').val(data == null? '' : data.typePhoneNumber);
                   



                $('#client-phone-modal-title').text(data == null ? 'Novo Contato' : 'Editar Contato');
                $('#client-phone-modal').modal('show');
                }

                $('#client-phone-modal-save-button').click(function () {
                if (!validateInputs('form-client-phone')) return;
                $('#success-area-client-phone').e");
            WriteLiteral("mpty();\n\n                $.post(\"");
#nullable restore
#line 111 "C:\Users\Rafaella Alves Silva\source\repos\WebApplicationTeste\WebApplication\Views\Shared\Components\ClientPhoneNumberIndex\Default.cshtml"
                   Write(Url.Action("ManageAjax", "ClientPhoneNumber"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@""", $('#form-client-phone').serializeArray(), function (d) {
                clientPhoneDatatables.ajax.reload();
                clientPhoneDatatables.search($('#client-phone-search').val()).draw();

                $('#success-area-client-phone').empty().append(successMessage());

                $('#client-phone-modal').modal('hide');
                });
                });

                //$('#client-collection-address-modal').on('modal.bs.hide', function () {
                //    $(""#main-address-area"").appendTo(""#form-client-collection-address .address-sm:first"");
                //});
</script>
");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
