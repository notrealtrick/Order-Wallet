﻿namespace WalletService.API.Services.Identity
{
    public interface IIdentityService
    {
        string GetUserIdentity();
        string GetUserName();
        string GetUserRoomName();
    }
}
