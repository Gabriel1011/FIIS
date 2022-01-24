// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


double quoteValue = 10.05;
double quoteDiv = 0.09;
double startQuote =  600;//(int)(2000 / quoteValue);
double saldo = 0.0;
int anos = 5;
int investimentoTotal = (int)startQuote;

for (int i = 0; i < (12 * anos); i++)
{
  startQuote += 100;
  investimentoTotal += 100;

  var dividendos = startQuote * quoteDiv;


  var caixa = dividendos + saldo;

  if (caixa >= quoteValue)
  {
    int quantidadeParaCompra = (int)(caixa / quoteValue);
    if (quantidadeParaCompra > 1)
      {
        startQuote += quantidadeParaCompra;
        saldo = (caixa - (quantidadeParaCompra * quoteValue)).ToRound(2);
      }
    else
    {
      ++startQuote;
      saldo = caixa - quoteValue;
    }
  }
  else
    saldo = caixa;

    System.Console.WriteLine($@"
    Mês: {i + 1} | MXRFF11: Quantidade de cotas: {startQuote}
    Rendimento: R${dividendos.ToRound(2)}
    Valor do Patrimônio: R$ {(startQuote * quoteValue).ToRound(2)}
    Investimento: R$ {(investimentoTotal * quoteValue).ToRound(2)}"
  );
}