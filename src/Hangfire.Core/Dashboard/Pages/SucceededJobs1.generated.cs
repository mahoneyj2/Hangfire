﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Hangfire.Dashboard.Pages
{
    
    #line 2 "..\..\Dashboard\Pages\SucceededJobs.cshtml"
    using System;
    
    #line default
    #line hidden
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    
    #line 3 "..\..\Dashboard\Pages\SucceededJobs.cshtml"
    using Hangfire.Dashboard;
    
    #line default
    #line hidden
    
    #line 4 "..\..\Dashboard\Pages\SucceededJobs.cshtml"
    using Hangfire.Dashboard.Pages;
    
    #line default
    #line hidden
    
    #line 5 "..\..\Dashboard\Pages\SucceededJobs.cshtml"
    using Hangfire.Dashboard.Resources;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    internal partial class SucceededJobs : RazorPage
    {
#line hidden

        public override void Execute()
        {


WriteLiteral("\r\n");







            
            #line 7 "..\..\Dashboard\Pages\SucceededJobs.cshtml"
  
    Layout = new LayoutPage(Strings.SucceededJobsPage_Title);

    int from, perPage;

    int.TryParse(Query("from"), out from);
    int.TryParse(Query("count"), out perPage);

    var monitor = Storage.GetMonitoringApi();
    var pager = new Pager(from, perPage, monitor.SucceededListCount());
    var succeededJobs = monitor.SucceededJobs(pager.FromRecord, pager.RecordsPerPage);
    var servers = monitor.Servers();


            
            #line default
            #line hidden
WriteLiteral("\r\n<div class=\"row\">\r\n    <div class=\"col-md-3\">\r\n        ");


            
            #line 23 "..\..\Dashboard\Pages\SucceededJobs.cshtml"
   Write(Html.JobsSidebar());

            
            #line default
            #line hidden
WriteLiteral("\r\n    </div>\r\n    <div class=\"col-md-9\">\r\n        <h1 class=\"page-header\">");


            
            #line 26 "..\..\Dashboard\Pages\SucceededJobs.cshtml"
                           Write(Strings.SucceededJobsPage_Title);

            
            #line default
            #line hidden
WriteLiteral("</h1>\r\n\r\n");


            
            #line 28 "..\..\Dashboard\Pages\SucceededJobs.cshtml"
         if (pager.TotalPageCount == 0)
        {

            
            #line default
            #line hidden
WriteLiteral("            <div class=\"alert alert-info\">\r\n                ");


            
            #line 31 "..\..\Dashboard\Pages\SucceededJobs.cshtml"
           Write(Strings.SucceededJobsPage_NoJobs);

            
            #line default
            #line hidden
WriteLiteral("\r\n            </div>\r\n");


            
            #line 33 "..\..\Dashboard\Pages\SucceededJobs.cshtml"
        }
        else
        {

            
            #line default
            #line hidden
WriteLiteral("            <div class=\"js-jobs-list\">\r\n                <div class=\"btn-toolbar b" +
"tn-toolbar-top\">\r\n");


            
            #line 38 "..\..\Dashboard\Pages\SucceededJobs.cshtml"
                     if (SpecificJobRequeue == true)
                    {

            
            #line default
            #line hidden
WriteLiteral(@"                        <div class=""btn-group"">
                            <button data-toggle=""dropdown"" data-target=""#advanced-requeue-dropdown""
                                    class=""js-jobs-list-select btn dropdown-toggle btn-sm btn-primary""
                                    aria-haspopup=""true"" aria-expanded=""false"" disabled=""disabled"">
                                <span class=""glyphicon glyphicon-repeat""></span>
                                ");


            
            #line 45 "..\..\Dashboard\Pages\SucceededJobs.cshtml"
                           Write(Strings.Common_RequeueJobs);

            
            #line default
            #line hidden
WriteLiteral("\r\n                            </button>\r\n                            <ul class=\"d" +
"ropdown-menu\">\r\n                                <li>\r\n                          " +
"          <a class=\"js-jobs-list-command noselect\" data-url=\"");


            
            #line 49 "..\..\Dashboard\Pages\SucceededJobs.cshtml"
                                                                                  Write(Url.To("/jobs/succeeded/requeue"));

            
            #line default
            #line hidden
WriteLiteral("\">\r\n                                        Default queue\r\n                      " +
"              </a>\r\n                                </li>\r\n                     " +
"           <li class=\"divider\" role=\"separator\"></li>\r\n");


            
            #line 54 "..\..\Dashboard\Pages\SucceededJobs.cshtml"
                                 foreach (var server in servers)
                                {

            
            #line default
            #line hidden
WriteLiteral("                                    <li class=\"noselect dropdown-header\">");


            
            #line 56 "..\..\Dashboard\Pages\SucceededJobs.cshtml"
                                                                     Write(server.Name.ToUpperInvariant().Split(':')[0]);

            
            #line default
            #line hidden
WriteLiteral("</li>\r\n");


            
            #line 57 "..\..\Dashboard\Pages\SucceededJobs.cshtml"
                                    foreach (var queue in server.Queues)
                                    {

            
            #line default
            #line hidden
WriteLiteral("                                        <li>\r\n                                   " +
"         <a class=\"noselect js-jobs-list-command\"\r\n                             " +
"                  data-url=\"");


            
            #line 61 "..\..\Dashboard\Pages\SucceededJobs.cshtml"
                                                    Write(Url.To("/jobs/succeeded/specificrequeue"));

            
            #line default
            #line hidden
WriteLiteral("\"\r\n                                               id=\"");


            
            #line 62 "..\..\Dashboard\Pages\SucceededJobs.cshtml"
                                              Write(queue);

            
            #line default
            #line hidden
WriteLiteral("\">\r\n                                                ");


            
            #line 63 "..\..\Dashboard\Pages\SucceededJobs.cshtml"
                                           Write(queue);

            
            #line default
            #line hidden
WriteLiteral("\r\n                                            </a>\r\n                             " +
"           </li>\r\n");


            
            #line 66 "..\..\Dashboard\Pages\SucceededJobs.cshtml"
                                    }
                                }

            
            #line default
            #line hidden
WriteLiteral("                            </ul>\r\n                        </div>\r\n");


            
            #line 70 "..\..\Dashboard\Pages\SucceededJobs.cshtml"
                    }
                    else
                    {

            
            #line default
            #line hidden
WriteLiteral("                        <button class=\"js-jobs-list-command btn btn-sm btn-primar" +
"y\"\r\n                                data-url=\"");


            
            #line 74 "..\..\Dashboard\Pages\SucceededJobs.cshtml"
                                     Write(Url.To("/jobs/succeeded/requeue"));

            
            #line default
            #line hidden
WriteLiteral("\"\r\n                                data-loading-text=\"");


            
            #line 75 "..\..\Dashboard\Pages\SucceededJobs.cshtml"
                                              Write(Strings.Common_Enqueueing);

            
            #line default
            #line hidden
WriteLiteral("\"\r\n                                disabled=\"disabled\">\r\n                        " +
"    <span class=\"glyphicon glyphicon-repeat\"></span>\r\n                          " +
"  ");


            
            #line 78 "..\..\Dashboard\Pages\SucceededJobs.cshtml"
                       Write(Strings.Common_RequeueJobs);

            
            #line default
            #line hidden
WriteLiteral("\r\n                        </button>\r\n");


            
            #line 80 "..\..\Dashboard\Pages\SucceededJobs.cshtml"
                    }

            
            #line default
            #line hidden
WriteLiteral("\r\n                    ");


            
            #line 82 "..\..\Dashboard\Pages\SucceededJobs.cshtml"
               Write(Html.PerPageSelector(pager));

            
            #line default
            #line hidden
WriteLiteral(@"
                </div>

                <div class=""table-responsive"">
                    <table class=""table"">
                        <thead>
                            <tr>
                                <th class=""min-width"">
                                    <input type=""checkbox"" class=""js-jobs-list-select-all"" />
                                </th>
                                <th class=""min-width"">");


            
            #line 92 "..\..\Dashboard\Pages\SucceededJobs.cshtml"
                                                 Write(Strings.Common_Id);

            
            #line default
            #line hidden
WriteLiteral("</th>\r\n                                <th>");


            
            #line 93 "..\..\Dashboard\Pages\SucceededJobs.cshtml"
                               Write(Strings.Common_Job);

            
            #line default
            #line hidden
WriteLiteral("</th>\r\n                                <th class=\"min-width\">");


            
            #line 94 "..\..\Dashboard\Pages\SucceededJobs.cshtml"
                                                 Write(Strings.SucceededJobsPage_Table_TotalDuration);

            
            #line default
            #line hidden
WriteLiteral("</th>\r\n                                <th class=\"align-right\">");


            
            #line 95 "..\..\Dashboard\Pages\SucceededJobs.cshtml"
                                                   Write(Strings.SucceededJobsPage_Table_Succeeded);

            
            #line default
            #line hidden
WriteLiteral("</th>\r\n                            </tr>\r\n                        </thead>\r\n     " +
"                   <tbody>\r\n");


            
            #line 99 "..\..\Dashboard\Pages\SucceededJobs.cshtml"
                             foreach (var job in succeededJobs)
                            {

            
            #line default
            #line hidden
WriteLiteral("                                <tr class=\"js-jobs-list-row ");


            
            #line 101 "..\..\Dashboard\Pages\SucceededJobs.cshtml"
                                                        Write(job.Value == null || !job.Value.InSucceededState ? "obsolete-data" : null);

            
            #line default
            #line hidden
WriteLiteral(" ");


            
            #line 101 "..\..\Dashboard\Pages\SucceededJobs.cshtml"
                                                                                                                                     Write(job.Value != null && job.Value.InSucceededState ? "hover" : null);

            
            #line default
            #line hidden
WriteLiteral("\">\r\n                                    <td>\r\n");


            
            #line 103 "..\..\Dashboard\Pages\SucceededJobs.cshtml"
                                         if (job.Value == null || job.Value.InSucceededState)
                                        {

            
            #line default
            #line hidden
WriteLiteral("                                            <input type=\"checkbox\" class=\"js-jobs" +
"-list-checkbox\" name=\"jobs[]\" value=\"");


            
            #line 105 "..\..\Dashboard\Pages\SucceededJobs.cshtml"
                                                                                                                 Write(job.Key);

            
            #line default
            #line hidden
WriteLiteral("\" />\r\n");


            
            #line 106 "..\..\Dashboard\Pages\SucceededJobs.cshtml"
                                        }

            
            #line default
            #line hidden
WriteLiteral("                                    </td>\r\n                                    <t" +
"d class=\"min-width\">\r\n                                        ");


            
            #line 109 "..\..\Dashboard\Pages\SucceededJobs.cshtml"
                                   Write(Html.JobIdLink(job.Key));

            
            #line default
            #line hidden
WriteLiteral("\r\n");


            
            #line 110 "..\..\Dashboard\Pages\SucceededJobs.cshtml"
                                         if (job.Value != null && !job.Value.InSucceededState)
                                        {

            
            #line default
            #line hidden
WriteLiteral("                                            <span title=\"");


            
            #line 112 "..\..\Dashboard\Pages\SucceededJobs.cshtml"
                                                    Write(Strings.Common_JobStateChanged_Text);

            
            #line default
            #line hidden
WriteLiteral("\" class=\"glyphicon glyphicon-question-sign\"></span>\r\n");


            
            #line 113 "..\..\Dashboard\Pages\SucceededJobs.cshtml"
                                        }

            
            #line default
            #line hidden
WriteLiteral("                                    </td>\r\n\r\n");


            
            #line 116 "..\..\Dashboard\Pages\SucceededJobs.cshtml"
                                     if (job.Value == null)
                                    {

            
            #line default
            #line hidden
WriteLiteral("                                        <td colspan=\"3\">\r\n                       " +
"                     <em>");


            
            #line 119 "..\..\Dashboard\Pages\SucceededJobs.cshtml"
                                           Write(Strings.Common_JobExpired);

            
            #line default
            #line hidden
WriteLiteral("</em>\r\n                                        </td>\r\n");


            
            #line 121 "..\..\Dashboard\Pages\SucceededJobs.cshtml"
                                    }
                                    else
                                    {

            
            #line default
            #line hidden
WriteLiteral("                                        <td>\r\n                                   " +
"         ");


            
            #line 125 "..\..\Dashboard\Pages\SucceededJobs.cshtml"
                                       Write(Html.JobNameLink(job.Key, job.Value.Job));

            
            #line default
            #line hidden
WriteLiteral("\r\n                                        </td>\r\n");



WriteLiteral("                                        <td class=\"min-width align-right\">\r\n");


            
            #line 128 "..\..\Dashboard\Pages\SucceededJobs.cshtml"
                                             if (job.Value.TotalDuration.HasValue)
                                            {
                                                
            
            #line default
            #line hidden
            
            #line 130 "..\..\Dashboard\Pages\SucceededJobs.cshtml"
                                           Write(Html.ToHumanDuration(TimeSpan.FromMilliseconds(job.Value.TotalDuration.Value), false));

            
            #line default
            #line hidden
            
            #line 130 "..\..\Dashboard\Pages\SucceededJobs.cshtml"
                                                                                                                                      
                                            }

            
            #line default
            #line hidden
WriteLiteral("                                        </td>\r\n");



WriteLiteral("                                        <td class=\"min-width align-right\">\r\n");


            
            #line 134 "..\..\Dashboard\Pages\SucceededJobs.cshtml"
                                             if (job.Value.SucceededAt.HasValue)
                                            {
                                                
            
            #line default
            #line hidden
            
            #line 136 "..\..\Dashboard\Pages\SucceededJobs.cshtml"
                                           Write(Html.RelativeTime(job.Value.SucceededAt.Value));

            
            #line default
            #line hidden
            
            #line 136 "..\..\Dashboard\Pages\SucceededJobs.cshtml"
                                                                                               
                                            }

            
            #line default
            #line hidden
WriteLiteral("                                        </td>\r\n");


            
            #line 139 "..\..\Dashboard\Pages\SucceededJobs.cshtml"
                                    }

            
            #line default
            #line hidden
WriteLiteral("                                </tr>\r\n");


            
            #line 141 "..\..\Dashboard\Pages\SucceededJobs.cshtml"
                            }

            
            #line default
            #line hidden
WriteLiteral("                        </tbody>\r\n                    </table>\r\n                <" +
"/div>\r\n\r\n                ");


            
            #line 146 "..\..\Dashboard\Pages\SucceededJobs.cshtml"
           Write(Html.Paginator(pager));

            
            #line default
            #line hidden
WriteLiteral("\r\n            </div>\r\n");


            
            #line 148 "..\..\Dashboard\Pages\SucceededJobs.cshtml"
        }

            
            #line default
            #line hidden
WriteLiteral("    </div>\r\n</div>");


        }
    }
}
#pragma warning restore 1591
