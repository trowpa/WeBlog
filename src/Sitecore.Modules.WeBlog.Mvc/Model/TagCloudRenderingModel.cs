using System.Collections.Generic;

namespace Sitecore.Modules.WeBlog.Mvc.Model
{
    public class TagCloudRenderingModel
    {
        public string[] SortNames { get; set; }
        public IEnumerable<TagRenderingModel> Tags { get; set; }
    }
}