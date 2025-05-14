using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorApp1.Data.Models;
using Core.Entities;
using BlazorApp1.Data.Services;
using Microsoft.AspNetCore.Components;

namespace BlazorApp1.Components.Pages.UpdateUser
{
    public partial class UpdateUser
    {
        [Inject]
        NavigationManager NavigationManager { get; set; }
        [Inject]
        TokenContainer tokenContainer { get; set; }
        public UserDTO user { get; set; } = new();
        public string mensaje { get; set; } = string.Empty;
        public string claseMensaje { get; set; } = string.Empty;    
        [Inject]
        public AuthService service { get; set; }

        public async void Update()
        {
            var response = await service.UpdateUser(user, tokenContainer.token);

            if(response.Ok)
            {
                mensaje = "Usuario Actualizado con Exito";
                claseMensaje = "alert alert-success";
            }
            else
            {
                mensaje = response.Message;
                claseMensaje = "alert alert-success";
            }
            Clear();
            StateHasChanged();
        }

        public void Clear()
        {
            user.UserName = string.Empty;
            user.Password = string.Empty;
        }

        public void Logout()
        {
            tokenContainer.Clear();
            NavigationManager.NavigateTo("/");
        }
    }
}