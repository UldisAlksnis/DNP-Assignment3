using Assignment1.Models.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace Assignment1.Data.Authorization.Impl
{
    public class CloudUserService : IUserService
    {
        private string uri1 = "https://localhost:44350/api";
        private string uri = "http://dnp.metamate.me";
        private readonly HttpClient client;

        public CloudUserService()
        {
            client = new HttpClient();
        }
        async Task<User> IUserService.ValidateUser(string userName, string passWord)
        {
            Task<string> stringAsync = client.GetStringAsync(uri1 + $"/Users/{userName}");
            string message = await stringAsync;
            User result = JsonSerializer.Deserialize<User>(message);
            if (!result.UserName.Equals(userName)){
                throw new Exception("User not found");
            }

            if (!result.Password.Equals(passWord))
            {
                throw new Exception("Incorrect password");
            }
            return result;
        }
    }
}
