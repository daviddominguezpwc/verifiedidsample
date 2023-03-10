#pragma checksum "/home/azureusercoffeeuniversity/GartnerHotel/verifiedidsample/Pages/Issuer.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d37f151ceee843e74e7fa5cd0b3e14b9d67e9438"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCoreVerifiableCredentials.Pages.Pages_Issuer), @"mvc.1.0.razor-page", @"/Pages/Issuer.cshtml")]
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
#line 1 "/home/azureusercoffeeuniversity/GartnerHotel/verifiedidsample/Pages/_ViewImports.cshtml"
using AspNetCoreVerifiableCredentials;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d37f151ceee843e74e7fa5cd0b3e14b9d67e9438", @"/Pages/Issuer.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c9a6c6105e21e45cb7ef575038cfac3da5f8e208", @"/Pages/_ViewImports.cshtml")]
    #nullable restore
    public class Pages_Issuer : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "/home/azureusercoffeeuniversity/GartnerHotel/verifiedidsample/Pages/Issuer.cshtml"
  
    ViewData["Title"] = "Issuer";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"	    <div class = ""flex-home"">
                <div class = ""picture-div-home"">
                <object type=""image/svg+xml"" data=""key.svg""> </object>
                </div>

                <div class = ""text-container"">
                <h1>Issue Credential</h1>
                <h1>Scan the QR code below with your Microsoft Authenticator app to retrieve your credential.</h1>

                </div>
            </div>
	    <div style=""text-align: center;"">
 
");
            WriteLiteral(@"	    <object type = ""image/svg+xml"" id = ""sign-in"" data = ""loading-icon.svg""> </object>
            <div id=""errorMessage""></div>
            <br />
            <div id=""qrText""  style=""display:none;"">
                <p class=""small-text"">
                    <img src=""authenticator-icon.png"" alt=""Authenticator icon"" class=""icon-small""><br>
                    Scan with Microsoft Authenticator
                </p>
            </div>
            <a id=""deeplink"" style=""display: none;margin-top: 10px;"">Tap to open Authenticator on mobile</a>
            <div id=""qrcode"" style=""text-align: center""></div>
            <div id=""pinCodeText"" style=""display: none""></div>

            <div id=""message-wrapper"" class=""margin-bottom-75 margin-top-75"" style=""display: none"">
               <i class=""fas fa-user-check green icon-text-large margin-bottom-25""></i>
               <div id=""message""></div>
               <br />
               <div id=""payload""></div>
            </div>

            <script src=""qrcode.min.js"">");
            WriteLiteral(@"</script>
            <script>
                var signIn = document.getElementById('sign-in');
                var signOut = document.getElementById('sign-out');
                var display = document.getElementById('display');
                var qrcode = new QRCode(""qrcode"", { width: 300, height: 300 });
                var respIssuanceReq = null;

document.addEventListener('DOMContentLoaded', () => {
    fetch('/api/issuer/issuance-request')
        .then(response => response.text())
        //.catch(error => { console.log(error.message); document.getElementById(""errorMessage"").innerHTML += error.message; })
        .then(function(message) {
            respIssuanceReq = JSON.parse(message);
            if (/Android/i.test(navigator.userAgent)) {
                console.log(`Android device! Using deep link (${respIssuanceReq.url}).`);
                window.location.href = respIssuanceReq.url; setTimeout(function() {
                    window.location.href = ""https://play.google.com/store/apps/details?id");
            WriteLiteral(@"=com.azure.authenticator"";
                }, 2000);
            } else if (/iPhone/i.test(navigator.userAgent)) {
                console.log(`iOS device! Using deep link (${respIssuanceReq.url}).`);
                window.location.replace(respIssuanceReq.url);
            } else {
                console.log(`Not Android or IOS. Generating QR code encoded with ${message}`);
                qrcode.makeCode(respIssuanceReq.url);
                document.getElementById('sign-in').style.display = ""none"";
                document.getElementById('qrText').style.display = ""block"";
                if (respIssuanceReq.pin) {
                    document.getElementById('pinCodeText').innerHTML = ""Pin code: "" + respIssuanceReq.pin;
                    document.getElementById('pinCodeText').style.display = ""block"";
                }

		
                var checkStatus = setInterval(function() {
                    fetch('api/issuer/issuance-response?id=' + respIssuanceReq.id)
                        .then(response => r");
            WriteLiteral(@"esponse.text())
                        .catch(error => document.getElementById(""message"").innerHTML += error)
                        .then(response => {
                            if (response.length > 0) {
                                console.log(response)
                                respMsg = JSON.parse(response);
                                // QR Code scanned, show pincode if pincode is required
                                if (respMsg.status == 'request_retrieved') {
                                    document.getElementById('message-wrapper').style.display = ""block"";
                                    document.getElementById('qrText').style.display = ""none"";
                                    document.getElementById('qrcode').style.display = ""none"";
				    document.getElementById('sign-in').style.display = ""inline"";

                                    if (respMsg.pin) {
                                        document.getElementById('pinCodeText').style.display = ""visible"";
        ");
            WriteLiteral(@"                        }
                                    document.getElementById('message').innerHTML = respMsg.message;
                                }
                                if (respMsg.status == 'issuance_successful') {
				    document.getElementById('sign-in').style.display = ""none"";
                                    document.getElementById('pinCodeText').style.display = ""none"";
                                    document.getElementById('message').innerHTML = respMsg.message;
				    window.location.href = ""/verifier"";
                                    clearInterval(checkStatus);
                                }
                                if (respMsg.status == 'issuance_error') {
                                    document.getElementById('pinCodeText').style.display = ""none"";
                                    document.getElementById('message').innerHTML = ""Issuance error occured, did you enter the wrong pincode? Please refresh the page and try again."";
                      ");
            WriteLiteral(@"              document.getElementById('payload').innerHTML = ""Payload: "" + respMsg.payload;
                                    clearInterval(checkStatus);
                                }
                            }
                        })
                }, 1500); //change this to higher interval if you use ngrok to prevent overloading the free tier service

            }
        }).catch(error => { console.log(error.message); document.getElementById(""errorMessage"").innerHTML += error.message; })
});                
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AspNetCoreVerifiableCredentials.Pages.IssuerModel> Html { get; private set; } = default!;
        #nullable disable
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<AspNetCoreVerifiableCredentials.Pages.IssuerModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<AspNetCoreVerifiableCredentials.Pages.IssuerModel>)PageContext?.ViewData;
        public AspNetCoreVerifiableCredentials.Pages.IssuerModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
