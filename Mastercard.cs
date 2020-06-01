using System;

namespace aula07Encapsulamento
{
    public class Mastercard : Cartão
    {
        public int parcelas { get; set; }
        /// <summary>
        /// aplicaçao do desconto e numero e parcelas
        /// </summary>
        /// <param name="desconto e parcela"></param>
        public void ComprarComDescontoMastercard(float desconto){
            Console.WriteLine($"Aplicando desconto de {desconto}, no total de {parcelas} parcelas");

            //protectec na classe cartao//
            cvc = 456;

            Console.WriteLine($"Aplicado desconto de {desconto}, no total de {parcelas} parcelas");
            //sempre usar o using system pra usar o console nas classes fora do program
        }
    }
}