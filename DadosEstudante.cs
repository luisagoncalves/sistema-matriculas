using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaMatricula
{
    public class DadosEstudante
    {
        public string Nome { get; private set; }
        public string Matricula { get; private set; }
        public string Disciplina { get; private set; }

        public DadosEstudante(string nome, string matricula, string disciplina)
        {
            if (string.IsNullOrEmpty(nome))
            {
                throw new Exception("Os campos são obrigatórios!");
            }
            if (string.IsNullOrEmpty(matricula))
            {
                throw new Exception("Os campos são obrigatórios!");
            }
            if (string.IsNullOrEmpty(disciplina))
            {
                throw new Exception("Os campos são obrigatórios!");
            }

            Nome = nome;
            Matricula = matricula;
            Disciplina = disciplina;
        }

    }
}
