using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationCore.Pages.PageHelper
{
    [HtmlTargetElement("pager", Attributes = "pageIndex, path")]
    public class PageTagHelper : TagHelper
    {
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "a";   //原生标签名

            //分别取出pageIndex和path的值
            object pageIndex = context.AllAttributes["pageIndex"].Value;
            //output.Attributes.Remove(context.AllAttributes["pageIndex"]);

            object path = context.AllAttributes["path"].Value;
            //output.Attributes.RemoveAll("path");

            //设置a标签里href的值
            output.Attributes.Add("href", $"{path}/Page-{pageIndex}");

            base.Process(context, output);
            
        }
    }
}
