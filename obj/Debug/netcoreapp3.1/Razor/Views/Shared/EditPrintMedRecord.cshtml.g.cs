#pragma checksum "C:\Users\Arina\Desktop\Laba45\Views\Shared\EditPrintMedRecord.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "edf6088fcff190fc60b0c226a7895e3cdcc71851"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_EditPrintMedRecord), @"mvc.1.0.view", @"/Views/Shared/EditPrintMedRecord.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"edf6088fcff190fc60b0c226a7895e3cdcc71851", @"/Views/Shared/EditPrintMedRecord.cshtml")]
    public class Views_Shared_EditPrintMedRecord : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Laba45.Models.Entity.Medical_Record>>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Arina\Desktop\Laba45\Views\Shared\EditPrintMedRecord.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!DOCTYPE html>\r\n\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "edf6088fcff190fc60b0c226a7895e3cdcc718512978", async() => {
                WriteLiteral("\r\n    <meta name=\"viewport\" content=\"width=device-width\" />\r\n    <title>PrintMedRecord</title>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "edf6088fcff190fc60b0c226a7895e3cdcc718514046", async() => {
                WriteLiteral(@"
    <h1 align=""center"">Карты</h1>
    <table border=""1"" width=""100%"">
        <tr>
            <th>Фамилия пациента</th>
            <th>ID</th>
            <th>Номер карты</th>
            <th>Номер мед.полиса</th>
            <th>Дата рождения</th>
            <th>Номер телефона</th>
            <th>Адрес</th>
            <th>Ссылка на изменение</th>
        </tr>
");
#nullable restore
#line 26 "C:\Users\Arina\Desktop\Laba45\Views\Shared\EditPrintMedRecord.cshtml"
          
            foreach (var records in Model)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 30 "C:\Users\Arina\Desktop\Laba45\Views\Shared\EditPrintMedRecord.cshtml"
                   Write(records.Patient.Surname);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 31 "C:\Users\Arina\Desktop\Laba45\Views\Shared\EditPrintMedRecord.cshtml"
                   Write(records.Id);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 32 "C:\Users\Arina\Desktop\Laba45\Views\Shared\EditPrintMedRecord.cshtml"
                   Write(records.NumberRecord);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 33 "C:\Users\Arina\Desktop\Laba45\Views\Shared\EditPrintMedRecord.cshtml"
                   Write(records.Insurance_policy);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 34 "C:\Users\Arina\Desktop\Laba45\Views\Shared\EditPrintMedRecord.cshtml"
                   Write(records.BirthDate);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 35 "C:\Users\Arina\Desktop\Laba45\Views\Shared\EditPrintMedRecord.cshtml"
                   Write(records.NumberPhone);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 36 "C:\Users\Arina\Desktop\Laba45\Views\Shared\EditPrintMedRecord.cshtml"
                   Write(records.Adress);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                    <td><a");
                BeginWriteAttribute("href", " href=\"", 1083, "\"", 1125, 2);
                WriteAttributeValue("", 1090, "/Hospital/EditMedRecord/", 1090, 24, true);
#nullable restore
#line 37 "C:\Users\Arina\Desktop\Laba45\Views\Shared\EditPrintMedRecord.cshtml"
WriteAttributeValue("", 1114, records.Id, 1114, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Изменение карты</a></td>\r\n                </tr>\r\n");
#nullable restore
#line 39 "C:\Users\Arina\Desktop\Laba45\Views\Shared\EditPrintMedRecord.cshtml"
            }
        

#line default
#line hidden
#nullable disable
                WriteLiteral("    </table>\r\n    <div>\r\n        ");
#nullable restore
#line 43 "C:\Users\Arina\Desktop\Laba45\Views\Shared\EditPrintMedRecord.cshtml"
   Write(Html.ActionLink("Вернуться на главную страницу", "MainPage"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    </div>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Laba45.Models.Entity.Medical_Record>> Html { get; private set; }
    }
}
#pragma warning restore 1591
