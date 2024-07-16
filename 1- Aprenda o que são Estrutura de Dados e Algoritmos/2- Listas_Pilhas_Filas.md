## Objetivo da Aula

1. Listas
2. Pilha
3. Fila



## Listas

Estrutura de Dados do tipo Lista, armazena dados de um determinado tipo em uma ordem específica.

Listas possuem tamanhos ajustáveis, diferentes de arrays, que possuem valores fixos. Listas podemos ir preenchendo.

Existem dois tipos de listas:

* Ligadas

* Duplamente Ligadas

  

### => Lista Ligada

Na estrutura do tipo lista existem os nós onde cada um dos nós conhece o valor que está sendo armazenado em seu interior além de conhecer o elemento posterior a ele: por isso ela é chamada de "lista ligada", pois os nós são amarrados com essa indicação de qual é o próximo nó.

![](C:\Users\Admin\Desktop\DigitalOne\2- Bootcamp_Decola_Tech\1- Aprenda o que são Estrutura de Dados e Algoritmos\PNGs\2- Lista_Ligada.png)

* Se adicionarmos mais um nome, ficaria da seguinte forma:

![](C:\Users\Admin\Desktop\DigitalOne\2- Bootcamp_Decola_Tech\1- Aprenda o que são Estrutura de Dados e Algoritmos\PNGs\3- Lista_Ligada_Dois_Nomes.png)



### => Lista Duplamente Ligadas

As listas duplamente ligadas constituem uma variação das listas ligadas.

A grande diferença das listas duplamente ligadas paras as listas ligadas é que elas são bidirecionais. Vimos que, naturalmente, não conseguimos "andar para trás" em listas ligadas, pois os nós de uma lista ligada sabem somente quem é o próximo elemento, Nas listas duplamente ligadas, os nós sabem que é o próximo elemento e também que é o elemento anterior, o que permite a navegação reversa.

![](C:\Users\Admin\Desktop\DigitalOne\2- Bootcamp_Decola_Tech\1- Aprenda o que são Estrutura de Dados e Algoritmos\PNGs\4- lista_duplamente_ligada.png)



## Pilhas

Uma pilha é uma estrutura que serve como uma coleção de elementos, e permite o acesso a somente um item de dados armazenado.

O acesso aos itens de uma pilha é restrito - somente um item pode ser lido ou removido por vez.



### => Titpos de Pilhas:

* LIFO ou UEPS
* FIFO ou PEPS



### LIFO ou UEPS

A estrutura do tipo PILHA LIFO (Last in First Out) ou UEPS (Último que Entra, Primeiro que Sai), apresenta o seguinte critério: o primeiro elemento a ser retirado é o último que tiver sido inserido.

![](C:\Users\Admin\Desktop\DigitalOne\2- Bootcamp_Decola_Tech\1- Aprenda o que são Estrutura de Dados e Algoritmos\PNGs\5- lifo.png)

push = inserir

pop = remover



### => FIFO

A estrutura do tipo PILHA FIFO (First in First Out) ou PEPS (Primeiro que Entra Primeiro que Sai), apresenta o seguinte critério: o primeiro elemento a ser retirado é o primeiro que tiver sido inserido.

![](C:\Users\Admin\Desktop\DigitalOne\2- Bootcamp_Decola_Tech\1- Aprenda o que são Estrutura de Dados e Algoritmos\PNGs\6- Fifo.png)



## Parte 2: Filas

A estrutura do tipo Fila admite remoção de elemento e inserção de novos sujeita à seguinte regra de operação:

O elemento removido é o que está na estrutura há mais tempo ou seja, o primeiro objeto inserido na fila é também o primeiro a ser removido seguindo o conceito FIFO.

![](C:\Users\Admin\Desktop\DigitalOne\2- Bootcamp_Decola_Tech\1- Aprenda o que são Estrutura de Dados e Algoritmos\PNGs\7- Filas.png)