using System.Web;
using System.ComponentModel.DataAnnotations;
using GitHubDemo_2.Models.Pages;
using EPiServer.Web;
using EPiServer.Core;

namespace GitHubDemo_2.Models.ViewModels
{
    public class ContactBlockModel
    {
        [UIHint(UIHint.Image)]
        public ContentReference Image { get; set; }
        public string Heading { get; set; }
        public string LinkText { get; set; }
        public IHtmlString LinkUrl { get; set; }
        public bool ShowLink { get; set; }
        public ContactPage ContactPage { get; set; }
    }
}
