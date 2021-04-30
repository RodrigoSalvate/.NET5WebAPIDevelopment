# .NETWebAPIDevelopment

# Projeto sand box para implementação e aprendizado em APIs.
PSW-Project. Ideia baseada no curso de ciências da computação CEFET-RJ (Aluno: Rodrigo Campos - https://github.com/rodcampos21). O objetivo é criar uma API em .net core e passar o conhecimento para o Rodrigo Campos e demais interessados.


# PSW-Project
Repositório do aplicativo construído durante as aulas programação de software para Web na faculdade CEFET/RJ.

# Nome/Propósito: 
Bolsa de Horas - Aplicação para troca de horas em regime de permuta.

# Business Case:
É comum precisamos pedir favores para pessoas e em troca ficamos devendo favores (permuta). Quando estes favores envolvem 
serviços profissionais o tempo gasto nestes serviços e o tipo dele costumam ser balizadores para medir o seu valor. Contudo, é 
comum que as trocas de favores ocorram de maneira injusta. Algumas pessoas costumam pedir favores sem devidamente compensá-los 
posteriormente, outras vezes a troca não é equivalente em valor. Por fim, relações são desgastadas e um enorme potencial de 
troca é perdido. O Bolsa de Horas permite que as horas sejam trocadas entre os profissionais de forma registrada, confiável e 
com valor regulado pelo mercado (oferta/demanda).

# Processo de Negócio Principal:
Primeiro um indivíduo que precisa de um serviço, mas não tem como ou não quer pagar em dinheiro por ele, registra uma demanda, informando a descrição dela, sua estimativa de horas para o serviço, prazo de entrega e a especialidade necessária (demanda). Os indivíduos que possuem a especialidade são informados, e, caso se interessem pelo serviço, informam sua estimativa em horas, fazendo uma oferta para a prestação de serviço (cotação). O solicitante escolhe a melhor oferta, iniciando o serviço (serviço). Após a prestação do serviço ser realizada, o prestador informa a quantidade real de horas despendidas, e o solicitante aprova o serviço (serviço). O solicitante, neste momento, contrai uma dívida proporcional a quantidade de horas reais despendidas pelo prestador, devendo esta ser paga prestando serviços (indivíduo) antes que ele possa solicitar um novo serviço. 

# Entidades:
- Indivíduo
- Demanda
- Cotação
- Serviço
