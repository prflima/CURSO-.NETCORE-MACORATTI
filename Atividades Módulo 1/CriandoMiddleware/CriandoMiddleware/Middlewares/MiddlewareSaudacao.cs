using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;

namespace CriandoMiddleware.Middlewares
{
    public class MiddlewareSaudacao
    {
        private readonly RequestDelegate _next;

        public MiddlewareSaudacao(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext context)
        {
                _ = context.Response.StatusCode == 400;           
                if (!context.Request.Path.Equals("/saudacoes", StringComparison.Ordinal))
                {
                    await context.Response.WriteAsync("Caminho da requisição inválida");
                }

                if (!context.Request.Method.Equals("GET"))
                {
                    await context.Response.WriteAsync($"{context.Request.Method} Método não suportado");
                }

                if (!context.Request.Query.Any() || string.IsNullOrEmpty(context.Request.Query["nomes"]))
                {
                    await context.Response.WriteAsync("A consulta esta vazia ou inválida");
                }

                _ = context.Response.StatusCode == 200;
                var nomes = context.Request.Query["nomes"].ToString().Split(',').ToList();
                var sb = new StringBuilder();

                nomes.ForEach(n => sb.Append($"Olá {n}{Environment.NewLine}"));

                await context.Response.WriteAsync(sb.ToString());

                return;
        }
    }
}
