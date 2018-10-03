using Furiza.Base.Core.Exceptions;

namespace Furiza.Base.Core.Domain.BR.Exceptions
{
    public class CnpjInvalidoException : CoreException
    {
        public override string Key => "CnpjInvalido";
        public override string Message => "O CNPJ fornecido está em branco, é inválido ou está em um formato inválido.";
    }
}