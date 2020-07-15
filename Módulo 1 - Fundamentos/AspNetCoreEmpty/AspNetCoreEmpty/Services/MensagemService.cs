using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreEmpty.Services
{
    public class MensagemService : IMensagemService
    {
        public string GetMensagem()
        {
            return "Curso Maccoratti .Net - Eu sou aluno e me chamo Paulo";
        }
    }
}
