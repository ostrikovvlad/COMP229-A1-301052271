#pragma checksum "C:\Users\ostri\OneDrive\Desktop\Folders\College\Fall 2019\COMP 229\Assignments\Assignment1\Assignment1\Views\Home\ViewRecipe.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3bdf81f979e0893eaa3da64907d4cfee81e7aed9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ViewRecipe), @"mvc.1.0.view", @"/Views/Home/ViewRecipe.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/ViewRecipe.cshtml", typeof(AspNetCore.Views_Home_ViewRecipe))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3bdf81f979e0893eaa3da64907d4cfee81e7aed9", @"/Views/Home/ViewRecipe.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"29e0c2a2a7a5c0c2e7337ecc9b2220db49d23e55", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_ViewRecipe : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Assignment1.Models.Recipe>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "LeaveReview", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
#line 2 "C:\Users\ostri\OneDrive\Desktop\Folders\College\Fall 2019\COMP 229\Assignments\Assignment1\Assignment1\Views\Home\ViewRecipe.cshtml"
  
    Layout = "_Layout";

#line default
#line hidden
#line 5 "C:\Users\ostri\OneDrive\Desktop\Folders\College\Fall 2019\COMP 229\Assignments\Assignment1\Assignment1\Views\Home\ViewRecipe.cshtml"
 foreach (Assignment1.Models.Recipe r in Model)
{

#line default
#line hidden
            BeginContext(131, 43, true);
            WriteLiteral("    <div class=\"panel-body\">\r\n        <h2> ");
            EndContext();
            BeginContext(175, 7, false);
#line 8 "C:\Users\ostri\OneDrive\Desktop\Folders\College\Fall 2019\COMP 229\Assignments\Assignment1\Assignment1\Views\Home\ViewRecipe.cshtml"
        Write(r.Title);

#line default
#line hidden
            EndContext();
            BeginContext(182, 23, true);
            WriteLiteral("</h2>\r\n        <h3> by ");
            EndContext();
            BeginContext(206, 6, false);
#line 9 "C:\Users\ostri\OneDrive\Desktop\Folders\College\Fall 2019\COMP 229\Assignments\Assignment1\Assignment1\Views\Home\ViewRecipe.cshtml"
           Write(r.Name);

#line default
#line hidden
            EndContext();
            BeginContext(212, 114, true);
            WriteLiteral("</h3>\r\n        <table class=\"table table-sm table-striped table-bordered\">\r\n            <tr>\r\n                <td>");
            EndContext();
            BeginContext(327, 13, false);
#line 12 "C:\Users\ostri\OneDrive\Desktop\Folders\College\Fall 2019\COMP 229\Assignments\Assignment1\Assignment1\Views\Home\ViewRecipe.cshtml"
               Write(r.Description);

#line default
#line hidden
            EndContext();
            BeginContext(340, 224, true);
            WriteLiteral("</td>\r\n            </tr>\r\n            <tr>\r\n                <td>\r\n                    <img src=\"/images/perogies.jpg\" width=\"256\" height=\"224\" id=\"descImg\" />\r\n                    <ul>\r\n                        Ingredients:\r\n");
            EndContext();
#line 19 "C:\Users\ostri\OneDrive\Desktop\Folders\College\Fall 2019\COMP 229\Assignments\Assignment1\Assignment1\Views\Home\ViewRecipe.cshtml"
                         foreach (string i in r.Ingredients.Split(";"))
                        {

#line default
#line hidden
            BeginContext(664, 32, true);
            WriteLiteral("                            <li>");
            EndContext();
            BeginContext(697, 1, false);
#line 21 "C:\Users\ostri\OneDrive\Desktop\Folders\College\Fall 2019\COMP 229\Assignments\Assignment1\Assignment1\Views\Home\ViewRecipe.cshtml"
                           Write(i);

#line default
#line hidden
            EndContext();
            BeginContext(698, 7, true);
            WriteLiteral("</li>\r\n");
            EndContext();
#line 22 "C:\Users\ostri\OneDrive\Desktop\Folders\College\Fall 2019\COMP 229\Assignments\Assignment1\Assignment1\Views\Home\ViewRecipe.cshtml"
                        }

#line default
#line hidden
            BeginContext(732, 174, true);
            WriteLiteral("                    </ul>\r\n                </td>\r\n            </tr>\r\n            <tr>\r\n                <td>\r\n                    <ol>\r\n                        Instructions:\r\n");
            EndContext();
#line 30 "C:\Users\ostri\OneDrive\Desktop\Folders\College\Fall 2019\COMP 229\Assignments\Assignment1\Assignment1\Views\Home\ViewRecipe.cshtml"
                         foreach (string i in r.Instruction.Split(";"))
                        {

#line default
#line hidden
            BeginContext(1006, 32, true);
            WriteLiteral("                            <li>");
            EndContext();
            BeginContext(1039, 1, false);
#line 32 "C:\Users\ostri\OneDrive\Desktop\Folders\College\Fall 2019\COMP 229\Assignments\Assignment1\Assignment1\Views\Home\ViewRecipe.cshtml"
                           Write(i);

#line default
#line hidden
            EndContext();
            BeginContext(1040, 7, true);
            WriteLiteral("</li>\r\n");
            EndContext();
#line 33 "C:\Users\ostri\OneDrive\Desktop\Folders\College\Fall 2019\COMP 229\Assignments\Assignment1\Assignment1\Views\Home\ViewRecipe.cshtml"
                        }

#line default
#line hidden
            BeginContext(1074, 145, true);
            WriteLiteral("                    </ol>\r\n                </td>\r\n            </tr>\r\n        </table>\r\n        <h2>Reviews</h2>\r\n        <table class=\"review\">\r\n");
            EndContext();
#line 40 "C:\Users\ostri\OneDrive\Desktop\Folders\College\Fall 2019\COMP 229\Assignments\Assignment1\Assignment1\Views\Home\ViewRecipe.cshtml"
             foreach (Assignment1.Models.Review c in r.Review)
            {

#line default
#line hidden
            BeginContext(1298, 49, true);
            WriteLiteral("                <tr>\r\n                    <td><b>");
            EndContext();
            BeginContext(1348, 6, false);
#line 43 "C:\Users\ostri\OneDrive\Desktop\Folders\College\Fall 2019\COMP 229\Assignments\Assignment1\Assignment1\Views\Home\ViewRecipe.cshtml"
                      Write(c.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1354, 6, true);
            WriteLiteral("</b>: ");
            EndContext();
            BeginContext(1361, 9, false);
#line 43 "C:\Users\ostri\OneDrive\Desktop\Folders\College\Fall 2019\COMP 229\Assignments\Assignment1\Assignment1\Views\Home\ViewRecipe.cshtml"
                                   Write(c.Comment);

#line default
#line hidden
            EndContext();
            BeginContext(1370, 30, true);
            WriteLiteral("</td>\r\n                </tr>\r\n");
            EndContext();
#line 45 "C:\Users\ostri\OneDrive\Desktop\Folders\College\Fall 2019\COMP 229\Assignments\Assignment1\Assignment1\Views\Home\ViewRecipe.cshtml"
            }

#line default
#line hidden
            BeginContext(1415, 26, true);
            WriteLiteral("        </table>\r\n        ");
            EndContext();
            BeginContext(1441, 46, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0e8c4a24f19e4159be123c9f050cb4ea", async() => {
                BeginContext(1469, 14, true);
                WriteLiteral("Leave a Review");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1487, 14, true);
            WriteLiteral("\r\n    </div>\r\n");
            EndContext();
#line 49 "C:\Users\ostri\OneDrive\Desktop\Folders\College\Fall 2019\COMP 229\Assignments\Assignment1\Assignment1\Views\Home\ViewRecipe.cshtml"
}

#line default
#line hidden
            BeginContext(1504, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Assignment1.Models.Recipe>> Html { get; private set; }
    }
}
#pragma warning restore 1591
