# Desafio do MiniERP com Entity Framework e Windows Forms em C#

### Descrição do desafio

Com Windows Forms, construa um MiniERP, que deve conter utilizando o Entity Framework:
-Cadastro de produtos (vincular a 1 fornecedor)
-Cadastro de Fornecedores
-Cadastro de clientes
-Lançamento de nota (vincular ao cliente e aos produtos - N X N)

-Use seus conhecimentos para decidir aos atributos e como as telas irão de comportar.

Plus: gerar PDF da nota

### Video de Amostra

 [Link para exibição do projeto](https://www.youtube.com/watch?v=k3OFsyN-ENo)

 ### Tecnologias Utilizadas

 - SqlServer
 - Windows Forms
 - Entity Framework Core
 - iText7 (Biblioteca do PDF)
 - .NET 6

 ### Observações a serem apontadas acerca do desenvolvimento

 #### Minhas escolhas

- Escolhi a opção de fazer a integração com o Banco utilizando o método CodeFirst, com o principal objetivo de aprender mais.
 - Utilizei o componente ``TabControl`` para a divisão dos menus, de modo que não precisasse criar tantas telas. Porém, ao fim do meu desenvolvimento percebi o quanto isso me atrapalhou, pois os métodos de todos os componentes e ``TabControl`` encontram-se em uma única tela, no Form1.
 - Outro ponto a ser apresentado, foi que escolhi o componente ``listView`` para fazer a exibição dos itens, percebi também que utilizar o dataGridView para esses casos é melhor, do que ficar manipulando e criando listas antes da exibição. Utilizei o dataGridView em uma atividade não obrigatória, com os mesmos requisitos desse desafio, porém utilizando ADO .NET.
 - Um ponto importante a ser apresentado é a utilização de uma ``List<>`` para receber os itens do carrinho, decidi armazenar tudo em uma lista e só gravar no banco de dados quando realmente o Cliente ter finalizado a compra.
 
 #### Materiais de apoio utilizado para desenvolvimento do desafio

 Utilização LINQ para consultas em Banco de Dados
https://learn.microsoft.com/pt-br/dotnet/visual-basic/programming-guide/language-features/linq/how-to-query-a-database-by-using-linq?source=recommendations

Relacionamento de Tabelas
https://learn.microsoft.com/pt-br/ef/core/modeling/relationships/many-to-many

Selecionar um item de uma ListView
https://learn.microsoft.com/pt-br/dotnet/api/system.windows.forms.listview.selectedindexcollection?view=windowsdesktop-8.0
https://learn.microsoft.com/pt-br/dotnet/api/system.windows.forms.listview.selecteditems?view=windowsdesktop-7.0

Listas de tabelas N:N
https://learn.microsoft.com/pt-br/dotnet/api/system.collections.generic.list-1?view=net-8.0

### Como instalar e executar

##### 1º Passo - GitHub

Baixar ou clonar o repositório

##### 2º Passo - SQL Server

Abra a solução/projeto no Visual Studio
E também abra o SQL Server. Para facilitar, na pasta Banco de Dados tem um documento para executar a criação do banco de dados, leia os comentários do documento e os execute!

Depois de seguir os passos e criar um usuário, possivelmente você terá que dar permissão a ele 
Nas propriedades você deve procurar esses campos e deixa-los marcados, conforme imagem a baixo

<img src="/ImagesReadMe/sqlServer.png" width="250px"><img src="/ImagesReadMe/esquemasPrio.png"><img src="/ImagesReadMe/associa.png">



#### 3º Passo - Visual Studio

Aqui você deve saber, se está usando a versão EXPRESS ou Developer do Sql Server, para a versão EXPRESS siga as instruções abaixo:
##### Mudando a string de conexão com o banco de dados - EXPRESS
Na pasta do Projeto MiniERP_Entity, você deve procurar o documento Contexto.cs
Na linha 25, onde diz:

``optionsBuilder.UseSqlServer("Data Source=.\\SQLEXPRESS;Initial Catalog=miniERP_Entity;User ID=usuario;Password=senha123");``
Caso esteja usando a versão EXPRESS do SQL Server, mantenha assim como está.

##### Mudando a string de conexão com o banco de dados - DEVELOPER

Para a versão DEVELOPER você deve substituir a linha 25 por:
``optionsBuilder.UseSqlServer("Data Source=localhost; Initial Catalog=miniERP_Entity; User ID=usuario; password=senha123; language=Portuguese; Trusted_Connection=True; TrustServerCertificate=True;");``

- Initial Catalog é o nome do banco de dados
- User ID é o usuário que foi criado conforme as orientações no arquivo .sql
- Password é a senha que foi utilizada também no arquivo de orientações .sql

#### 4º Passo - Visual Studio

Executando o ``Update-Database`` no Console de Gerenciador de Pacotes do Visual Studio para criar as tabelas.

#### 5º Passo a sua escolha - SQL Server

Depois de criadas as tabelas, você pode querer ou não popular as tabelas, caso queira, acesse o mesmo arquivo .sql e execute a inserção de dados na tabela

#### 6º Passo

Executar o programa

### Author

👨🏻‍🦱 [Gabriel Castagna](https://github.com/castagnagh/)