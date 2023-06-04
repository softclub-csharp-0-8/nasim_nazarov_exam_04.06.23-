using Domain.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers;
using System.Data;

using Infrastructure.Services;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("[controller]")]

public class QuoteImageController
{
    private readonly IWebHostEnvironment _webHostEnvironment;
    private readonly QuoteImagesService _quoteImagesService;

    public QuoteImageController(IWebHostEnvironment webHostEnvironment, QuoteImagesService quoteImagesService)
    {
        _webHostEnvironment = webHostEnvironment;
        _quoteImagesService = quoteImagesService;
    }

    [HttpGet("Get")]
    public async Task<List<GetQuoteImageDto>> GetQuoteImageAsync()
    {
        return await _quoteImagesService.GetQuoteImageAsync();
    }

    [HttpPost("Add")]
    public async Task<GetQuoteImageDto> AddQuoteImageAsync(AddQuoteImageDto quoteImageDto)
    {
        return await _quoteImagesService.AddQuoteImageAsync(quoteImageDto);
    }

}