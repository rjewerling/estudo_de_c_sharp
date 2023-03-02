using System;
using System.Windows.Forms;
using TicketsControl.model;
using TicketsControl.view;

namespace TicketsControl {

    internal static class Program {

        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new TicketsControlForm());
        }
    }
}

/***    anotações    ***

EmpregadoForm
    CPF: somente numeros e talvez formatação com pontuação.
	Situação: Quando salva pela primeira vez aceita como inativo.


	Verificar como proceder quando ultrapassa o tamanho do campo no banco.
	A exception é levantada. Acho que terá que tratar isso de alguma forma mais elegante.



*******              *******/