namespace Atividade_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // string que contém o caminho de um arquivo
            string caminho = @"c:\temp\arquivo1.txt";
            // bloco try
            try
            {
                    // using fecha o objeto leitor depois de seu uso
                    using(StreamReader leitor = File.Open(caminho)) {
                        // bloco while
                        while(!leitor.EnOfStream){
                         // string que recebe leitor
                        string linhas = leitor.ReadLine();
                        // mostra linhas
                        Console.WriteLine(linhas);}
                       
                }
            }
            // trata erros
            catch (IOException e) {
                // mostra mensagem se ocorrer erro
                Console.WriteLine("Ocorreu um erro!");
                // mostra mensagem se ocorrer erro
                Console.WriteLine(e.Message);
            }
        }
    }
}
