#pragma checksum "C:\Users\drach\Documents\Year 4 College\EAD\CA3\EAD_CA3_JamesLynam_X00073019\X00073019_EAD_CA3\Pages\Cat.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f67bcf46b736a929b0d09a0cd475f66b9618eab2"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/cats")]
    public partial class Cat : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "html");
            __builder.OpenElement(1, "body");
#nullable restore
#line 8 "C:\Users\drach\Documents\Year 4 College\EAD\CA3\EAD_CA3_JamesLynam_X00073019\X00073019_EAD_CA3\Pages\Cat.razor"
     if (data == null)
    {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(2, "<p><em>Loading...here kitty...</em></p>");
#nullable restore
#line 10 "C:\Users\drach\Documents\Year 4 College\EAD\CA3\EAD_CA3_JamesLynam_X00073019\X00073019_EAD_CA3\Pages\Cat.razor"
                                                }

    else
    {


#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(3, "<div class=\"catText\"><h3>Cat Pictures!</h3></div>");
            __builder.AddMarkupContent(4, @"<div class=""pageDescription""><p>The purpose of this page is to display cat pictures based on user choice.</p>
            <p>The user can hit the big red button for a random cat picture.</p>
            <p>We can also use the category buttons on the right, or type in a category number below.</p></div>");
            __builder.OpenElement(5, "div");
            __builder.OpenElement(6, "button");
            __builder.AddAttribute(7, "class", "bigButton");
            __builder.AddAttribute(8, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 27 "C:\Users\drach\Documents\Year 4 College\EAD\CA3\EAD_CA3_JamesLynam_X00073019\X00073019_EAD_CA3\Pages\Cat.razor"
                                                 GetDataAsync

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(9, "Click for a random Cat!");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "style", "float:left");
            __builder.OpenElement(12, "img");
            __builder.AddAttribute(13, "src", 
#nullable restore
#line 32 "C:\Users\drach\Documents\Year 4 College\EAD\CA3\EAD_CA3_JamesLynam_X00073019\X00073019_EAD_CA3\Pages\Cat.razor"
                       data[0].url

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(14, "alt", "Meow");
            __builder.AddAttribute(15, "width", "800");
            __builder.AddAttribute(16, "height", "600");
            __builder.AddAttribute(17, "style", " margin:0.3em;");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.OpenElement(18, "div");
            __builder.AddAttribute(19, "style", "width:20%;display:inline-block; margin-left:5em; margin-top:3em");
            __builder.AddMarkupContent(20, "<h2>Cat Categories:</h2>\r\n\r\n            \r\n            ");
            __builder.OpenElement(21, "button");
            __builder.AddAttribute(22, "class", "categoryButton");
            __builder.AddAttribute(23, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 42 "C:\Users\drach\Documents\Year 4 College\EAD\CA3\EAD_CA3_JamesLynam_X00073019\X00073019_EAD_CA3\Pages\Cat.razor"
                                                     CatsInHats

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(24, "Cats in Hats");
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n\r\n            ");
            __builder.OpenElement(26, "button");
            __builder.AddAttribute(27, "class", "categoryButton");
            __builder.AddAttribute(28, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 44 "C:\Users\drach\Documents\Year 4 College\EAD\CA3\EAD_CA3_JamesLynam_X00073019\X00073019_EAD_CA3\Pages\Cat.razor"
                                                     CatsInSpace

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(29, "Cats in Space");
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n\r\n            ");
            __builder.OpenElement(31, "button");
            __builder.AddAttribute(32, "class", "categoryButton");
            __builder.AddAttribute(33, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 46 "C:\Users\drach\Documents\Year 4 College\EAD\CA3\EAD_CA3_JamesLynam_X00073019\X00073019_EAD_CA3\Pages\Cat.razor"
                                                     CatsInSunglasses

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(34, "Cats in Sunglasses");
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n\r\n            ");
            __builder.OpenElement(36, "button");
            __builder.AddAttribute(37, "class", "categoryButton");
            __builder.AddAttribute(38, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 48 "C:\Users\drach\Documents\Year 4 College\EAD\CA3\EAD_CA3_JamesLynam_X00073019\X00073019_EAD_CA3\Pages\Cat.razor"
                                                     CatsInBoxes

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(39, "Cats in Boxes");
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n\r\n            ");
            __builder.OpenElement(41, "button");
            __builder.AddAttribute(42, "class", "categoryButton");
            __builder.AddAttribute(43, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 50 "C:\Users\drach\Documents\Year 4 College\EAD\CA3\EAD_CA3_JamesLynam_X00073019\X00073019_EAD_CA3\Pages\Cat.razor"
                                                     CatsInTies

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(44, "Cats in Ties");
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\r\n\r\n            ");
            __builder.OpenElement(46, "button");
            __builder.AddAttribute(47, "class", "categoryButton");
            __builder.AddAttribute(48, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 52 "C:\Users\drach\Documents\Year 4 College\EAD\CA3\EAD_CA3_JamesLynam_X00073019\X00073019_EAD_CA3\Pages\Cat.razor"
                                                     CatsInSinks

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(49, "Cats in Sinks");
            __builder.CloseElement();
            __builder.AddMarkupContent(50, "\r\n\r\n            ");
            __builder.OpenElement(51, "button");
            __builder.AddAttribute(52, "class", "categoryButton");
            __builder.AddAttribute(53, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 54 "C:\Users\drach\Documents\Year 4 College\EAD\CA3\EAD_CA3_JamesLynam_X00073019\X00073019_EAD_CA3\Pages\Cat.razor"
                                                     CatsInClothes

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(54, "Cats in Clothes");
            __builder.CloseElement();
            __builder.AddMarkupContent(55, "\r\n\r\n\r\n            ");
            __builder.OpenElement(56, "div");
            __builder.AddAttribute(57, "style", "clear:both; margin-top:1em");
            __builder.AddMarkupContent(58, "<p>You can also search by category numbers!</p>\r\n                ");
            __builder.AddMarkupContent(59, "<p>Enter a number between 1-15!</p>\r\n\r\n                ");
            __builder.OpenElement(60, "input");
            __builder.AddAttribute(61, "placeholder", "Cat Category (1-15)");
            __builder.AddAttribute(62, "pattern", "[0-9]+");
            __builder.AddAttribute(63, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 62 "C:\Users\drach\Documents\Year 4 College\EAD\CA3\EAD_CA3_JamesLynam_X00073019\X00073019_EAD_CA3\Pages\Cat.razor"
                                                                                  catCategory

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(64, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value =>  catCategory = __value,  catCategory));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(65, "\r\n                ");
            __builder.OpenElement(66, "p");
            __builder.AddContent(67, "Current Category: ");
            __builder.AddContent(68, 
#nullable restore
#line 63 "C:\Users\drach\Documents\Year 4 College\EAD\CA3\EAD_CA3_JamesLynam_X00073019\X00073019_EAD_CA3\Pages\Cat.razor"
                                      catCategory

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 66 "C:\Users\drach\Documents\Year 4 College\EAD\CA3\EAD_CA3_JamesLynam_X00073019\X00073019_EAD_CA3\Pages\Cat.razor"
                 if (catCategory < 0 || catCategory > 15)
                {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(69, "<p>Error! You must enter a value between 0 and 15!</p>");
#nullable restore
#line 69 "C:\Users\drach\Documents\Year 4 College\EAD\CA3\EAD_CA3_JamesLynam_X00073019\X00073019_EAD_CA3\Pages\Cat.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(70, "\r\n\r\n            ");
            __builder.OpenElement(71, "div");
            __builder.AddAttribute(72, "class", "searchButton");
            __builder.OpenElement(73, "button");
            __builder.AddAttribute(74, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 74 "C:\Users\drach\Documents\Year 4 College\EAD\CA3\EAD_CA3_JamesLynam_X00073019\X00073019_EAD_CA3\Pages\Cat.razor"
                                  Search

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(75, "Search by Category!");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 78 "C:\Users\drach\Documents\Year 4 College\EAD\CA3\EAD_CA3_JamesLynam_X00073019\X00073019_EAD_CA3\Pages\Cat.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(76, "\r\n\r\n");
            __builder.AddMarkupContent(77, @"<head><style>
        .bigButton {
            display: inline-block;
            padding: 15px 25px;
            font-size: 24px;
            cursor: pointer;
            text-align: center;
            text-decoration: none;
            outline: none;
            color: #fff;
            background-color: darkred;
            border: none;
            border-radius: 50px;
            margin-bottom: 1em;
        }

        .categoryButton {
            background-color: #008CBA;
            border-radius: 25px;
            margin-bottom: 5px;
            color: #fff;
            border-color: #1861ac;
            width: 10em;
        }

        body {
            background-color: lightgrey;
        }

        .catText {
            background-color: antiquewhite;
            width: 100%;
            padding-bottom: 16px;
            padding-top: 16px;
            border-radius: 25px;
            border: 2px solid black;
        }

        h3 {
            text-align: center;
        }

        .pageDescription {
            margin-top: 1em;
        }

        img {
            border: 2px solid black;
        }
    </style></head>");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
