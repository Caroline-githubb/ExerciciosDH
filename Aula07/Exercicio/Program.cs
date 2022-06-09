// Cotação do dólar no dia 3 de maio de 2022.
double cotacaoDoDolarHoje = 4.97;
const double VALOR_MINIMO_DE_COMPRA_EM_DOLAR = 100;
const double VALOR_MAXIMO_DE_COMPRA_EM_DOLAR = 2500;

Console.WriteLine("Digite o valor real da sua compra?");
double.TryParse(Console.ReadLine(), out double valorDaCompraEmReais);
double valorConvertido = (ConverterRealParaDolar(valorDaCompraEmReais));

if (valorConvertido <= VALOR_MINIMO_DE_COMPRA_EM_DOLAR)
{
    Console.WriteLine($"A compra mínima permitida é de $ {VALOR_MINIMO_DE_COMPRA_EM_DOLAR}, e o sua compra é no valor de $ {valorConvertido}");
}

else if (valorConvertido <= VALOR_MAXIMO_DE_COMPRA_EM_DOLAR)
{
    Console.WriteLine($"A compra máxima permitida é de $ {VALOR_MAXIMO_DE_COMPRA_EM_DOLAR}, e o sua compra é no valor de $ {valorConvertido}");
}

else
{
    Console.WriteLine($"Você pode comprar $ {valorConvertido}");
}

double ConverterRealParaDolar(double valorDaCompraEmReais)
{
    double conversao = valorDaCompraEmReais * cotacaoDoDolarHoje;
    return conversao;
}


