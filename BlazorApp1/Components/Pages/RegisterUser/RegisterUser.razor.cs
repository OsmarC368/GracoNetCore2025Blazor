using BlazorApp1.Data.Models;
using BlazorApp1.Data.Services;
using Microsoft.AspNetCore.Components;



namespace BlazorApp1.Components.Pages.RegisterUser
{
    public partial class RegisterUser
    {
        public UserDTO user = new();
        [Inject]
        public AuthService? service { get; set; }
    
        public string mensaje { get; set; } = string.Empty;
        public string claseMensaje { get; set; } = string.Empty;


        public async void Register()
        {
            if(user.UserName.Length < 4 && user.Password.Length < 4)
        {
            //como deberia manejar esto?, ver la clase otra vez
            mensaje = "Los Campos son Requeridos";
            claseMensaje = "alert alert-danger";
            return;
        }

            var response = await service.Register(user);

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
