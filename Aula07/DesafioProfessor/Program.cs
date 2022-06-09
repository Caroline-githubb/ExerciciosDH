// Utilize a mensagem a seguir como base do retorno esperado:
// Seu diagnóstico é XXXXXX.
Console.WriteLine("Digite a sua altura: ");
double.TryParse(Console.ReadLine(), out double alturaDoUsuario);
Console.WriteLine("Digite o seu peso: ");
double.TryParse(Console.ReadLine(), out double pesoDoUsuario);
Console.WriteLine($"Seu diagnóstico é {RetornarDiagnosticoDoUsuario(alturaDoUsuario, pesoDoUsuario)}");


string RetornarDiagnosticoDoUsuario(double alturaDoUsuario, double pesoDoUsuario)
{     
    double imc = pesoDoUsuario / (alturaDoUsuario*alturaDoUsuario);
    string diagnostico = "";

    if (imc < 18.5)
    {
        diagnostico = "Anêmico!";
    }
    
    else if (imc >= 18.5 && imc <= 24.9)
    {
        diagnostico = "Normal!";
    }

    else if (imc >= 25 && imc <= 29.9)
    {
        diagnostico = "Sobrepeso!";
    }

    else if (imc >= 30 && imc <= 40)
    {
        diagnostico = "Obesidade!";
    }

    else {diagnostico = "Obesidade Grave!";}

    return diagnostico;  
}



