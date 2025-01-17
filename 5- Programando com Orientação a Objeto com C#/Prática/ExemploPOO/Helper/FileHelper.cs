using System.Collections.Generic;
using System.IO;

namespace ExemploPOO.Helper
{
    public class FileHelper
    {
        // Listar Pastas dos diretórios
        public void ListarDiretorios(string caminho) 
        {
            var retornoCaminho = Directory.GetDirectories(caminho, "*", SearchOption.AllDirectories);

            foreach(var retorno in retornoCaminho)
            {
                System.Console.WriteLine(retorno);
            }
        }

        // Listar Arquivos Diretorios
        public void ListarArquivosDiretorios(string caminho)
        {
            var retornoArquivos = Directory.GetFiles(caminho,"*", SearchOption.AllDirectories);

            foreach(var retorno in retornoArquivos)
            {
                System.Console.WriteLine(retorno);
            }
        }
        
        // Criar diretório
        public void CriarDiretorio(string caminho)
        {
            var retorno = Directory.CreateDirectory(caminho);
            System.Console.WriteLine(retorno.FullName);
        }

        // Apagar Diretório
        public void ApagarDiretorio(string caminho, bool apagarCaminho)
        {
            Directory.Delete(caminho, apagarCaminho);
        }

        public void CriarArquivoTexto(string caminho, string conteudo)
        {
            if(!File.Exists(caminho))
            {
                File.WriteAllText(caminho, conteudo);
            }
        }

        public void CriarArquivoTextoStream(string caminho, List<string> conteudo)
        {
            using (var stream = File.CreateText(caminho))
            {
                foreach(var linha in conteudo)
                {
                    stream.WriteLine(linha);
                }
            }
        }

        public void AdicionarTexto(string caminho, string conteudo)
        {
            File.AppendAllText(caminho, conteudo);
            /*
            AppendAllText = Abre um arquivo, acrescenta a string especificada ao arquivo e, a seguir, fecha o arquivo. Se o arquivo não existir, este método cria um arquivo, grava a string especificada no arquivo e fecha o arquivo.
            */
        }

        public  void  AdicionarTextoStream(string caminho, List<string> conteudo)
        {
            using (var stream = File.AppendText(caminho))
            {
                foreach (var linha in conteudo)
                {
                    stream.WriteLine(linha);
                }
            }
        }

        public void LerArquivos(string caminho)
        {
            var conteudo = File.ReadAllLines(caminho);

            foreach(var linha in conteudo)
            {
                System.Console.WriteLine(linha);
            }
        }

        public void LerArquivosStream(string caminho)
        {
            string linha = string.Empty;

            using (var stream = File.OpenText(caminho))
            {
                while ((linha = stream.ReadLine()) != null)
                {
                    System.Console.WriteLine(linha);
                }
            }
        }

        public void MoverArquivo(string caminho, string novoCaminho, bool sobreescrever)
        {
            File.Move(caminho, novoCaminho, sobreescrever);
        }

        public void CopiarArquivo(string caminho, string novoCaminho, bool sobreescrever)
        {
            File.Copy(caminho, novoCaminho, sobreescrever);
        }

        public void DeletarArquivo(string caminho)
        {
            File.Delete(caminho);
        }
    }
}