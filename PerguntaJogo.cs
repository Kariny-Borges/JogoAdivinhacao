using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoAdivinhacao
{
    public class PerguntaJogo
    {
        public PerguntaJogo() 
        {
            this.Pergunta = "";
            this.Resposta = "";
        }

        public PerguntaJogo(String pergunta, String resposta)
        {
            this.Pergunta = pergunta;
            this.Resposta = resposta;
        }

        public string Pergunta { get; set; }
        public string Resposta { get; set; }
    }
}
