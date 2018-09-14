using FF.Base.Core.Exceptions;

namespace FF.Base.Core.Domain.Exceptions
{
    public class CpfInvalidoException : CoreException
    {
        public override string Key => "CpfInvalido";
        public override string Message => "O CPF fornecido está em branco, é inválido ou está em um formato inválido.";
    }
}