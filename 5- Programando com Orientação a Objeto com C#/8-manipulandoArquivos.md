O C# nos apresenta algumas classes estáticas que facilitam o trabalho com arquivos, dentre elas:

* File ( Arquivo )
* Directory ( Diretório )
* Path ( Caminho )
* Para fazer o uso dessas classes basta fazer o import do system.io



C:\Users\Admin\Desktop\DigitalOne\2- Bootcamp_Decola_Tech\5- Programando com Orientação a Objeto com C#\TrabalhandoComArquivos



### Metódo que lista todas Pastas do Diretório

 public void ListarDiretorios(string caminho) 

​    {

​      var retornoCaminho = Directory.GetDirectories(caminho, "*", SearchOption.AllDirectories);



​      foreach(var retorno in retornoCaminho)

​      {

​        System.Console.WriteLine(retorno);

​      }

​    }

### OBS: * significa tudo



### OBS 2: Lista 'List<>' é uma coleção de strings

### OBS 3: Usar streams significa trabalhar com o arquivo em partes e de forma incremental, não sobrecarregando a memória do sistema, onde não precisamos carregar todo o arquivo de uma vez.