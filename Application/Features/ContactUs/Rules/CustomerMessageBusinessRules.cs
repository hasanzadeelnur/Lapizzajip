//using Application.Features.ContactUs.Constants;
//using Core.Application.Rules;
//using Core.CrossCuttingConcerns.Exceptions.Types;
//using Microsoft.Extensions.Configuration;
//using Newtonsoft.Json;

//namespace Application.Features.ContactUs.Rules;
//public class CustomerMessageBusinessRules(IConfiguration _configuration) : BaseBusinessRules
//{
//    public async Task CheckReCaptchaAsync(string reCaptchaKey, string ipAddress, CancellationToken cancellationToken = default)
//    {
//        using HttpClient client = new()
//        {
//            BaseAddress = new("https://www.google.com/")
//        };

//        string reCaptchaServerKey = _configuration["ReCaptchaServerSide"]!;

//        Dictionary<string, string> parameters = new()
//        {
//                {"secret", reCaptchaServerKey},
//                {"response", reCaptchaKey},
//                {"remoteip", ipAddress }
//        };

//        using HttpContent formContent = new FormUrlEncodedContent(parameters);

//        var reCaptchaResult = await client.PostAsync("recaptcha/api/siteverify", formContent, cancellationToken: cancellationToken);

//        string reCaptchaResponseString = await reCaptchaResult.Content.ReadAsStringAsync(cancellationToken);

//        //var reCaptchaResponse = JsonConvert.DeserializeObject<ReCaptchaResponse>(reCaptchaResponseString);

//        client.Dispose();

//        if (reCaptchaResponse != null && !reCaptchaResponse.Success)
//            throw new BusinessException(CustomerMessageMessages.ReCaptchaIsNotValid);
//    }
//}
