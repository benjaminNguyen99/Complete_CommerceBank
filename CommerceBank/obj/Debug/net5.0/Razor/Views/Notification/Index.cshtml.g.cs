#pragma checksum "C:\Users\phuc3\CS451_phase_3\CommerceBank\Views\Notification\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f9dcc45b3fde7847e2e436823c90296362bdd65e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Notification_Index), @"mvc.1.0.view", @"/Views/Notification/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\phuc3\CS451_phase_3\CommerceBank\Views\_ViewImports.cshtml"
using CommerceBank;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\phuc3\CS451_phase_3\CommerceBank\Views\_ViewImports.cshtml"
using CommerceBank.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\phuc3\CS451_phase_3\CommerceBank\Views\Notification\Index.cshtml"
using System.Collections.Generic;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\phuc3\CS451_phase_3\CommerceBank\Views\Notification\Index.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\phuc3\CS451_phase_3\CommerceBank\Views\Notification\Index.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f9dcc45b3fde7847e2e436823c90296362bdd65e", @"/Views/Notification/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9d934e34716462721fe53e0e988ee9360efed3c2", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Notification_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 8 "C:\Users\phuc3\CS451_phase_3\CommerceBank\Views\Notification\Index.cshtml"
  
    ViewData["Title"] = "Index";

    SortModels sortModel = (SortModels)ViewData["sortModel"];

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<link rel=\"stylesheet\" href = \"https://use.fontawesome.com/releases/v5.7.0/css/all.css\" />\r\n\r\n<h1>Alerts </h1>\r\n\r\n<p>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f9dcc45b3fde7847e2e436823c90296362bdd65e5277", async() => {
                WriteLiteral("Add New Notification");
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
            WriteLiteral("\r\n</p>\r\n\r\n\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                Type\r\n");
            WriteLiteral("            </th>\r\n            <th>\r\n                Rule\r\n");
            WriteLiteral("            </th>\r\n            <th>\r\n                Past Month Count\r\n");
            WriteLiteral("            </th>\r\n            <th>\r\n                Past Year Count\r\n");
            WriteLiteral("            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n<tbody>\r\n\r\n\r\n");
#nullable restore
#line 48 "C:\Users\phuc3\CS451_phase_3\CommerceBank\Views\Notification\Index.cshtml"
 foreach (Notifica item in Model.notilist) 
{
            int countMonth = 0;
            int countYear = 0;
            
            
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 54 "C:\Users\phuc3\CS451_phase_3\CommerceBank\Views\Notification\Index.cshtml"
             foreach (Transaction x in Model.translist)
            {
                var today = DateTime.Now;
                var month = new DateTime(today.Year, today.Month, 1);
                var first = month.AddMonths(-1);
                var last = month.AddDays(-1);
                var year = DateTime.Now.AddYears(-1);
                var pastfirst = new DateTime(year.Year, 1, 1);
                var pastlast = new DateTime(year.Year, 12, 31);
                float check = 0;
                if (item.NotificationType == "Category")
                {
                    string word1 = item.NotificationRule.ToLower();
                    string word2 = x.Description.ToLower();
                    if (x.CreatedDate >= first && x.CreatedDate <= last 
                    && item.UserKey == @UserManager.GetUserId(User) && word2.Contains(word1) && x.UserKey == @UserManager.GetUserId(User))
                    {
                        countMonth += 1;
                    }
                    if (x.CreatedDate >= pastfirst && x.CreatedDate <= pastlast 
                    && item.UserKey == @UserManager.GetUserId(User) && word2.Contains(word1) && x.UserKey == @UserManager.GetUserId(User))
                    {
                    countYear += 1;
                    }
                }
                else if (item.NotificationType == "Amount Exceed" && float.TryParse(item.NotificationRule,out check))
                {
                    string word1 = item.NotificationRule.ToLower();
                    string word2 = x.Description.ToLower();
                    if (x.CreatedDate >= first && x.CreatedDate <= last 
                    && item.UserKey == @UserManager.GetUserId(User) && x.Amount >= float.Parse(item.NotificationRule) && x.UserKey == @UserManager.GetUserId(User))
                    {
                        countMonth += 1;
                    }
                    if (x.CreatedDate >= pastfirst && x.CreatedDate <= pastlast 
                    && item.UserKey == @UserManager.GetUserId(User) && x.Amount >= float.Parse(item.NotificationRule) && x.UserKey == @UserManager.GetUserId(User))
                    {
                    countYear += 1;
                    }
                }
                else if (item.NotificationType == "Location")
                {
                    string word1 = item.NotificationRule.ToLower();
                    string word2 = x.Description.ToLower();
                    if (x.CreatedDate >= first && x.CreatedDate <= last 
                    && item.UserKey == @UserManager.GetUserId(User) && item.NotificationRule == x.Location && x.UserKey == @UserManager.GetUserId(User))
                    {
                        countMonth += 1;
                    }
                    if (x.CreatedDate >= pastfirst && x.CreatedDate <= pastlast 
                    && item.UserKey == @UserManager.GetUserId(User) && item.NotificationRule == x.Location && x.UserKey == @UserManager.GetUserId(User))
                    {
                    countYear += 1;
                    }
                }
                
                
                
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 115 "C:\Users\phuc3\CS451_phase_3\CommerceBank\Views\Notification\Index.cshtml"
             if (item.UserKey == @UserManager.GetUserId(User))
            {
                float check = 0;

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>\r\n                        ");
#nullable restore
#line 120 "C:\Users\phuc3\CS451_phase_3\CommerceBank\Views\Notification\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.NotificationType));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n");
#nullable restore
#line 122 "C:\Users\phuc3\CS451_phase_3\CommerceBank\Views\Notification\Index.cshtml"
                     if (item.NotificationType == "Amount Exceed" && float.TryParse(item.NotificationRule,out check))
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <td>\r\n                            ");
#nullable restore
#line 125 "C:\Users\phuc3\CS451_phase_3\CommerceBank\Views\Notification\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.NotificationRule));

#line default
#line hidden
#nullable disable
            WriteLiteral(" \r\n                        </td>\r\n");
#nullable restore
#line 127 "C:\Users\phuc3\CS451_phase_3\CommerceBank\Views\Notification\Index.cshtml"
                    }
                    else if (item.NotificationType == "Category" || item.NotificationType == "Location")
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <td>\r\n                            ");
#nullable restore
#line 131 "C:\Users\phuc3\CS451_phase_3\CommerceBank\Views\Notification\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.NotificationRule));

#line default
#line hidden
#nullable disable
            WriteLiteral(" \r\n                        </td>\r\n");
#nullable restore
#line 133 "C:\Users\phuc3\CS451_phase_3\CommerceBank\Views\Notification\Index.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <td>\r\n                            Invalid Value. \"");
#nullable restore
#line 137 "C:\Users\phuc3\CS451_phase_3\CommerceBank\Views\Notification\Index.cshtml"
                                       Write(Html.DisplayFor(modelItem => item.NotificationRule));

#line default
#line hidden
#nullable disable
            WriteLiteral("\"\" is not a number. <br>\r\n                            Please edit or delete it!\r\n                        </td>\r\n");
#nullable restore
#line 140 "C:\Users\phuc3\CS451_phase_3\CommerceBank\Views\Notification\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 142 "C:\Users\phuc3\CS451_phase_3\CommerceBank\Views\Notification\Index.cshtml"
                     if (item.NotificationType == "Amount Exceed" && float.TryParse(item.NotificationRule,out check))
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <td>\r\n                            ");
#nullable restore
#line 145 "C:\Users\phuc3\CS451_phase_3\CommerceBank\Views\Notification\Index.cshtml"
                       Write(countMonth);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 148 "C:\Users\phuc3\CS451_phase_3\CommerceBank\Views\Notification\Index.cshtml"
                       Write(countYear);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n");
#nullable restore
#line 150 "C:\Users\phuc3\CS451_phase_3\CommerceBank\Views\Notification\Index.cshtml"
                    }
                    else if (item.NotificationType == "Category" || item.NotificationType == "Location")
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <td>\r\n                            ");
#nullable restore
#line 154 "C:\Users\phuc3\CS451_phase_3\CommerceBank\Views\Notification\Index.cshtml"
                       Write(countMonth);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 157 "C:\Users\phuc3\CS451_phase_3\CommerceBank\Views\Notification\Index.cshtml"
                       Write(countYear);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n");
#nullable restore
#line 159 "C:\Users\phuc3\CS451_phase_3\CommerceBank\Views\Notification\Index.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <td>\r\n                            NaN\r\n                        </td>\r\n                        <td>\r\n                            NaN\r\n                        </td>\r\n");
#nullable restore
#line 168 "C:\Users\phuc3\CS451_phase_3\CommerceBank\Views\Notification\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    \r\n                    \r\n                    <td>\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f9dcc45b3fde7847e2e436823c90296362bdd65e16464", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 172 "C:\Users\phuc3\CS451_phase_3\CommerceBank\Views\Notification\Index.cshtml"
                                               WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" |\r\n");
            WriteLiteral("                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f9dcc45b3fde7847e2e436823c90296362bdd65e18672", async() => {
                WriteLiteral("Delete");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 174 "C:\Users\phuc3\CS451_phase_3\CommerceBank\Views\Notification\Index.cshtml"
                                                 WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 177 "C:\Users\phuc3\CS451_phase_3\CommerceBank\Views\Notification\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 177 "C:\Users\phuc3\CS451_phase_3\CommerceBank\Views\Notification\Index.cshtml"
             
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</tbody>\r\n</table>\r\n\r\n\r\n\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                Date\r\n");
            WriteLiteral("            </th>\r\n            <th>\r\n                Transaction ID\r\n");
            WriteLiteral("            </th>\r\n            <th>\r\n                Details\r\n");
            WriteLiteral("            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n\r\n\r\n\r\n<tbody>\r\n");
#nullable restore
#line 207 "C:\Users\phuc3\CS451_phase_3\CommerceBank\Views\Notification\Index.cshtml"
 foreach (Notifica x in Model.notilist)
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 209 "C:\Users\phuc3\CS451_phase_3\CommerceBank\Views\Notification\Index.cshtml"
     foreach (Transaction item in Model.translist) {
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 210 "C:\Users\phuc3\CS451_phase_3\CommerceBank\Views\Notification\Index.cshtml"
     if (item.UserKey == @UserManager.GetUserId(User) && x.UserKey == @UserManager.GetUserId(User))
    {
        float check = 0;
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 213 "C:\Users\phuc3\CS451_phase_3\CommerceBank\Views\Notification\Index.cshtml"
         if (x.NotificationType == "Amount Exceed" && float.TryParse(x.NotificationRule,out check))
        {
            if (item.Amount >= float.Parse(x.NotificationRule))
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>\r\n                        ");
#nullable restore
#line 219 "C:\Users\phuc3\CS451_phase_3\CommerceBank\Views\Notification\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.CreatedDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        #");
#nullable restore
#line 222 "C:\Users\phuc3\CS451_phase_3\CommerceBank\Views\Notification\Index.cshtml"
                    Write(Html.DisplayFor(modelItem => item.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n");
#nullable restore
#line 224 "C:\Users\phuc3\CS451_phase_3\CommerceBank\Views\Notification\Index.cshtml"
                     if (item.BalanceType == "Withdraw")
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <td>\r\n                            Transaction withdraw $");
#nullable restore
#line 227 "C:\Users\phuc3\CS451_phase_3\CommerceBank\Views\Notification\Index.cshtml"
                                             Write(Html.DisplayFor(modelItem => item.Amount));

#line default
#line hidden
#nullable disable
            WriteLiteral(" that exceeds $");
#nullable restore
#line 227 "C:\Users\phuc3\CS451_phase_3\CommerceBank\Views\Notification\Index.cshtml"
                                                                                                      Write(Html.DisplayFor(modelItem => x.NotificationRule));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n");
#nullable restore
#line 229 "C:\Users\phuc3\CS451_phase_3\CommerceBank\Views\Notification\Index.cshtml"
                    }
                    else
                    {
                        

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <td>\r\n                            Transaction deposit $");
#nullable restore
#line 234 "C:\Users\phuc3\CS451_phase_3\CommerceBank\Views\Notification\Index.cshtml"
                                            Write(Html.DisplayFor(modelItem => item.Amount));

#line default
#line hidden
#nullable disable
            WriteLiteral(" that exceeds $");
#nullable restore
#line 234 "C:\Users\phuc3\CS451_phase_3\CommerceBank\Views\Notification\Index.cshtml"
                                                                                                     Write(Html.DisplayFor(modelItem => x.NotificationRule));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n");
#nullable restore
#line 236 "C:\Users\phuc3\CS451_phase_3\CommerceBank\Views\Notification\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    \r\n");
            WriteLiteral("\r\n                    <td>\r\n                    \r\n");
            WriteLiteral("                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f9dcc45b3fde7847e2e436823c90296362bdd65e26003", async() => {
                WriteLiteral("Details");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 251 "C:\Users\phuc3\CS451_phase_3\CommerceBank\Views\Notification\Index.cshtml"
                                                  WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" \r\n");
            WriteLiteral("                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 255 "C:\Users\phuc3\CS451_phase_3\CommerceBank\Views\Notification\Index.cshtml"
            }
        }
        else if (x.NotificationType == "Location" && x.NotificationRule == item.Location)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                    <td>\r\n                        ");
#nullable restore
#line 261 "C:\Users\phuc3\CS451_phase_3\CommerceBank\Views\Notification\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.CreatedDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        #");
#nullable restore
#line 264 "C:\Users\phuc3\CS451_phase_3\CommerceBank\Views\Notification\Index.cshtml"
                    Write(Html.DisplayFor(modelItem => item.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        Transaction was made in ");
#nullable restore
#line 267 "C:\Users\phuc3\CS451_phase_3\CommerceBank\Views\Notification\Index.cshtml"
                                           Write(Html.DisplayFor(modelItem => x.NotificationRule));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n         \r\n");
            WriteLiteral("                    <td>\r\n                    \r\n");
            WriteLiteral("                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f9dcc45b3fde7847e2e436823c90296362bdd65e29816", async() => {
                WriteLiteral("Details");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 282 "C:\Users\phuc3\CS451_phase_3\CommerceBank\Views\Notification\Index.cshtml"
                                                  WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" \r\n");
            WriteLiteral("                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 286 "C:\Users\phuc3\CS451_phase_3\CommerceBank\Views\Notification\Index.cshtml"
        }
        else if (x.NotificationType == "Category" )
        {
            string word1 = x.NotificationRule.ToLower();
            string word2 = item.Description.ToLower();
            if (word2.Contains(word1))
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>\r\n                        ");
#nullable restore
#line 295 "C:\Users\phuc3\CS451_phase_3\CommerceBank\Views\Notification\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.CreatedDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        #");
#nullable restore
#line 298 "C:\Users\phuc3\CS451_phase_3\CommerceBank\Views\Notification\Index.cshtml"
                    Write(Html.DisplayFor(modelItem => item.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        Transaction was made from ");
#nullable restore
#line 301 "C:\Users\phuc3\CS451_phase_3\CommerceBank\Views\Notification\Index.cshtml"
                                             Write(Html.DisplayFor(modelItem => x.NotificationRule));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n         \r\n");
            WriteLiteral("                    <td>\r\n                    \r\n");
            WriteLiteral("                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f9dcc45b3fde7847e2e436823c90296362bdd65e33753", async() => {
                WriteLiteral("Details");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 316 "C:\Users\phuc3\CS451_phase_3\CommerceBank\Views\Notification\Index.cshtml"
                                                  WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" \r\n");
            WriteLiteral("                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 320 "C:\Users\phuc3\CS451_phase_3\CommerceBank\Views\Notification\Index.cshtml"
            }
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 321 "C:\Users\phuc3\CS451_phase_3\CommerceBank\Views\Notification\Index.cshtml"
         
       
            
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 324 "C:\Users\phuc3\CS451_phase_3\CommerceBank\Views\Notification\Index.cshtml"
 
   
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 326 "C:\Users\phuc3\CS451_phase_3\CommerceBank\Views\Notification\Index.cshtml"
 

           
}

#line default
#line hidden
#nullable disable
            WriteLiteral("</tbody>\r\n</table>\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public UserManager<ApplicationUser> UserManager { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SignInManager<ApplicationUser> SignInManager { get; private set; } = default!;
        #nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
