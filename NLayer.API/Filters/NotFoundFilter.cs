﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using NLayer.Core.DTO_s;
using NLayer.Core.Models;
using NLayer.Core.Services;

namespace NLayer.API.Filters
{
    public class NotFoundFilter<T> : IAsyncActionFilter where T : BaseEntity
    {
        private readonly IService<T> service;

        public NotFoundFilter(IService<T> service)
        {
            this.service = service;
        }

        public async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            var idValue = context.ActionArguments.Values.FirstOrDefault();

            if (idValue == null)
            {
                await next.Invoke();
                return;
            }

            var id = (int)idValue;
            var anyEntity = await service.AnyAsync(x=>x.Id == id);

            if(anyEntity)
            {
                await next.Invoke();
                return;
            }
            else
            {
                context.Result = new NotFoundObjectResult(CustomResponseDTO<NoContentDTO>.Fail($"{typeof(T).Name}({id}) not found", 404));
            }
        }
    }
}
