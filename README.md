# TradutorPostFix
Tradutor de expressões numéricas com notação infixada para a forma pós-fixada.
Na Main, existe um loop onde se insere uma entrada infixada e se atribui à variável "postfix" o retorno da função Tradutor que é reponsável por fazer a conversão de infix para postfix.
Na função Tradutor é criado uma string aux(usada para ir inserindo os digitos da expressão pos-fixada) e uma pilha para nos auxiliar na conversão. Existe um for para tratar digito por digito, onde irá passar pelos "ifs" e "elses" para, saber primeiramente, se é uma letra ou número, caso não seja, será testado se é ou não parenteses, se não ser nenhuma das opções, será dado como um operador, onde, um while irá testar se a precedência do operador do digito e o operador do topo da pilha, caso o mesmo seja de uma precedencia menor a variável aux irá receber o topo da pilha,e no mesmo else a pilha receberá o operador em questão.
Na função Precedencia, é recebido o digito de operador como parametro e então é passado um switch case que, para os operadores + e - deve retornar o valor 1, para * e / 2, e para ^ é retornado o valor 3, dessa forma classificando a precedência dos operadores.
