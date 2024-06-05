﻿namespace Server.Controllers;

[ApiController]
[Route("api/common/book")]
public class BookController(
    IBookService bookService)
    : ControllerBase
{
    [HttpGet]
    public async Task<IActionResult> GetPaginatedBooksAsync(
        int pageNumber, int pageSize, string? searchTerms)
    {
        return Ok(await bookService.GetPaginatedBooksAsync(
            pageNumber, pageSize, searchTerms));
    }

    [HttpGet("{id:guid}")]
    public async Task<IActionResult> GetByIdAsync(Guid id)
    {
        return Ok(await bookService.GetByIdAsync(id));
    }
}