using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorApp1.Data.Models;
using Core.Entities;

namespace BlazorApp1.Components.Pages.UpdateUser
{
    public partial class UpdateUser
    {
        public UserDTO user { get; set; } = new();
        public string mensaje { get; set; } = string.Empty;
        public string claseMensaje { get; set; } = string.Empty;

        public async void Update()
        {

        }

        public void Clear()
        {

        }
    }
}