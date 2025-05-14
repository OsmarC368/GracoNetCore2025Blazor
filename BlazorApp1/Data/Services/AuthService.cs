using BlazorApp1.Data.Models;
using Core.Entities;
using Data.Models;
namespace BlazorApp1.Data.Services
{
    public class AuthService
    {
        const string url = "User";
        public async Task<Response<string>> Login(UserDTO usuario)
        {
            Response<string> response = new Response<string>();

            try
            {
                response = await
                    Consumer
                    .Execute<string, UserDTO>(
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
                response.Message = ex.Message;
            }
            return response;
        }

        public async Task<Response<User>> UpdateUser(UserDTO updatedUser, string token)
        {
             Response<User> response = new Response<User>();

            try
            {
                response = (await
                    Consumer
                    .Execute<User, UserDTO>(
                        url,
                        methodHttp.PUT,
                        updatedUser,
                        token)
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
