using System;

namespace DevIO.UI.Site.Models
{
    public class Aluno
    {
        public Aluno(string nome, string email, DateTime dataNascimento)
        {
            Id = Guid.NewGuid();
            Nome = nome;
            Email = email;
            DataNascimento = dataNascimento;
        }

        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public DateTime DataNascimento { get; set; }
    }
}
