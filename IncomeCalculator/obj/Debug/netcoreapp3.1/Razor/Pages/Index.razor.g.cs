#pragma checksum "C:\Users\user\source\repos\IncomeCalculator\IncomeCalculator\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f200b540b8ec0f101a90ccf97901e0c6561c5204"
// <auto-generated/>
#pragma warning disable 1591
namespace IncomeCalculator.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\user\source\repos\IncomeCalculator\IncomeCalculator\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\user\source\repos\IncomeCalculator\IncomeCalculator\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\user\source\repos\IncomeCalculator\IncomeCalculator\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\user\source\repos\IncomeCalculator\IncomeCalculator\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\user\source\repos\IncomeCalculator\IncomeCalculator\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\user\source\repos\IncomeCalculator\IncomeCalculator\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\user\source\repos\IncomeCalculator\IncomeCalculator\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\user\source\repos\IncomeCalculator\IncomeCalculator\_Imports.razor"
using IncomeCalculator;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\user\source\repos\IncomeCalculator\IncomeCalculator\_Imports.razor"
using IncomeCalculator.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\user\source\repos\IncomeCalculator\IncomeCalculator\_Imports.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\user\source\repos\IncomeCalculator\IncomeCalculator\_Imports.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\user\source\repos\IncomeCalculator\IncomeCalculator\_Imports.razor"
using Syncfusion.Blazor.Buttons;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\user\source\repos\IncomeCalculator\IncomeCalculator\_Imports.razor"
using Syncfusion.Blazor.Notifications;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h2 class=\"mb-4 text-center\" style=\"color: #0367A6;\">App OverView</h2>\r\n\r\n\r\n");
            __builder.AddMarkupContent(1, @"<div class=""card border-0 mt-3 "" style=""width: 28rem;"">
<div class=""card-body"">
<h6 class=""card-subtitle font-weight-bold pb-2"">The two main functions of this app are:</h6>
<ol class=""card-text list-group list-group-flush"">
	<li class=""list-group-item "">1.<a href=""wages"">  Wages calculator</a></li>
	<li class=""list-group-item "">2.<a href=""benefits"">  Benefits calculator</a></li>
</ol>
</div>
</div>

");
            __builder.AddMarkupContent(2, @"<div class=""container"">
<div class=""row"">

<div class=""card col-7 mb-2"" style=""border-color:#0367A6 ;"">
<div class=""card-body "">
<h6 class=""card-title font-weight-bold""> Wages calculator:</h6>
<p class=""text-justify fs-5 lh-base mt-3"">This app enable's you to work out what
is your income in total, per week/month, or per annum. Once you enter the amount of hours and
the hourly rate, the total would we worked out for you automatically <br>

There is also an option to select the minimum wage button, at it would work it out according
to the minimum wage in the UK,depending on your age group.
</p>
</div>
</div>

<div class=""card col-4  ml-5 mr-2 mb-2"" style=""border-color:#0367A6;"">
	<div class=""card-body"">
	 <h6 class=""card-title font-weight-bold"">Benefits calculator:</h6>
	 <p class=""card-text text-justify"">This App allows you to work out the amount of tax credits and/or housing benefits
 one is entitled to, which depend's on the income, and on the size of the family.</p>
 </div>
</div>
</div>
</div>");
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591