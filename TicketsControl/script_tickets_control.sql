-- Inicio do script para criação da base de dados bem como tabelas e regras:
CREATE DATABASE db_ticketscontrol;
PRINT 'Base de dados criada para o TicketsControl';
GO
USE db_ticketscontrol;

CREATE TABLE empregado (
	id INTEGER PRIMARY KEY IDENTITY NOT NULL,
	nome VARCHAR(100) NOT NULL,
	cpf VARCHAR(15) NOT NULL,
	situacao CHAR(01) DEFAULT 'A' NOT NULL,
	ultimaAlteracao DATETIME,

	CONSTRAINT ch_empregado_ativo CHECK (situacao IN ('A', 'I'))
);

CREATE TABLE ticket (
	id INTEGER PRIMARY KEY IDENTITY NOT NULL,
	quantidade INT NOT NULL,
	idEmpregado int NOT NULL,
	situacao CHAR(01) DEFAULT 'A' NOT NULL,
	dataEntrega DATETIME DEFAULT GETDATE() NOT NULL,

	CONSTRAINT ch_ticket_ativo CHECK (situacao IN ('A', 'I'))
);

ALTER TABLE empregado ADD CONSTRAINT uq_empregado_cpf UNIQUE (cpf);
ALTER TABLE empregado ADD CONSTRAINT ch_empregado_cpf CHECK (cpf <> '');
ALTER TABLE empregado ADD CONSTRAINT ch_empregado_nome CHECK (nome <> '');

ALTER TABLE ticket ADD CONSTRAINT fk_empregado FOREIGN KEY (idEmpregado) REFERENCES empregado(id);

-- A partir disso já é possível executar o aplicativo se desejar.

-- Geração de dados para melhor experiência:
INSERT INTO empregado(nome, cpf, situacao, ultimaAlteracao) VALUES ('Fulano de Tal', '12345678900', 'A', CONVERT(DATETIME, '2023-02-28 13:42:52.663', 121));
INSERT INTO empregado(nome, cpf, situacao, ultimaAlteracao) VALUES ('Ciclano Montana', '12345678901', 'A', CONVERT(DATETIME, '2023-02-28 22:50:00.630', 121));
INSERT INTO empregado(nome, cpf, situacao, ultimaAlteracao) VALUES ('Magno Claudio', '12345678902', 'A', (DATEADD(day,-2,GETDATE())));
INSERT INTO empregado(nome, cpf, situacao, ultimaAlteracao) VALUES ('Caio Roger', '12345678903', 'I', CONVERT(DATETIME, '2023-02-28 22:50:00.630', 121));
INSERT INTO empregado(nome, cpf, situacao, ultimaAlteracao) VALUES ('Ângela Clara', '12345678904', 'A', (DATEADD(day,-4,GETDATE())));
INSERT INTO empregado(nome, cpf, situacao, ultimaAlteracao) VALUES ('Beltrano Melo', '12345678905', 'I', CONVERT(DATETIME, '2023-02-21 15:29:59.340', 121));
INSERT INTO empregado(nome, cpf, situacao, ultimaAlteracao) VALUES ('Juca Bala', '12345678906', 'A', (DATEADD(day,-6,GETDATE())));
INSERT INTO empregado(nome, cpf, situacao, ultimaAlteracao) VALUES ('Mirian Leno', '12345678907', 'A', (DATEADD(day,-8,GETDATE())));
INSERT INTO empregado(nome, cpf, situacao, ultimaAlteracao) VALUES ('Danilo Barros Lima', '92838487213', 'A', CONVERT(DATETIME, '2023-02-28 22:38:57.180', 121));
INSERT INTO empregado(nome, cpf, situacao, ultimaAlteracao) VALUES ('Gabriela Rocha Dias', '38681822411', 'I', (DATEADD(day,-10,GETDATE())));
INSERT INTO empregado(nome, cpf, situacao, ultimaAlteracao) VALUES ('Leonardo Goncalves Araujo', '62723207528', 'A', (DATEADD(day,-12,GETDATE())));
INSERT INTO empregado(nome, cpf, situacao, ultimaAlteracao) VALUES ('Júlio Goncalves Oliveira', '30268780730', 'I', (DATEADD(day,-14,GETDATE())));
INSERT INTO empregado(nome, cpf, situacao, ultimaAlteracao) VALUES ('João Costa Ferreira', '19405966103', 'I', (DATEADD(day,-16,GETDATE())));
INSERT INTO empregado(nome, cpf, situacao, ultimaAlteracao) VALUES ('Amanda Rodrigues Cunha', '33192474092', 'A', (DATEADD(day,-25,GETDATE())));
INSERT INTO empregado(nome, cpf, situacao, ultimaAlteracao) VALUES ('Joao Correia Almeida', '11288614020', 'A', (DATEADD(day,-25,GETDATE())));
INSERT INTO empregado(nome, cpf, situacao, ultimaAlteracao) VALUES ('Guilherme Melo Araujo', '24017241336', 'A', (DATEADD(day,-15,GETDATE())));
INSERT INTO empregado(nome, cpf, situacao, ultimaAlteracao) VALUES ('Sofia Alves Dias', '92304936601', 'I', (DATEADD(day,-8,GETDATE())));
INSERT INTO empregado(nome, cpf, situacao, ultimaAlteracao) VALUES ('Marisa Barbosa Melo', '17872808706', 'I', (DATEADD(day,-4,GETDATE())));
INSERT INTO empregado(nome, cpf, situacao, ultimaAlteracao) VALUES ('Ana Oliveira Sousa', '89825648104', 'A', (DATEADD(day,-3,GETDATE())));
INSERT INTO empregado(nome, cpf, situacao, ultimaAlteracao) VALUES ('Lucas Pereira', '43014478652', 'A', null);
INSERT INTO empregado(nome, cpf, situacao, ultimaAlteracao) VALUES ('Carolina Araújo', '32811344403', 'A', null);
INSERT INTO empregado(nome, cpf, situacao, ultimaAlteracao) VALUES ('Bianca Melo', '65021383736', 'A', null);
INSERT INTO empregado(nome, cpf, situacao, ultimaAlteracao) VALUES ('Mirella da Cruz', '84232762280', 'I', null);
INSERT INTO empregado(nome, cpf, situacao, ultimaAlteracao) VALUES ('Lívia Mendes', '62135322776', 'I', null);
INSERT INTO empregado(nome, cpf, situacao, ultimaAlteracao) VALUES ('Luiz Miguel Azevedo', '02646022344', 'A', null);
INSERT INTO empregado(nome, cpf, situacao, ultimaAlteracao) VALUES ('Mariana Cavalcanti', '10126734569', 'I', null);
INSERT INTO empregado(nome, cpf, situacao, ultimaAlteracao) VALUES ('Carlos Eduardo Fernandes', '08212143066', 'A', null);
INSERT INTO empregado(nome, cpf, situacao, ultimaAlteracao) VALUES ('Srta. Rebeca Alves', '12438552743', 'A', null);
INSERT INTO empregado(nome, cpf, situacao, ultimaAlteracao) VALUES ('Julia Barbosa', '67671028738', 'A', null);
INSERT INTO empregado(nome, cpf, situacao, ultimaAlteracao) VALUES ('Fernando Teixeira', '18703658287', 'A', null);
INSERT INTO empregado(nome, cpf, situacao, ultimaAlteracao) VALUES ('Lucca da Cunha', '41025744683', 'A', null);
INSERT INTO empregado(nome, cpf, situacao, ultimaAlteracao) VALUES ('Ana Júlia Aragão', '55504413575', 'A', null);
INSERT INTO empregado(nome, cpf, situacao, ultimaAlteracao) VALUES ('Emanuel Farias', '47152420360', 'A', null);
INSERT INTO empregado(nome, cpf, situacao, ultimaAlteracao) VALUES ('Alexia Vieira', '23242841034', 'I', null);
INSERT INTO empregado(nome, cpf, situacao, ultimaAlteracao) VALUES ('Marcelo Martins', '34324104506', 'I', null);
INSERT INTO empregado(nome, cpf, situacao, ultimaAlteracao) VALUES ('Srta. Gabrielly Cardoso', '50104478357', 'A', null);
INSERT INTO empregado(nome, cpf, situacao, ultimaAlteracao) VALUES ('Daniel Gonçalves', '76160163752', 'A', null);
INSERT INTO empregado(nome, cpf, situacao, ultimaAlteracao) VALUES ('Nina da Cruz', '37312486460', 'A', null);
INSERT INTO empregado(nome, cpf, situacao, ultimaAlteracao) VALUES ('Guilherme Monteiro', '66645424477', 'A', null);
INSERT INTO empregado(nome, cpf, situacao, ultimaAlteracao) VALUES ('Otávio Ribeiro', '87116858750', 'I', null);
INSERT INTO empregado(nome, cpf, situacao, ultimaAlteracao) VALUES ('Pedro Miguel Souza', '80182763587', 'I', null);
INSERT INTO empregado(nome, cpf, situacao, ultimaAlteracao) VALUES ('Bruna Gomes', '67623154613', 'A', null);
INSERT INTO empregado(nome, cpf, situacao, ultimaAlteracao) VALUES ('Benício Ribeiro', '32553228040', 'I', null);
INSERT INTO empregado(nome, cpf, situacao, ultimaAlteracao) VALUES ('Beatriz Campos', '82521605654', 'A', null);
INSERT INTO empregado(nome, cpf, situacao, ultimaAlteracao) VALUES ('Diego da Costa', '26535643190', 'A', null);
INSERT INTO empregado(nome, cpf, situacao, ultimaAlteracao) VALUES ('Lucca Campos', '52345851740', 'A', null);
INSERT INTO empregado(nome, cpf, situacao, ultimaAlteracao) VALUES ('Srta. Laís Freitas', '12054654302', 'I', null);
INSERT INTO empregado(nome, cpf, situacao, ultimaAlteracao) VALUES ('Otávio Duarte', '42430442442', 'I', null);
INSERT INTO empregado(nome, cpf, situacao, ultimaAlteracao) VALUES ('Dra. Evelyn da Cunha', '15250488560', 'A', null);
INSERT INTO empregado(nome, cpf, situacao, ultimaAlteracao) VALUES ('Brenda Rezende', '16118571805', 'A', null);
INSERT INTO empregado(nome, cpf, situacao, ultimaAlteracao) VALUES ('Luiz Gustavo Araújo', '04580656091', 'A', null);
INSERT INTO empregado(nome, cpf, situacao, ultimaAlteracao) VALUES ('Dra. Amanda Gonçalves', '24605325719', 'I', null);
INSERT INTO empregado(nome, cpf, situacao, ultimaAlteracao) VALUES ('João Miguel da Mata', '15155734606', 'I', null);
INSERT INTO empregado(nome, cpf, situacao, ultimaAlteracao) VALUES ('Stella Rezende', '34535552444', 'A', null);

INSERT INTO ticket (quantidade, idEmpregado, situacao, dataEntrega) VALUES ((SELECT FLOOR(RAND()*(20-1+1))+10), (SELECT id FROM empregado WHERE cpf = '12345678903'), 'I', CONVERT(DATETIME, '2023-02-28 23:10:01.435', 121));
INSERT INTO ticket (quantidade, idEmpregado, situacao, dataEntrega) VALUES ((SELECT FLOOR(RAND()*(20-1+1))+10), (SELECT id FROM empregado WHERE cpf = '12345678905'), 'I', CONVERT(DATETIME, '2023-02-22 14:19:50.521', 121));
INSERT INTO ticket (quantidade, idEmpregado, situacao, dataEntrega) VALUES ((SELECT FLOOR(RAND()*(20-1+1))+10), (SELECT id FROM empregado WHERE cpf = '38681822411'), 'I', (DATEADD(day, -10, GETDATE())));
INSERT INTO ticket (quantidade, idEmpregado, situacao, dataEntrega) VALUES ((SELECT FLOOR(RAND()*(20-1+1))+10), (SELECT id FROM empregado WHERE cpf = '30268780730'), 'I', (DATEADD(day, -14, GETDATE())));
INSERT INTO ticket (quantidade, idEmpregado, situacao, dataEntrega) VALUES ((SELECT FLOOR(RAND()*(20-1+1))+10), (SELECT id FROM empregado WHERE cpf = '19405966103'), 'I', (DATEADD(day, -16, GETDATE())));
INSERT INTO ticket (quantidade, idEmpregado, situacao, dataEntrega) VALUES ((SELECT FLOOR(RAND()*(20-1+1))+10), (SELECT id FROM empregado WHERE cpf = '92304936601'), 'I', (DATEADD(day, -8, GETDATE())));
INSERT INTO ticket (quantidade, idEmpregado, situacao, dataEntrega) VALUES ((SELECT FLOOR(RAND()*(20-1+1))+10), (SELECT id FROM empregado WHERE cpf = '17872808706'), 'I', (DATEADD(day, -4, GETDATE())));
INSERT INTO ticket (quantidade, idEmpregado, situacao, dataEntrega) VALUES ((SELECT FLOOR(RAND()*(20-1+1))+10), (SELECT id FROM empregado WHERE cpf = '84232762280'), 'I', (DATEADD(day, -180, GETDATE())));
INSERT INTO ticket (quantidade, idEmpregado, situacao, dataEntrega) VALUES ((SELECT FLOOR(RAND()*(20-1+1))+10), (SELECT id FROM empregado WHERE cpf = '62135322776'), 'I', (DATEADD(day, -210, GETDATE())));
INSERT INTO ticket (quantidade, idEmpregado, situacao, dataEntrega) VALUES ((SELECT FLOOR(RAND()*(20-1+1))+10), (SELECT id FROM empregado WHERE cpf = '10126734569'), 'I', (DATEADD(day, -240, GETDATE())));
INSERT INTO ticket (quantidade, idEmpregado, situacao, dataEntrega) VALUES ((SELECT FLOOR(RAND()*(20-1+1))+10), (SELECT id FROM empregado WHERE cpf = '23242841034'), 'I', (DATEADD(day, 0, GETDATE())));
INSERT INTO ticket (quantidade, idEmpregado, situacao, dataEntrega) VALUES ((SELECT FLOOR(RAND()*(20-1+1))+10), (SELECT id FROM empregado WHERE cpf = '12345678900'), 'I', CONVERT(DATETIME, '2023-03-01 10:42:23.336', 121));
INSERT INTO ticket (quantidade, idEmpregado, situacao, dataEntrega) VALUES ((SELECT FLOOR(RAND()*(20-1+1))+10), (SELECT id FROM empregado WHERE cpf = '12345678901'), 'I', CONVERT(DATETIME, '2023-03-01 09:15:01.102', 121));
INSERT INTO ticket (quantidade, idEmpregado, situacao, dataEntrega) VALUES ((SELECT FLOOR(RAND()*(20-1+1))+10), (SELECT id FROM empregado WHERE cpf = '12345678902'), 'I', (DATEADD(day, 0, GETDATE())));
INSERT INTO ticket (quantidade, idEmpregado, situacao, dataEntrega) VALUES ((SELECT FLOOR(RAND()*(20-1+1))+10), (SELECT id FROM empregado WHERE cpf = '12345678904'), 'I', (DATEADD(day, -1, GETDATE())));
INSERT INTO ticket (quantidade, idEmpregado, situacao, dataEntrega) VALUES ((SELECT FLOOR(RAND()*(20-1+1))+10), (SELECT id FROM empregado WHERE cpf = '12345678906'), 'I', (DATEADD(day, -4, GETDATE())));
INSERT INTO ticket (quantidade, idEmpregado, situacao, dataEntrega) VALUES ((SELECT FLOOR(RAND()*(20-1+1))+10), (SELECT id FROM empregado WHERE cpf = '62723207528'), 'I', (DATEADD(day, -5, GETDATE())));
INSERT INTO ticket (quantidade, idEmpregado, situacao, dataEntrega) VALUES ((SELECT FLOOR(RAND()*(20-1+1))+10), (SELECT id FROM empregado WHERE cpf = '33192474092'), 'I', (DATEADD(day, -22, GETDATE())));
INSERT INTO ticket (quantidade, idEmpregado, situacao, dataEntrega) VALUES ((SELECT FLOOR(RAND()*(20-1+1))+10), (SELECT id FROM empregado WHERE cpf = '11288614020'), 'I', (DATEADD(day, -23, GETDATE())));
INSERT INTO ticket (quantidade, idEmpregado, situacao, dataEntrega) VALUES ((SELECT FLOOR(RAND()*(20-1+1))+10), (SELECT id FROM empregado WHERE cpf = '89825648104'), 'I', (DATEADD(day, -3, GETDATE())));
INSERT INTO ticket (quantidade, idEmpregado, situacao, dataEntrega) VALUES ((SELECT FLOOR(RAND()*(20-1+1))+10), (SELECT id FROM empregado WHERE cpf = '43014478652'), 'I', (DATEADD(day, -45, GETDATE())));
INSERT INTO ticket (quantidade, idEmpregado, situacao, dataEntrega) VALUES ((SELECT FLOOR(RAND()*(20-1+1))+10), (SELECT id FROM empregado WHERE cpf = '65021383736'), 'I', (DATEADD(day, -40, GETDATE())));
INSERT INTO ticket (quantidade, idEmpregado, situacao, dataEntrega) VALUES ((SELECT FLOOR(RAND()*(20-1+1))+10), (SELECT id FROM empregado WHERE cpf = '02646022344'), 'I', (DATEADD(day, -35, GETDATE())));
INSERT INTO ticket (quantidade, idEmpregado, situacao, dataEntrega) VALUES ((SELECT FLOOR(RAND()*(20-1+1))+10), (SELECT id FROM empregado WHERE cpf = '08212143066'), 'I', (DATEADD(day, -30, GETDATE())));
INSERT INTO ticket (quantidade, idEmpregado, situacao, dataEntrega) VALUES ((SELECT FLOOR(RAND()*(20-1+1))+10), (SELECT id FROM empregado WHERE cpf = '43014478652'), 'A', (DATEADD(day, -29, GETDATE())));
INSERT INTO ticket (quantidade, idEmpregado, situacao, dataEntrega) VALUES ((SELECT FLOOR(RAND()*(20-1+1))+10), (SELECT id FROM empregado WHERE cpf = '32811344403'), 'A', (DATEADD(day, -28, GETDATE())));
INSERT INTO ticket (quantidade, idEmpregado, situacao, dataEntrega) VALUES ((SELECT FLOOR(RAND()*(20-1+1))+10), (SELECT id FROM empregado WHERE cpf = '34535552444'), 'A', (DATEADD(day, -27, GETDATE())));
INSERT INTO ticket (quantidade, idEmpregado, situacao, dataEntrega) VALUES ((SELECT FLOOR(RAND()*(20-1+1))+10), (SELECT id FROM empregado WHERE cpf = '04580656091'), 'A', (DATEADD(day, -26, GETDATE())));
INSERT INTO ticket (quantidade, idEmpregado, situacao, dataEntrega) VALUES ((SELECT FLOOR(RAND()*(20-1+1))+10), (SELECT id FROM empregado WHERE cpf = '16118571805'), 'A', (DATEADD(day, -25, GETDATE())));
INSERT INTO ticket (quantidade, idEmpregado, situacao, dataEntrega) VALUES ((SELECT FLOOR(RAND()*(20-1+1))+10), (SELECT id FROM empregado WHERE cpf = '15250488560'), 'A', (DATEADD(day, -22, GETDATE())));
INSERT INTO ticket (quantidade, idEmpregado, situacao, dataEntrega) VALUES ((SELECT FLOOR(RAND()*(20-1+1))+10), (SELECT id FROM empregado WHERE cpf = '52345851740'), 'A', (DATEADD(day, -20, GETDATE())));
INSERT INTO ticket (quantidade, idEmpregado, situacao, dataEntrega) VALUES ((SELECT FLOOR(RAND()*(20-1+1))+10), (SELECT id FROM empregado WHERE cpf = '26535643190'), 'A', (DATEADD(day, -17, GETDATE())));
INSERT INTO ticket (quantidade, idEmpregado, situacao, dataEntrega) VALUES ((SELECT FLOOR(RAND()*(20-1+1))+10), (SELECT id FROM empregado WHERE cpf = '82521605654'), 'A', (DATEADD(day, -15, GETDATE())));
INSERT INTO ticket (quantidade, idEmpregado, situacao, dataEntrega) VALUES ((SELECT FLOOR(RAND()*(20-1+1))+10), (SELECT id FROM empregado WHERE cpf = '67623154613'), 'A', (DATEADD(day, -12, GETDATE())));
INSERT INTO ticket (quantidade, idEmpregado, situacao, dataEntrega) VALUES ((SELECT FLOOR(RAND()*(20-1+1))+10), (SELECT id FROM empregado WHERE cpf = '66645424477'), 'A', (DATEADD(day, -10, GETDATE())));
INSERT INTO ticket (quantidade, idEmpregado, situacao, dataEntrega) VALUES ((SELECT FLOOR(RAND()*(20-1+1))+10), (SELECT id FROM empregado WHERE cpf = '76160163752'), 'A', (DATEADD(day, -9, GETDATE())));
INSERT INTO ticket (quantidade, idEmpregado, situacao, dataEntrega) VALUES ((SELECT FLOOR(RAND()*(20-1+1))+10), (SELECT id FROM empregado WHERE cpf = '47152420360'), 'A', (DATEADD(day, -7, GETDATE())));
INSERT INTO ticket (quantidade, idEmpregado, situacao, dataEntrega) VALUES ((SELECT FLOOR(RAND()*(20-1+1))+10), (SELECT id FROM empregado WHERE cpf = '55504413575'), 'A', (DATEADD(day, -5, GETDATE())));
INSERT INTO ticket (quantidade, idEmpregado, situacao, dataEntrega) VALUES ((SELECT FLOOR(RAND()*(20-1+1))+10), (SELECT id FROM empregado WHERE cpf = '18703658287'), 'A', (DATEADD(day, -4, GETDATE())));
INSERT INTO ticket (quantidade, idEmpregado, situacao, dataEntrega) VALUES ((SELECT FLOOR(RAND()*(20-1+1))+10), (SELECT id FROM empregado WHERE cpf = '37312486460'), 'A', (DATEADD(day, -3, GETDATE())));
INSERT INTO ticket (quantidade, idEmpregado, situacao, dataEntrega) VALUES ((SELECT FLOOR(RAND()*(20-1+1))+10), (SELECT id FROM empregado WHERE cpf = '50104478357'), 'A', (DATEADD(day, -2, GETDATE())));
INSERT INTO ticket (quantidade, idEmpregado, situacao, dataEntrega) VALUES ((SELECT FLOOR(RAND()*(20-1+1))+10), (SELECT id FROM empregado WHERE cpf = '41025744683'), 'A', (DATEADD(day, -1, GETDATE())));
INSERT INTO ticket (quantidade, idEmpregado, situacao, dataEntrega) VALUES ((SELECT FLOOR(RAND()*(20-1+1))+10), (SELECT id FROM empregado WHERE cpf = '16118571805'), 'A', (DATEADD(day, -50, GETDATE())));
INSERT INTO ticket (quantidade, idEmpregado, situacao, dataEntrega) VALUES ((SELECT FLOOR(RAND()*(20-1+1))+10), (SELECT id FROM empregado WHERE cpf = '15250488560'), 'A', (DATEADD(day, -44, GETDATE())));
INSERT INTO ticket (quantidade, idEmpregado, situacao, dataEntrega) VALUES ((SELECT FLOOR(RAND()*(20-1+1))+10), (SELECT id FROM empregado WHERE cpf = '52345851740'), 'A', (DATEADD(day, -40, GETDATE())));
INSERT INTO ticket (quantidade, idEmpregado, situacao, dataEntrega) VALUES ((SELECT FLOOR(RAND()*(20-1+1))+10), (SELECT id FROM empregado WHERE cpf = '26535643190'), 'A', (DATEADD(day, -34, GETDATE())));
INSERT INTO ticket (quantidade, idEmpregado, situacao, dataEntrega) VALUES ((SELECT FLOOR(RAND()*(20-1+1))+10), (SELECT id FROM empregado WHERE cpf = '82521605654'), 'A', (DATEADD(day, -30, GETDATE())));
INSERT INTO ticket (quantidade, idEmpregado, situacao, dataEntrega) VALUES ((SELECT FLOOR(RAND()*(20-1+1))+10), (SELECT id FROM empregado WHERE cpf = '67623154613'), 'A', (DATEADD(day, -24, GETDATE())));
INSERT INTO ticket (quantidade, idEmpregado, situacao, dataEntrega) VALUES ((SELECT FLOOR(RAND()*(20-1+1))+10), (SELECT id FROM empregado WHERE cpf = '66645424477'), 'A', (DATEADD(day, -20, GETDATE())));
INSERT INTO ticket (quantidade, idEmpregado, situacao, dataEntrega) VALUES ((SELECT FLOOR(RAND()*(20-1+1))+10), (SELECT id FROM empregado WHERE cpf = '76160163752'), 'A', (DATEADD(day, -16, GETDATE())));
INSERT INTO ticket (quantidade, idEmpregado, situacao, dataEntrega) VALUES ((SELECT FLOOR(RAND()*(20-1+1))+10), (SELECT id FROM empregado WHERE cpf = '47152420360'), 'A', (DATEADD(day, -14, GETDATE())));
INSERT INTO ticket (quantidade, idEmpregado, situacao, dataEntrega) VALUES ((SELECT FLOOR(RAND()*(20-1+1))+10), (SELECT id FROM empregado WHERE cpf = '55504413575'), 'A', (DATEADD(day, -10, GETDATE())));
INSERT INTO ticket (quantidade, idEmpregado, situacao, dataEntrega) VALUES ((SELECT FLOOR(RAND()*(20-1+1))+10), (SELECT id FROM empregado WHERE cpf = '18703658287'), 'A', (DATEADD(day, -8, GETDATE())));
INSERT INTO ticket (quantidade, idEmpregado, situacao, dataEntrega) VALUES ((SELECT FLOOR(RAND()*(20-1+1))+10), (SELECT id FROM empregado WHERE cpf = '37312486460'), 'A', (DATEADD(day, -6, GETDATE())));
INSERT INTO ticket (quantidade, idEmpregado, situacao, dataEntrega) VALUES ((SELECT FLOOR(RAND()*(20-1+1))+10), (SELECT id FROM empregado WHERE cpf = '50104478357'), 'A', (DATEADD(day, -4, GETDATE())));
INSERT INTO ticket (quantidade, idEmpregado, situacao, dataEntrega) VALUES ((SELECT FLOOR(RAND()*(20-1+1))+10), (SELECT id FROM empregado WHERE cpf = '41025744683'), 'A', (DATEADD(day, -2, GETDATE())));
INSERT INTO ticket (quantidade, idEmpregado, situacao, dataEntrega) VALUES ((SELECT FLOOR(RAND()*(20-1+1))+10), (SELECT id FROM empregado WHERE cpf = '12345678903'), 'I', (DATEADD(day, -20, GETDATE())));
INSERT INTO ticket (quantidade, idEmpregado, situacao, dataEntrega) VALUES ((SELECT FLOOR(RAND()*(20-1+1))+10), (SELECT id FROM empregado WHERE cpf = '12345678905'), 'I', (DATEADD(day, -15, GETDATE())));
INSERT INTO ticket (quantidade, idEmpregado, situacao, dataEntrega) VALUES ((SELECT FLOOR(RAND()*(20-1+1))+10), (SELECT id FROM empregado WHERE cpf = '38681822411'), 'I', (DATEADD(day, -15, GETDATE())));
INSERT INTO ticket (quantidade, idEmpregado, situacao, dataEntrega) VALUES ((SELECT FLOOR(RAND()*(20-1+1))+10), (SELECT id FROM empregado WHERE cpf = '30268780730'), 'I', (DATEADD(day, -24, GETDATE())));
INSERT INTO ticket (quantidade, idEmpregado, situacao, dataEntrega) VALUES ((SELECT FLOOR(RAND()*(20-1+1))+10), (SELECT id FROM empregado WHERE cpf = '19405966103'), 'I', (DATEADD(day, -32, GETDATE())));
INSERT INTO ticket (quantidade, idEmpregado, situacao, dataEntrega) VALUES ((SELECT FLOOR(RAND()*(20-1+1))+10), (SELECT id FROM empregado WHERE cpf = '92304936601'), 'I', (DATEADD(day, -18, GETDATE())));
INSERT INTO ticket (quantidade, idEmpregado, situacao, dataEntrega) VALUES ((SELECT FLOOR(RAND()*(20-1+1))+10), (SELECT id FROM empregado WHERE cpf = '17872808706'), 'I', (DATEADD(day, -6, GETDATE())));
INSERT INTO ticket (quantidade, idEmpregado, situacao, dataEntrega) VALUES ((SELECT FLOOR(RAND()*(20-1+1))+10), (SELECT id FROM empregado WHERE cpf = '84232762280'), 'I', (DATEADD(day, -47, GETDATE())));
INSERT INTO ticket (quantidade, idEmpregado, situacao, dataEntrega) VALUES ((SELECT FLOOR(RAND()*(20-1+1))+10), (SELECT id FROM empregado WHERE cpf = '62135322776'), 'I', (DATEADD(day, -60, GETDATE())));
INSERT INTO ticket (quantidade, idEmpregado, situacao, dataEntrega) VALUES ((SELECT FLOOR(RAND()*(20-1+1))+10), (SELECT id FROM empregado WHERE cpf = '10126734569'), 'I', (DATEADD(day, -8, GETDATE())));
INSERT INTO ticket (quantidade, idEmpregado, situacao, dataEntrega) VALUES ((SELECT FLOOR(RAND()*(20-1+1))+10), (SELECT id FROM empregado WHERE cpf = '23242841034'), 'I', (DATEADD(day, -90, GETDATE())));
INSERT INTO ticket (quantidade, idEmpregado, situacao, dataEntrega) VALUES ((SELECT FLOOR(RAND()*(20-1+1))+10), (SELECT id FROM empregado WHERE cpf = '12345678900'), 'I', (DATEADD(day, -120, GETDATE())));
INSERT INTO ticket (quantidade, idEmpregado, situacao, dataEntrega) VALUES ((SELECT FLOOR(RAND()*(20-1+1))+10), (SELECT id FROM empregado WHERE cpf = '12345678901'), 'I', (DATEADD(day, -150, GETDATE())));
INSERT INTO ticket (quantidade, idEmpregado, situacao, dataEntrega) VALUES ((SELECT FLOOR(RAND()*(20-1+1))+10), (SELECT id FROM empregado WHERE cpf = '12345678902'), 'I', (DATEADD(day, -20, GETDATE())));
INSERT INTO ticket (quantidade, idEmpregado, situacao, dataEntrega) VALUES ((SELECT FLOOR(RAND()*(20-1+1))+10), (SELECT id FROM empregado WHERE cpf = '12345678904'), 'I', (DATEADD(day, -11, GETDATE())));
INSERT INTO ticket (quantidade, idEmpregado, situacao, dataEntrega) VALUES ((SELECT FLOOR(RAND()*(20-1+1))+10), (SELECT id FROM empregado WHERE cpf = '12345678906'), 'I', (DATEADD(day, -13, GETDATE())));
INSERT INTO ticket (quantidade, idEmpregado, situacao, dataEntrega) VALUES ((SELECT FLOOR(RAND()*(20-1+1))+10), (SELECT id FROM empregado WHERE cpf = '62723207528'), 'I', (DATEADD(day, -21, GETDATE())));
INSERT INTO ticket (quantidade, idEmpregado, situacao, dataEntrega) VALUES ((SELECT FLOOR(RAND()*(20-1+1))+10), (SELECT id FROM empregado WHERE cpf = '33192474092'), 'I', (DATEADD(day, -44, GETDATE())));
INSERT INTO ticket (quantidade, idEmpregado, situacao, dataEntrega) VALUES ((SELECT FLOOR(RAND()*(20-1+1))+10), (SELECT id FROM empregado WHERE cpf = '11288614020'), 'I', (DATEADD(day, -46, GETDATE())));
INSERT INTO ticket (quantidade, idEmpregado, situacao, dataEntrega) VALUES ((SELECT FLOOR(RAND()*(20-1+1))+10), (SELECT id FROM empregado WHERE cpf = '89825648104'), 'I', (DATEADD(day, -35, GETDATE())));


-- Duas consultinhas para ajudar a explorar rapidamente:

SELECT
	e.id AS 'Id',
	e.nome AS 'Nome completo',
	e.cpf AS 'Cadastro de pessoa física',
	e.situacao AS 'Situação',
	e.ultimaAlteracao AS 'Data da última alteração'
FROM empregado e
ORDER BY e.nome ASC;

SELECT
	t.id AS 'Id',
	e.nome AS 'Nome do empregado',
	t.quantidade AS 'Quantidade',
	t.situacao AS 'Situação',
	t.dataEntrega AS 'Data e hora da Entrega'
FROM ticket t
INNER JOIN empregado e ON t.idEmpregado = e.id
ORDER BY  e.nome ASC, t.dataEntrega ASC;

