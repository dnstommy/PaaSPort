﻿namespace TheInjectables.Foundation.PaaSPort.Azure.Service.Authentication
{
    public interface IAzureCredential
    {
        string TenantId { get; set; }
        string ClientId { get; set; }
        string SubscriptionId { get; set; }
        string Key { get; set; }
    }
}
