#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Hangfire.MissionControl.Dashboard.Pages
{
    using System;
    using System.Collections.Generic;
    
    #line 2 "..\..\Dashboard\Pages\MissionsOverviewPage.cshtml"
    using System.Linq;
    
    #line default
    #line hidden
    using System.Text;
    
    #line 3 "..\..\Dashboard\Pages\MissionsOverviewPage.cshtml"
    using Hangfire.Dashboard.Pages;
    
    #line default
    #line hidden
    
    #line 4 "..\..\Dashboard\Pages\MissionsOverviewPage.cshtml"
    using Hangfire.MissionControl;
    
    #line default
    #line hidden
    
    #line 5 "..\..\Dashboard\Pages\MissionsOverviewPage.cshtml"
    using Hangfire.MissionControl.Dashboard.Pages;
    
    #line default
    #line hidden
    
    #line 6 "..\..\Dashboard\Pages\MissionsOverviewPage.cshtml"
    using Hangfire.MissionControl.Dashboard.Pages.Controls;
    
    #line default
    #line hidden
    
    #line 7 "..\..\Dashboard\Pages\MissionsOverviewPage.cshtml"
    using Hangfire.MissionControl.Model;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    internal partial class MissionsOverviewPage : Hangfire.Dashboard.RazorPage
    {
#line hidden

        public override void Execute()
        {


WriteLiteral("\r\n");









            
            #line 9 "..\..\Dashboard\Pages\MissionsOverviewPage.cshtml"
  
    string selectedCategory = this.SelectedCategory;
    MissionMap missionMap = this.MissionMap;
    MissionControlOptions options = this.Options;
    Layout = new LayoutPage(Title);
    var availableMissions = missionMap.Missions.Where(x => x.Value.CategoryName == selectedCategory).Select(x => x.Value).ToArray();


            
            #line default
            #line hidden
WriteLiteral("\r\n<link rel=\"stylesheet\" type=\"text/css\" href=\"");


            
            #line 17 "..\..\Dashboard\Pages\MissionsOverviewPage.cshtml"
                                        Write(Url.To("/mission-control/css/styles"));

            
            #line default
            #line hidden
WriteLiteral("\" />\r\n<link rel=\"stylesheet\" type=\"text/css\" href=\"");


            
            #line 18 "..\..\Dashboard\Pages\MissionsOverviewPage.cshtml"
                                        Write(Url.To("/mission-control/css/bootstrap-datetimepicker"));

            
            #line default
            #line hidden
WriteLiteral("\" />\r\n<script>\r\n    var baseUrl = \"");


            
            #line 20 "..\..\Dashboard\Pages\MissionsOverviewPage.cshtml"
              Write(Url.To("/mission/launch"));

            
            #line default
            #line hidden
WriteLiteral("\";\r\n    var idFieldName = \"");


            
            #line 21 "..\..\Dashboard\Pages\MissionsOverviewPage.cshtml"
                  Write(Mission.IdField);

            
            #line default
            #line hidden
WriteLiteral("\";\r\n    var jobLinkBaseUrl = \"");


            
            #line 22 "..\..\Dashboard\Pages\MissionsOverviewPage.cshtml"
                     Write(Url.JobDetails(""));

            
            #line default
            #line hidden
WriteLiteral("\";\r\n    var requireConfirmation = ");


            
            #line 23 "..\..\Dashboard\Pages\MissionsOverviewPage.cshtml"
                         Write(options.RequireConfirmation.ToString().ToLowerInvariant());

            
            #line default
            #line hidden
WriteLiteral(";\r\n</script>\r\n<script type=\"text/javascript\" src=\"");


            
            #line 25 "..\..\Dashboard\Pages\MissionsOverviewPage.cshtml"
                               Write(Url.To("/mission-control/js/moment"));

            
            #line default
            #line hidden
WriteLiteral("\"></script>\r\n<script defer type=\"text/javascript\" src=\"");


            
            #line 26 "..\..\Dashboard\Pages\MissionsOverviewPage.cshtml"
                                     Write(Url.To("/mission-control/js/bootstrap-datetimepicker"));

            
            #line default
            #line hidden
WriteLiteral("\"></script>\r\n<script defer type=\"text/javascript\" src=\"");


            
            #line 27 "..\..\Dashboard\Pages\MissionsOverviewPage.cshtml"
                                     Write(Url.To("/mission-control/js/page"));

            
            #line default
            #line hidden
WriteLiteral("\"></script>\r\n\r\n<div class=\"row\">\r\n    <div class=\"col-md-3\">\r\n        ");


            
            #line 31 "..\..\Dashboard\Pages\MissionsOverviewPage.cshtml"
   Write(CategoriesSidebar.Render(Html, selectedCategory, missionMap));

            
            #line default
            #line hidden
WriteLiteral("\r\n    </div>\r\n    <div class=\"col-md-9\">\r\n        <h1 class=\"page-header\">");


            
            #line 34 "..\..\Dashboard\Pages\MissionsOverviewPage.cshtml"
                           Write(selectedCategory);

            
            #line default
            #line hidden
WriteLiteral("</h1>\r\n");


            
            #line 35 "..\..\Dashboard\Pages\MissionsOverviewPage.cshtml"
         if (availableMissions.Length == 0)
        {

            
            #line default
            #line hidden
WriteLiteral("            <div class=\"alert alert-warning\" role=\"alert\">\r\n                No mi" +
"ssions for selected category are available\r\n            </div>\r\n");


            
            #line 40 "..\..\Dashboard\Pages\MissionsOverviewPage.cshtml"
        }

            
            #line default
            #line hidden
WriteLiteral("\r\n");


            
            #line 42 "..\..\Dashboard\Pages\MissionsOverviewPage.cshtml"
         foreach (var mission in availableMissions)
        {

            
            #line default
            #line hidden
WriteLiteral("            <div class=\"panel panel-default\">\r\n                <div class=\"panel-" +
"heading\">\r\n                    <div class=\"btn-group\">\r\n                        " +
"<a role=\"button\" data-toggle=\"collapse\" href=\"#");


            
            #line 47 "..\..\Dashboard\Pages\MissionsOverviewPage.cshtml"
                                                                  Write(mission.Id);

            
            #line default
            #line hidden
WriteLiteral("-panel\" aria-expanded=\"false\">\r\n                            <h3 class=\"panel-titl" +
"e\">");


            
            #line 48 "..\..\Dashboard\Pages\MissionsOverviewPage.cshtml"
                                               Write(mission.Name);

            
            #line default
            #line hidden
WriteLiteral("</h3>\r\n                        </a>\r\n                    </div>\r\n                " +
"</div>\r\n                <div id=\"");


            
            #line 52 "..\..\Dashboard\Pages\MissionsOverviewPage.cshtml"
                    Write(mission.Id);

            
            #line default
            #line hidden
WriteLiteral(@"-panel"" class=""panel-body collapse"">
                    <!--templates-->
                    <div class=""mission-template-container panel panel-default"">
                        <div class=""panel-heading"">
                            <div class=""btn-group"">
                                <a role=""button"" data-toggle=""collapse"" href=""#");


            
            #line 57 "..\..\Dashboard\Pages\MissionsOverviewPage.cshtml"
                                                                          Write(mission.Id);

            
            #line default
            #line hidden
WriteLiteral("-templates\" aria-expanded=\"false\">\r\n                                    <h3 class" +
"=\"panel-title\">Templates</h3>\r\n                                </a>\r\n           " +
"                 </div>\r\n                        </div>\r\n                       " +
" <div id=\"");


            
            #line 62 "..\..\Dashboard\Pages\MissionsOverviewPage.cshtml"
                            Write(mission.Id);

            
            #line default
            #line hidden
WriteLiteral("-templates\" class=\"panel-body collapse\">\r\n                            <label for=" +
"\"");


            
            #line 63 "..\..\Dashboard\Pages\MissionsOverviewPage.cshtml"
                                   Write(mission.Id);

            
            #line default
            #line hidden
WriteLiteral("-template-search\">Search templates</label>\r\n                            <input id" +
"=\"");


            
            #line 64 "..\..\Dashboard\Pages\MissionsOverviewPage.cshtml"
                                  Write(mission.Id);

            
            #line default
            #line hidden
WriteLiteral("-template-search\" type=\"search\" class=\"template-search form-control\" />\r\n        " +
"                    <ol class=\"templates\">\r\n                                <li " +
"class=\"template\">\r\n                                    <h1 class=\"template-heade" +
"r\">Test name</h1>\r\n                                    <button type=\"button\" cla" +
"ss=\"btn btn-info\">Use</button> <button type=\"button\" class=\"btn btn-danger\">Dele" +
"te</button>\r\n                                    <table class=\"table\">\r\n        " +
"                                <thead>\r\n                                       " +
"     <tr>\r\n                                                <th>Parameter</th>\r\n " +
"                                               <th>Value</th>\r\n                 " +
"                           </tr>\r\n                                        </thea" +
"d>\r\n                                        <tbody>\r\n                           " +
"                 <tr>\r\n                                                <td>Somet" +
"hing</td>\r\n                                                <td>123</td>\r\n       " +
"                                     </tr>\r\n                                    " +
"        <tr>\r\n                                                <td>Something2</td" +
">\r\n                                                <td>123123</td>\r\n            " +
"                                </tr>\r\n                                        <" +
"/tbody>\r\n                                    </table>\r\n                         " +
"       </li>\r\n                            </ol>\r\n                        </div>\r" +
"\n                    </div>\r\n                    <!--end templates-->\r\n");


            
            #line 92 "..\..\Dashboard\Pages\MissionsOverviewPage.cshtml"
                     if (!string.IsNullOrWhiteSpace(mission.Description))
                    {

            
            #line default
            #line hidden
WriteLiteral("                        <p>");


            
            #line 94 "..\..\Dashboard\Pages\MissionsOverviewPage.cshtml"
                      Write(mission.Description);

            
            #line default
            #line hidden
WriteLiteral("</p>\r\n");


            
            #line 95 "..\..\Dashboard\Pages\MissionsOverviewPage.cshtml"
                    }

            
            #line default
            #line hidden
WriteLiteral("\r\n                    <div class=\"job-snippet\">\r\n                        <div cla" +
"ss=\"job-snippet-code\">\r\n                            <pre><code>");


            
            #line 99 "..\..\Dashboard\Pages\MissionsOverviewPage.cshtml"
                                  Write(MissionRenderer.RenderMission(mission.MethodInfo));

            
            #line default
            #line hidden
WriteLiteral("</code></pre>\r\n                        </div>\r\n                    </div>\r\n\r\n    " +
"                <form id=\"");


            
            #line 103 "..\..\Dashboard\Pages\MissionsOverviewPage.cshtml"
                         Write(mission.Id);

            
            #line default
            #line hidden
WriteLiteral("\" autocomplete=\"off\">\r\n");


            
            #line 104 "..\..\Dashboard\Pages\MissionsOverviewPage.cshtml"
                         foreach (var parameter in mission.MethodInfo.GetParameters())
                        {
                            var control = ControlFactory.CreateControl(parameter);
                            if (control is NullControl)
                            {
                                continue;
                            }


            
            #line default
            #line hidden
WriteLiteral("                            <div class=\"form-group\">\r\n                           " +
"     ");


            
            #line 113 "..\..\Dashboard\Pages\MissionsOverviewPage.cshtml"
                           Write(Html.RenderPartial(control));

            
            #line default
            #line hidden
WriteLiteral("\r\n                            </div>\r\n");


            
            #line 115 "..\..\Dashboard\Pages\MissionsOverviewPage.cshtml"
                        }

            
            #line default
            #line hidden
WriteLiteral("\r\n                        <button type=\"button\" class=\"btn btn-info\" onclick=\"onM" +
"issionStart(this, \'");


            
            #line 117 "..\..\Dashboard\Pages\MissionsOverviewPage.cshtml"
                                                                                             Write(mission.Id);

            
            #line default
            #line hidden
WriteLiteral("\');\">Enqueue</button>\r\n                    </form>\r\n                </div>\r\n     " +
"           <div id=\"");


            
            #line 120 "..\..\Dashboard\Pages\MissionsOverviewPage.cshtml"
                    Write(mission.Id);

            
            #line default
            #line hidden
WriteLiteral("-alerts\" class=\"panel-footer hidden\"></div>\r\n            </div>\r\n");


            
            #line 122 "..\..\Dashboard\Pages\MissionsOverviewPage.cshtml"
        }

            
            #line default
            #line hidden
WriteLiteral("    </div>\r\n</div>\r\n");


        }
    }
}
#pragma warning restore 1591
