**SCRIPT — TABELA Carro:**



CREATE TABLE Carro (

&nbsp;   Id INT IDENTITY(1,1) PRIMARY KEY,

&nbsp;   Modelo VARCHAR(100) NOT NULL,

&nbsp;   Marca VARCHAR(100) NOT NULL,

&nbsp;   Cor VARCHAR(50) NOT NULL,

&nbsp;   Preco DECIMAL(10,2) NOT NULL,

&nbsp;   Ano INT NOT NULL,

&nbsp;   Categoria VARCHAR(50) NOT NULL

);



**SCRIPT — TABELA Cliente:**



CREATE TABLE Cliente (

&nbsp;   Id INT IDENTITY(1,1) PRIMARY KEY,

&nbsp;   Nome VARCHAR(100) NOT NULL,

&nbsp;   Email VARCHAR(150) NOT NULL,

&nbsp;   Sexo VARCHAR(1) NOT NULL,

&nbsp;   Cpf VARCHAR(11) NOT NULL,

&nbsp;   DataNascimento DATE NOT NULL,

&nbsp;   TipoUsuario VARCHAR(50) NULL

);



**SCRIPT — TABELA Empréstimos:**



CREATE TABLE Emprestimos (

&nbsp;   Id INT IDENTITY(1,1) PRIMARY KEY,

&nbsp;   IdCliente INT NOT NULL,

&nbsp;   IdCarro INT NOT NULL,

&nbsp;   Status VARCHAR(50) NOT NULL,

&nbsp;   DataRetirada DATETIME NOT NULL,

&nbsp;   DataDevolucao DATETIME NOT NULL,



&nbsp;   FOREIGN KEY (IdCliente) REFERENCES Cliente(Id),

&nbsp;   FOREIGN KEY (IdCarro) REFERENCES Carro(Id)

);



**INSERT EXEMPLO Cliente:**



INSERT INTO Cliente

(Nome, Email, Sexo, Cpf, DataNascimento, TipoUsuario)

VALUES

('João Silva', 'joao@email.com', 'M', '12345678901', '2000-05-10', 'Comum');



**INSERT EXEMPLO Carro:**



INSERT INTO Carro

(Modelo, Marca, Cor, Preco, Ano, Categoria)

VALUES

('Civic', 'Honda', 'Preto', 95000.00, 2022, 'Ouro');



**INSERT EXEMPLO Empréstimo:**



INSERT INTO Emprestimos

(IdCliente, IdCarro, Status, DataRetirada, DataDevolucao)

VALUES

(1, 1, 'Ativo', GETDATE(), DATEADD(DAY, 9, GETDATE()));



