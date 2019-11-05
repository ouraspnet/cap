﻿using DotNetCore.CAP.Messages;

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

namespace DotNetCore.CAP.Dashboard.Pages
{

#line 2 "..\..\HomePage.cshtml"
    using System;

#line default
#line hidden

#line 3 "..\..\HomePage.cshtml"
    using System.Collections.Generic;

#line default
#line hidden
    using System.Linq;
    using System.Text;

#line 5 "..\..\HomePage.cshtml"
    using DotNetCore.CAP.Dashboard;

#line default
#line hidden

#line 6 "..\..\HomePage.cshtml"
    using DotNetCore.CAP.Dashboard.Pages;

#line default
#line hidden

#line 7 "..\..\HomePage.cshtml"
    using DotNetCore.CAP.Dashboard.Resources;

#line default
#line hidden

#line 4 "..\..\HomePage.cshtml"
#line default
#line hidden

#line 8 "..\..\HomePage.cshtml"
    using Newtonsoft.Json;

#line default
#line hidden

    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    internal partial class HomePage : RazorPage
    {
#line hidden

        protected override void Execute()
        {


            WriteLiteral("\r\n");











#line 10 "..\..\HomePage.cshtml"

            Layout = new LayoutPage(Strings.HomePage_Title);

            var monitor = Storage.GetMonitoringApi();
            IDictionary<DateTime, int> publishedSucceeded = monitor.HourlySucceededJobs(MessageType.Publish);
            IDictionary<DateTime, int> publishedFailed = monitor.HourlyFailedJobs(MessageType.Publish);

            IDictionary<DateTime, int> receivedSucceeded = monitor.HourlySucceededJobs(MessageType.Subscribe);
            IDictionary<DateTime, int> receivedFailed = monitor.HourlyFailedJobs(MessageType.Subscribe);



#line default
#line hidden
            WriteLiteral("\r\n<div class=\"row\">\r\n    <div class=\"col-md-12\">\r\n        <h1 class=\"page-header\"" +
            ">");



#line 23 "..\..\HomePage.cshtml"
            Write(Strings.HomePage_Title);


#line default
#line hidden
            WriteLiteral("</h1>\r\n");



#line 24 "..\..\HomePage.cshtml"
            if (Metrics.Count > 0)
            {


#line default
#line hidden
                WriteLiteral("            <div class=\"row\">\r\n");



#line 27 "..\..\HomePage.cshtml"
                foreach (var metric in Metrics)
                {


#line default
#line hidden
                    WriteLiteral("                    <div class=\"col-md-2\">\r\n                        ");



#line 30 "..\..\HomePage.cshtml"
                    Write(Html.BlockMetric(metric));


#line default
#line hidden
                    WriteLiteral("\r\n                    </div>\r\n");



#line 32 "..\..\HomePage.cshtml"
                }


#line default
#line hidden
                WriteLiteral("            </div>\r\n");



#line 34 "..\..\HomePage.cshtml"
            }


#line default
#line hidden
            WriteLiteral("        <h3>");



#line 35 "..\..\HomePage.cshtml"
            Write(Strings.HomePage_RealtimeGraph);


#line default
#line hidden
            WriteLiteral("</h3>\r\n        <div id=\"realtimeGraph\"\r\n             data-published-succeeded=\"");



#line 37 "..\..\HomePage.cshtml"
            Write(Statistics.PublishedSucceeded);


#line default
#line hidden
            WriteLiteral("\"\r\n             data-published-failed=\"");



#line 38 "..\..\HomePage.cshtml"
            Write(Statistics.PublishedFailed);


#line default
#line hidden
            WriteLiteral("\"\r\n             data-published-succeeded-string=\"");



#line 39 "..\..\HomePage.cshtml"
            Write(Strings.HomePage_GraphHover_PSucceeded);


#line default
#line hidden
            WriteLiteral("\"\r\n             data-published-failed-string=\"");



#line 40 "..\..\HomePage.cshtml"
            Write(Strings.HomePage_GraphHover_PFailed);


#line default
#line hidden
            WriteLiteral("\"\r\n             data-received-succeeded=\"");



#line 41 "..\..\HomePage.cshtml"
            Write(Statistics.ReceivedSucceeded);


#line default
#line hidden
            WriteLiteral("\"\r\n             data-received-failed=\"");



#line 42 "..\..\HomePage.cshtml"
            Write(Statistics.ReceivedFailed);


#line default
#line hidden
            WriteLiteral("\"\r\n             data-received-succeeded-string=\"");



#line 43 "..\..\HomePage.cshtml"
            Write(Strings.HomePage_GraphHover_RSucceeded);


#line default
#line hidden
            WriteLiteral("\"\r\n             data-received-failed-string=\"");



#line 44 "..\..\HomePage.cshtml"
            Write(Strings.HomePage_GraphHover_RFailed);


#line default
#line hidden
            WriteLiteral(@"""></div>
        <div style=""display: none;"">
            <span data-metric=""published_succeeded:count""></span>
            <span data-metric=""published_failed:count""></span>
            <span data-metric=""received_succeeded:count""></span>
            <span data-metric=""received_failed:count""></span>
        </div>
        <div id=""legend""></div>
        <h3>
            ");



#line 53 "..\..\HomePage.cshtml"
            Write(Strings.HomePage_HistoryGraph);


#line default
#line hidden
            WriteLiteral("\r\n        </h3>\r\n\r\n        <div id=\"historyGraph\"\r\n             data-published-su" +
            "cceeded=\"");



#line 57 "..\..\HomePage.cshtml"
            Write(JsonConvert.SerializeObject(publishedSucceeded));


#line default
#line hidden
            WriteLiteral("\"\r\n             data-published-failed=\"");



#line 58 "..\..\HomePage.cshtml"
            Write(JsonConvert.SerializeObject(publishedFailed));


#line default
#line hidden
            WriteLiteral("\"\r\n             data-published-succeeded-string=\"");



#line 59 "..\..\HomePage.cshtml"
            Write(Strings.HomePage_GraphHover_PSucceeded);


#line default
#line hidden
            WriteLiteral("\"\r\n             data-published-failed-string=\"");



#line 60 "..\..\HomePage.cshtml"
            Write(Strings.HomePage_GraphHover_PFailed);


#line default
#line hidden
            WriteLiteral("\"\r\n             data-received-succeeded=\"");



#line 61 "..\..\HomePage.cshtml"
            Write(JsonConvert.SerializeObject(receivedSucceeded));


#line default
#line hidden
            WriteLiteral("\"\r\n             data-received-failed=\"");



#line 62 "..\..\HomePage.cshtml"
            Write(JsonConvert.SerializeObject(receivedFailed));


#line default
#line hidden
            WriteLiteral("\"\r\n             data-received-succeeded-string=\"");



#line 63 "..\..\HomePage.cshtml"
            Write(Strings.HomePage_GraphHover_RSucceeded);


#line default
#line hidden
            WriteLiteral("\"\r\n             data-received-failed-string=\"");



#line 64 "..\..\HomePage.cshtml"
            Write(Strings.HomePage_GraphHover_RFailed);


#line default
#line hidden
            WriteLiteral("\">\r\n        </div>\r\n    </div>\r\n</div>");


        }
    }
}
#pragma warning restore 1591