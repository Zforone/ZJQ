using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationCore.Pages.TagHelpers
{
    [HtmlTargetElement("datetime", Attributes = "asp-showicon,asp-only")]
    public class DateTimeTagHelper : TagHelper
    {
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "small";   //原生标签名
            output.Content.Clear();
            
            //分别取出pageIndex和path的值
            object showicon = context.AllAttributes["asp-showicon"].Value;
            //output.Attributes.Remove(context.AllAttributes["asp-showicon"]);

            object only = context.AllAttributes["asp-only"].Value;
            //output.Attributes.RemoveAll("path");
            if (showicon.ToString() == "true")
            {
                string str = "glyphicon-calendar";
                output.PreContent.SetHtmlContent($"< span class={str}>" + "</span>");
            }
            if (only.ToString() == "date")
            {
                output.Content.Append(DateTime.Now.ToString("yyyy年MM月dd日"));
            }
            else
            {
                output.Content.Append(DateTime.Now.ToString("yyyy年MM月dd日 HH点mm分"));

            }
            base.Process(context, output);


        }
    }
}
