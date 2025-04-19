-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Tempo de geração: 11-Dez-2024 às 13:40
-- Versão do servidor: 10.4.25-MariaDB
-- versão do PHP: 8.1.10

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Banco de dados: `gocompany`
--

-- --------------------------------------------------------

--
-- Estrutura da tabela `clientes`
--

CREATE TABLE `clientes` (
  `idcliente` int(3) NOT NULL,
  `nome` varchar(100) NOT NULL,
  `senha` text NOT NULL,
  `tipagem` varchar(10) DEFAULT NULL,
  `email` text NOT NULL,
  `cpf` varchar(14) NOT NULL,
  `rg` text NOT NULL,
  `estado` text NOT NULL,
  `genero` text NOT NULL,
  `data_nascimento` date DEFAULT current_timestamp(),
  `idade` int(3) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estrutura da tabela `funcionarios`
--

CREATE TABLE `funcionarios` (
  `id` int(11) NOT NULL,
  `nome` text NOT NULL,
  `cpf` varchar(11) NOT NULL,
  `senha` varchar(30) NOT NULL,
  `funcao` text NOT NULL,
  `nacionalidade` text DEFAULT NULL,
  `genero` char(1) DEFAULT NULL,
  `sexualidade` text NOT NULL,
  `viagens_feitas_na_empresa` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Extraindo dados da tabela `funcionarios`
--

INSERT INTO `funcionarios` (`id`, `nome`, `cpf`, `senha`, `funcao`, `nacionalidade`, `genero`, `sexualidade`, `viagens_feitas_na_empresa`) VALUES
(46, 'João Silva', '12345678900', 'P@ssw0rd!2024Secure12345', 'Gerente', 'Brasileiro', 'M', 'Heterossexual', 0),
(47, 'Maria Oliveira', '98765432100', 'Str0ng!P@ss5678Word9876', 'Gerente', 'Brasileiro', 'F', 'Heterossexual', 0),
(48, 'Carlos Pereira', '23456789000', 'Uniqu3P@ssw0rd0987!234', 'Piloto', 'Brasileiro', 'M', 'Heterossexual', 3),
(49, 'Ana Santos', '34567890100', 'S@feP@ssw0rd!5678Uniqu3', 'Comissário', 'Argentino', 'F', 'Heterossexual', 2),
(50, 'Luiz Almeida', '45678901200', 'S3cure!P@ss2345WordUni!', 'Copiloto', 'Chileno', 'M', 'Homossexual', 6);

-- --------------------------------------------------------

--
-- Estrutura da tabela `passagens`
--

CREATE TABLE `passagens` (
  `id` int(11) NOT NULL,
  `id_piloto` int(11) NOT NULL,
  `id_copiloto` int(11) NOT NULL,
  `id_comissaria1` int(11) NOT NULL,
  `id_comissaria2` int(11) NOT NULL,
  `id_comissaria3` int(11) NOT NULL,
  `imagem_destino` blob NOT NULL,
  `destino` text NOT NULL,
  `local_partida` text NOT NULL,
  `valor_economica` decimal(10,0) NOT NULL,
  `valor_luxo` decimal(10,0) NOT NULL,
  `data_hora_partida` datetime NOT NULL,
  `data_hora_chegada` datetime NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estrutura da tabela `passagens_canceladas`
--

CREATE TABLE `passagens_canceladas` (
  `id` int(11) NOT NULL,
  `id_passagens` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Índices para tabelas despejadas
--

--
-- Índices para tabela `clientes`
--
ALTER TABLE `clientes`
  ADD PRIMARY KEY (`idcliente`);

--
-- Índices para tabela `funcionarios`
--
ALTER TABLE `funcionarios`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `senha` (`senha`);

--
-- Índices para tabela `passagens`
--
ALTER TABLE `passagens`
  ADD PRIMARY KEY (`id`),
  ADD KEY `id_piloto` (`id_piloto`),
  ADD KEY `id_copiloto` (`id_copiloto`),
  ADD KEY `id_comissaria1` (`id_comissaria1`),
  ADD KEY `id_comissaria2` (`id_comissaria2`),
  ADD KEY `id_comissaria3` (`id_comissaria3`);

--
-- Índices para tabela `passagens_canceladas`
--
ALTER TABLE `passagens_canceladas`
  ADD PRIMARY KEY (`id`),
  ADD KEY `id_passagens` (`id_passagens`);

--
-- AUTO_INCREMENT de tabelas despejadas
--

--
-- AUTO_INCREMENT de tabela `clientes`
--
ALTER TABLE `clientes`
  MODIFY `idcliente` int(3) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de tabela `funcionarios`
--
ALTER TABLE `funcionarios`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=51;

--
-- AUTO_INCREMENT de tabela `passagens`
--
ALTER TABLE `passagens`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=16;

--
-- AUTO_INCREMENT de tabela `passagens_canceladas`
--
ALTER TABLE `passagens_canceladas`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;

--
-- Restrições para despejos de tabelas
--

--
-- Limitadores para a tabela `passagens`
--
ALTER TABLE `passagens`
  ADD CONSTRAINT `id_comissaria1` FOREIGN KEY (`id_comissaria1`) REFERENCES `funcionarios` (`id`),
  ADD CONSTRAINT `id_comissaria2` FOREIGN KEY (`id_comissaria2`) REFERENCES `funcionarios` (`id`),
  ADD CONSTRAINT `id_comissaria3` FOREIGN KEY (`id_comissaria3`) REFERENCES `funcionarios` (`id`),
  ADD CONSTRAINT `id_copiloto` FOREIGN KEY (`id_copiloto`) REFERENCES `funcionarios` (`id`),
  ADD CONSTRAINT `id_piloto` FOREIGN KEY (`id_piloto`) REFERENCES `funcionarios` (`id`);

--
-- Limitadores para a tabela `passagens_canceladas`
--
ALTER TABLE `passagens_canceladas`
  ADD CONSTRAINT `passagens_canceladas_ibfk_1` FOREIGN KEY (`id_passagens`) REFERENCES `passagens` (`id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
