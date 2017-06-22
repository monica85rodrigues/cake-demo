namespace Presentation.Web.SpecflowTests.Helpers
{
    using RestSharp;
    public class RestRequestSettings
    {
        public Method Method { get; set; }
        public string Resource { get; set; }
    }
}