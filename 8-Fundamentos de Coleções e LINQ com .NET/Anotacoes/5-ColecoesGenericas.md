## Aula 4: Coleções específicas

As coleções específicas implementam regras para sua ordem de acesso e manipulação de seus elementos, são elas:

- Queue (Fila) : Obedece a ordem FIFO (First in First Out) - Primeiro a entrar, primeiro a sair.
- Stack (Pilha): Obedece a ordem LIFO (Last in First Out) - Ultimo a entrar, primeiro a sair.



### Queue (Fila - FIFO)

![](C:\Users\Admin\Desktop\DigitalOne\2- Bootcamp_Decola_Tech\8-Fundamentos de Coleções e LINQ com .NET\PNGs\6-Fila.png)

Exemplo:

Queue<string> fila = new Queue<string>();



​      fila.Enqueue("Lucas");

​      fila.Enqueue("Joana");

​      fila.Enqueue("Tampinha");



​      System.Console.WriteLine($"Pessoas na fila: {fila.Count}");



​      while(fila.Count > 0)

​      {

​        System.Console.WriteLine($"Vez de: {fila.Peek()}");

​        System.Console.WriteLine($"{fila.Dequeue()} atendido");

​      }



​      System.Console.WriteLine($"Pessoas na fila: {fila.Count}");



### Stack (Pilha - LIFO)

![](C:\Users\Admin\Desktop\DigitalOne\2- Bootcamp_Decola_Tech\8-Fundamentos de Coleções e LINQ com .NET\PNGs\7-Stack (Pilha).png)