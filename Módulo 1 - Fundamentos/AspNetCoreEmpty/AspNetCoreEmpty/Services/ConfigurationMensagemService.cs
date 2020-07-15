using Microsoft.Extensions.Configuration;
using System;

namespace AspNetCoreEmpty.Services
{
    public class ConfigurationMensagemService : IConfigurationMensagem
    {
        // Estamos criando nossa injeção de dependência atráves do construtor
        private IConfiguration _config;
        public ConfigurationMensagemService(IConfiguration config)
        {
            _config = config;
        }
        public string GetConfigMensagem()
        {
            // Configuramos na Startup que o _config acessa as informações do nosso arquivo
            // appsettings.json, aqui vou retornar o valor do atributo/name/chave "Mensagem"
            return _config["Mensagem"];
        }
    }
}
