using bootstrapsite.Models.Regions;
using Piranha.AttributeBuilder;
using Piranha.Extend;
using Piranha.Models;

namespace bootstrapsite.Models
{
    [PostType(Title = "Blog post")]
    public class BlogPost  : Post<BlogPost>
    {
        /// <summary>
        /// Gets/sets the post hero.
        /// </summary>
        [Region(Display = RegionDisplayMode.Setting)]
        public Hero Hero { get; set; }
    }
}