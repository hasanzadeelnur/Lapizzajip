using Application.Features.AboutUs.Queries.GetData;
using Application.Features.ContactUs.Commands.SendMessage;
using Application.Features.ContactUs.Queries.GetData;
using Application.Features.Services.Queries.GetList;
using Application.Features.Settings.Queries.GetList;
using Application.Features.Sliders.Queries.GetList;
using Application.Features.TextTranslations.Queries.GetList;
using Infrastructure.Dtos.Messages;
using Infrastructure.Libs;
using Mapster;
using MediatR;
using Microsoft.Extensions.Caching.Memory;
using System.Globalization;

namespace ClientApp.Repositories;

public interface IGeneralRepository
{
    void RemoveCache();
    Task<List<GetListSliderDto>> GetSliders();
    Task<List<GetListServiceResponse>> GetServices();
    Task<GetAboutUsResponse> GetAboutUs();
    Task<GetContactUsResponse> GetContactUs();
    Task<SendedMessageResponse> CreateCustomerMessage(CreateMessageDto request);
    Task<Dictionary<string, string>> GetTranslations();
    Task<Dictionary<string, string>> GetSettings();
}

public class GeneralRepository(IMediator _mediator, IHttpContextAccessor httpContextAccessor, IMyCache cache) : IGeneralRepository
{
    private readonly IHttpContextAccessor _httpContextAccessor = httpContextAccessor;
    private readonly IMyCache _cache = cache;
    private readonly string _culture = CultureInfo.CurrentCulture.Name;

    public void RemoveCache()
    {
        _cache.Clear();
    }

    public async Task<List<GetListSliderDto>> GetSliders()
    {
        bool result = _cache.TryGetValue($"{nameof(GetSliders)}_{_culture}", out List<GetListSliderDto>? sliders);
        if (!result)
        {
            sliders = await _mediator.Send(new GetListSliderQuery());
            _cache.Set($"{nameof(GetSliders)}_{_culture}", sliders);
        }
        return sliders ?? [];
    }

    public async Task<GetAboutUsResponse> GetAboutUs()
    {
        bool result = _cache.TryGetValue($"{nameof(GetAboutUs)}_{_culture}", out GetAboutUsResponse? response);
        if (!result)
        {
            response = await _mediator.Send(new GetAboutUsQuery());
            _cache.Set($"{nameof(GetAboutUs)}_{_culture}", response);
        }
        return response ?? new();
    }

    public async Task<GetContactUsResponse> GetContactUs()
    {
        bool result = _cache.TryGetValue($"{nameof(GetContactUs)}_{_culture}", out GetContactUsResponse? response);
        if (!result)
        {
            response = await _mediator.Send(new GetContactUsQuery());
            _cache.Set($"{nameof(GetContactUs)}_{_culture}", response);
        }
        return response ?? new();
    }

    public async Task<SendedMessageResponse> CreateCustomerMessage(CreateMessageDto request)
    {
        SendMessageCommand sendMessageCommand = request.Adapt<SendMessageCommand>();
        SendedMessageResponse response = await _mediator.Send(sendMessageCommand);
        return response;
    }
    public async Task<Dictionary<string, string>> GetTranslations()
    {
        bool result = _cache.TryGetValue($"{nameof(GetTranslations)}_{_culture}", out Dictionary<string, string>? translations);
        if (!result)
        {
            var response = await _mediator.Send(new GetListTextTranslationQuery());
            translations = response ?? [];
            _cache.Set($"{nameof(GetTranslations)}_{_culture}", translations);
        }
        return translations ?? [];
    }

    public async Task<Dictionary<string, string>> GetSettings()
    {
        bool result = _cache.TryGetValue($"{nameof(GetSettings)}_{_culture}", out Dictionary<string, string>? translations);
        if (!result)
        {
            var response = await _mediator.Send(new GetListSettingQuery());
            translations = response ?? [];
            _cache.Set($"{nameof(GetSettings)}_{_culture}", translations);
        }
        return translations ?? [];
    }

    public async Task<List<GetListServiceResponse>> GetServices()
    {
        bool result = _cache.TryGetValue($"{nameof(GetServices)}_{_culture}", out List<GetListServiceResponse>? services);
        if (!result)
        {
            services = await _mediator.Send(new GetListServiceQuery());
            _cache.Set($"{nameof(GetServices)}_{_culture}", services);
        }
        return services ?? [];
    }
}