#pragma checksum "C:\Users\mooly\Documents\codingDojo\C#\Exam\BeltExam\Views\Home\Dashboard.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ec7ff7c6f303262464042b5cb12073a844e54c06"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Dashboard), @"mvc.1.0.view", @"/Views/Home/Dashboard.cshtml")]
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
#line 1 "C:\Users\mooly\Documents\codingDojo\C#\Exam\BeltExam\Views\_ViewImports.cshtml"
using BeltExam;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\mooly\Documents\codingDojo\C#\Exam\BeltExam\Views\_ViewImports.cshtml"
using BeltExam.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ec7ff7c6f303262464042b5cb12073a844e54c06", @"/Views/Home/Dashboard.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a84119000702c45f5036e3e300b27d647b6aca13", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Dashboard : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Activityy>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Leave", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Join", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("float-right"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "newAct", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ec7ff7c6f303262464042b5cb12073a844e54c065254", async() => {
                WriteLiteral("\r\n    <meta charset=\"UTF-8\">\r\n    <meta http-equiv=\"X-UA-Compatible\" content=\"IE=edge\">\r\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\">\r\n    <title>Document</title>\r\n");
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ec7ff7c6f303262464042b5cb12073a844e54c066430", async() => {
                WriteLiteral("\r\n    <div class=\"flex\">\r\n        <div>\r\n            <h1>Dojo Activity Center</h1>\r\n        </div>\r\n        <div>\r\n            <p style=\"display: inline;\"> Welcome, ");
#nullable restore
#line 16 "C:\Users\mooly\Documents\codingDojo\C#\Exam\BeltExam\Views\Home\Dashboard.cshtml"
                                             Write(ViewBag.User.name);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"!</p>
            <a href=""/logout"">Log Out</a>
        </div>
    </div>
    <p style=""width: 100%; border-bottom: black solid thin;""></p>
        <table class=""table"">
            <thead class=""thead-dark"">
                <th>Activity</th>
                <th>Date And Time</th>
                <th>Duration</th>
                <th>Event Cordinator</th>
                <th>No. of Participants</th>
                <th>Action</th>
            <tbody>
");
#nullable restore
#line 30 "C:\Users\mooly\Documents\codingDojo\C#\Exam\BeltExam\Views\Home\Dashboard.cshtml"
                  
                    foreach(Activityy act in Model)
                    {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 34 "C:\Users\mooly\Documents\codingDojo\C#\Exam\BeltExam\Views\Home\Dashboard.cshtml"
                         if(act.ActDate >= DateTime.Now){

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <tr>\r\n                            <td><a");
                BeginWriteAttribute("href", " href=\"", 1191, "\"", 1223, 2);
                WriteAttributeValue("", 1198, "/activity/", 1198, 10, true);
#nullable restore
#line 36 "C:\Users\mooly\Documents\codingDojo\C#\Exam\BeltExam\Views\Home\Dashboard.cshtml"
WriteAttributeValue("", 1208, act.ActivityId, 1208, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">");
#nullable restore
#line 36 "C:\Users\mooly\Documents\codingDojo\C#\Exam\BeltExam\Views\Home\Dashboard.cshtml"
                                                               Write(act.Title);

#line default
#line hidden
#nullable disable
                WriteLiteral("</a></td>\r\n                            <td>");
#nullable restore
#line 37 "C:\Users\mooly\Documents\codingDojo\C#\Exam\BeltExam\Views\Home\Dashboard.cshtml"
                           Write(act.ActDate.ToString("MM/dd"));

#line default
#line hidden
#nullable disable
                WriteLiteral(" at ");
#nullable restore
#line 37 "C:\Users\mooly\Documents\codingDojo\C#\Exam\BeltExam\Views\Home\Dashboard.cshtml"
                                                             Write(act.Time);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 38 "C:\Users\mooly\Documents\codingDojo\C#\Exam\BeltExam\Views\Home\Dashboard.cshtml"
                           Write(act.ActDuration);

#line default
#line hidden
#nullable disable
                WriteLiteral("  ");
#nullable restore
#line 38 "C:\Users\mooly\Documents\codingDojo\C#\Exam\BeltExam\Views\Home\Dashboard.cshtml"
                                             Write(act.durationUnit);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 39 "C:\Users\mooly\Documents\codingDojo\C#\Exam\BeltExam\Views\Home\Dashboard.cshtml"
                           Write(act.PlanedBy.name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 40 "C:\Users\mooly\Documents\codingDojo\C#\Exam\BeltExam\Views\Home\Dashboard.cshtml"
                           Write(act.participants.Count);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                            <td>\r\n");
#nullable restore
#line 42 "C:\Users\mooly\Documents\codingDojo\C#\Exam\BeltExam\Views\Home\Dashboard.cshtml"
                                 if(@act.PlanedBy.UserId==@ViewBag.User.UserId)
                                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ec7ff7c6f303262464042b5cb12073a844e54c0611086", async() => {
                    WriteLiteral("Delete");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-actId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 44 "C:\Users\mooly\Documents\codingDojo\C#\Exam\BeltExam\Views\Home\Dashboard.cshtml"
                                                            WriteLiteral(act.ActivityId);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["actId"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-actId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["actId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 45 "C:\Users\mooly\Documents\codingDojo\C#\Exam\BeltExam\Views\Home\Dashboard.cshtml"
                                }
                                else if(@act.participants.Any(p =>p.UserId == @ViewBag.User.UserId))
                                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ec7ff7c6f303262464042b5cb12073a844e54c0613992", async() => {
                    WriteLiteral("Leave\r\n                                    ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-actId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 48 "C:\Users\mooly\Documents\codingDojo\C#\Exam\BeltExam\Views\Home\Dashboard.cshtml"
                                                               WriteLiteral(act.ActivityId);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["actId"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-actId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["actId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 50 "C:\Users\mooly\Documents\codingDojo\C#\Exam\BeltExam\Views\Home\Dashboard.cshtml"
                                }
                                else{
                                    

#line default
#line hidden
#nullable disable
                WriteLiteral("                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ec7ff7c6f303262464042b5cb12073a844e54c0616880", async() => {
                    WriteLiteral("Join\r\n                                    ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-actId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 53 "C:\Users\mooly\Documents\codingDojo\C#\Exam\BeltExam\Views\Home\Dashboard.cshtml"
                                                              WriteLiteral(act.ActivityId);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["actId"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-actId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["actId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 55 "C:\Users\mooly\Documents\codingDojo\C#\Exam\BeltExam\Views\Home\Dashboard.cshtml"
                                }

#line default
#line hidden
#nullable disable
                WriteLiteral("                            </td>\r\n                        </tr>\r\n");
#nullable restore
#line 58 "C:\Users\mooly\Documents\codingDojo\C#\Exam\BeltExam\Views\Home\Dashboard.cshtml"
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 58 "C:\Users\mooly\Documents\codingDojo\C#\Exam\BeltExam\Views\Home\Dashboard.cshtml"
                         
                    }
                

#line default
#line hidden
#nullable disable
                WriteLiteral("            </tbody>\r\n            </thead>\r\n        </table>\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ec7ff7c6f303262464042b5cb12073a844e54c0620253", async() => {
                    WriteLiteral("\r\n        <button class=\"btn btn-sm btn-primary\">Add new Activity</button>\r\n    ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Activityy>> Html { get; private set; }
    }
}
#pragma warning restore 1591