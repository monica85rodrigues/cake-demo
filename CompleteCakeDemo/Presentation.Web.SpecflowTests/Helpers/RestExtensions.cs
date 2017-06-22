namespace Presentation.Web.SpecflowTests.Helpers
{
    using Newtonsoft.Json;
    using RestSharp;

    public static class RestExtensions
    {
        public static IRestResponse Execute(this RestClient client, RestRequestSettings settings)
        {
            var restRequest = new RestRequest();
            restRequest.Method = settings.Method;
            restRequest.Resource = settings.Resource;

            //TODO: add more settings such as: parameters, headers and other things
            
            return client.Execute(restRequest);
        }

        public static T Execute<T>(this RestClient client, RestRequestSettings settings)
        {
            var restResponse = client.Execute(settings);
            var data = JsonConvert.DeserializeObject<T>(restResponse.Content);
            return data;
        }
    }
}
