using BlazorApp1.Data.Models;
using BlazorApp1.Data.Services;
using Microsoft.AspNetCore.Components;



namespace BlazorApp1.Components.RegisterUser
{
    public partial class RegisterUser
    {
        public UserDTO user = new();
        [Inject]
        public AuthService service { get; set; }

        public string mensaje { get; set; } = string.Empty;
        public string claseMensaje { get; set; } = string.Empty;

        public async void Register()
        {
            var response = await service.Register(user);

            if(response.Ok)
            {
                mensaje = response.Message;
                claseMensaje = "alert alert-success";
            }
            else
            {
                mensaje = response.Message;
                claseMensaje = "alert alert-danger";
            }

        }

        public void Clear()
        {
            user.Password = "";
            user.UserName = "";
        }

    }
}
