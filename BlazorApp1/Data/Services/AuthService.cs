using BlazorApp1.Data.Models;
using Core.Entities;
using Data.Models;
namespace BlazorApp1.Data.Services
{
    public class AuthService
    {
        const string url = "User";
        public async Task<Response<string>> Login(User usuario)
        {
            Response<string> response = new Response<string>();

            try
            {
                response = await
                    Consumer
                    .Execute<string, User>(
                        $"{url}/Login",
                        methodHttp.POST,
                        usuario)
                    ;

                return response;
            }
            catch (Exception ex)
            {
            }
            return response;
        }

        public async Task<Response<User>> Register(UserDTO user)
        {
            Response<User> response = new Response<User>();

            try
            {
                response = await
                    Consumer
                    .Execute<User, UserDTO>(
                        url,
                        methodHttp.POST,
                        user
                    );
            }
            catch (Exception ex)
            {
                
            }
            return response;
        }

        public async Task<Response<User>> UpdateUser(UserDTO updatedUser)
        {
             Response<User> response = new Response<User>();

            try
            {
                response = (await
                    Consumer
                    .Execute<User, UserDTO>(
                        url,
                        methodHttp.PUT,
                        updatedUser)
                    );

                return response;
            }
            catch (Exception ex)
            {

            }
            return response;
        }
        
    }
}
