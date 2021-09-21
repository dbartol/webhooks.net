﻿namespace Octokit.Webhooks.Events
{
    using System.Text.Json.Serialization;
    using Octokit.Webhooks.Converter;
    using Octokit.Webhooks.Models;
    using JetBrains.Annotations;

    [PublicAPI]
    [WebhookEventType(WebhookEventType.Issues)]
    [JsonConverter(typeof(WebhookConverter<IssuesEvent>))]
    public abstract record IssuesEvent : WebhookEvent
    {
        [JsonPropertyName("issue")]
        public Issue Issue { get; init; }
    }
}