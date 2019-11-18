using System;

namespace Restaurante.Domain.Entities
{
    public class Restaurante : Entity
    {
        public Restaurante () { }

        public Restaurante (int id, String nome, String endereco, String bairro, String cidade, String estado)
        {
            this.id = id;
            this.nome = nome;
            this.endereco = endereco;
            this.bairro = bairro;
            this.cidade = cidade;
            this.estado = estado;
        }

        public int id { get; set; }
        public String nome { get; set; }
        public String endereco { get; set; }
        public String bairro { get; set; }
        public String cidade { get; set; }
        public String estado { get; set; }
        public Consumo consumo { get; set; }
    }
}