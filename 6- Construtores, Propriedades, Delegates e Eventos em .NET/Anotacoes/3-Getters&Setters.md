## Set e Get

O Get e Set serve para que você possa atribuir um valor em uma variável de maneira controlada e com validações.



### Propriedades

É uma maneira de unificar o get e set, podendo ter validações ou não.

Ex: public int Mes {get; set;}



##### Quando implementamos uma propriedade que precisa realizar alguma validação, precisamos:

Alterar o get ou set da propriedade para trabalhar com uma variável privada da classe.