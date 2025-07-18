using DynamicFormsApp.Shared.Models;
using DynamicFormsApp.Shared.Services;
using System.Net.Http.Json;

namespace DynamicFormsApp.Client.Services
{
    public class UserServiceProxy : IUserService
    {
        private readonly HttpClient _httpClient;

        public UserServiceProxy(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<bool> ValidateUser(UserModel user)
        {
            var response = await _httpClient.PostAsJsonAsync("api/user", user);
            return await response.Content.ReadFromJsonAsync<bool>();
        }

        public async Task<UserModel?> GetUserData(string userName)
        {
            try
            {
                return await _httpClient.GetFromJsonAsync<UserModel>($"api/user/{userName}");
            }
            catch (HttpRequestException ex) when (ex.StatusCode == System.Net.HttpStatusCode.NotFound)
            {
                return null;
            }
        }

        public async Task<List<UserModel>> GetAllUsers()
        {
            return await _httpClient.GetFromJsonAsync<List<UserModel>>("api/user/list");
        }

        public async Task<List<UserModel>> SearchUsers(string term)
        {
            var encoded = System.Net.WebUtility.UrlEncode(term);
            return await _httpClient.GetFromJsonAsync<List<UserModel>>($"api/user/search?term={encoded}");
        }
    }
}
