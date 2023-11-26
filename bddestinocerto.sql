-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Tempo de geração: 26/06/2023 às 23:49
-- Versão do servidor: 10.4.28-MariaDB
-- Versão do PHP: 8.2.4

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Banco de dados: `bddestinocerto`
--

-- --------------------------------------------------------

--
-- Estrutura para tabela `pacotes`
--

CREATE TABLE `pacotes` (
  `Id` int(11) NOT NULL,
  `Nome` varchar(80) NOT NULL,
  `Origem` varchar(21) NOT NULL,
  `Destino` varchar(21) NOT NULL,
  `Atrativos` varchar(200) NOT NULL,
  `Saida` date NOT NULL,
  `Retorno` date NOT NULL,
  `Usuario` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Despejando dados para a tabela `pacotes`
--

INSERT INTO `pacotes` (`Id`, `Nome`, `Origem`, `Destino`, `Atrativos`, `Saida`, `Retorno`, `Usuario`) VALUES
(9, 'Pacote de viagem', 'Rio de Janeiro', 'Gramado', 'Café da manhã; hospedagem', '2023-10-01', '2023-10-06', 0);

-- --------------------------------------------------------

--
-- Estrutura para tabela `usuario`
--

CREATE TABLE `usuario` (
  `ID` int(11) NOT NULL,
  `Nome` varchar(80) NOT NULL,
  `Login` varchar(80) NOT NULL,
  `Senha` varchar(32) NOT NULL,
  `Nascimento` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Despejando dados para a tabela `usuario`
--

INSERT INTO `usuario` (`ID`, `Nome`, `Login`, `Senha`, `Nascimento`) VALUES
(1, 'Lucas Tavares', 'lucas.tavares', '27725966', '1998-06-15'),
(2, 'Lucas Tavares', 'lucas', '2772', '1998-06-15');

--
-- Índices para tabelas despejadas
--

--
-- Índices de tabela `pacotes`
--
ALTER TABLE `pacotes`
  ADD PRIMARY KEY (`Id`),
  ADD KEY `Usuario` (`Usuario`);

--
-- Índices de tabela `usuario`
--
ALTER TABLE `usuario`
  ADD PRIMARY KEY (`ID`);

--
-- AUTO_INCREMENT para tabelas despejadas
--

--
-- AUTO_INCREMENT de tabela `pacotes`
--
ALTER TABLE `pacotes`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10;

--
-- AUTO_INCREMENT de tabela `usuario`
--
ALTER TABLE `usuario`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
