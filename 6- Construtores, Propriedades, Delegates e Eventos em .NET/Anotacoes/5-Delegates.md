## => Aula 4: Delegates

### -- Delegates

Um delegate é uma maneira de passar um método como referência, podendo ser usado como um callback, aceitando qualquer método que contenha a mesma assinatura.

Ex: public delegate void Operacao(int x, int y);



### -- Multi Cast Delegate

É uma extensão do Delegate, que nada mais é, do que chamarmos vários métodos em sequência em uma única chamada do Delegate.

EX:

Operacao op = new Operacao(Calculadora.Somar);

op  += Calculadora.Subtrair;



##### Ao realizarmos um multi cast delegate, a chamada dos métodos obedece a ordem de:

FIFO (First in First out)
