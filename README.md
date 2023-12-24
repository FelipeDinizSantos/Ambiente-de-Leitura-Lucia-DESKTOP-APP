# Sistema Ambiente de Leitura Lucia

O Sistema Ambiente de Leitura Lucia é uma iniciativa destinada a solucionar os desafios enfrentados pela biblioteca da Escola Lúcia de Castro Bueno. Atualmente, o sistema de gerenciamento da biblioteca é manual, resultando em dificuldades na gestão eficiente do acervo, controle de empréstimos, e cobrança de devoluções. A proposta visa modernizar e simplificar esses processos, proporcionando uma solução tecnológica eficaz.

Esta aplicação desktop tem como principal objetivo simplificar e inovar os procedimentos manuais da biblioteca, abrangendo desde a busca de livros até o gerenciamento de empréstimos, organização, devoluções e doações. Desenvolvida em C#, foi construida para ser administrada pela bibliotecaria, consumindo constantemente o banco de dados em MySQL!

## Tecnologias Utilizadas

- **Windows Forms:** Plataforma de desenvolvimento para a criação de aplicativos Windows desktop. Oferece uma interface gráfica intuitiva e ferramentas para o desenvolvimento de interfaces de usuário. 
- **mysql.data:** Um conector que permite a comunicação entre aplicativos Windows e bancos de dados MySQL. Facilita a integração do aplicativo desktop com o banco de dados utilizado pelo Sistema de Gerenciamento de Bibliotecas.

## Funcionalidades Principais

### Controle de Acervo

- Cadastro e controle preciso de livros no acervo.
- Atualização de informações, como título, situação, sinopse etc.

### Gestão de Empréstimos

- Registros de usuários, incluindo alunos e professores.
- Histórico de empréstimos por leitor.
- Notificações de datas de devolução.

### Sistema de Fila de Espera

- Possibilidade de entrada na fila de espera para livros emprestados.

### Explorador de Livros

- Ferramenta de pesquisa para busca por livros, com filtros por tags, títulos, anos, gêneros e autores.

### Perfil do Leitor

- Registros individuais de usuários, incluindo histórico de livros alugados, pendentes e eventuais multas

### Integração Desktop e Web

- A aplicação desktop é integrada com a [aplicação web](https://github.com/FelipeDinizSantos/Ambiente-de-Leitura-Lucia-APP)

## Como Contribuir

1. Faça um fork do repositório.
2. Crie uma branch para sua contribuição: `git checkout -b nome-da-sua-feature`.
3. Faça commit das suas alterações: `git commit -m 'Adiciona nova funcionalidade'`.
4. Faça push para a branch: `git push origin nome-da-sua-feature`.
5. Abra um Pull Request.

## Estado Atual do Projeto: Entregue

O projeto foi entregue à escola, e agora cabe à instituição decidir sobre a utilização e implementação na biblioteca. A escola será responsável pela hospedagem do sistema, contando com o auxílio da nossa equipe para esse processo.

Para mais informações, consulte a documentação: [DOCUMENTAÇÃO](https://drive.google.com/drive/folders/1DxZTdcw6DDnBS3thdouUKrSPJgGQlOjR?usp=sharing)
