#pragma checksum "C:\Users\samar\Source\Repos\BDTransportCompany\BDTransportCompany\Pages\Zf\Filtri\Fzakazi4.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0532705333619fbde4fa18a8117f3a02f7995526"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(BDTransportCompany.Pages.Zf.Filtri.Pages_Zf_Filtri_Fzakazi4), @"mvc.1.0.razor-page", @"/Pages/Zf/Filtri/Fzakazi4.cshtml")]
namespace BDTransportCompany.Pages.Zf.Filtri
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0532705333619fbde4fa18a8117f3a02f7995526", @"/Pages/Zf/Filtri/Fzakazi4.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aa52d245b43874c1c3c462dbe06e571b0ae8dfd4", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Zf_Filtri_Fzakazi4 : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("    <h1>Заказы4</h1>\r\n");
            WriteLiteral("    <table class=\"table\">\r\n        <thead>\r\n            <tr>\r\n                <th>\r\n                    ");
#nullable restore
#line 10 "C:\Users\samar\Source\Repos\BDTransportCompany\BDTransportCompany\Pages\Zf\Filtri\Fzakazi4.cshtml"
               Write(Html.DisplayNameFor(model => model.Routes[0].Customer));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n\r\n                <th>\r\n                    ");
#nullable restore
#line 14 "C:\Users\samar\Source\Repos\BDTransportCompany\BDTransportCompany\Pages\Zf\Filtri\Fzakazi4.cshtml"
               Write(Html.DisplayNameFor(model => model.Routes[0].TheMarkOnTheReturn));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
#nullable restore
#line 20 "C:\Users\samar\Source\Repos\BDTransportCompany\BDTransportCompany\Pages\Zf\Filtri\Fzakazi4.cshtml"
             foreach (var item in Model.Routes)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n\r\n                    <td>\r\n                        ");
#nullable restore
#line 25 "C:\Users\samar\Source\Repos\BDTransportCompany\BDTransportCompany\Pages\Zf\Filtri\Fzakazi4.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Customer));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n\r\n                    <td>\r\n                        ");
#nullable restore
#line 29 "C:\Users\samar\Source\Repos\BDTransportCompany\BDTransportCompany\Pages\Zf\Filtri\Fzakazi4.cshtml"
                   Write(Html.DisplayFor(modelItem => item.TheMarkOnTheReturn));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n\r\n                </tr>\r\n");
#nullable restore
#line 33 "C:\Users\samar\Source\Repos\BDTransportCompany\BDTransportCompany\Pages\Zf\Filtri\Fzakazi4.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BDTransportCompany.Pages.Zf.Filtri.Fzakazi4> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<BDTransportCompany.Pages.Zf.Filtri.Fzakazi4> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<BDTransportCompany.Pages.Zf.Filtri.Fzakazi4>)PageContext?.ViewData;
        public BDTransportCompany.Pages.Zf.Filtri.Fzakazi4 Model => ViewData.Model;
    }
}
#pragma warning restore 1591
