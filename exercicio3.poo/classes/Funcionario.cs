using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio3.poo.classes
{
    internal class Funcionario
    {
        int matricula;
        string nome;
        string cargoAtual;
        float salarioAtual;

        void cadastrar(int m,string n, string c, float s)
        {
            matricula = m;
            nome = n;
            cargoAtual = c;
            salarioAtual = s;
            Funcionario f = new Funcionario()
        }
        void consultar()
        {

        }
        void atualizarSalario(float novoSalario)
        {

        }
        void listarDependentes()
        {

        }
    }
}
