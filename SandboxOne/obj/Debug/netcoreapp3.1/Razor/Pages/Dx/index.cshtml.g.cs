#pragma checksum "C:\Users\cliff\source\repos\Sandbox\SandboxOne\Pages\Dx\index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "557c0b2ee93043d00b6b64480a958a5e321d9f94"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(SandboxOne.Pages.Dx.Pages_Dx_index), @"mvc.1.0.razor-page", @"/Pages/Dx/index.cshtml")]
namespace SandboxOne.Pages.Dx
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
#line 1 "C:\Users\cliff\source\repos\Sandbox\SandboxOne\Pages\_ViewImports.cshtml"
using SandboxOne;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\cliff\source\repos\Sandbox\SandboxOne\Pages\_ViewImports.cshtml"
using DevExtreme.AspNet.Mvc;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"557c0b2ee93043d00b6b64480a958a5e321d9f94", @"/Pages/Dx/index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a7c1347c3b9f26e053788e70b22bfce1898888a5", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Dx_index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\cliff\source\repos\Sandbox\SandboxOne\Pages\Dx\index.cshtml"
  
    ViewData["Title"] = "DevExtreme Form Validation";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>_dxLayout</h2>\r\n\r\n");
#nullable restore
#line 8 "C:\Users\cliff\source\repos\Sandbox\SandboxOne\Pages\Dx\index.cshtml"
Write(Html.DevExtreme().Form<SandboxOne.Models.Person>()
    .Items(items => {

        items.AddSimpleFor(m => m.Id);

        items.AddSimpleFor(m => m.FirstName);

        items.AddSimpleFor(m => m.LastName);

        items.AddSimpleFor(m => m.Age);
    })
);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Pages_Dx_index> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Pages_Dx_index> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Pages_Dx_index>)PageContext?.ViewData;
        public Pages_Dx_index Model => ViewData.Model;
    }
}
#pragma warning restore 1591
