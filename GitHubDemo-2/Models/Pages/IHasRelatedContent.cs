using EPiServer.Core;

namespace GitHubDemo_2.Models.Pages
{
    public interface IHasRelatedContent
    {
        ContentArea RelatedContentArea { get; }
    }
}
