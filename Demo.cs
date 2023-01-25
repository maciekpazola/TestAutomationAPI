using Newtonsoft.Json;
using RestSharp;
using TestAutomationAPI.DTO;

namespace TestAutomationAPI
{
    public class Demo
    {
        public ListOfUsersDTO GetUsers()
        {
            var restClient = new RestClient("https://reqres.in/");
            var restRequest = new RestRequest("/api/users?page=2", Method.Get);
            restRequest.AddHeader("Accept", "application/json");
            restRequest.RequestFormat = DataFormat.Json;

            RestResponse restResponse = restClient.Execute(restRequest);
            var content = restResponse.Content;

            var users = JsonConvert.DeserializeObject<ListOfUsersDTO>(content);
            return users;
        }
    }
}