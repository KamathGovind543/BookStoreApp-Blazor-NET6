﻿using Blazored.LocalStorage;
using BookStoreApp.Blazor.Server.UI.Providers;

using BookStoteApp.Blazor.Server.UI.Services.Base;
using Microsoft.AspNetCore.Components.Authorization;

namespace BookStoreApp.Blazor.Server.UI.Services.Authentication
{
    public class AuthenticationService : IAuthenticationService
    {
        private readonly Client httpClient;
        private readonly ILocalStorageService localStorage;
        private readonly AuthenticationStateProvider authenticationStateProvider;

        public AuthenticationService(Client httpClient, ILocalStorageService localStorage, AuthenticationStateProvider authenticationStateProvider)
        {
            this.httpClient = httpClient;
            this.localStorage = localStorage;
            this.authenticationStateProvider = authenticationStateProvider;
        }

        public async Task<bool> AuthenticateAsync(UserLoginDto loginModel)
        {
            var response = await httpClient.LoginAsync(loginModel);

            //Store Token
            await localStorage.SetItemAsync("accessToken", response.Token);

            //Change auth state of app
            await ((ApiAuthenticationStateProvider)authenticationStateProvider).LoggedIn();

            return true;
        }

        public async Task Logout()
        {
            await ((ApiAuthenticationStateProvider)authenticationStateProvider).LoggedOut();
        }
    }

}
