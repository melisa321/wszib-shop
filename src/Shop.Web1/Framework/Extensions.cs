using Microsoft.AspNetCore.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Web1.Framework
{
    public static class Extensions
    {
        public static IApplicationBuilder UseMyMiddleware(this IApplicationBuilder builder)
            => builder.UseMiddleware<MyMiddleware>();
    }
}
