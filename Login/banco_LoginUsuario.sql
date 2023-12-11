create database Cadastro

use Conexao

Create table Login
(
  Id NUMERIC(3) PRIMARY KEY NOT NULL,
  Usuario VARCHAR(40) NOT NULL,
  Senha VARCHAR(20) NOT NULL
)
INSERT INTO Usuario values ('joao.velho@gmail.com', 'spfc456')