#pragma checksum "D:\Projects\itra\123\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "833a1d95ffc6c272196ef2bab7dc40cc8670f453"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Delete), @"mvc.1.0.razor-page", @"/Delete.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"833a1d95ffc6c272196ef2bab7dc40cc8670f453", @"/Delete.cshtml")]
    public class Delete : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h3>Are you sure you want to delete this?</h3>\r\n<div>\r\n    <h4>TableUserViewModel</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 10 "D:\Projects\itra\123\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.TableUserViewModel.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 13 "D:\Projects\itra\123\Delete.cshtml"
       Write(Html.DisplayFor(model => model.TableUserViewModel.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 16 "D:\Projects\itra\123\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.TableUserViewModel.RegistrationDateTime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 19 "D:\Projects\itra\123\Delete.cshtml"
       Write(Html.DisplayFor(model => model.TableUserViewModel.RegistrationDateTime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 22 "D:\Projects\itra\123\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.TableUserViewModel.LastLoginDateTime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 25 "D:\Projects\itra\123\Delete.cshtml"
       Write(Html.DisplayFor(model => model.TableUserViewModel.LastLoginDateTime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 28 "D:\Projects\itra\123\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.TableUserViewModel.IsEnabled));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 31 "D:\Projects\itra\123\Delete.cshtml"
       Write(Html.DisplayFor(model => model.TableUserViewModel.IsEnabled));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
        </dd>
    </dl>
    
    <form method=""post"">
        <input type=""hidden"" asp-for=""TableUserViewModel.Id"" />
        <input type=""submit"" value=""Delete"" class=""btn btn-danger"" /> |
        <a asp-page=""./Index"">Back to List</a>
    </form>
</div>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<_123.DeleteModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<_123.DeleteModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<_123.DeleteModel>)PageContext?.ViewData;
        public _123.DeleteModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
