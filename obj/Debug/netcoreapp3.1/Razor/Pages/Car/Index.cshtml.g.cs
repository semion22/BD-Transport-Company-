#pragma checksum "C:\Users\samar\Source\Repos\BDTransportCompany\BDTransportCompany\Pages\Car\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8c817debac99a543fba9b6c956bac72e928b24e3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(BDTransportCompany.Pages.Car.Pages_Car_Index), @"mvc.1.0.razor-page", @"/Pages/Car/Index.cshtml")]
namespace BDTransportCompany.Pages.Car
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8c817debac99a543fba9b6c956bac72e928b24e3", @"/Pages/Car/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aa52d245b43874c1c3c462dbe06e571b0ae8dfd4", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Car_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
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
#line 4 "C:\Users\samar\Source\Repos\BDTransportCompany\BDTransportCompany\Pages\Car\Index.cshtml"
  
    ViewData["Title"] = "??????????????";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>??????????????</h1>\r\n\r\n<p>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8c817debac99a543fba9b6c956bac72e928b24e34415", async() => {
                WriteLiteral("????????????????");
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
#line 17 "C:\Users\samar\Source\Repos\BDTransportCompany\BDTransportCompany\Pages\Car\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Cars[0].Car_ID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 20 "C:\Users\samar\Source\Repos\BDTransportCompany\BDTransportCompany\Pages\Car\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Cars[0].CarBrand_ID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 23 "C:\Users\samar\Source\Repos\BDTransportCompany\BDTransportCompany\Pages\Car\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Cars[0].TypeOfCar_ID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 26 "C:\Users\samar\Source\Repos\BDTransportCompany\BDTransportCompany\Pages\Car\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Cars[0].RegistrationNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 29 "C:\Users\samar\Source\Repos\BDTransportCompany\BDTransportCompany\Pages\Car\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Cars[0].BodyNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 32 "C:\Users\samar\Source\Repos\BDTransportCompany\BDTransportCompany\Pages\Car\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Cars[0].EngineNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 35 "C:\Users\samar\Source\Repos\BDTransportCompany\BDTransportCompany\Pages\Car\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Cars[0].YearOfIssue));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 38 "C:\Users\samar\Source\Repos\BDTransportCompany\BDTransportCompany\Pages\Car\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Cars[0].Position_ID1));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 41 "C:\Users\samar\Source\Repos\BDTransportCompany\BDTransportCompany\Pages\Car\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Cars[0].LastMaintenanceDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 44 "C:\Users\samar\Source\Repos\BDTransportCompany\BDTransportCompany\Pages\Car\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Cars[0].Position_ID2));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 50 "C:\Users\samar\Source\Repos\BDTransportCompany\BDTransportCompany\Pages\Car\Index.cshtml"
 foreach (var item in Model.Cars) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 53 "C:\Users\samar\Source\Repos\BDTransportCompany\BDTransportCompany\Pages\Car\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Car_ID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n");
#nullable restore
#line 56 "C:\Users\samar\Source\Repos\BDTransportCompany\BDTransportCompany\Pages\Car\Index.cshtml"
                  
                    try
                    {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 59 "C:\Users\samar\Source\Repos\BDTransportCompany\BDTransportCompany\Pages\Car\Index.cshtml"
                   Write(Model.CarsBrands.First(r => r.ID == item.CarBrandID).Title);

#line default
#line hidden
#nullable disable
#nullable restore
#line 59 "C:\Users\samar\Source\Repos\BDTransportCompany\BDTransportCompany\Pages\Car\Index.cshtml"
                                                                                   
                    }
                    catch
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <p> ???????????? ?????? </p>\r\n");
#nullable restore
#line 64 "C:\Users\samar\Source\Repos\BDTransportCompany\BDTransportCompany\Pages\Car\Index.cshtml"
                    }
                

#line default
#line hidden
#nullable disable
            WriteLiteral("            </td>\r\n            <td>\r\n");
#nullable restore
#line 68 "C:\Users\samar\Source\Repos\BDTransportCompany\BDTransportCompany\Pages\Car\Index.cshtml"
                  
                    try
                    {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 71 "C:\Users\samar\Source\Repos\BDTransportCompany\BDTransportCompany\Pages\Car\Index.cshtml"
                   Write(Model.TypesOfCars.First(r => r.ID == item.TypeOfCarID).Name);

#line default
#line hidden
#nullable disable
#nullable restore
#line 71 "C:\Users\samar\Source\Repos\BDTransportCompany\BDTransportCompany\Pages\Car\Index.cshtml"
                                                                                    
                    }
                    catch
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <p> ???????????? ?????? </p>\r\n");
#nullable restore
#line 76 "C:\Users\samar\Source\Repos\BDTransportCompany\BDTransportCompany\Pages\Car\Index.cshtml"
                    }
                

#line default
#line hidden
#nullable disable
            WriteLiteral("            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 80 "C:\Users\samar\Source\Repos\BDTransportCompany\BDTransportCompany\Pages\Car\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.RegistrationNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 83 "C:\Users\samar\Source\Repos\BDTransportCompany\BDTransportCompany\Pages\Car\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.BodyNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 86 "C:\Users\samar\Source\Repos\BDTransportCompany\BDTransportCompany\Pages\Car\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.EngineNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 89 "C:\Users\samar\Source\Repos\BDTransportCompany\BDTransportCompany\Pages\Car\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.YearOfIssue));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n");
#nullable restore
#line 92 "C:\Users\samar\Source\Repos\BDTransportCompany\BDTransportCompany\Pages\Car\Index.cshtml"
                  
                    try
                    {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 95 "C:\Users\samar\Source\Repos\BDTransportCompany\BDTransportCompany\Pages\Car\Index.cshtml"
                   Write(Model.Staff.First(r => r.ID == item.PositionID1).FullName);

#line default
#line hidden
#nullable disable
#nullable restore
#line 95 "C:\Users\samar\Source\Repos\BDTransportCompany\BDTransportCompany\Pages\Car\Index.cshtml"
                                                                                  
                    }
                    catch
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <p> ???????????? ?????? </p>\r\n");
#nullable restore
#line 100 "C:\Users\samar\Source\Repos\BDTransportCompany\BDTransportCompany\Pages\Car\Index.cshtml"
                    }
                

#line default
#line hidden
#nullable disable
            WriteLiteral("            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 104 "C:\Users\samar\Source\Repos\BDTransportCompany\BDTransportCompany\Pages\Car\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.LastMaintenanceDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n");
#nullable restore
#line 107 "C:\Users\samar\Source\Repos\BDTransportCompany\BDTransportCompany\Pages\Car\Index.cshtml"
                  
                    try
                    {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 110 "C:\Users\samar\Source\Repos\BDTransportCompany\BDTransportCompany\Pages\Car\Index.cshtml"
                   Write(Model.Staff.First(r => r.ID == item.PositionID2).FullName);

#line default
#line hidden
#nullable disable
#nullable restore
#line 110 "C:\Users\samar\Source\Repos\BDTransportCompany\BDTransportCompany\Pages\Car\Index.cshtml"
                                                                                  
                    }
                    catch
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <p> ???????????? ?????? </p>\r\n");
#nullable restore
#line 115 "C:\Users\samar\Source\Repos\BDTransportCompany\BDTransportCompany\Pages\Car\Index.cshtml"
                    }
                

#line default
#line hidden
#nullable disable
            WriteLiteral("            </td>\r\n            \r\n            <td>\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8c817debac99a543fba9b6c956bac72e928b24e316236", async() => {
                WriteLiteral("????????????????");
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
#line 120 "C:\Users\samar\Source\Repos\BDTransportCompany\BDTransportCompany\Pages\Car\Index.cshtml"
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8c817debac99a543fba9b6c956bac72e928b24e318414", async() => {
                WriteLiteral("??????????????????");
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
#line 121 "C:\Users\samar\Source\Repos\BDTransportCompany\BDTransportCompany\Pages\Car\Index.cshtml"
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8c817debac99a543fba9b6c956bac72e928b24e320596", async() => {
                WriteLiteral("??????????????");
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
#line 122 "C:\Users\samar\Source\Repos\BDTransportCompany\BDTransportCompany\Pages\Car\Index.cshtml"
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
#line 125 "C:\Users\samar\Source\Repos\BDTransportCompany\BDTransportCompany\Pages\Car\Index.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BDTransportCompany.Pages.Car.IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<BDTransportCompany.Pages.Car.IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<BDTransportCompany.Pages.Car.IndexModel>)PageContext?.ViewData;
        public BDTransportCompany.Pages.Car.IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
