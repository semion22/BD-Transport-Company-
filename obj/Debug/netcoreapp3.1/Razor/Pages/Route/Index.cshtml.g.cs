#pragma checksum "C:\Users\samar\Source\Repos\BDTransportCompany\BDTransportCompany\Pages\Route\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5fa3733f273bcf7ba2c8f4d7e85d1e7027b11be6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(BDTransportCompany.Pages.Route.Pages_Route_Index), @"mvc.1.0.razor-page", @"/Pages/Route/Index.cshtml")]
namespace BDTransportCompany.Pages.Route
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
#line 1 "C:\Users\samar\Source\Repos\BDTransportCompany\BDTransportCompany\Pages\_ViewImports.cshtml"
using BDTransportCompany;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5fa3733f273bcf7ba2c8f4d7e85d1e7027b11be6", @"/Pages/Route/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aa52d245b43874c1c3c462dbe06e571b0ae8dfd4", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Route_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\samar\Source\Repos\BDTransportCompany\BDTransportCompany\Pages\Route\Index.cshtml"
  
    ViewData["Title"] = "Таблица";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Таблица</h1>\r\n\r\n<p>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5fa3733f273bcf7ba2c8f4d7e85d1e7027b11be64431", async() => {
                WriteLiteral("Добавить");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 17 "C:\Users\samar\Source\Repos\BDTransportCompany\BDTransportCompany\Pages\Route\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Routes[0].CarID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 20 "C:\Users\samar\Source\Repos\BDTransportCompany\BDTransportCompany\Pages\Route\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Routes[0].Customer));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 23 "C:\Users\samar\Source\Repos\BDTransportCompany\BDTransportCompany\Pages\Route\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Routes[0].WhereFrom));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 26 "C:\Users\samar\Source\Repos\BDTransportCompany\BDTransportCompany\Pages\Route\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Routes[0].Where));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 29 "C:\Users\samar\Source\Repos\BDTransportCompany\BDTransportCompany\Pages\Route\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Routes[0].DateOfDeparture));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 32 "C:\Users\samar\Source\Repos\BDTransportCompany\BDTransportCompany\Pages\Route\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Routes[0].DateOfArrival));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 35 "C:\Users\samar\Source\Repos\BDTransportCompany\BDTransportCompany\Pages\Route\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Routes[0].Cargo_ID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 38 "C:\Users\samar\Source\Repos\BDTransportCompany\BDTransportCompany\Pages\Route\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Routes[0].Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 41 "C:\Users\samar\Source\Repos\BDTransportCompany\BDTransportCompany\Pages\Route\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Routes[0].RecordOfThePayment));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 44 "C:\Users\samar\Source\Repos\BDTransportCompany\BDTransportCompany\Pages\Route\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Routes[0].TheMarkOnTheReturn));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 47 "C:\Users\samar\Source\Repos\BDTransportCompany\BDTransportCompany\Pages\Route\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Routes[0].Staff_ID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 53 "C:\Users\samar\Source\Repos\BDTransportCompany\BDTransportCompany\Pages\Route\Index.cshtml"
 foreach (var item in Model.Routes) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n");
#nullable restore
#line 56 "C:\Users\samar\Source\Repos\BDTransportCompany\BDTransportCompany\Pages\Route\Index.cshtml"
                  
                    try
                    {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 59 "C:\Users\samar\Source\Repos\BDTransportCompany\BDTransportCompany\Pages\Route\Index.cshtml"
                   Write(Model.Cars.First(r => r.ID == item.CarID).CarBrand_ID);

#line default
#line hidden
#nullable disable
#nullable restore
#line 59 "C:\Users\samar\Source\Repos\BDTransportCompany\BDTransportCompany\Pages\Route\Index.cshtml"
                                                                              
                    }
                    catch
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <p> Данных нет </p>\r\n");
#nullable restore
#line 64 "C:\Users\samar\Source\Repos\BDTransportCompany\BDTransportCompany\Pages\Route\Index.cshtml"
                    }
                

#line default
#line hidden
#nullable disable
            WriteLiteral("            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 68 "C:\Users\samar\Source\Repos\BDTransportCompany\BDTransportCompany\Pages\Route\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Customer));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 71 "C:\Users\samar\Source\Repos\BDTransportCompany\BDTransportCompany\Pages\Route\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.WhereFrom));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 74 "C:\Users\samar\Source\Repos\BDTransportCompany\BDTransportCompany\Pages\Route\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Where));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 77 "C:\Users\samar\Source\Repos\BDTransportCompany\BDTransportCompany\Pages\Route\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.DateOfDeparture));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 80 "C:\Users\samar\Source\Repos\BDTransportCompany\BDTransportCompany\Pages\Route\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.DateOfArrival));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n");
#nullable restore
#line 83 "C:\Users\samar\Source\Repos\BDTransportCompany\BDTransportCompany\Pages\Route\Index.cshtml"
                  
                    try
                    {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 86 "C:\Users\samar\Source\Repos\BDTransportCompany\BDTransportCompany\Pages\Route\Index.cshtml"
                   Write(Model.Cargos.First(r => r.ID == item.CargoID).Title);

#line default
#line hidden
#nullable disable
#nullable restore
#line 86 "C:\Users\samar\Source\Repos\BDTransportCompany\BDTransportCompany\Pages\Route\Index.cshtml"
                                                                            
                    }
                    catch
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <p> Данных нет </p>\r\n");
#nullable restore
#line 91 "C:\Users\samar\Source\Repos\BDTransportCompany\BDTransportCompany\Pages\Route\Index.cshtml"
                    }
                

#line default
#line hidden
#nullable disable
            WriteLiteral("            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 95 "C:\Users\samar\Source\Repos\BDTransportCompany\BDTransportCompany\Pages\Route\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 98 "C:\Users\samar\Source\Repos\BDTransportCompany\BDTransportCompany\Pages\Route\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.RecordOfThePayment));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 101 "C:\Users\samar\Source\Repos\BDTransportCompany\BDTransportCompany\Pages\Route\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.TheMarkOnTheReturn));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n");
#nullable restore
#line 104 "C:\Users\samar\Source\Repos\BDTransportCompany\BDTransportCompany\Pages\Route\Index.cshtml"
                  
                    try
                    {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 107 "C:\Users\samar\Source\Repos\BDTransportCompany\BDTransportCompany\Pages\Route\Index.cshtml"
                   Write(Model.Staff.First(r => r.ID == item.StaffID).FullName);

#line default
#line hidden
#nullable disable
#nullable restore
#line 107 "C:\Users\samar\Source\Repos\BDTransportCompany\BDTransportCompany\Pages\Route\Index.cshtml"
                                                                              
                    }
                    catch
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <p> Данных нет </p>\r\n");
#nullable restore
#line 112 "C:\Users\samar\Source\Repos\BDTransportCompany\BDTransportCompany\Pages\Route\Index.cshtml"
                    }
                

#line default
#line hidden
#nullable disable
            WriteLiteral("            </td>\r\n            <td>\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5fa3733f273bcf7ba2c8f4d7e85d1e7027b11be616048", async() => {
                WriteLiteral("Изменить");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 116 "C:\Users\samar\Source\Repos\BDTransportCompany\BDTransportCompany\Pages\Route\Index.cshtml"
                                       WriteLiteral(item.ID);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" |\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5fa3733f273bcf7ba2c8f4d7e85d1e7027b11be618228", async() => {
                WriteLiteral("Подробнее");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 117 "C:\Users\samar\Source\Repos\BDTransportCompany\BDTransportCompany\Pages\Route\Index.cshtml"
                                          WriteLiteral(item.ID);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" |\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5fa3733f273bcf7ba2c8f4d7e85d1e7027b11be620412", async() => {
                WriteLiteral("Удалить");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 118 "C:\Users\samar\Source\Repos\BDTransportCompany\BDTransportCompany\Pages\Route\Index.cshtml"
                                         WriteLiteral(item.ID);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 121 "C:\Users\samar\Source\Repos\BDTransportCompany\BDTransportCompany\Pages\Route\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BDTransportCompany.Pages.Route.IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<BDTransportCompany.Pages.Route.IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<BDTransportCompany.Pages.Route.IndexModel>)PageContext?.ViewData;
        public BDTransportCompany.Pages.Route.IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591