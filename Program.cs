// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


double quoteValue = 9.95;
double quoteDiv = 0.09;

double startQuote =  (int)(2000 / 10.06);

double saldo = 0.0;

for (int i = 0; i < 60; i++)
{
  startQuote += 100;

  var dividendos = startQuote * quoteDiv;


  var caixa = dividendos + saldo;

  if (caixa >= quoteValue)
  {
    int quantidadeParaCompra = (int)(caixa / quoteValue);
    if (quantidadeParaCompra > 1)
      {
        startQuote += quantidadeParaCompra;
        saldo = Math.Round(caixa - (quantidadeParaCompra * quoteValue), 2);
      }
    else
    {
      ++startQuote;
      saldo = caixa - quoteValue;
    }
  }
  else
    saldo = caixa;

    System.Console.WriteLine($"MXRFF11: Quantidade de cotas: {startQuote} | Rendimento: R${Math.Round(dividendos, 2)} | Valor do Patrimônio: R$ {Math.Round(startQuote * quoteValue, 2)}"
  );
}