#pragma checksum "C:\Users\kiril\OneDrive\Рабочий стол\Анечка тут главная\BookCatalogue\BookCatalogue\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1194753ba427ea62f083850fee2707c31f336e42"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "C:\Users\kiril\OneDrive\Рабочий стол\Анечка тут главная\BookCatalogue\BookCatalogue\Views\_ViewImports.cshtml"
using BookCatalogue;

#line default
#line hidden
#line 1 "C:\Users\kiril\OneDrive\Рабочий стол\Анечка тут главная\BookCatalogue\BookCatalogue\Views\Home\Index.cshtml"
using BookCatalogue.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1194753ba427ea62f083850fee2707c31f336e42", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3a3e341844b1e70867f1fc803cb47ab86b608b64", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Book>>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\Users\kiril\OneDrive\Рабочий стол\Анечка тут главная\BookCatalogue\BookCatalogue\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Книжный каталог";

#line default
#line hidden
            BeginContext(106, 31, true);
            WriteLiteral("\r\n\r\n<!DOCTYPE html>\r\n\r\n<html>\r\n");
            EndContext();
            BeginContext(194, 746, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1194753ba427ea62f083850fee2707c31f336e423517", async() => {
                BeginContext(200, 273, true);
                WriteLiteral(@"

    <h1>Книжный каталог</h1>
    <table class=""table"">
        <tr>
            <td>Название книги</td>
            <td>Автор</td>
            <td>Цена</td>
            <td>Жанр</td>
            <td>Количество страниц</td>
            <td></td>
        </tr>
");
                EndContext();
#line 26 "C:\Users\kiril\OneDrive\Рабочий стол\Анечка тут главная\BookCatalogue\BookCatalogue\Views\Home\Index.cshtml"
         foreach (Book book in Model)
        {

#line default
#line hidden
                BeginContext(523, 22, true);
                WriteLiteral("    <tr>\r\n        <td>");
                EndContext();
                BeginContext(546, 10, false);
#line 29 "C:\Users\kiril\OneDrive\Рабочий стол\Анечка тут главная\BookCatalogue\BookCatalogue\Views\Home\Index.cshtml"
       Write(book.Title);

#line default
#line hidden
                EndContext();
                BeginContext(556, 19, true);
                WriteLiteral("</td>\r\n        <td>");
                EndContext();
                BeginContext(576, 11, false);
#line 30 "C:\Users\kiril\OneDrive\Рабочий стол\Анечка тут главная\BookCatalogue\BookCatalogue\Views\Home\Index.cshtml"
       Write(book.Author);

#line default
#line hidden
                EndContext();
                BeginContext(587, 19, true);
                WriteLiteral("</td>\r\n        <td>");
                EndContext();
                BeginContext(607, 10, false);
#line 31 "C:\Users\kiril\OneDrive\Рабочий стол\Анечка тут главная\BookCatalogue\BookCatalogue\Views\Home\Index.cshtml"
       Write(book.Price);

#line default
#line hidden
                EndContext();
                BeginContext(617, 19, true);
                WriteLiteral("</td>\r\n        <td>");
                EndContext();
                BeginContext(637, 10, false);
#line 32 "C:\Users\kiril\OneDrive\Рабочий стол\Анечка тут главная\BookCatalogue\BookCatalogue\Views\Home\Index.cshtml"
       Write(book.Genre);

#line default
#line hidden
                EndContext();
                BeginContext(647, 19, true);
                WriteLiteral("</td>\r\n        <td>");
                EndContext();
                BeginContext(667, 14, false);
#line 33 "C:\Users\kiril\OneDrive\Рабочий стол\Анечка тут главная\BookCatalogue\BookCatalogue\Views\Home\Index.cshtml"
       Write(book.PageCount);

#line default
#line hidden
                EndContext();
                BeginContext(681, 21, true);
                WriteLiteral("</td>\r\n        <td><a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 702, "\"", 730, 2);
                WriteAttributeValue("", 709, "/Home/Update/", 709, 13, true);
#line 34 "C:\Users\kiril\OneDrive\Рабочий стол\Анечка тут главная\BookCatalogue\BookCatalogue\Views\Home\Index.cshtml"
WriteAttributeValue("", 722, book.Id, 722, 8, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(731, 39, true);
                WriteLiteral(">Редактировать</a></td>\r\n        <td><a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 770, "\"", 798, 2);
                WriteAttributeValue("", 777, "/Home/Delete/", 777, 13, true);
#line 35 "C:\Users\kiril\OneDrive\Рабочий стол\Анечка тут главная\BookCatalogue\BookCatalogue\Views\Home\Index.cshtml"
WriteAttributeValue("", 790, book.Id, 790, 8, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(799, 30, true);
                WriteLiteral(">Удалить</a></td>\r\n    </tr>\r\n");
                EndContext();
#line 37 "C:\Users\kiril\OneDrive\Рабочий стол\Анечка тут главная\BookCatalogue\BookCatalogue\Views\Home\Index.cshtml"
        }

#line default
#line hidden
                BeginContext(840, 93, true);
                WriteLiteral("    </table>\r\n    <a href=\"/Home/Update/\"><input type=\"submit\" value=\"Добавить книгу\"/></a>\r\n");
                EndContext();
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
            EndContext();
            BeginContext(940, 13, true);
            WriteLiteral("\r\n</html>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Book>> Html { get; private set; }
    }
}
#pragma warning restore 1591
