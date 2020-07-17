using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using AspNetCoreEmpty.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.FileProviders;

namespace AspNetCoreEmpty
{
    public class Startup
    {
        public IConfiguration _config { get; set; }

        public Startup(IHostingEnvironment env)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json");

            _config = builder.Build();

        }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            // Configurando minha injeção de dependência.
            services.AddSingleton<IMensagemService, MensagemService>();

            // Vamos configurar uma nova injteção para o arquivo ConfigurationMensagemService
            services.AddSingleton(provider => _config); // Estamos preparando nossa injeção para adicionar o servico _config na nossa instância.
            services.AddSingleton<IConfigurationMensagem, ConfigurationMensagemService>(); // Estamos apontando qual interface e instância queremos.
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, IMensagemService msg, IConfigurationMensagem cfgMsg)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseStaticFiles(new StaticFileOptions() 
            {
                FileProvider = new PhysicalFileProvider(Path.Combine(Directory.GetCurrentDirectory(), @"Arquivos")),
                RequestPath = new PathString("/Arquivos")
            });

            app.Run(async (context) =>
            {
                //await context.Response.WriteAsync($"{_config["Mensagem"]}, {_config["ConnectionStrings:DefaultConnection"]}");
                await context.Response.WriteAsync(msg.GetMensagem());
                await context.Response.WriteAsync(cfgMsg.GetConfigMensagem());
            });
        }
    }
}
