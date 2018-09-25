using Furiza.Base.Core.Domain.BR.Exceptions;
using Furiza.Base.Core.SeedWork;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Furiza.Base.Core.Domain.BR.ValueObjects
{
    public sealed class Cpf : ValueObject
    {
        public string Numero { get; }
        public string NumeroComMascara =>
            !string.IsNullOrEmpty(Numero)
            ? Convert.ToUInt64(Numero).ToString(@"000\.000\.000\-00")
            : string.Empty;

        public Cpf(string cpf)
        {
            Numero = cpf?.Trim().Replace(".", "").Replace("-", "").PadLeft(11, '0');
            if (!EValido())
                throw new CpfInvalidoException();
        }

        protected override IEnumerable<object> GetAtomicValues()
        {
            yield return Numero;
            yield return NumeroComMascara;
        }

        public bool EValido()
        {
            if (string.IsNullOrWhiteSpace(Numero))
                return true;

            if (Numero.Length != 11 || !Numero.All(char.IsDigit))
                return false;

            var igual = true;
            for (int i = 1; i < 11 && igual; i++)
                if (Numero[i] != Numero[0])
                    igual = false;
            if (igual || Numero == "12345678909")
                return false;

            var multiplicador1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            var multiplicador2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            var soma = 0;
            var resto = 0;

            var valorTemp = Numero;

            for (int i = 0; i < 9; i++)
                soma += int.Parse(valorTemp[i].ToString()) * multiplicador1[i];
            resto = soma % 11;

            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;

            var digito = resto.ToString();
            valorTemp = valorTemp + digito;

            soma = 0;
            for (int i = 0; i < 10; i++)
                soma += int.Parse(valorTemp[i].ToString()) * multiplicador2[i];
            resto = soma % 11;

            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;

            digito = digito + resto.ToString();

            return Numero.EndsWith(digito);
        }

        public static implicit operator Cpf(string text) => new Cpf(text);
        public static implicit operator string(Cpf cpf) => cpf.Numero;
    }
}