using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioExceptions.Exceptions
{
    public class SaldoInsuficienteException : Exception
    {
        public SaldoInsuficienteException(string message) : base(message)
        {
        }
    }
}
