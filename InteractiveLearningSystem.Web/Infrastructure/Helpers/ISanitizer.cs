namespace InteractiveLearningSystem.Web.Infrastructure.Helpers
{
    public interface ISanitizer
    {
        string Sanitize(string html);
    }
}