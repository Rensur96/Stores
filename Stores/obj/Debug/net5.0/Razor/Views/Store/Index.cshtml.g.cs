#pragma checksum "C:\Users\Alex\Desktop\proyectos\Net Core\Stores\Stores\Views\Store\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c0362bb06b7fae083424a9775df2fd7839f835f3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Store_Index), @"mvc.1.0.view", @"/Views/Store/Index.cshtml")]
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
#line 1 "C:\Users\Alex\Desktop\proyectos\Net Core\Stores\Stores\Views\_ViewImports.cshtml"
using Stores;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Alex\Desktop\proyectos\Net Core\Stores\Stores\Views\_ViewImports.cshtml"
using Stores.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Alex\Desktop\proyectos\Net Core\Stores\Stores\Views\_ViewImports.cshtml"
using Stores.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Alex\Desktop\proyectos\Net Core\Stores\Stores\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c0362bb06b7fae083424a9775df2fd7839f835f3", @"/Views/Store/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a02f08a0bf1fb25500dea8fbba33f820d4735f46", @"/Views/_ViewImports.cshtml")]
    public class Views_Store_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Store>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info d-block"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddStore", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Store", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success "), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger "), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\Alex\Desktop\proyectos\Net Core\Stores\Stores\Views\Store\Index.cshtml"
  
    ViewData["Title"] = "Stores";

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Alex\Desktop\proyectos\Net Core\Stores\Stores\Views\Store\Index.cshtml"
 if (TempData["mensaje"] != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"alert alert-success alert-dismissible fade show \" role=\"alert\">\r\n        ");
#nullable restore
#line 9 "C:\Users\Alex\Desktop\proyectos\Net Core\Stores\Stores\Views\Store\Index.cshtml"
   Write(TempData["mensaje"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(";\r\n        <button type=\"button\" class=\"close\" data-dismiss=\"alert\" aria-label=\"Close\">\r\n            <span aria-hidden=\"true\">&times;</span>\r\n        </button>\r\n    </div>\r\n");
#nullable restore
#line 14 "C:\Users\Alex\Desktop\proyectos\Net Core\Stores\Stores\Views\Store\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"row\">\r\n    <div class=\"col-sm-6\">\r\n        <h3>");
#nullable restore
#line 17 "C:\Users\Alex\Desktop\proyectos\Net Core\Stores\Stores\Views\Store\Index.cshtml"
       Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n    </div>\r\n    <div class=\"col-sm-6\">\r\n");
#nullable restore
#line 20 "C:\Users\Alex\Desktop\proyectos\Net Core\Stores\Stores\Views\Store\Index.cshtml"
         if (SignInManager.IsSignedIn(User) && User.IsInRole("administrador"))
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c0362bb06b7fae083424a9775df2fd7839f835f37481", async() => {
                WriteLiteral("Add Store");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 23 "C:\Users\Alex\Desktop\proyectos\Net Core\Stores\Stores\Views\Store\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</div>\r\n<div class=\"row\">\r\n    <div class=\"col-sm-12\">\r\n\r\n");
#nullable restore
#line 29 "C:\Users\Alex\Desktop\proyectos\Net Core\Stores\Stores\Views\Store\Index.cshtml"
         if (Model.Count() > 0)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <table id=\"dtBasicExample\" class=\"table table-striped table-bordered table-m\" cellspacing=\"0\" width=\"100%\">\r\n                <thead>\r\n                    <tr>\r\n                        <th class=\"th-sm\">");
#nullable restore
#line 34 "C:\Users\Alex\Desktop\proyectos\Net Core\Stores\Stores\Views\Store\Index.cshtml"
                                     Write(Html.DisplayNameFor(m => m.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                        <th class=\"th-sm\">");
#nullable restore
#line 35 "C:\Users\Alex\Desktop\proyectos\Net Core\Stores\Stores\Views\Store\Index.cshtml"
                                     Write(Html.DisplayNameFor(m => m.Nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                        <th class=\"th-sm\">");
#nullable restore
#line 36 "C:\Users\Alex\Desktop\proyectos\Net Core\Stores\Stores\Views\Store\Index.cshtml"
                                     Write(Html.DisplayNameFor(m => m.Direccion));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                        <th class=\"th-sm\">");
#nullable restore
#line 37 "C:\Users\Alex\Desktop\proyectos\Net Core\Stores\Stores\Views\Store\Index.cshtml"
                                     Write(Html.DisplayNameFor(m => m.Telefono));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                        <th class=\"th-sm\">");
#nullable restore
#line 38 "C:\Users\Alex\Desktop\proyectos\Net Core\Stores\Stores\Views\Store\Index.cshtml"
                                     Write(Html.DisplayNameFor(m => m.Lat));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                        <th class=\"th-sm\">");
#nullable restore
#line 39 "C:\Users\Alex\Desktop\proyectos\Net Core\Stores\Stores\Views\Store\Index.cshtml"
                                     Write(Html.DisplayNameFor(m => m.Long));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                        <th class=\"th-sm\"><center>Actions</center></th>\r\n                    </tr>\r\n                </thead>\r\n                <tbody>\r\n");
#nullable restore
#line 44 "C:\Users\Alex\Desktop\proyectos\Net Core\Stores\Stores\Views\Store\Index.cshtml"
                     foreach (var item in Model)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td>");
#nullable restore
#line 47 "C:\Users\Alex\Desktop\proyectos\Net Core\Stores\Stores\Views\Store\Index.cshtml"
                           Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 48 "C:\Users\Alex\Desktop\proyectos\Net Core\Stores\Stores\Views\Store\Index.cshtml"
                           Write(item.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 49 "C:\Users\Alex\Desktop\proyectos\Net Core\Stores\Stores\Views\Store\Index.cshtml"
                           Write(item.Direccion);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 50 "C:\Users\Alex\Desktop\proyectos\Net Core\Stores\Stores\Views\Store\Index.cshtml"
                           Write(item.Telefono);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td class=\"td-lat\">");
#nullable restore
#line 51 "C:\Users\Alex\Desktop\proyectos\Net Core\Stores\Stores\Views\Store\Index.cshtml"
                                          Write(item.Lat);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td class=\"td-long\">");
#nullable restore
#line 52 "C:\Users\Alex\Desktop\proyectos\Net Core\Stores\Stores\Views\Store\Index.cshtml"
                                           Write(item.Long);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>\r\n                               \r\n");
#nullable restore
#line 55 "C:\Users\Alex\Desktop\proyectos\Net Core\Stores\Stores\Views\Store\Index.cshtml"
                                     if (SignInManager.IsSignedIn(User) && User.IsInRole("administrador"))
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c0362bb06b7fae083424a9775df2fd7839f835f314245", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 57 "C:\Users\Alex\Desktop\proyectos\Net Core\Stores\Stores\Views\Store\Index.cshtml"
                                                                                         WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c0362bb06b7fae083424a9775df2fd7839f835f316772", async() => {
                WriteLiteral("Delete");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 58 "C:\Users\Alex\Desktop\proyectos\Net Core\Stores\Stores\Views\Store\Index.cshtml"
                                                                                        WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 59 "C:\Users\Alex\Desktop\proyectos\Net Core\Stores\Stores\Views\Store\Index.cshtml"

                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                    <button type=""button"" class=""btn btn-primary  btn-viewmap"" data-toggle=""modal"" data-target=""#exampleModalCenter"">
                                        View Map
                                    </button>
                            
                            </td>
                        </tr>
");
#nullable restore
#line 67 "C:\Users\Alex\Desktop\proyectos\Net Core\Stores\Stores\Views\Store\Index.cshtml"

                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </tbody>\r\n                <tfoot>\r\n                    <tr>\r\n                        <th class=\"th-sm\">");
#nullable restore
#line 72 "C:\Users\Alex\Desktop\proyectos\Net Core\Stores\Stores\Views\Store\Index.cshtml"
                                     Write(Html.DisplayNameFor(m => m.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                        <th class=\"th-sm\">");
#nullable restore
#line 73 "C:\Users\Alex\Desktop\proyectos\Net Core\Stores\Stores\Views\Store\Index.cshtml"
                                     Write(Html.DisplayNameFor(m => m.Nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                        <th class=\"th-sm\">");
#nullable restore
#line 74 "C:\Users\Alex\Desktop\proyectos\Net Core\Stores\Stores\Views\Store\Index.cshtml"
                                     Write(Html.DisplayNameFor(m => m.Direccion));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                        <th class=\"th-sm\">");
#nullable restore
#line 75 "C:\Users\Alex\Desktop\proyectos\Net Core\Stores\Stores\Views\Store\Index.cshtml"
                                     Write(Html.DisplayNameFor(m => m.Telefono));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                        <th class=\"th-sm\">");
#nullable restore
#line 76 "C:\Users\Alex\Desktop\proyectos\Net Core\Stores\Stores\Views\Store\Index.cshtml"
                                     Write(Html.DisplayNameFor(m => m.Lat));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                        <th class=\"th-sm\">");
#nullable restore
#line 77 "C:\Users\Alex\Desktop\proyectos\Net Core\Stores\Stores\Views\Store\Index.cshtml"
                                     Write(Html.DisplayNameFor(m => m.Long));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                        <th class=\"th-sm\"><center>Actions</center></th>\r\n                    </tr>\r\n                </tfoot>\r\n            </table>\r\n");
#nullable restore
#line 82 "C:\Users\Alex\Desktop\proyectos\Net Core\Stores\Stores\Views\Store\Index.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <p>No contiene registros</p>\r\n");
#nullable restore
#line 86 "C:\Users\Alex\Desktop\proyectos\Net Core\Stores\Stores\Views\Store\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    </div>
</div>
<!-- Modal View map -->
<div class=""modal fade"" id=""exampleModalCenter"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalCenterTitle"" aria-hidden=""true"">
    <div class=""modal-dialog modal-dialog-centered"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"" id=""exampleModalLongTitle"">Ubication</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body"">
                <div class=""col-sm-12"">
                    <div id=""map"" style=""height:400px;width:100%;""></div>
                </div>
            </div>
            <div class=""modal-footer"">
                <button type=""button"" class=""btn btn-danger"" data-dismiss=""modal"">Close</button>
            </div>
        </div>
    </div>
</div>
<script>
    le");
            WriteLiteral(@"t storeLat ="""";
    let storeLong = """";
    let mapa;
    let marker;
    var myLatLng = { lat: 13.794185, lng: -88.89653 };
    $(document).ready(function () {
        $("".btn-viewmap"").click(function () {
            // Obtenemos todos los valores contenidos en los <td> de la fila
            // seleccionada
            $(this).parents(""tr"").find("".td-lat"").each(function () {
                storeLat = Number($(this).html() );
            });
            $(this).parents(""tr"").find("".td-long"").each(function () {
                storeLong = Number($(this).html());
            });

            myLatLng = { lat: Number(storeLat), lng: Number(storeLong) };
            console.log(myLatLng);
            marker.setPosition(myLatLng);
        });
    });
    function initMap() {
        //Ubicacion por defecto
        console.log(myLatLng);
        mapa = new google.maps.Map(document.getElementById(""map""), {
            zoom: 8,
            center: myLatLng,
            mapTypeId: google.");
            WriteLiteral(@"maps.MapTypeId.ROADMAP
        });
        marker = new google.maps.Marker({
            position: myLatLng,
            map: mapa,
            draggable: true,
        });
        // centrar mapa en coordenadas
        mapa.setCenter(marker.position);

        //agregar marker al mapa
        marker.setMap(mapa);
    }
</script>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SignInManager<UsuarioApliacion> SignInManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Store>> Html { get; private set; }
    }
}
#pragma warning restore 1591
