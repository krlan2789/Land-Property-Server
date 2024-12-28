using System;
using Microsoft.AspNetCore.Antiforgery;

namespace Land_Property.API.Middleware;

public class AntiForgeryMiddleware
{
    private readonly RequestDelegate _next;
    private readonly IAntiforgery _antiforgery;

    public AntiForgeryMiddleware(RequestDelegate next, IAntiforgery antiforgery)
    {
        _next = next;
        _antiforgery = antiforgery;
    }

    public async Task Invoke(HttpContext context)
    {
        try
        {
            if (string.Equals(context.Request.Method, "GET", StringComparison.OrdinalIgnoreCase))
            {
                var tokens = _antiforgery.GetAndStoreTokens(context);
                context.Response.Cookies.Append("XSRF-TOKEN", "" + tokens.RequestToken, new CookieOptions
                {
                    HttpOnly = false
                });
            }

            await _next(context);
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
}
