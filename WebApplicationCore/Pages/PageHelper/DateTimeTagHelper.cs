using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationCore.Pages.PageHelper
{
    [HtmlTargetElement("datetime", Attributes = "asp-showicon, asp-only")]
    public class DateTimeTagHelper : TagHelper
    {
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "small";   //原生标签名
            
            //分别取出pageIndex和path的值
            object showicon = context.AllAttributes["asp-showicon"].Value;
            //output.Attributes.Remove(context.AllAttributes["pageIndex"]);

            object only = context.AllAttributes["asp-only"].Value;
            //output.Attributes.RemoveAll("path");

            
            //output.Attributes.Add("href", $"{only}/Page-{showicon}");
            base.Process(context, output);
        }
    }
}
