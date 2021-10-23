#pragma checksum "C:\Users\Charl\OneDrive\Documents\GitHub\GUI-application-that-handles-databases\OENIK_PROG3_2020_2_DWFD1I\NBA.Web\Views\Players\PlayersList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6528b39893c3d68a0c2c5907b65fc39736fb5ebd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Players_PlayersList), @"mvc.1.0.view", @"/Views/Players/PlayersList.cshtml")]
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
#nullable restore
#line 1 "C:\Users\Charl\OneDrive\Documents\GitHub\GUI-application-that-handles-databases\OENIK_PROG3_2020_2_DWFD1I\NBA.Web\Views\_ViewImports.cshtml"
using NBA.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Charl\OneDrive\Documents\GitHub\GUI-application-that-handles-databases\OENIK_PROG3_2020_2_DWFD1I\NBA.Web\Views\_ViewImports.cshtml"
using NBA.Web.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6528b39893c3d68a0c2c5907b65fc39736fb5ebd", @"/Views/Players/PlayersList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"25c845dad990f4dcb5591cf3e1532b9e655c9cf7", @"/Views/_ViewImports.cshtml")]
    public class Views_Players_PlayersList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<NBA.Web.Models.Player>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h2> Player List </h2> \r\n\r\n");
#nullable restore
#line 5 "C:\Users\Charl\OneDrive\Documents\GitHub\GUI-application-that-handles-databases\OENIK_PROG3_2020_2_DWFD1I\NBA.Web\Views\Players\PlayersList.cshtml"
 if ( Model.Count() == 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p> There is no data in the database! </p>\r\n");
#nullable restore
#line 8 "C:\Users\Charl\OneDrive\Documents\GitHub\GUI-application-that-handles-databases\OENIK_PROG3_2020_2_DWFD1I\NBA.Web\Views\Players\PlayersList.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <table border=\"1\">\r\n        <tr>\r\n            <th> ");
#nullable restore
#line 13 "C:\Users\Charl\OneDrive\Documents\GitHub\GUI-application-that-handles-databases\OENIK_PROG3_2020_2_DWFD1I\NBA.Web\Views\Players\PlayersList.cshtml"
            Write(Html.DisplayNameFor(m => m.First().PlayerName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n            <th> Datasheet</th>\r\n            <th> Delete </th>\r\n            <th> Modify </th>\r\n        </tr>\r\n\r\n");
#nullable restore
#line 19 "C:\Users\Charl\OneDrive\Documents\GitHub\GUI-application-that-handles-databases\OENIK_PROG3_2020_2_DWFD1I\NBA.Web\Views\Players\PlayersList.cshtml"
         foreach (var player in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td> ");
#nullable restore
#line 22 "C:\Users\Charl\OneDrive\Documents\GitHub\GUI-application-that-handles-databases\OENIK_PROG3_2020_2_DWFD1I\NBA.Web\Views\Players\PlayersList.cshtml"
                Write(Html.DisplayFor(m=> player.PlayerName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td> ");
#nullable restore
#line 23 "C:\Users\Charl\OneDrive\Documents\GitHub\GUI-application-that-handles-databases\OENIK_PROG3_2020_2_DWFD1I\NBA.Web\Views\Players\PlayersList.cshtml"
                Write(Html.ActionLink("[SHOW]", "Details", new { Id = player.PlayerId}));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td> ");
#nullable restore
#line 24 "C:\Users\Charl\OneDrive\Documents\GitHub\GUI-application-that-handles-databases\OENIK_PROG3_2020_2_DWFD1I\NBA.Web\Views\Players\PlayersList.cshtml"
                Write(Html.ActionLink("[Del]", "Remove", new { Id = player.PlayerId}));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td> ");
#nullable restore
#line 25 "C:\Users\Charl\OneDrive\Documents\GitHub\GUI-application-that-handles-databases\OENIK_PROG3_2020_2_DWFD1I\NBA.Web\Views\Players\PlayersList.cshtml"
                Write(Html.ActionLink("[Edit]", "Edit", new { Id = player.PlayerId}));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n               \r\n            </tr>\r\n");
#nullable restore
#line 28 "C:\Users\Charl\OneDrive\Documents\GitHub\GUI-application-that-handles-databases\OENIK_PROG3_2020_2_DWFD1I\NBA.Web\Views\Players\PlayersList.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </table>\r\n");
#nullable restore
#line 30 "C:\Users\Charl\OneDrive\Documents\GitHub\GUI-application-that-handles-databases\OENIK_PROG3_2020_2_DWFD1I\NBA.Web\Views\Players\PlayersList.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<NBA.Web.Models.Player>> Html { get; private set; }
    }
}
#pragma warning restore 1591
