using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreTagHelpersExamples.Infrastructure.TagHelpers
{
    public class ButtonTagHelper:TagHelper
    {
        //bs-button-color
        public string BsButtonColor { get; set; } 
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.Attributes.SetAttribute("class", $"btn btn-{BsButtonColor}");
        }
    }
}
