#pragma checksum "C:\Users\Rafaella Alves Silva\source\repos\WebApplicationTeste\WebApplication\Views\Shared\Components\ClientIndex\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "71a6cee39244573f470dbe1d67915f64eebe23a5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_ClientIndex_Default), @"mvc.1.0.view", @"/Views/Shared/Components/ClientIndex/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"71a6cee39244573f470dbe1d67915f64eebe23a5", @"/Views/Shared/Components/ClientIndex/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fa0ef8da47a84ffb33e8bc853509aa4fa5703a26", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_ClientIndex_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<table id=""client-table"" class=""display table table-striped table-bordered table-condensed"" style=""border-collapse: collapse !important; width:100%;"">
    <thead>
        <tr>
            <th>Código</th>
            <th>Nome</th>
            <th>Email</th>
            <th>CPF/CNPJ</th>
            <th>Tipo</th>
            <th>&nbsp;</th>
        </tr>
    </thead>
    <tbody></tbody>
</table>
<script type=""text/javascript"">
    var clientDatatables;
    $(document).ready(function () {
        clientDatatables = $('#client-table').DataTable({
            serverSide: false,
            proccessing: true,
            searching: true,
            lengthChange: false,
            pageLength: 30,
            //dom: 'tip',
            ajax: {
                url: '");
#nullable restore
#line 25 "C:\Users\Rafaella Alves Silva\source\repos\WebApplicationTeste\WebApplication\Views\Shared\Components\ClientIndex\Default.cshtml"
                 Write(Url.Action("List", "Client"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"',
                type: 'POST'
            },
            columns: [
                { render: function (data, type, row) { return '<div class=""text-center"">' + row.clientId; } },
                { render: function (data, type, row) { return '<a class=""text-uppercase"" href=""");
#nullable restore
#line 30 "C:\Users\Rafaella Alves Silva\source\repos\WebApplicationTeste\WebApplication\Views\Shared\Components\ClientIndex\Default.cshtml"
                                                                                          Write(Url.Action("Manage", "Client"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"?id=' + row.clientId + '"" >' + row.name + '</a>'; } },
                { render: function (data, type, row) { return row.email; } },
                { render: function (data, type, row) { return row.cpfcnpjDocument; } },
                { render: function (data, type, row) { return '<div class=""' + (row.typeClient = 1 ? 'cpf' : 'cnpj') + '"">' + row.document + '</div>'; } },
                {
                    render: function (data, type, row)
                    {
                        return '<div class=""text-center"">' +                           
                            '&nbsp;<a href=""");
#nullable restore
#line 38 "C:\Users\Rafaella Alves Silva\source\repos\WebApplicationTeste\WebApplication\Views\Shared\Components\ClientIndex\Default.cshtml"
                                       Write(Url.Action("Manage", "Client"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"?id=' + row.clientId + '""  title=""Editar""><span class=""badge badge-pill badge-success""><i class=""simple-icon-note""></i></span></a>' +
                            '&nbsp;<a href=\'javascript:removeClient(' + JSON.stringify(row) + ')\' title=""Excluir""><span class=""badge badge-pill badge-danger""><i class=""simple-icon-trash""></i></span></a>' +
                            '</div>';
                    }
                }
            ]
        });
    });

    function removeClient(client) {
        bootboxConfirm(""Deseja realmente excluir o cliente \"""" + client.name + ""\""?"", function(result){
            if (!result) return;

            $.post('");
#nullable restore
#line 51 "C:\Users\Rafaella Alves Silva\source\repos\WebApplicationTeste\WebApplication\Views\Shared\Components\ClientIndex\Default.cshtml"
               Write(Url.Action("_Delete", "Client"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\', { id: client.clientId }, function (d) {\r\n                if (d.hasError) {\r\n                    bootboxConfirm(d.message, function (d) {\r\n                        if(d) window.location.href = \'");
#nullable restore
#line 54 "C:\Users\Rafaella Alves Silva\source\repos\WebApplicationTeste\WebApplication\Views\Shared\Components\ClientIndex\Default.cshtml"
                                                 Write(Url.Action("Manage", "Client"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"?id=' + client.clientId;
                    })
                    return;
                }

                bootbox.alert(""Cliente \"""" + client.name + ""\"" excluído com sucesso!"");
                clientDatatables.ajax.reload();
            });
        });
    }
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
