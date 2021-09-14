﻿namespace JamieMagee.Octokit.Webhooks.Models.StatusEvent
{
    using System.Text.Json.Serialization;

    public class CommitParent
    {
        [JsonPropertyName("sha")]
        public string Sha { get; init; } = null!;

        [JsonPropertyName("url")]
        public string Url { get; init; } = null!;

        [JsonPropertyName("html_url")]
        public string HtmlUrl { get; init; } = null!;
    }
}