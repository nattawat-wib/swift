#pragma checksum "C:\Users\nutella\Downloads\swift-main-dev\Views\Admin\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5498c80e461b95a66e416a10a2e1df31f11cd693"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_Index), @"mvc.1.0.view", @"/Views/Admin/Index.cshtml")]
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
#line 1 "C:\Users\nutella\Downloads\swift-main-dev\Views\_ViewImports.cshtml"
using Swift;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\nutella\Downloads\swift-main-dev\Views\_ViewImports.cshtml"
using Swift.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5498c80e461b95a66e416a10a2e1df31f11cd693", @"/Views/Admin/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"99dcd4ad05d8003e1690710613816ad6b16da116", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Swift.Models.UserAccount>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ExportToExcel", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-dark"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("max-width: 900px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("mx-auto"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("autocomplete", new global::Microsoft.AspNetCore.Html.HtmlString("off"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\nutella\Downloads\swift-main-dev\Views\Admin\Index.cshtml"
  

    ViewData["Title"] = "Admin";

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\nutella\Downloads\swift-main-dev\Views\Admin\Index.cshtml"
  
    string[] jobList = { "Computer Scientist","IT Professional","UX Designer & UI Developer","Frontend Developer","Backend Developer","SQL Developer","Web Designer","Web Developer","Help Desk Worker/Desktop Support","Software Engineer","Data Entry","DevOps Engineer","Computer Programmer","Network Administrator","Information Security Analyst","Artificial Intelligence Engineer","Cloud Architect","IT Manager","Technical Specialist","Application Developer","Chief Technology Officer (CTO)","Chief Information Officer (CIO)","Marketing Specialist","Marketing Manager","Marketing Director","Graphic Designer","Marketing Research Analyst","Marketing Communications Manager","Marketing Consultant","Product Manager","Public Relations","Social Media Assistant","Brand Manager","SEO Manager","Content Marketing Manager","Copywriter","Media Buyer","Digital Marketing Manager","eCommerce Marketing Specialist","Brand Strategist","Vice President of Marketing","Media Relations Coordinator","Administrative Assistant","Receptionist","Office Manager","Auditing Clerk","Bookkeeper","Account Executive","Branch Manager","Business Manager","Quality Control Coordinator","Administrative Manager","Chief Executive Officer","Business Analyst","Risk Manager","Human Resources","Office Assistant","Secretary","Office Clerk","File Clerk","Account Collector","Administrative Specialist","Executive Assistant","Program Administrator","Program Manager","Administrative Analyst","Data Entry","Team Leader","Manager","Assistant Manager","Executive","Director","Coordinator","Administrator","Controller","Officer","Organizer","Supervisor","Superintendent","Head","Overseer","Chief","Foreman","Controller","Principal","President","Lead" };


#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral(@"<main>
    <h2 class=""text-center""> All users </h2>
    <div class=""table-responsive my-4"">
        <table id=""user-data-table"" class=""table table-striped table-hover w-100"">
            <thead>
                
            <tr class=""bg-info text-light h6 fw-bold text-nowrap border-0"">
                <td>Id</td>
                <td>Name</td>
                <td>Email</td>
                <td>Occupation</td>
                <td>Income</td>
                <td>Date Of Birth</td>
                <td>Address</td>
                <td>Action</td>
            </tr>
            </thead>
            <tbody>

");
#nullable restore
#line 30 "C:\Users\nutella\Downloads\swift-main-dev\Views\Admin\Index.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr class=\"text-nowrap border-0\">\r\n                    <td class=\"fw-semi-bold w-25\">");
#nullable restore
#line 33 "C:\Users\nutella\Downloads\swift-main-dev\Views\Admin\Index.cshtml"
                                             Write(item.UserId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td class=\"fw-semi-bold w-100\">");
#nullable restore
#line 34 "C:\Users\nutella\Downloads\swift-main-dev\Views\Admin\Index.cshtml"
                                              Write(item.Username);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td class=\"fw-semi-bold w-100\">");
#nullable restore
#line 35 "C:\Users\nutella\Downloads\swift-main-dev\Views\Admin\Index.cshtml"
                                              Write(item.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td class=\"fw-semi-bold w-100\">");
#nullable restore
#line 36 "C:\Users\nutella\Downloads\swift-main-dev\Views\Admin\Index.cshtml"
                                              Write(item.Occupation);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td class=\"fw-semi-bold w-100\">");
#nullable restore
#line 37 "C:\Users\nutella\Downloads\swift-main-dev\Views\Admin\Index.cshtml"
                                              Write(item.Income);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td class=\"fw-semi-bold w-100\">");
#nullable restore
#line 38 "C:\Users\nutella\Downloads\swift-main-dev\Views\Admin\Index.cshtml"
                                              Write(item.DateOfBirth);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td class=\"fw-semi-bold w-100\">");
#nullable restore
#line 39 "C:\Users\nutella\Downloads\swift-main-dev\Views\Admin\Index.cshtml"
                                              Write(item.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td class=\" d-flex flex-nowrap text-nowrap\">\r\n                        <button class=\"btn btn-success me-2 edit-user\" data-id=\"");
#nullable restore
#line 41 "C:\Users\nutella\Downloads\swift-main-dev\Views\Admin\Index.cshtml"
                                                                           Write(item.UserId);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" data-name=\"");
#nullable restore
#line 41 "C:\Users\nutella\Downloads\swift-main-dev\Views\Admin\Index.cshtml"
                                                                                                    Write(item.Username);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"\r\n                        data-email=\"");
#nullable restore
#line 42 "C:\Users\nutella\Downloads\swift-main-dev\Views\Admin\Index.cshtml"
                               Write(item.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" data-occupation=\"");
#nullable restore
#line 42 "C:\Users\nutella\Downloads\swift-main-dev\Views\Admin\Index.cshtml"
                                                             Write(item.Occupation);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" data-income=\"");
#nullable restore
#line 42 "C:\Users\nutella\Downloads\swift-main-dev\Views\Admin\Index.cshtml"
                                                                                            Write(item.Income);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"\r\n                        data-telephone=\"");
#nullable restore
#line 43 "C:\Users\nutella\Downloads\swift-main-dev\Views\Admin\Index.cshtml"
                                   Write(item.Telephone);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" data-dateOfBirth=\"");
#nullable restore
#line 43 "C:\Users\nutella\Downloads\swift-main-dev\Views\Admin\Index.cshtml"
                                                                      Write(item.DateOfBirth);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"\r\n                        data-facebook=\"");
#nullable restore
#line 44 "C:\Users\nutella\Downloads\swift-main-dev\Views\Admin\Index.cshtml"
                                  Write(item.Facebook);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" data-ig=\"");
#nullable restore
#line 44 "C:\Users\nutella\Downloads\swift-main-dev\Views\Admin\Index.cshtml"
                                                           Write(item.Ig);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" data-address=\"");
#nullable restore
#line 44 "C:\Users\nutella\Downloads\swift-main-dev\Views\Admin\Index.cshtml"
                                                                                   Write(item.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"> <i\r\n                            class=\"fas fa-edit\"></i> EDIT </button>\r\n                        <button class=\"delete-user btn btn-danger\" data-user_id=\"");
#nullable restore
#line 46 "C:\Users\nutella\Downloads\swift-main-dev\Views\Admin\Index.cshtml"
                                                                            Write(item.UserId);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"\r\n                        data-user_name=\"");
#nullable restore
#line 47 "C:\Users\nutella\Downloads\swift-main-dev\Views\Admin\Index.cshtml"
                                   Write(item.Username);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"> <i class=\"far fa-trash-alt\"></i> DELETE </button>\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 50 "C:\Users\nutella\Downloads\swift-main-dev\Views\Admin\Index.cshtml"

            }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n    <div class=\"text-end\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5498c80e461b95a66e416a10a2e1df31f11cd69315180", async() => {
                WriteLiteral("Export");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
    </div>
    <br>
</main>

<!-- Modal -->
<div class=""modal fade"" id=""edit_user_modal"" tabindex=""-1"" aria-labelledby=""edit_user_modalLabel"" aria-hidden=""true"">
    <div class=""modal-dialog modal-lg modal-dialog-centered"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title edit_user_modalLabel""> edit user </h5>
                <button type=""button"" class=""btn-close"" data-mdb-dismiss=""modal"" aria-label=""Close""></button>
            </div>
            <div class=""modal-body"">
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5498c80e461b95a66e416a10a2e1df31f11cd69317018", async() => {
                WriteLiteral(@"
                    <div class=""row row-space"">
                        <div class=""col-md-6"">
                            <div class=""form-outline"">
                                <input type=""hidden"" name=""id"" />
                                <input value=""test"" type=""text"" name=""username"" class=""form-control"" disabled />
");
                WriteLiteral(@"                            </div>
                        </div>
                        <div class=""col-md-6"">
                            <div class=""form-outline"">
                                <input value=""test"" type=""email"" name=""email"" class=""form-control"" />
                                <label class=""form-label"" for=""form1"">Email Address</label>
                            </div>
                        </div>
                    </div>

                    <div class=""row row-space"">
                        <div class=""col-md-6"">
                            <select class=""selectpicker form-control"" name=""occupation"" data-live-search=""true"">
                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5498c80e461b95a66e416a10a2e1df31f11cd69318399", async() => {
                    WriteLiteral(" ---- select your occupation ---- ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("disabled", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 91 "C:\Users\nutella\Downloads\swift-main-dev\Views\Admin\Index.cshtml"
                                 foreach (var job in jobList)
                                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5498c80e461b95a66e416a10a2e1df31f11cd69320614", async() => {
                    WriteLiteral(" ");
#nullable restore
#line 93 "C:\Users\nutella\Downloads\swift-main-dev\Views\Admin\Index.cshtml"
                                                           Write(job);

#line default
#line hidden
#nullable disable
                    WriteLiteral(" ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 93 "C:\Users\nutella\Downloads\swift-main-dev\Views\Admin\Index.cshtml"
                                                    Write(job);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("data-tokens", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 94 "C:\Users\nutella\Downloads\swift-main-dev\Views\Admin\Index.cshtml"
                                }

#line default
#line hidden
#nullable disable
                WriteLiteral("                            </select>           \r\n                        </div>\r\n                        <div class=\"col-md-6\">\r\n                            <select class=\"form-select text-dark\" name=\"income\">\r\n                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5498c80e461b95a66e416a10a2e1df31f11cd69322902", async() => {
                    WriteLiteral(" ---- select your income ---- ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("disabled", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 100 "C:\Users\nutella\Downloads\swift-main-dev\Views\Admin\Index.cshtml"
                                  
                                    var income = 10000;
                                

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
#nullable restore
#line 104 "C:\Users\nutella\Downloads\swift-main-dev\Views\Admin\Index.cshtml"
                                 for (var i = 0; i < 40; i++)
                                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5498c80e461b95a66e416a10a2e1df31f11cd69325429", async() => {
                    WriteLiteral(" income : ");
#nullable restore
#line 106 "C:\Users\nutella\Downloads\swift-main-dev\Views\Admin\Index.cshtml"
                                                                                 Write(income);

#line default
#line hidden
#nullable disable
                    WriteLiteral(" ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 106 "C:\Users\nutella\Downloads\swift-main-dev\Views\Admin\Index.cshtml"
                                                        WriteLiteral(income);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 107 "C:\Users\nutella\Downloads\swift-main-dev\Views\Admin\Index.cshtml"
                                    income = income + 5000;
                                }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                            </select>                            
                        </div>
                    </div>

                    <div class=""row row-space"">
                        <div class=""col-12"">
                            <div class=""form-outline"">
                                <input value=""test"" type=""text"" name=""dateOfBirth"" class=""form-control datepicker"" />
                                <label class=""form-label"" for=""form1"">Date of birth</label>
                            </div>
                        </div>
                    </div>

                    <br />

                    <div class=""row row-space"">
                        <div class=""col-md-4"">
                            <div class=""form-outline"">
                                <input value=""test"" type=""text"" name=""facebook"" class=""form-control"" />
                                <label class=""form-label"" for=""province""> Facebook </label>
                            </div>
                 ");
                WriteLiteral(@"       </div>
                        <div class=""col-md-4"">
                            <div class=""form-outline"">
                                <input value=""test"" type=""text"" name=""ig"" class=""form-control"" />
                                <label class=""form-label"" for=""district""> Instragram </label>
                            </div>
                        </div>
                        <div class=""col-md-4"">
                            <div class=""form-outline"">
                                <input value=""test"" type=""number"" name=""telephone"" class=""form-control"" />
                                <label class=""form-label"" for=""amphoe""> Telephone </label>
                            </div>
                        </div>
                    </div>

                    <div class=""row row-space"">
                        <div class=""col-12"">
                            <div class=""form-outline"">
                                <textarea class=""form-control"" name=""address"" rows=""4""> te");
                WriteLiteral(@"st </textarea>
                                <label class=""form-label"" for=""form1"">Address</label>
                            </div>
                        </div>
                    </div>

                    <div class=""modal-footer"">
                        <button type=""button"" class=""btn btn-secondary"" data-mdb-dismiss=""modal"">
                            Close
                        </button>
                        <button type=""button"" class=""update-user btn btn-primary"">Save changes</button>
                    </div>
                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Swift.Models.UserAccount>> Html { get; private set; }
    }
}
#pragma warning restore 1591
