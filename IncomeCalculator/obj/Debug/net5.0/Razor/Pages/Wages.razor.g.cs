#pragma checksum "C:\Users\user\source\repos\IncomeCalculator\IncomeCalculator\Pages\Wages.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b37df1a5cb52f55040259eb67b907bff270d4056"
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
#nullable restore
#line 2 "C:\Users\user\source\repos\IncomeCalculator\IncomeCalculator\Pages\Wages.razor"
using IncomeCalculator.Model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\user\source\repos\IncomeCalculator\IncomeCalculator\Pages\Wages.razor"
using static Model.Period;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/wages")]
    public partial class Wages : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<style>\r\n\t\r\n\th1 ,h2{\r\n\t\tfont-family: \'Segoe UI\', Tahoma, Geneva, Verdana, sans-serif;\r\n\t\tcolor: #193441;\r\n\t}\r\n\tlabel, text{\r\n\t\tcolor : #193441;\r\n\t}\r\n\t.minWage{\r\n\t\tdisplay: none;\r\n\t}\r\n</style>\r\n\r\n\r\n");
            __builder.AddMarkupContent(1, "<h1 class=\"mb-9  text-center header\">Wages Calculator</h1>\r\n\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(2);
            __builder.AddAttribute(3, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 22 "C:\Users\user\source\repos\IncomeCalculator\IncomeCalculator\Pages\Wages.razor"
                  WdModel

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(4, "class", "p-3 ml-1 mr-5");
            __builder.AddAttribute(5, "style", " margin-top: 4%; margin-bottom:4%;");
            __builder.AddAttribute(6, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(7);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(8, "\r\n\t\r\n ");
                __builder2.OpenElement(9, "div");
                __builder2.AddAttribute(10, "class", "row mb-4");
                __builder2.AddMarkupContent(11, "<div class=\"col-5 text-right\"><label for=\"minWage\" class=\"form-label text-right\">Min Wage</label></div>\r\n\t\t");
                __builder2.OpenElement(12, "div");
                __builder2.AddAttribute(13, "class", "col-3");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputCheckbox>(14);
                __builder2.AddAttribute(15, "name", "minWage");
                __builder2.AddAttribute(16, "class", "form-check-input ml-1 mt-1 ");
                __builder2.AddAttribute(17, "style", "width: 1.5em; height: 1.5em;");
                __builder2.AddAttribute(18, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 30 "C:\Users\user\source\repos\IncomeCalculator\IncomeCalculator\Pages\Wages.razor"
                                                                                                                                 WdModel.IsMinWage

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(19, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => WdModel.IsMinWage = __value, WdModel.IsMinWage))));
                __builder2.AddAttribute(20, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.Boolean>>>(() => WdModel.IsMinWage));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(21, "\r\n\r\n\t ");
                __builder2.OpenElement(22, "div");
                __builder2.AddAttribute(23, "class", "row mb-4");
                __builder2.AddMarkupContent(24, "<div class=\"col-5 text-right\"><label for=\"hours\" class=\"form-label\">Hours per week</label></div>\r\n\t\t");
                __builder2.OpenElement(25, "div");
                __builder2.AddAttribute(26, "class", "col-3");
                __Blazor.IncomeCalculator.Pages.Wages.TypeInference.CreateInputNumber_0(__builder2, 27, 28, "hours", 29, "form-control", 30, 
#nullable restore
#line 39 "C:\Users\user\source\repos\IncomeCalculator\IncomeCalculator\Pages\Wages.razor"
                                                 WdModel.HoursPW

#line default
#line hidden
#nullable disable
                , 31, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => WdModel.HoursPW = __value, WdModel.HoursPW)), 32, () => WdModel.HoursPW);
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(33, "\r\n\r\n\t");
                __builder2.OpenElement(34, "div");
                __builder2.AddAttribute(35, "class", "row mb-4");
                __builder2.AddMarkupContent(36, "<div class=\"col-5 text-right\"><label for=\"rate\" class=\"form-label\">Hourly rate</label></div>\r\n\t\t");
                __builder2.OpenElement(37, "div");
                __builder2.AddAttribute(38, "class", "col-3 ");
                __Blazor.IncomeCalculator.Pages.Wages.TypeInference.CreateInputNumber_1(__builder2, 39, 40, "rate", 41, "£0.00", 42, "form-control w-60", 43, 
#nullable restore
#line 48 "C:\Users\user\source\repos\IncomeCalculator\IncomeCalculator\Pages\Wages.razor"
                                                                                               WdModel.HourlyRate

#line default
#line hidden
#nullable disable
                , 44, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => WdModel.HourlyRate = __value, WdModel.HourlyRate)), 45, () => WdModel.HourlyRate);
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(46, "\r\n\r\n\r\n");
                __builder2.OpenElement(47, "div");
                __builder2.AddAttribute(48, "class", "row mb-4");
                __builder2.AddAttribute(49, "style", "display:" + " " + (
#nullable restore
#line 53 "C:\Users\user\source\repos\IncomeCalculator\IncomeCalculator\Pages\Wages.razor"
                                       Display

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(50, "<div class=\"col-5 text-right\"><label for=\"year\" class=\"form-label\">Tax Year</label></div>\r\n\t\t");
                __builder2.OpenElement(51, "div");
                __builder2.AddAttribute(52, "class", "col-3");
                __Blazor.IncomeCalculator.Pages.Wages.TypeInference.CreateInputSelect_2(__builder2, 53, 54, "form-control w-60", 55, 
#nullable restore
#line 58 "C:\Users\user\source\repos\IncomeCalculator\IncomeCalculator\Pages\Wages.razor"
                                       WdModel.MinWage.TaxYear

#line default
#line hidden
#nullable disable
                , 56, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => WdModel.MinWage.TaxYear = __value, WdModel.MinWage.TaxYear)), 57, () => WdModel.MinWage.TaxYear, 58, (__builder3) => {
                    __builder3.OpenElement(59, "option");
                    __builder3.AddAttribute(60, "value", 
#nullable restore
#line 59 "C:\Users\user\source\repos\IncomeCalculator\IncomeCalculator\Pages\Wages.razor"
                                  new DateTime(2020, 04, 06)

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddContent(61, "2020-2021");
                    __builder3.CloseElement();
#nullable restore
#line 60 "C:\Users\user\source\repos\IncomeCalculator\IncomeCalculator\Pages\Wages.razor"
                 foreach(var year in TaxYears)
				{

#line default
#line hidden
#nullable disable
                    __builder3.OpenElement(62, "option");
                    __builder3.AddAttribute(63, "value", 
#nullable restore
#line 62 "C:\Users\user\source\repos\IncomeCalculator\IncomeCalculator\Pages\Wages.razor"
                                    year.DbTaxYear

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddContent(64, 
#nullable restore
#line 62 "C:\Users\user\source\repos\IncomeCalculator\IncomeCalculator\Pages\Wages.razor"
                                                     year.UiTaxYear

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
#nullable restore
#line 63 "C:\Users\user\source\repos\IncomeCalculator\IncomeCalculator\Pages\Wages.razor"
				}

#line default
#line hidden
#nullable disable
                }
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(65, "\r\n\r\n   \r\n   ");
                __builder2.OpenElement(66, "div");
                __builder2.AddAttribute(67, "class", "row mb-4 ");
                __builder2.AddAttribute(68, "style", "display:" + " " + (
#nullable restore
#line 69 "C:\Users\user\source\repos\IncomeCalculator\IncomeCalculator\Pages\Wages.razor"
                                           Display

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(69, "<div class=\"col-5 text-right\"><label for=\"age\" class=\"form-label\">Age</label></div>\r\n\t\t");
                __builder2.OpenElement(70, "div");
                __builder2.AddAttribute(71, "class", "col-3");
                __Blazor.IncomeCalculator.Pages.Wages.TypeInference.CreateInputNumber_3(__builder2, 72, 73, "age", 74, "form-control w-60", 75, 
#nullable restore
#line 74 "C:\Users\user\source\repos\IncomeCalculator\IncomeCalculator\Pages\Wages.razor"
                                               WdModel.Age

#line default
#line hidden
#nullable disable
                , 76, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => WdModel.Age = __value, WdModel.Age)), 77, () => WdModel.Age);
                __builder2.AddMarkupContent(78, "\r\n\t\t\t");
                __Blazor.IncomeCalculator.Pages.Wages.TypeInference.CreateValidationMessage_4(__builder2, 79, 80, 
#nullable restore
#line 75 "C:\Users\user\source\repos\IncomeCalculator\IncomeCalculator\Pages\Wages.razor"
                                      () => WdModel.Age

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(81, "\r\n\r\n\t\r\n\r\n    ");
                __builder2.OpenElement(82, "div");
                __builder2.AddAttribute(83, "class", "row mb-5 m");
                __builder2.AddMarkupContent(84, "<div class=\"col-5 text-right\"><label class=\"form-label\">Period to calculate</label></div>\r\n\t\t");
                __builder2.OpenElement(85, "div");
                __builder2.AddAttribute(86, "class", "col-6");
                __Blazor.IncomeCalculator.Pages.Wages.TypeInference.CreateInputRadioGroup_5(__builder2, 87, 88, 
#nullable restore
#line 86 "C:\Users\user\source\repos\IncomeCalculator\IncomeCalculator\Pages\Wages.razor"
                                          WdModel.Period

#line default
#line hidden
#nullable disable
                , 89, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => WdModel.Period = __value, WdModel.Period)), 90, () => WdModel.Period, 91, (__builder3) => {
#nullable restore
#line 87 "C:\Users\user\source\repos\IncomeCalculator\IncomeCalculator\Pages\Wages.razor"
                 foreach (var period in (Period[])Enum.GetValues(typeof(Period)))
				{

#line default
#line hidden
#nullable disable
                    __Blazor.IncomeCalculator.Pages.Wages.TypeInference.CreateInputRadio_6(__builder3, 92, 93, 
#nullable restore
#line 89 "C:\Users\user\source\repos\IncomeCalculator\IncomeCalculator\Pages\Wages.razor"
                           period

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddMarkupContent(94, "&nbsp");
                    __builder3.AddContent(95, 
#nullable restore
#line 90 "C:\Users\user\source\repos\IncomeCalculator\IncomeCalculator\Pages\Wages.razor"
                                 period

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddMarkupContent(96, "&nbsp&nbsp");
#nullable restore
#line 90 "C:\Users\user\source\repos\IncomeCalculator\IncomeCalculator\Pages\Wages.razor"
                                                         
				}

#line default
#line hidden
#nullable disable
                }
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(97, "\r\n\r\n\t\t");
                __builder2.OpenElement(98, "div");
                __builder2.AddAttribute(99, "class", "row ");
                __builder2.OpenElement(100, "div");
                __builder2.AddAttribute(101, "class", "col-12");
                __builder2.OpenElement(102, "h2");
                __builder2.AddAttribute(103, "class", "text-center");
                __builder2.AddContent(104, 
#nullable restore
#line 98 "C:\Users\user\source\repos\IncomeCalculator\IncomeCalculator\Pages\Wages.razor"
                           string.Format("Total per {0}: {1:C}",WdModel.Period.ToString(),WdModel.Total)

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
namespace __Blazor.IncomeCalculator.Pages.Wages
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateInputNumber_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "id", __arg0);
        __builder.AddAttribute(__seq1, "class", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", __arg4);
        __builder.CloseComponent();
        }
        public static void CreateInputNumber_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, System.Object __arg2, int __seq3, TValue __arg3, int __seq4, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg4, int __seq5, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg5)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "id", __arg0);
        __builder.AddAttribute(__seq1, "placeHolder", __arg1);
        __builder.AddAttribute(__seq2, "class", __arg2);
        __builder.AddAttribute(__seq3, "Value", __arg3);
        __builder.AddAttribute(__seq4, "ValueChanged", __arg4);
        __builder.AddAttribute(__seq5, "ValueExpression", __arg5);
        __builder.CloseComponent();
        }
        public static void CreateInputSelect_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3, int __seq4, global::Microsoft.AspNetCore.Components.RenderFragment __arg4)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputSelect<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.AddAttribute(__seq4, "ChildContent", __arg4);
        __builder.CloseComponent();
        }
        public static void CreateInputNumber_3<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "id", __arg0);
        __builder.AddAttribute(__seq1, "class", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", __arg4);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_4<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateInputRadioGroup_5<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, TValue __arg0, int __seq1, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg1, int __seq2, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg2, int __seq3, global::Microsoft.AspNetCore.Components.RenderFragment __arg3)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputRadioGroup<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.AddAttribute(__seq1, "ValueChanged", __arg1);
        __builder.AddAttribute(__seq2, "ValueExpression", __arg2);
        __builder.AddAttribute(__seq3, "ChildContent", __arg3);
        __builder.CloseComponent();
        }
        public static void CreateInputRadio_6<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, TValue __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputRadio<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
