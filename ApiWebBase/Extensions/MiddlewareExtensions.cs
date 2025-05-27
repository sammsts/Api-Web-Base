﻿using ApiWebBase.Middleware;

namespace ApiWebBase.Extensions
{
    public static class MiddlewareExtensions
    {
        public static IApplicationBuilder UseAuditMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<AuditMiddleware>();
        }
    }
}
