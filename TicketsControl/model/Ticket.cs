using System;
using System.Collections.Generic;
using System.Xml;

namespace TicketsControl.model {

    public class Ticket : ICloneable {

        public Ticket() {
        }

        public Ticket(Ticket ticket) {
            Id = ticket.Id;
            Quantidade = ticket.Quantidade;
            Empregado = ticket.Empregado;
            Situacao = ticket.Situacao;
            DataEntrega = ticket.DataEntrega;
        }

        public int Id { get; set; }
        public int Quantidade { get; set; }
        public Empregado Empregado { get; set; }
        public bool Situacao { get; set; }
        public DateTime DataEntrega { get; set; }

        public object Clone() {
            return new Ticket(this);
        }

        public override bool Equals(object obj) {
            return obj is Ticket ticket &&
                   Id == ticket.Id &&
                   Quantidade == ticket.Quantidade &&
                   EqualityComparer<Empregado>.Default.Equals(Empregado, ticket.Empregado) &&
                   Situacao == ticket.Situacao &&
                   DataEntrega == ticket.DataEntrega;
        }

        public override int GetHashCode() {
            int hashCode = -227498395;
            hashCode = hashCode * -1521134295 + Id.GetHashCode();
            hashCode = hashCode * -1521134295 + Quantidade.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<Empregado>.Default.GetHashCode(Empregado);
            hashCode = hashCode * -1521134295 + Situacao.GetHashCode();
            hashCode = hashCode * -1521134295 + DataEntrega.GetHashCode();
            return hashCode;
        }
    }
}
