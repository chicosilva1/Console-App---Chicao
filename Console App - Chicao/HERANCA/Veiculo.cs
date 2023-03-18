using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_App___Chicao.HERANCA
{
    public class Veiculo
    {
        public int numeroAssentos;
        public int numeroPortas;
        public bool TemMotor;

    
   // public Veiculo(int numeroassentos, int numeroportas, bool temmotor)
   // {
       // numeroassentos = numeroAssentos;
       // numeroportas = numeroPortas;
       // temmotor = TemMotor;
    //}
       public string ExibirDados()
        {
            if(TemMotor == true) { 
            return "Com Motor.     "+ "Assentos: " + numeroAssentos + " Nº Portas: " + numeroPortas;
            }
            else { 
            return "Assentos: " + numeroAssentos + "  Nº Portas: " + numeroPortas;
            }

        }
    }
    
}
