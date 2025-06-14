﻿namespace Caliber_Components.Authentication.APIKey
{
    public static class ApiKey
    {
        public static ApiKeyModel Apikeys { get; set; } = new();

        public static string Path { get; set; } = "";
        public static int ErrFlag { get; set; } = 0;

        public static void SetApiKeys(ApiKeyModel apikey)
        {
            Apikeys = apikey;
        }
    }
    public class ApiKeyModel
    {
        public string ApiKey { get; set; } = "";
        public string Keyvalue { get; set; } = "";
    }
}
