#pragma checksum "C:\Users\drach\Documents\Year 4 College\EAD\CA3\EAD_CA3_JamesLynam_X00073019\X00073019_EAD_CA3\Pages\Categories.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "73638789a5a3b51fb11342e9e44e4f7e677f19dd"
// <auto-generated/>
#pragma warning disable 1591
namespace X00073019_EAD_CA3.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\drach\Documents\Year 4 College\EAD\CA3\EAD_CA3_JamesLynam_X00073019\X00073019_EAD_CA3\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\drach\Documents\Year 4 College\EAD\CA3\EAD_CA3_JamesLynam_X00073019\X00073019_EAD_CA3\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\drach\Documents\Year 4 College\EAD\CA3\EAD_CA3_JamesLynam_X00073019\X00073019_EAD_CA3\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\drach\Documents\Year 4 College\EAD\CA3\EAD_CA3_JamesLynam_X00073019\X00073019_EAD_CA3\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\drach\Documents\Year 4 College\EAD\CA3\EAD_CA3_JamesLynam_X00073019\X00073019_EAD_CA3\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\drach\Documents\Year 4 College\EAD\CA3\EAD_CA3_JamesLynam_X00073019\X00073019_EAD_CA3\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\drach\Documents\Year 4 College\EAD\CA3\EAD_CA3_JamesLynam_X00073019\X00073019_EAD_CA3\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\drach\Documents\Year 4 College\EAD\CA3\EAD_CA3_JamesLynam_X00073019\X00073019_EAD_CA3\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\drach\Documents\Year 4 College\EAD\CA3\EAD_CA3_JamesLynam_X00073019\X00073019_EAD_CA3\_Imports.razor"
using X00073019_EAD_CA3;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\drach\Documents\Year 4 College\EAD\CA3\EAD_CA3_JamesLynam_X00073019\X00073019_EAD_CA3\_Imports.razor"
using X00073019_EAD_CA3.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/categories")]
    public partial class Categories : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<div class=\"catCategories\"><h3>Cat Categories</h3></div>\r\n\r\n");
            __builder.AddMarkupContent(1, "<div class=\"categoryDescription\"><p>This page is simply used as a reference for each cat picture category.</p>\r\n    <p>It pulls the information from the API.</p></div>");
#nullable restore
#line 17 "C:\Users\drach\Documents\Year 4 College\EAD\CA3\EAD_CA3_JamesLynam_X00073019\X00073019_EAD_CA3\Pages\Categories.razor"
 if (data == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(2, "<p><em>Loading...here kitty...</em></p>");
#nullable restore
#line 19 "C:\Users\drach\Documents\Year 4 College\EAD\CA3\EAD_CA3_JamesLynam_X00073019\X00073019_EAD_CA3\Pages\Categories.razor"
                                            }

else
{


#line default
#line hidden
#nullable disable
            __builder.OpenElement(3, "h4");
            __builder.AddContent(4, 
#nullable restore
#line 25 "C:\Users\drach\Documents\Year 4 College\EAD\CA3\EAD_CA3_JamesLynam_X00073019\X00073019_EAD_CA3\Pages\Categories.razor"
         data[0].name

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(5, " ID: ");
            __builder.AddContent(6, 
#nullable restore
#line 25 "C:\Users\drach\Documents\Year 4 College\EAD\CA3\EAD_CA3_JamesLynam_X00073019\X00073019_EAD_CA3\Pages\Categories.razor"
                           data[0].id

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\r\n    ");
            __builder.OpenElement(8, "h4");
            __builder.AddContent(9, 
#nullable restore
#line 26 "C:\Users\drach\Documents\Year 4 College\EAD\CA3\EAD_CA3_JamesLynam_X00073019\X00073019_EAD_CA3\Pages\Categories.razor"
         data[1].name

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(10, " ID: ");
            __builder.AddContent(11, 
#nullable restore
#line 26 "C:\Users\drach\Documents\Year 4 College\EAD\CA3\EAD_CA3_JamesLynam_X00073019\X00073019_EAD_CA3\Pages\Categories.razor"
                           data[1].id

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n    ");
            __builder.OpenElement(13, "h4");
            __builder.AddContent(14, 
#nullable restore
#line 27 "C:\Users\drach\Documents\Year 4 College\EAD\CA3\EAD_CA3_JamesLynam_X00073019\X00073019_EAD_CA3\Pages\Categories.razor"
         data[2].name

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(15, " ID: ");
            __builder.AddContent(16, 
#nullable restore
#line 27 "C:\Users\drach\Documents\Year 4 College\EAD\CA3\EAD_CA3_JamesLynam_X00073019\X00073019_EAD_CA3\Pages\Categories.razor"
                           data[2].id

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n    ");
            __builder.OpenElement(18, "h4");
            __builder.AddContent(19, 
#nullable restore
#line 28 "C:\Users\drach\Documents\Year 4 College\EAD\CA3\EAD_CA3_JamesLynam_X00073019\X00073019_EAD_CA3\Pages\Categories.razor"
         data[3].name

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(20, " ID: ");
            __builder.AddContent(21, 
#nullable restore
#line 28 "C:\Users\drach\Documents\Year 4 College\EAD\CA3\EAD_CA3_JamesLynam_X00073019\X00073019_EAD_CA3\Pages\Categories.razor"
                           data[3].id

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n    ");
            __builder.OpenElement(23, "h4");
            __builder.AddContent(24, 
#nullable restore
#line 29 "C:\Users\drach\Documents\Year 4 College\EAD\CA3\EAD_CA3_JamesLynam_X00073019\X00073019_EAD_CA3\Pages\Categories.razor"
         data[4].name

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(25, " ID: ");
            __builder.AddContent(26, 
#nullable restore
#line 29 "C:\Users\drach\Documents\Year 4 College\EAD\CA3\EAD_CA3_JamesLynam_X00073019\X00073019_EAD_CA3\Pages\Categories.razor"
                           data[4].id

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n    ");
            __builder.OpenElement(28, "h4");
            __builder.AddContent(29, 
#nullable restore
#line 30 "C:\Users\drach\Documents\Year 4 College\EAD\CA3\EAD_CA3_JamesLynam_X00073019\X00073019_EAD_CA3\Pages\Categories.razor"
         data[5].name

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(30, " ID: ");
            __builder.AddContent(31, 
#nullable restore
#line 30 "C:\Users\drach\Documents\Year 4 College\EAD\CA3\EAD_CA3_JamesLynam_X00073019\X00073019_EAD_CA3\Pages\Categories.razor"
                           data[5].id

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n    ");
            __builder.OpenElement(33, "h4");
            __builder.AddContent(34, 
#nullable restore
#line 31 "C:\Users\drach\Documents\Year 4 College\EAD\CA3\EAD_CA3_JamesLynam_X00073019\X00073019_EAD_CA3\Pages\Categories.razor"
         data[6].name

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(35, " ID: ");
            __builder.AddContent(36, 
#nullable restore
#line 31 "C:\Users\drach\Documents\Year 4 College\EAD\CA3\EAD_CA3_JamesLynam_X00073019\X00073019_EAD_CA3\Pages\Categories.razor"
                           data[6].id

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 32 "C:\Users\drach\Documents\Year 4 College\EAD\CA3\EAD_CA3_JamesLynam_X00073019\X00073019_EAD_CA3\Pages\Categories.razor"
}

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(37, @"<html><body></body>
<head><style>
        h3 {
            text-align: center;
        }

        .catCategories {
            background-color: antiquewhite;
            width: 100%;
            padding-bottom: 16px;
            padding-top: 16px;
            border-radius: 25px;
            border: 2px solid black;
        }

        body {
            background-color: lightgrey;
        }

        .categoryDescription {
            margin-top: 1em;
        }
    </style></head></html>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
