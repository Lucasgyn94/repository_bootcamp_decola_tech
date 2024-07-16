## Microsserviços

é um tipo de arquitetura de software que consiste em construir aplicações desmembrando-as em serviços independentes. Estes serviços se comunicam entre si usando APIs e promovem grande agilidade.



## Por que Microsserviços?

* Facilitar
* Agilizar
* Rápido e fácil para iniciar
* Infraestrutura simples
* Debug fascinante

### -- Contras

* Problemas com merge-conflicts
* Conexões simultâneas TCP é limitada
* Deadblock e concorrência
* Bugs e defeitos colaterais (Único ponto de falha)
* Build / Deploy longos pesados
* Baixa escalabilidade
* Agregação de tecnologia
* Demora de aculturamento



## => Escalabilidade

### -- Escalabilidade vertical

![](C:\Users\Admin\Desktop\DigitalOne\2- Bootcamp_Decola_Tech\9-Introdução a microsserviços com .NET\PNGs\1-EscalabilidadeVertical.png)



### -- Escalabilidade Horizontal

* Dividir para conquistar

![](C:\Users\Admin\Desktop\DigitalOne\2- Bootcamp_Decola_Tech\9-Introdução a microsserviços com .NET\PNGs\2-EscalabilidadeHorizontal.png)



### -- Microsservice Martin Fowler

![](C:\Users\Admin\Desktop\DigitalOne\2- Bootcamp_Decola_Tech\9-Introdução a microsserviços com .NET\PNGs\3-MicrosservicesMartinFowler.png)



### -- Escalabilidade Horizontal com Microsserviços

![](C:\Users\Admin\Desktop\DigitalOne\2- Bootcamp_Decola_Tech\9-Introdução a microsserviços com .NET\PNGs\4-EscalabilidadeHorizontalComMicrosservicos.png)

* Eu não preciso de escalar todos os meus serviços, somente aqueles que precisamos por demanda.



### -- Ecossistema de Microsserviços

![](C:\Users\Admin\Desktop\DigitalOne\2- Bootcamp_Decola_Tech\9-Introdução a microsserviços com .NET\PNGs\5-EcossistemadeMicrosservicos.png)



### -- Micro serviços dependem apenas um do outro via APIs públicas

![](C:\Users\Admin\Desktop\DigitalOne\2- Bootcamp_Decola_Tech\9-Introdução a microsserviços com .NET\PNGs\6-MicroservicosAPIsPublicas.png)



### -- Micro serviços podem (e devem!) ser poliglotas em seus stacks

![](C:\Users\Admin\Desktop\DigitalOne\2- Bootcamp_Decola_Tech\9-Introdução a microsserviços com .NET\PNGs\7-MicrosservicosStacks.png)



### -- Micro serviços encapsulam estado e comportamento

![](C:\Users\Admin\Desktop\DigitalOne\2- Bootcamp_Decola_Tech\9-Introdução a microsserviços com .NET\PNGs\8-MicroservicosEstadoComportamento.png)



### -- Micro serviços possuem deploy (implantação) diferentes

![](C:\Users\Admin\Desktop\DigitalOne\2- Bootcamp_Decola_Tech\9-Introdução a microsserviços com .NET\PNGs\9-MicroservicosDeploy.png)



### -- Micro serviços devem ter tratamentos isolados à falhas

![](C:\Users\Admin\Desktop\DigitalOne\2- Bootcamp_Decola_Tech\9-Introdução a microsserviços com .NET\PNGs\10-MicroservicosTratamentos.png)



### -- DDD - Domain Driven Design

DDD ou Domain Driven Design é um conjunto de princípios com foco em domínio, exploração de modelos de formas criativas e definir e falar a linguagem Ubíqua, baseado no contexto delimitado.

![](C:\Users\Admin\Desktop\DigitalOne\2- Bootcamp_Decola_Tech\9-Introdução a microsserviços com .NET\PNGs\11-MicrosservicosDDD.png)



### -- Modelo de integridade

![](C:\Users\Admin\Desktop\DigitalOne\2- Bootcamp_Decola_Tech\9-Introdução a microsserviços com .NET\PNGs\12-ModeloIntegridade.png)