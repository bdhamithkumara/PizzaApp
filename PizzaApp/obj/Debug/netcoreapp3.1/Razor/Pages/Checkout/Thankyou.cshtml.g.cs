#pragma checksum "C:\Users\User\Desktop\youtube\PizzaApp\PizzaApp\Pages\Checkout\Thankyou.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "59ab07399f34ccaad343817fe473d4658bf33c38"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(PizzaApp.Pages.Checkout.Pages_Checkout_Thankyou), @"mvc.1.0.razor-page", @"/Pages/Checkout/Thankyou.cshtml")]
namespace PizzaApp.Pages.Checkout
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
#line 1 "C:\Users\User\Desktop\youtube\PizzaApp\PizzaApp\Pages\_ViewImports.cshtml"
using PizzaApp;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"59ab07399f34ccaad343817fe473d4658bf33c38", @"/Pages/Checkout/Thankyou.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b04f6e8df7bfb7588c71e3cc582183aea7498d87", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Checkout_Thankyou : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n<div class=\"text-center\">\r\n    <h1>Order Completion</h1>\r\n\r\n    <div class=\"text-center\">\r\n        <p>Pizza name is : ");
#nullable restore
#line 11 "C:\Users\User\Desktop\youtube\PizzaApp\PizzaApp\Pages\Checkout\Thankyou.cshtml"
                      Write(Model.pizaaname);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ,</p>\r\n        <p>Total price for your is : ");
#nullable restore
#line 12 "C:\Users\User\Desktop\youtube\PizzaApp\PizzaApp\Pages\Checkout\Thankyou.cshtml"
                                Write(Model.PizzaPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral(" $</p>\r\n        <a class=\"btn btn-danger\">Done!</a>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PizzaApp.Pages.Checkout.ThankyouModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<PizzaApp.Pages.Checkout.ThankyouModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<PizzaApp.Pages.Checkout.ThankyouModel>)PageContext?.ViewData;
        public PizzaApp.Pages.Checkout.ThankyouModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
