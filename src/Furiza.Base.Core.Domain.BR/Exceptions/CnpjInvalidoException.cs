using Furiza.Base.Core.Exceptions;
using System;
using System.Runtime.Serialization;

namespace Furiza.Base.Core.Domain.BR.Exceptions
{
    [Serializable]
    public class CnpjInvalidoException : CoreException
    {
        public override string Key => "CnpjInvalido";
        public override string Message => "O CNPJ fornecido está em branco, é inválido ou está em um formato inválido.";

        public CnpjInvalidoException() : base()
        {
        }

        protected CnpjInvalidoException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}