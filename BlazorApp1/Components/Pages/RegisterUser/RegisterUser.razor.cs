using BlazorApp1.Data.Models;
using BlazorApp1.Data.Services;
using Microsoft.AspNetCore.Components;



namespace BlazorApp1.Components.Pages.RegisterUser
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
            Console.WriteLine("Entro");

            if(response.Ok)
            {
                mensaje = "Usuario Registrado con Exito";
                claseMensaje = "alert alert-success";
            }
            else
            {
                mensaje = response.Message;
                claseMensaje = "alert alert-danger";
            }
            Clear();
            StateHasChanged();

        }

        public void Clear()
        {
            user.Password = "";
            user.UserName = "";
        }

    }
}
