// See https://aka.ms/new-console-template for more information

using System.Numerics;

namespace JogoAdivinhacao
{
    class Program
    {

        static void Main(string[] args)
        {
            // Lista de perguntas
            List<NovaPergunta> perguntas;
            perguntas = CriarPerguntas();
            //Pergunta que será exibida para o usuário
            Random r = new Random(); // objetivo pegar um valor aleatório
            int pos = r.Next(0, perguntas.Count); // posição da pergunta e recebe um método next pega um valor notório inicial e final
            // Count vou obter o total de perguntas
            NovaPergunta pergunta = perguntas[pos];
            // Lógica da resposta
            int tentativas = 0;
            Boolean flag = false; //quer dizer que não acertou 
            String resposta = "";                        // outra variável para resposta
            while (tentativas < 3 && flag == false) // enquanto número de tentativas for menor que 3 pode tentar e flag for igual a false, se acertar sai do laço, se acabar as tentativas também sai do laço
            {
                Console.WriteLine("Pergunta: " + pergunta.Pergunta);  // mostrar pergunta para o usuário (pergunta - objeto, pergunta - propriedade)
                Console.Write("Resposta: ");
                resposta = Console.ReadLine();
                if (resposta == pergunta.Resposta)  // se resposta for igual a pergunta.resposta, acertou 
                {
                    flag = true;
                }
                else
                {
                    Console.WriteLine("Errou!! Dica: " + pergunta.Dica); // toda vez que errar, vou mostrar a dica

                }
                tentativas++; // número de tentativas tem que aumentar 
            }
            if (flag == true) // se acertou
            {
                Console.WriteLine("Parabéns!! Você ganhou o jogo.");
            }
            else // se não
            {
                Console.WriteLine("Que pena!! Você perdeu o jogo.");
            }
            Console.ReadKey(); // espera o usuário pressionar uma tecla no teclado
        }

        static List<NovaPergunta> CriarPerguntas()
        { // método que cria várias perguntas
            List<NovaPergunta> lista = new List<NovaPergunta>();
            lista.Add(new NovaPergunta("Qual é a cor do céu?", "Azul", "Informe uma cor que comece com a letra A"));
            lista.Add(new NovaPergunta("Quantos dias tem uma semana?", "7", "Menos de 10"));
            lista.Add(new NovaPergunta("Aplicativo de assistir filmes", "Netflix", "O mais utilizado do momento"));
            lista.Add(new NovaPergunta("O que significa RGB", "Vermelho, Verde e Azul", "Cores"));
            lista.Add(new NovaPergunta("Qual é o primeiro mês do ano?", "Janeiro", "Começa com J"));
            lista.Add(new NovaPergunta("Qual é a capital do Brasil?", "Brasília", "Cidade planejada, inaugurada em 1960"));
            lista.Add(new NovaPergunta("Qual o planeta conhecido como Planeta Vermelho ? ", "Marte", "É vizinho da Terra"));
            lista.Add(new NovaPergunta("Quantos segundos tem um minuto?", "60", "É o mesmo número de minutos em uma hora"));
            lista.Add(new NovaPergunta("Qual o nome do criador do Facebook?", "Mark Zuckerberg", "Fundou a rede social ainda na faculdade"));
            lista.Add(new NovaPergunta("Quem pintou a Mona Lisa?", "Leonardo da Vinci", "Artista do Renascimento"));
            return lista;
        }

    }

}


