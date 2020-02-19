using bootstrapsite.Models.Regions;
using Piranha.AttributeBuilder;
using Piranha.Extend;
using Piranha.Models;
using System.Collections.Generic;

namespace bootstrapsite.Models
{
    [PageType(Title = "Start page")]
    [PageTypeRoute(Title = "Default", Route = "/start")]
    public class StartPage : Page<StartPage>
    {
        public StartPage()
        {
            Hero.PrimaryImage = "";
        }
        /// <summary>
        /// Gets/sets the page hero.
        /// </summary>
        [Region(Display = RegionDisplayMode.Setting)]
        public Hero Hero { get; set; }

        /// <summary>
        /// Gets/sets the available teasers.
        /// </summary>
        [Region(ListTitle = "Title")]
        public IList<Teaser> Teasers { get; set; }

        /// <summary>
        /// Default constructor.
        /// </summary>
        public StartPage() {
            Teasers = new List<Teaser>();
        }
    }
}