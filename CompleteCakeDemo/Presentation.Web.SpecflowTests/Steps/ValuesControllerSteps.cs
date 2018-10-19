namespace Presentation.Web.SpecflowTests.Steps
{
    using NUnit.Framework;
    using Presentation.Web.SpecflowTests.Helpers;
    using RestSharp;
    using TechTalk.SpecFlow;

    [Binding]
    public sealed class ValuesControllerSteps
    {
        public const string BaseUri = "http://localhost:64355";
        public const string ResourceApi = "api/values";
        public const string KeyToSaveDataResponse = "ValuesDataResponse";

        [When(@"I retrieve list of all values")]
        public void WhenIRetrieveListOfAllValues()
        {
            var dataResponse = new RestClient(BaseUri).Execute<string[]>(new RestRequestSettings
            {
                Method = Method.GET,
                Resource = ResourceApi
            });
            ScenarioContext.Current.Add(KeyToSaveDataResponse, dataResponse);
        }

        [Then(@"I get a list with two values")]
        public void ThenIGetAListWithTwoValues()
        {
            var numberOfValues = 2;
            var dataResponse = ScenarioContext.Current.Get<string[]>(KeyToSaveDataResponse);

            Assert.AreEqual(numberOfValues, dataResponse.Length);
        }
    }
}
