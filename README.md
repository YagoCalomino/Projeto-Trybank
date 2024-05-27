# Trybank

Boas-vindas ao repositório do projeto `Trybank`

Para realizar o projeto, atente-se a cada passo descrito a seguir, e se tiver **qualquer dúvida**, nos envie no _Slack_ da turma! #vqv 🚀

Aqui, você vai encontrar os detalhes de como estruturar o desenvolvimento do seu projeto a partir desse repositório, utilizando uma branch específica e um _Pull Request_ para colocar seus códigos.

## Termos e acordos

Ao iniciar este projeto, você concorda com as diretrizes do [Código de Conduta e do Manual da Pessoa Estudante da Trybe](https://app.betrybe.com/learn/student-manual/codigo-de-conduta-da-pessoa-estudante).

## Entregáveis

<details>
<summary><strong>🤷🏽‍♀️ Como entregar</strong></summary>

Para entregar o seu projeto você deverá criar um _Pull Request_ neste repositório.

Lembre-se que você pode consultar nosso conteúdo sobre [Git & GitHub](https://app.betrybe.com/learn/course/5e938f69-6e32-43b3-9685-c936530fd326/module/fc998c60-386e-46bc-83ca-4269beb17e17/section/fe827a71-3222-4b4d-a66f-ed98e09961af/day/1a530297-e176-4c79-8ed9-291ae2950540/lesson/2b2edce7-9c49-4907-92a2-aa571f823b79) e nosso [Blog - Git & GitHub](https://blog.betrybe.com/tecnologia/git-e-github/) sempre que precisar!

</details>
  
<details>
<summary><strong>🧑‍💻 O que deverá ser desenvolvido</strong></summary>

Já pensou em criar um sistema de um banco? Nesse projeto, você vai criar uma aplicação para controlar contas bancárias bem como realizar as suas operações básicas de checar um saldo, depositar, sacar e transferir dinheiro.
Além disso, você irá permitir com que nessa aplicação, você cadastre novas contas, faça login e logout no seu sistema.

</details>
  
<details>
  <summary><strong>:memo: Habilidades a serem trabalhadas </strong></summary>

Neste projeto, verificamos se você é capaz de:

- Entender sobre as estruturas de array
- Realizar a conversão e manipulação de variáveis de diversos tipos
- Realizar operações aritméticas
- Construir algorítmos que implementem estruturas de controle
- Lançar exceções controladas.


</details>

## Orientações

<details>
  <summary><strong>‼️ Antes de começar a desenvolver</strong></summary><br />

  1. Clone o repositório

  - Use o comando: `git clone git@github.com:tryber/csharp-034-csharp-projeto-trybank.git`.
  - Entre na pasta do repositório que você acabou de clonar:
    - `cd csharp-034-csharp-projeto-trybank`

  2. Instale as dependências
  
  - Entre na pasta `src/`.
  - Execute o comando: `dotnet restore`.
  
  3. Crie uma branch a partir da branch `master`

  - Verifique se você está na branch `master`.
    - Exemplo: `git branch`
  - Se não estiver, mude para a branch `master`.
    - Exemplo: `git checkout master`
  - Agora crie uma branch à qual você vai submeter os `commits` do seu projeto.
    - Você deve criar uma branch no seguinte formato: `nome-de-usuario-nome-do-projeto`
    - Exemplo: `git checkout -b joaozinho-csharp-034-csharp-projeto-trybank`

  4. Adicione as mudanças ao _stage_ do Git e faça um `commit`

  - Verifique que as mudanças ainda não estão no _stage_.
    - Exemplo: `git status` (deve aparecer listada a pasta _joaozinho_ em vermelho)
  - Adicione o novo arquivo ao _stage_ do Git.
    - Exemplo:
      - `git add .` (adicionando todas as mudanças - _que estavam em vermelho_ - ao stage do Git)
      - `git status` (deve aparecer listado o arquivo _joaozinho/README.md_ em verde)
  - Faça o `commit` inicial.
    - Exemplo:
      - `git commit -m 'iniciando o projeto x'` (fazendo o primeiro commit)
      - `git status` (deve aparecer uma mensagem tipo essa: _nothing to commit_ )

  5. Adicione a sua branch com o novo `commit` ao repositório remoto

  - Usando o exemplo anterior: `git push -u origin joaozinho-csharp-034-csharp-projeto-trybank`.

  6. Crie um novo `Pull Request` _(PR)_

  - Vá até a página de _Pull Requests_ do [repositório no GitHub](https://github.com/tryber/csharp-034-csharp-projeto-trybank/pulls).
  - Clique no botão verde _"New pull request"_.
  - Clique na caixa de seleção _"Compare"_ e escolha a sua branch **com atenção**.
  - Coloque um título para a sua _Pull Request_.
    - Exemplo: _"Cria tela de busca"_
  - Clique no botão verde _"Create pull request"_.
  - Adicione uma descrição para o _Pull Request_ e clique no botão verde _"Create pull request"_.
  - **Não se preocupe em preencher mais nada por enquanto!**.
  - Volte até a [página de _Pull Requests_ do repositório](https://github.com/tryber/csharp-034-csharp-projeto-trybank/pulls) e confira que o seu _Pull Request_ está criado.

</details>

<details>
  <summary><strong>⌨️ Durante o desenvolvimento</strong></summary><br/>

  - Faça `commits` das alterações que você fizer no código regularmente.

  - Lembre-se sempre, após um (ou alguns) `commits`, de atualizar o repositório remoto.

  - Os comandos que você utilizará com mais frequência são:
    1. `git status` _(para verificar o que está em vermelho - fora do stage - e o que está em verde - no stage)_
    2. `git add` _(para adicionar arquivos ao stage do Git)_
    3. `git commit` _(para criar um commit com os arquivos que estão no stage do Git)_
    4. `git push -u origin nome-da-branch` _(para enviar o commit para o repositório remoto na primeira vez que fizer o `push` de uma nova branch)_
    5. `git push` _(para enviar o commit para o repositório remoto após o passo anterior)_

</details>

<details>
  <summary><strong>🤝 Depois de terminar o desenvolvimento (opcional)</strong></summary><br/>

  Para sinalizar que o seu projeto está pronto para o _"Code Review"_, faça o seguinte:

  - Vá até a página **DO SEU** _Pull Request_, adicione a label de _"code-review"_ e marque seus colegas:

    - No menu à direita, clique no _link_ **"Labels"** e escolha a _label_ **code-review**;

    - No menu à direita, clique no _link_ **"Assignees"** e escolha **o seu usuário**;

    - No menu à direita, clique no _link_ **"Reviewers"** e digite `students`, selecione o time `tryber/students-sd-034-csharp`.

  Caso tenha alguma dúvida, [aqui tem um video explicativo](https://vimeo.com/362189205).

</details>

<details>
  <summary><strong>🕵🏿 Revisando um pull request</strong></summary><br />

  Use o conteúdo sobre [Code Review](https://app.betrybe.com/course/real-life-engineer/code-review) para te ajudar a revisar os _Pull Requests_.

</details>

<details>
  <summary><strong>🎛 Linter</strong></summary><br />

  Usaremos o [NetAnalyzer](https://docs.microsoft.com/pt-br/dotnet/fundamentals/code-analysis/overview) para fazer a análise estática do seu código.

  Este projeto já vem com as dependências relacionadas ao _linter_ configuradas no arquivo `.csproj`.

  O analisador já é instalado pelo plugin da `Microsoft C#` no `VSCode`. Para isso, basta fazer o download do [plugin](https://marketplace.visualstudio.com/items?itemName=ms-dotnettools.csharp) e instalá-lo.
</details>

<details>
  <summary><strong>🛠 Testes</strong></summary><br />

  O .NET já possui sua própria plataforma de testes.
  
  Este projeto já vem configurado e com suas dependências.

  ### Executando todos os testes

Para executar os testes com o .NET, execute o comando dentro do diretório do seu projeto `src` ou de seus testes `src/trybank.Test.Test`!
  ```
  dotnet test
  ```

  ### Executando um teste específico

  Para executar um teste expecífico, basta executar o comando `dotnet test --filter Name~TestMethod1`.

  :warning: **Importante:** o comando irá executar testes cujo nome contém `TestMethod1`.

  :warning: **O avaliador automático não necessariamente avalia seu projeto na ordem em que os requisitos aparecem no readme. Isso acontece para deixar o processo de avaliação mais rápido. Então, não se assuste se isso acontecer, ok?**

  ### Outras opções para testes
  - Algumas opções que podem lhe ajudar são:
    -  `-?|-h|--help`: exibem a descrição completa de como utilizar o comando.
    -  `-t|--list-tests`: lista todos os testes, ao invés de executá-los.
    -  `-v|--verbosity <LEVEL>`: define o nível de detalhe na resposta dos testes.
      - `q | quiet`
      - `m | minimal`
      - `n | normal`
      - `d | detailed`
      - `diag | diagnostic`
      - Exemplo de uso: 
         ```
           dotnet test -v diag
         ```
         ou
         ```            
           dotnet test --verbosity=diagnostic
         ``` 
</details>

<details>
  <summary><strong>🗣 Nos dê feedbacks sobre o projeto!</strong></summary><br />

Ao finalizar e submeter o projeto, não se esqueça de avaliar sua experiência preenchendo o formulário. 
**Leva menos de 3 minutos!**

[FORMULÁRIO DE AVALIAÇÃO DE PROJETO](https://be-trybe.typeform.com/to/PsefzL2e)

</details>

<details>
  <summary><strong>🗂 Compartilhe seu portfólio!</strong></summary><br />

  Você sabia que o LinkedIn é a principal rede social profissional e que compartilhar aprendizados lá é muito importante para quem deseja construir uma carreira de sucesso? Compartilhe este projeto no seu LinkedIn, marque o perfil da Trybe (@trybe) e mostre para a sua rede toda a sua evolução.

</details>


# Requisitos do Projeto

Boas-vindas ao TryBank, uma iniciativa de implementar um serviço de banco financeiro para sua instituição do coração.💚

Você recebeu a demanda de criar a versão inicial do TryBank. Nesse projeto, você tem como objetivo construir um banco que contenha contas. Além disso, deve criar e validar os processos de cadastro, login, saque, depósito e transferência do saldo dessas contas. 

Como ainda não aprendemos a persistir dados, este projeto irá armazenar os dados em um array. Como os dados do array estarão sempre em memória, toda vez que reiniciar o programa a memória do apagar e você terá os dados do array zerados.

Os dados da conta bancária ficará armazenado em um array multidimensional. Cada array que irá armazenar os dados tem na posição 0 o número da conta, na posição 1, a agencia, na posição 2 a senha de acesso e na posição 3 o saldo da conta. Por exemplo, para cadastro das seguintes contas:

Conta 1: Agência 1, Número da conta: 1234, Senha: 987, Saldo: 0
Conta 2: Agência 2, Número da conta: 5678, Senha: 765, Saldo: 0

O array multidimensional ficaria:

```csharp
    int[] conta1 = new int[4] {1234, 1, 987, 0};
    int[] conta2 = new int[4] {5678, 2, 765, 0};

    int[][] Bank = new int[50][conta1, conta2];
```

De olho na dica👀: Faça uma boa separação de responsabilidades garantindo assim que a evolução desse sistema ocorra facilmente. Construa os requisitos em ordem para que os testes utilizem os métodos implementados por você corretamente.
 

## 1. Construa a funcionalidade de cadastrar novas contas

Crie a lógica do seu requisito no arquivo src/trybank/Trybank.cs.

<details>
  <summary>O programa deve permitir o cadastro de novas contas</summary><br />

Crie esse requisito na função `RegisterAccount()`

Se essa combinação de **número e agência** já existir, você deverá lançar uma exceção do tipo `ArgumentException` com a mensagem `A conta já está sendo usada!`.

Caso contrário, a função deve armazenar os dados no array `Bank` na próxima posição disponível marcada por `registeredAccounts` com saldo 0;

Caso tudo corra bem, a função deve incrementar a variável registeredAccounts;

**O que será testado:**

Será testado que ao chamar o método implementado, o mesmo registre uma conta nova no array e incremente a variável `registeredAccounts`.


</details>

## 2. Construa a funcionalidade de fazer Login

Crie a lógica do seu requisito no arquivo src/trybank/Trybank.cs.

<details>
  <summary>O programa deve permitir o Login da pessoa usuária</summary><br />

Crie esse requisito na função `Login()`

O estado de pessoa usuária logada é controlado pela variável `Logged`


- **Se já houver uma pessoa usuária logada**, você deverá lançar uma exceção do tipo `AccessViolationException` com a mensagem `Usuário já está logado`


 **Caso contrário**, a função deve procurar por essa combinação de número e agência.

-   **Se encontrado e a senha for correta**, a função deve alterar o estado da variável `Logged` e armazenar a posição da pessoa usuária logada na variável `loggedUser` (será útil futuramente para as próximas funções, fica a dica!)

-   **Se encontrado e a senha for incorreta**, você deve lançar uma exceção do tipo `ArgumentException` com a mensagem `Senha incorreta`

-   Se não for encontrada a combinação de `número e agência`, você deve lançar uma exceção do tipo `ArgumentException`com a mensagem `Agência + Conta não encontrada`

**O que será testado:**

Será testado que ao chamar o método implementado, o mesmo registre o login caso o usuário exista e a senha esteja correta e lance os erros caso a senha esteja incorreta ou caso a combinação de agência e conta não exista.

</details>

## 3. Construa a funcionalidade de fazer Logout

Crie a lógica do seu requisito no arquivo src/trybank/Trybank.cs.

<details>
  <summary>O programa deve permitir o Logout do usário</summary><br />

Crie esse requisito na função `Logout()`

O estado de pessoa usuária logada é controlado pela variável `Logged`

**Se não houver uma pessoa usuária logada**, você deverá lançar uma exceção do tipo `AccessViolationException` com a mensagem `Usuário não está logado`

**Caso contrário**, a função deve alterar o estado da variável `Logged` e o índice de pessoa usuária `loggedUser` de volta para `-99`


**O que será testado:**

Será testado que ao chamar o método implementado, o mesmo faça o logout do usuário logado e lance um erro caso o usuário em questão não esteja logado.

</details>


## 4. Construa a funcionalidade de checar o saldo

Crie a lógica do seu requisito no arquivo src/trybank/Trybank.cs.

<details>
  <summary>O programa deve permitir verificar o saldo na conta da pessoa usária logada</summary><br />

Crie esse requisito na função `CheckBalance()`

**Se não houver uma pessoa usuária logada**, você deverá lançar uma exceção do tipo `AccessViolationException` com a mensagem `Usuário não está logado`

**Caso contrário**, a função deve retornar o saldo na conta da pessoa usuária logada.


**O que será testado:**

Será testado que ao chamar o método implementado, o mesmo mostre o saldo da conta e lance um erro caso o usuário em questão não esteja logado.

</details>

## 5. Construa a funcionalidade de depositar dinheiro

Crie a lógica do seu requisito no arquivo src/trybank/Trybank.cs.

<details>
  <summary>O programa deve permitir o depósito de um valor na conta da pessoa usária logada</summary><br />

Crie esse requisito na função `Deposit()`

**Se não houver uma pessoa usuária logada**, você deverá lançar uma exceção do tipo `AccessViolationException` com a mensagem `Usuário não está logado`

**Caso contrário**, a função deve adicionar o valor passado por parâmetro para o saldo da pessoa usuária logada.


**O que será testado:**

Será testado que ao chamar o método implementado, o mesmo aumente o saldo da conta e lance um erro caso o usuário em questão não esteja logado.


</details>

## 6. Construa a funcionalidade de sacar dinheiro

Crie a lógica do seu requisito no arquivo src/trybank/Trybank.cs.

<details>
  <summary>O programa deve permitir o saque de um valor na conta da pessoa usuária logada</summary><br />

Crie esse requisito na função `Withdraw()`

**Se não houver uma pessoa usuária logada**, você deverá lançar uma exceção do tpo `AccessViolationException`, com a mensagem `Usuário não está logado`

**Caso contrário**, a função deve retirar o valor passado por parâmetro para o saldo da pessoa usuária logada.
  Se o saldo da conta da pessoa usuária logada for insuficiente para fazer o saque, você deve lançar uma exceção do tipo `InvalidOperationException` com a mensagem `Saldo insuficiente`


**O que será testado:**

Será testado que ao chamar o método implementado, o mesmo diminua o saldo da conta e lance um erro caso o usuário em questão não esteja logado ou caso o saldo seja insuficiente.

</details>


## 7. Construa a funcionalidade de transferir dinheiro entre contas

Crie a lógica do seu requisito no arquivo src/trybank/Trybank.cs.

<details>
  <summary>O programa deve permitir a transferência de saldo entre uma pessoa usuária logada e uma conta existente</summary><br />

Crie esse requisito na função `Transfer(int destinationNumber, int destinationAgency, int value)()`

**Se não houver uma pessoa usuária logada**, você deverá lançar uma exceção do tipo `AccessViolationException`, com a mensagem `Usuário não está logado`

Se o saldo da conta da pessoa usuária logada for insuficiente para fazer a transferência, você deve lançar uma exceção do tipo `InvalidOperationException` com a mensagem `Saldo insuficiente`

**Caso contrário**, a função deve transferir o valor passado por parâmetro do saldo da pessoa usuária logada para o saldo da conta passada por parâmetro.


**O que será testado:**

Será testado que ao chamar o método implementado, o mesmo diminua o saldo da conta origem e aumente o saldo da conta destino no mesmo valor. Também será testado que o software lance um erro caso o usuário em questão não esteja logado ou caso o saldo seja insuficiente.

</details>


<details>
<summary><strong>🗣 Nos dê feedbacks sobre o projeto!</strong></summary>

Ao finalizar e submeter o projeto, não se esqueça de avaliar sua experiência preenchendo o formulário.
**Leva menos de 3 minutos!**

[Formulário de avaliação do projeto](https://be-trybe.typeform.com/to/ZTeR4IbH#cohort_hidden=CH34-CSHARP&template=betrybe/csharp-0x-projeto-trybank)

</details>
  
<details>
<summary><strong>🗂 Compartilhe seu portfólio!</strong></summary>

Você sabia que o LinkedIn é a principal rede social profissional e compartilhar o seu aprendizado lá é muito importante para quem deseja construir uma carreira de sucesso? Compartilhe esse projeto no seu LinkedIn, marque o perfil da Trybe (@trybe) e mostre para a sua rede toda a sua evolução.

</details>

---

<!-- mdi versão 1.1 projeto ⚠️ não exclua esse comentário -->
