using System;
using System.Collections.Generic;

namespace TicketsControl.model {
    public class Empregado : ICloneable {

        private string nome;
        private string cpf;
        private bool situacao;
        private DateTime dataUltimaAlteracao;

        public Empregado() {
        }

        private Empregado(Empregado empregado) {
            this.Id = empregado.Id;
            this.Nome(empregado.Nome());
            this.cpf = empregado.cpf;
            this.situacao= empregado.situacao;
            this.dataUltimaAlteracao = empregado.dataUltimaAlteracao;
        }

        public int Id { get; set; }

        public string Nome() {
            return nome;
        }

        public void Nome(string nome) {
            this.nome = nome;
        }

        public string Cpf { get { return cpf; } set { cpf = value; } }

        public bool Situacao { get { return situacao; } set { situacao = value; } }

        public DateTime DataUltimaAlteracao { get { return dataUltimaAlteracao; } set { dataUltimaAlteracao = value; } }

        public object Clone() {
            return new Empregado(this);
        }

        public override bool Equals(object obj) {
            return obj is Empregado empregado &&
                   nome == empregado.nome &&
                   cpf == empregado.cpf &&
                   situacao == empregado.situacao &&
                   Id == empregado.Id &&
                   Cpf == empregado.Cpf &&
                   Situacao == empregado.Situacao;
        }

        public override int GetHashCode() {
            int hashCode = 1623162058;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(nome);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(cpf);
            hashCode = hashCode * -1521134295 + situacao.GetHashCode();
            hashCode = hashCode * -1521134295 + Id.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Cpf);
            hashCode = hashCode * -1521134295 + Situacao.GetHashCode();
            return hashCode;
        }

        public override string ToString() {
            return nome + " - " + cpf;
        }

    }

}
