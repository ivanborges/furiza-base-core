using Furiza.Base.Core.Domain.BR.Exceptions;
using Furiza.Base.Core.SeedWork;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Furiza.Base.Core.Domain.BR.ValueObjects
{
    public sealed class Cnpj : ValueObject
    {
        public string Numero { get; }
        public string NumeroComMascara => 
            !string.IsNullOrEmpty(Numero)
            ? Convert.ToUInt64(Numero).ToString(@"00\.000\.000\/0000\-00")
            : string.Empty;

        public Cnpj(string cnpj)
        {
            Numero = cnpj?.Trim().Replace(".", "").Replace("-", "").Replace("/", "");
            if (!EValido())
                throw new CnpjInvalidoException();
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

            if (Numero.Length != 14 || !Numero.All(char.IsDigit))
                return false;

            var multiplicador1 = new int[12] { 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            var multiplicador2 = new int[13] { 6, 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            var soma = 0;
            var resto = 0;

            var valorTemp = Numero.Substring(0, 12);

            for (int i = 0; i < 12; i++)
                soma += int.Parse(valorTemp[i].ToString()) * multiplicador1[i];
            resto = (soma % 11);

            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;

            var digito = resto.ToString();
            valorTemp = valorTemp + digito;

            soma = 0;
            for (int i = 0; i < 13; i++)
                soma += int.Parse(valorTemp[i].ToString()) * multiplicador2[i];
            resto = (soma % 11);

            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;

            digito = digito + resto.ToString();

            return Numero.EndsWith(digito);
        }

        public static implicit operator Cnpj(string text) => new Cnpj(text);
        public static implicit operator string(Cnpj cnpj) => cnpj.Numero;
    }
}