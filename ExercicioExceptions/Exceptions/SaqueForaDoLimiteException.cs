using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioExceptions.Exceptions
{
    public class SaqueForaDoLimiteException : Exception
    {
        public SaqueForaDoLimiteException(string message) : base(message)
        {
        }
    }
}
