using Furiza.Base.Core.Exceptions;

namespace Furiza.Base.Core.Domain.BR.Exceptions
{
    public class CpfInvalidoException : CoreException
    {
        public override string Key => "CpfInvalido";
        public override string Message => "O CPF fornecido está em branco, é inválido ou está em um formato inválido.";
    }
}