#pragma checksum "/home/azureusercoffeeuniversity/AzureSampleTest/active-directory-verifiable-credentials-dotnet/1-asp-net-core-api-idtokenhint/Pages/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7948b6904f4aaf2ba47017dd27b4f75aa3c577fb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCoreVerifiableCredentials.Pages.Pages_Index), @"mvc.1.0.razor-page", @"/Pages/Index.cshtml")]
namespace AspNetCoreVerifiableCredentials.Pages
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
#line 1 "/home/azureusercoffeeuniversity/AzureSampleTest/active-directory-verifiable-credentials-dotnet/1-asp-net-core-api-idtokenhint/Pages/_ViewImports.cshtml"
using AspNetCoreVerifiableCredentials;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7948b6904f4aaf2ba47017dd27b4f75aa3c577fb", @"/Pages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c9a6c6105e21e45cb7ef575038cfac3da5f8e208", @"/Pages/_ViewImports.cshtml")]
    #nullable restore
    public class Pages_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "/home/azureusercoffeeuniversity/AzureSampleTest/active-directory-verifiable-credentials-dotnet/1-asp-net-core-api-idtokenhint/Pages/Index.cshtml"
  
    ViewData["Title"] = "Home";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
            <div style=""text-align: center;"">
                <img src=""https://coffeeuniversity.blob.core.windows.net/coffeeuniversityimages/PwC_Pictograms_HousingHospitalityCities_Orange_RGB.png"" height=200px; />
                <h1>Gartner Hotel Key Issuance and Verification</h1>
        
                <button type=""button"" id=""idIssue"" class=""button"">GET KEY</button>
                <button type=""button"" id=""idVerify"" class=""button"">VERIFY KEY</button>
                <script>
                        var idIssue = document.getElementById('idIssue');
                        var idVerify = document.getElementById('idVerify');

                        idIssue.addEventListener('click', () => {
                            window.location = ""issuer"";
                        })
                        idVerify.addEventListener('click', () => {
                            window.location = ""verifier"";
                        })
                    </script>
            </div>
");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexModel> Html { get; private set; } = default!;
        #nullable disable
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel>)PageContext?.ViewData;
        public IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
