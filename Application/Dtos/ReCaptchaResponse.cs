using Newtonsoft.Json;

namespace Application.Dtos;

public class ReCaptchaResponse
{
    [JsonProperty("success")]
    public bool Success { get; set; }
    [JsonProperty("challenge_ts")]
    public DateTime ChallengeTs { get; set; }
    [JsonProperty("hostname")]
    public string Hostname { get; set; }
    [JsonProperty("error-codes")]
    public List<string> ErrorCodes { get; set; }

    public ReCaptchaResponse()
    {
        Hostname = string.Empty;
        ErrorCodes = [];
    }

    public ReCaptchaResponse(bool success, DateTime challengeTs, string hostname, List<string> errorCodes)
    {
        Success = success;
        ChallengeTs = challengeTs;
        Hostname = hostname;
        ErrorCodes = errorCodes;
    }
}