using Blazored.SessionStorage;
using Microsoft.AspNetCore.Components.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Tarea9_10.Data
{
    public class Authorize:AuthenticationStateProvider
    {
        private ISessionStorageService _sessionStorage;
        public Authorize(ISessionStorageService sessionStorage)
        {
            _sessionStorage = sessionStorage;
        }

        public override async Task<AuthenticationState> GetAuthenticationStateAsync()
        {
            ClaimsIdentity identity;
            var correo = await _sessionStorage.GetItemAsync<string>("correo");

            if (correo != null)
            {

                identity = new ClaimsIdentity(new[]
                {
                    new Claim(ClaimTypes.Name, correo),
                }, "api");
            }
            else
            {
                identity = new ClaimsIdentity();
            }


            var user = new ClaimsPrincipal(identity);

            return await Task.FromResult(new AuthenticationState(user));
        }

        public void Logeado(string correo)
        {
            var identity = new ClaimsIdentity(new[]
            {
                new Claim(ClaimTypes.Name, correo),
            }, "api");


            var user = new ClaimsPrincipal(identity);

            NotifyAuthenticationStateChanged(Task.FromResult(new AuthenticationState(user)));
        }

        public void Deslogueado()
        {
            _sessionStorage.RemoveItemAsync("correo");

            var identity = new ClaimsIdentity();

            var user = new ClaimsPrincipal(identity);

            NotifyAuthenticationStateChanged(Task.FromResult(new AuthenticationState(user)));
        }
    }

}

