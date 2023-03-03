
	Objetivo desse projeto é criar um sisteminha onde seja possível controlar os tickets distribuidos para cada empregado/funcionário
	da organização.


	Empregado
		Id                  -> Not null and Primary Key
		Nome                -> Not Null
		CPF                 -> Not null
		Situacao            - Not null, aceitará A(ativo) ou I(inativo)
		DataUltimaAlteracao -> Somente será preenchida em caso de update
	
	Ticket
		Id          -> Not null and Primary Key
		IdEmpregado -> Not null and Foreign Key
		Quantidade  -> Not null
		Situacao    -> Not null, aceitará A(ativo) ou I(inativo)
		DataEntrega -> Not null, somente preenchida quando ocorrer o insert.
	

	Observe que há um relacionamento de um para muitos, ou seja, um empregado pode ter mais de um registro de ticket.


	No cadastro de empregado:
		Se registro é novo:
			Deve ser armazenado na base de dado sempre como ativo(A) e DataUltimaAlteracao como nula.

		Se registro é alterado:
			Deve ser armazenado na base de dados as devidas alterações porém setando a DataUltimaAlteracao como a data corrente.
		
		Em ambas as situações, o CPF deve ser validado, principalmente se já foi cadastrado.
			

	No cadastro de ticket:
		Se registro é novo:
			Deve ser armazenado na base de dados sempre como ativo(A) e DataEntrega como a data corrente.

		Se registro é alterado:
			Deve ser armazenado na base de dados as devidas alterações porém a DataEntrega não deve ser alterada.
			

	Nem registro deve ser deletado, excluído, por isso a ideia de se utilizar o campo situacao.
	
	
	Consultas/Relatórios
		É possível fazer consultas avançadas com vários filtros e em seguida se desejar exportar para uma planilha.
		Você também poderá contar com um campo totalizador de tickets com base na consulta efetuada.


	Com a criação desse projeto será possível: cadastrar, alterar, selecionar um empregado/funcionário, consultar e exportar
	para uma planilha do Excel os dados gerados.



	Para rodar o projeto:
		Há um arquivo de script para a criação da base de dados nesse link:
		https://github.com/rjewerling/estudo_de_c_sharp/blob/master/TicketsControl/script_tickets_control.sql
		
		O banco de dados utilizado foi o SQL Server 16.0.1050.5 - 2023
