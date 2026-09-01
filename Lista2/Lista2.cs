// Exercício 1: Escreva um programa em C# que exiba se um número é positivo, negativo ou zero.
{
    int numero = -5;

    if (numero > 0)
    {
        Console.WriteLine("O número é positivo.");
    }
    else if (numero < 0)
    {
        Console.WriteLine("O número é negativo.");
    }
    else
    {
        Console.WriteLine("O número é zero.");
    }
}

// Exercício 2: Escreva um programa em C# que exiba a idade e informe se é maior ou menor de idade.
{
    int idade = 21;

    if (idade >= 18)
    {
        Console.WriteLine("Maior de idade.");
    }
    else
    {
        Console.WriteLine("Menor de idade.");
    }
}

// Exercício 3: Escreva um programa em C# que verifique se um número é par ou ímpar.
{
    int numero = 7;

    if (numero % 2 == 0)
    {
        Console.WriteLine("O número é par.");
    }
    else
    {
        Console.WriteLine("O número é ímpar.");
    }
}

// Exercício 4: Escreva um programa em C# que leia três números e informe o maior.
{
    int numero1 = 10;
    int numero2 = 25;
    int numero3 = 18;

    int maior = Math.Max(numero1, Math.Max(numero2, numero3));

    Console.WriteLine("O maior número é: " + maior);
}

// Exercício 5: Escreva um programa em C# que calcule a média de duas notas e informe se está aprovado (>= 7).
{
    double nota1 = 8.0;
    double nota2 = 6.5;

    double media = (nota1 + nota2) / 2;

    Console.WriteLine("Média: " + media);

    if (media >= 7)
    {
        Console.WriteLine("Aprovado.");
    }
    else
    {
        Console.WriteLine("Reprovado.");
    }
}

// Exercício 6: Escreva um programa em C# que verifique se um ano é bissexto.
{
    int ano = 2028;

    bool bissexto = (ano % 400 == 0) || (ano % 4 == 0 && ano % 100 != 0);

    Console.WriteLine("Ano bissexto: " + bissexto);
}

// Exercício 7: Escreva um programa em C# que leia um número e informe se está entre 10 e 50.
{
    int numero = 30;

    if (numero >= 10 && numero <= 50)
    {
        Console.WriteLine("O número está entre 10 e 50.");
    }
    else
    {
        Console.WriteLine("O número não está entre 10 e 50.");
    }
}

// Exercício 8: Escreva um programa em C# que calcule o IMC e classifique.

{
    double peso = 70.0;
    double altura = 1.75;

    double imc = peso / (altura * altura);

    Console.WriteLine("IMC: " + imc.ToString("F2"));

    if (imc < 18.5)
    {
        Console.WriteLine("Classificação: abaixo do peso.");
    }
    else if (imc < 25)
    {
        Console.WriteLine("Classificação: peso normal.");
    }
    else if (imc < 30)
    {
        Console.WriteLine("Classificação: sobrepeso.");
    }
    else
    {
        Console.WriteLine("Classificação: obesidade.");
    }
}

// Exercício 9: Escreva um programa em C# que leia senha e valide se é "1234".
{
    string senha = "1234";

    if (senha == "1234")
    {
        Console.WriteLine("Senha válida.");
    }
    else
    {
        Console.WriteLine("Senha inválida.");
    }
}

// Exercício 10: Escreva um programa em C# que use switch para menu com 4 opções.
{
    int opcao = 2;

    switch (opcao)
    {
        case 1:
            Console.WriteLine("Opção 1 selecionada.");
            break;

        case 2:
            Console.WriteLine("Opção 2 selecionada.");
            break;

        case 3:
            Console.WriteLine("Opção 3 selecionada.");
            break;

        case 4:
            Console.WriteLine("Opção 4 selecionada.");
            break;

        default:
            Console.WriteLine("Opção inválida.");
            break;
    }
}

// Exercício 11: Escreva um programa em C# que converta número (1–7) para dia da semana.
{
    int numero = 3;

    switch (numero)
    {
        case 1:
            Console.WriteLine("Domingo");
            break;
        case 2:
            Console.WriteLine("Segunda-feira");
            break;
        case 3:
            Console.WriteLine("Terça-feira");
            break;
        case 4:
            Console.WriteLine("Quarta-feira");
            break;
        case 5:
            Console.WriteLine("Quinta-feira");
            break;
        case 6:
            Console.WriteLine("Sexta-feira");
            break;
        case 7:
            Console.WriteLine("Sábado");
            break;
        default:
            Console.WriteLine("Número inválido.");
            break;
    }
}

// Exercício 12: Escreva um programa em C# que classifique nota A, B, C, D ou F usando switch.
{
    double nota = 8.5;
    string classificacao;

    switch (nota)
    {
        case >= 9:
            classificacao = "A";
            break;
        case >= 8:
            classificacao = "B";
            break;
        case >= 7:
            classificacao = "C";
            break;
        case >= 6:
            classificacao = "D";
            break;
        default:
            classificacao = "F";
            break;
    }

    Console.WriteLine("Classificação: " + classificacao);
}

// Exercício 13: Escreva um programa em C# que verifique se três lados formam um triângulo.
{
    double lado1 = 5;
    double lado2 = 6;
    double lado3 = 7;

    bool formaTriangulo =
        lado1 + lado2 > lado3 &&
        lado1 + lado3 > lado2 &&
        lado2 + lado3 > lado1;

    Console.WriteLine("Forma um triângulo: " + formaTriangulo);
}

// Exercício 14: Escreva um programa em C# que identifique o tipo de triângulo.
{
    double lado1 = 5;
    double lado2 = 5;
    double lado3 = 5;

    if (lado1 == lado2 && lado2 == lado3)
    {
        Console.WriteLine("Triângulo equilátero.");
    }
    else if (lado1 == lado2 || lado1 == lado3 || lado2 == lado3)
    {
        Console.WriteLine("Triângulo isósceles.");
    }
    else
    {
        Console.WriteLine("Triângulo escaleno.");
    }
}

// Exercício 15: Escreva um programa em C# que simule uma calculadora com switch (+, -, *, /).
{
    double numero1 = 20;
    double numero2 = 5;
    char operador = '*';

    switch (operador)
    {
        case '+':
            Console.WriteLine("Resultado: " + (numero1 + numero2));
            break;
        case '-':
            Console.WriteLine("Resultado: " + (numero1 - numero2));
            break;
        case '*':
            Console.WriteLine("Resultado: " + (numero1 * numero2));
            break;
        case '/':
            if (numero2 != 0)
            {
                Console.WriteLine("Resultado: " + (numero1 / numero2));
            }
            else
            {
                Console.WriteLine("Não é possível dividir por zero.");
            }
            break;
        default:
            Console.WriteLine("Operador inválido.");
            break;
    }
}

// Exercício 16: Escreva um programa em C# que imprima números de 1 a 100 usando for.
{
    for (int i = 1; i <= 100; i++)
    {
        Console.WriteLine(i);
    }
}

// Exercício 17: Escreva um programa em C# que imprima números pares de 1 a 50.
{
    for (int i = 1; i <= 50; i++)
    {
        if (i % 2 == 0)
        {
            Console.WriteLine(i);
        }
    }
}

// Exercício 18: Escreva um programa em C# que some números de 1 a N.
{
    int n = 10;
    int soma = 0;

    for (int i = 1; i <= n; i++)
    {
        soma += i;
    }

    Console.WriteLine("Soma: " + soma);
}

// Exercício 19: Escreva um programa em C# que calcule o fatorial de um número.
{
    int numero = 5;
    long fatorial = 1;

    for (int i = 1; i <= numero; i++)
    {
        fatorial *= i;
    }

    Console.WriteLine("Fatorial: " + fatorial);
}

// Exercício 20: Escreva um programa em C# que gere a tabuada de um número.
{
    int numero = 7;

    for (int i = 1; i <= 10; i++)
    {
        Console.WriteLine($"{numero} x {i} = {numero * i}");
    }
}

// Exercício 21: Escreva um programa em C# que conte regressivamente de 10 a 0.
{
    for (int i = 10; i >= 0; i--)
    {
        Console.WriteLine(i);
    }
}

// Exercício 22: Escreva um programa em C# que leia números até digitar 0.
{
    int numero;

    do
    {
        Console.Write("Digite um número (0 para sair): ");
        numero = int.Parse(Console.ReadLine()!);

        Console.WriteLine("Número lido: " + numero);
    }
    while (numero != 0);
}

// Exercício 23: Escreva um programa em C# que calcule média de vários números.
{
    double[] numeros = { 7, 8, 9, 10 };
    double soma = 0;

    foreach (double numero in numeros)
    {
        soma += numero;
    }

    double media = soma / numeros.Length;

    Console.WriteLine("Média: " + media);
}

// Exercício 24: Escreva um programa em C# que conte quantos números são positivos.
{
    int[] numeros = { -2, 5, 8, -1, 0, 10 };
    int quantidadePositivos = 0;

    foreach (int numero in numeros)
    {
        if (numero > 0)
        {
            quantidadePositivos++;
        }
    }

    Console.WriteLine("Quantidade de positivos: " + quantidadePositivos);
}

// Exercício 25: Escreva um programa em C# que mostre apenas números ímpares até 100.
{
    for (int i = 1; i <= 100; i++)
    {
        if (i % 2 != 0)
        {
            Console.WriteLine(i);
        }
    }
}

// Exercício 26: Escreva um programa em C# que use foreach para exibir lista de nomes.
{
    List<string> nomes = new List<string>
    {
        "Nicole",
        "Ana",
        "Carlos",
        "João"
    };

    foreach (string nome in nomes)
    {
        Console.WriteLine(nome);
    }
}

// Exercício 27: Escreva um programa em C# que some elementos de uma lista.
{
    List<int> numeros = new List<int> { 10, 20, 30, 40 };
    int soma = 0;

    foreach (int numero in numeros)
    {
        soma += numero;
    }

    Console.WriteLine("Soma: " + soma);
}

// Exercício 28: Escreva um programa em C# que conte palavras com mais de 5 letras.
{
    List<string> palavras = new List<string>
    {
        "programação",
        "casa",
        "computador",
        "CSharp",
        "estudo"
    };

    int quantidade = 0;

    foreach (string palavra in palavras)
    {
        if (palavra.Length > 5)
        {
            quantidade++;
        }
    }

    Console.WriteLine("Quantidade de palavras com mais de 5 letras: " + quantidade);
}

// Exercício 29: Escreva um programa em C# que encontre o maior número em uma lista.
{
    List<int> numeros = new List<int> { 10, 35, 22, 50, 8 };
    int maior = numeros[0];

    foreach (int numero in numeros)
    {
        if (numero > maior)
        {
            maior = numero;
        }
    }

    Console.WriteLine("Maior número: " + maior);
}

// Exercício 30: Escreva um programa em C# que inverta uma lista manualmente.
{
    List<int> numeros = new List<int> { 1, 2, 3, 4, 5 };
    List<int> invertida = new List<int>();

    for (int i = numeros.Count - 1; i >= 0; i--)
    {
        invertida.Add(numeros[i]);
    }

    Console.WriteLine("Lista invertida:");

    foreach (int numero in invertida)
    {
        Console.WriteLine(numero);
    }
}

// Exercício 31: Escreva um programa em C# que crie uma lista de inteiros e adicione 5 valores.
{
    List<int> numeros = new List<int>();

    numeros.Add(10);
    numeros.Add(20);
    numeros.Add(30);
    numeros.Add(40);
    numeros.Add(50);

    foreach (int numero in numeros)
    {
        Console.WriteLine(numero);
    }
}

// Exercício 32: Escreva um programa em C# que remova um valor específico.
{
    List<int> numeros = new List<int> { 10, 20, 30, 40, 50 };

    numeros.Remove(30);

    Console.WriteLine("Lista após remoção:");

    foreach (int numero in numeros)
    {
        Console.WriteLine(numero);
    }
}

// Exercício 33: Escreva um programa em C# que verifique se lista contém número informado.
{
    List<int> numeros = new List<int> { 10, 20, 30, 40, 50 };
    int numeroProcurado = 30;

    bool contem = numeros.Contains(numeroProcurado);

    Console.WriteLine("A lista contém o número: " + contem);
}

// Exercício 34: Escreva um programa em C# que ordene lista crescente.
{
    List<int> numeros = new List<int> { 40, 10, 30, 20, 50 };

    numeros.Sort();

    Console.WriteLine("Lista crescente:");

    foreach (int numero in numeros)
    {
        Console.WriteLine(numero);
    }
}

// Exercício 35: Escreva um programa em C# que ordene lista decrescente.
{
    List<int> numeros = new List<int> { 40, 10, 30, 20, 50 };

    numeros.Sort();
    numeros.Reverse();

    Console.WriteLine("Lista decrescente:");

    foreach (int numero in numeros)
    {
        Console.WriteLine(numero);
    }
}

// Exercício 36: Escreva um programa em C# que crie Dictionary de alunos e notas.
{
    Dictionary<string, double> alunos = new Dictionary<string, double>
    {
        { "Nicole", 9.0 },
        { "Ana", 8.5 },
        { "Carlos", 7.0 }
    };

    foreach (var aluno in alunos)
    {
        Console.WriteLine($"Aluno: {aluno.Key} - Nota: {aluno.Value}");
    }
}

// Exercício 37: Escreva um programa em C# que busque nota pelo nome.
{
    Dictionary<string, double> alunos = new Dictionary<string, double>
    {
        { "Nicole", 9.0 },
        { "Ana", 8.5 },
        { "Carlos", 7.0 }
    };

    string nomeProcurado = "Nicole";

    if (alunos.ContainsKey(nomeProcurado))
    {
        Console.WriteLine("Nota: " + alunos[nomeProcurado]);
    }
    else
    {
        Console.WriteLine("Aluno não encontrado.");
    }
}

// Exercício 38: Escreva um programa em C# que percorra Dictionary exibindo chave e valor.
{
    Dictionary<string, double> alunos = new Dictionary<string, double>
    {
        { "Nicole", 9.0 },
        { "Ana", 8.5 },
        { "Carlos", 7.0 }
    };

    foreach (KeyValuePair<string, double> aluno in alunos)
    {
        Console.WriteLine($"Chave: {aluno.Key} | Valor: {aluno.Value}");
    }
}

// Exercício 39: Escreva um programa em C# que conte quantidade de elementos.
{
    List<int> numeros = new List<int> { 10, 20, 30, 40, 50 };

    Console.WriteLine("Quantidade de elementos: " + numeros.Count);
}

// Exercício 40: Escreva um programa em C# que crie lista de objetos Produto (Nome, Preço).
{
    List<Produto> produtos = new List<Produto>
    {
        new Produto("Caderno", 25.90),
        new Produto("Caneta", 3.50),
        new Produto("Mochila", 120.00)
    };

    foreach (Produto produto in produtos)
    {
        Console.WriteLine($"Produto: {produto.Nome} - Preço: R$ {produto.Preco:F2}");
    }
}

// Exercício 41: Escreva um programa em C# que crie função que soma dois números.
{
    int resultado = Somar(10, 20);

    Console.WriteLine("Soma: " + resultado);
}

// Exercício 42: Escreva um programa em C# que exiba uma função que retorna maior entre dois números.
{
    int maior = MaiorNumero(15, 25);

    Console.WriteLine("Maior número: " + maior);
}

// Exercício 43: Escreva um programa em C# que exiba uma função que calcula média.
{
    double media = CalcularMedia(8, 7);

    Console.WriteLine("Média: " + media);
}

// Exercício 44: Escreva um programa em C# que crie função que verifica se número é par.
{
    bool par = EhPar(10);

    Console.WriteLine("É par: " + par);
}

// Exercício 45: Escreva um programa em C# que crie função que recebe lista e retorna soma.
{
    List<int> numeros = new List<int> { 10, 20, 30 };

    int soma = SomarLista(numeros);

    Console.WriteLine("Soma da lista: " + soma);
}

// Exercício 46: Escreva um programa em C# que crie função que recebe string e retorna invertida.
{
    string texto = "CSharp";

    string textoInvertido = InverterString(texto);

    Console.WriteLine("String invertida: " + textoInvertido);
}

// Exercício 47: Escreva um programa em C# que crie função que calcula idade.
{
    DateTime nascimento = new DateTime(2005, 5, 10);

    int idade = CalcularIdade(nascimento);

    Console.WriteLine("Idade: " + idade);
}

// Exercício 48: Escreva um programa em C# que crie função com parâmetro ref.
{
    int numero = 10;

    Dobrar(ref numero);

    Console.WriteLine("Número após a função: " + numero);
}

// Exercício 49: Escreva um programa em C# que crie função que retorna lista de pares.
{
    List<int> numeros = new List<int> { 1, 2, 3, 4, 5, 6 };

    List<int> pares = ObterPares(numeros);

    Console.WriteLine("Números pares:");

    foreach (int numero in pares)
    {
        Console.WriteLine(numero);
    }
}

// Exercício 50: Escreva um programa em C# que crie função que valida senha.
{
    string senha = "1234";

    bool senhaValida = ValidarSenha(senha);

    Console.WriteLine("Senha válida: " + senhaValida);
}

// Exercício 51: Escreva um programa em C# que converta string para maiúscula.
{
    string texto = "olá, mundo!";

    Console.WriteLine(texto.ToUpper());
}

// Exercício 52: Escreva um programa em C# que exiba a quantidade de caracteres de uma frase.
{
    string frase = "Olá, mundo!";

    Console.WriteLine("Quantidade de caracteres: " + frase.Length);
}

// Exercício 53: Escreva um programa em C# que verifique se string contém palavra.
{
    string frase = "Estou estudando C#.";
    string palavra = "C#";

    bool contem = frase.Contains(palavra);

    Console.WriteLine("Contém a palavra: " + contem);
}

// Exercício 54: Escreva um programa em C# que substitua palavra em frase.
{
    string frase = "Eu gosto de Java.";
    string novaFrase = frase.Replace("Java", "C#");

    Console.WriteLine(novaFrase);
}

// Exercício 55: Escreva um programa em C# que extraia os 3 primeiros caracteres.
{
    string texto = "Programação";

    string primeirosTres = texto.Substring(0, 3);

    Console.WriteLine("Primeiros 3 caracteres: " + primeirosTres);
}

// Exercício 56: Escreva um programa em C# que formate data atual dd/MM/yyyy.
{
    DateTime dataAtual = DateTime.Now;

    Console.WriteLine(dataAtual.ToString("dd/MM/yyyy"));
}

// Exercício 57: Escreva um programa em C# que calcule diferença entre duas datas.
{
    DateTime data1 = new DateTime(2026, 8, 1);
    DateTime data2 = new DateTime(2026, 8, 31);

    TimeSpan diferenca = data2 - data1;

    Console.WriteLine("Diferença em dias: " + diferenca.Days);
}

// Exercício 58: Escreva um programa em C# que adicione 30 dias à data atual.
{
    DateTime dataAtual = DateTime.Now;
    DateTime novaData = dataAtual.AddDays(30);

    Console.WriteLine("Data após 30 dias: " + novaData.ToString("dd/MM/yyyy"));
}

// Exercício 59: Escreva um programa em C# que verifique se data é fim de semana.
{
    DateTime data = new DateTime(2026, 8, 30);

    bool fimDeSemana =
        data.DayOfWeek == DayOfWeek.Saturday ||
        data.DayOfWeek == DayOfWeek.Sunday;

    Console.WriteLine("É fim de semana: " + fimDeSemana);
}

// Exercício 60: Escreva um programa em C# que calcule dias restantes até final do ano.
{
    DateTime hoje = DateTime.Now;
    DateTime finalDoAno = new DateTime(hoje.Year, 12, 31);

    int diasRestantes = (finalDoAno - hoje.Date).Days;

    Console.WriteLine("Dias restantes até o final do ano: " + diasRestantes);
}

// FUNÇÕES 

static int Somar(int numero1, int numero2)
{
    return numero1 + numero2;
}

static int MaiorNumero(int numero1, int numero2)
{
    return numero1 > numero2 ? numero1 : numero2;
}

static double CalcularMedia(double nota1, double nota2)
{
    return (nota1 + nota2) / 2;
}

static bool EhPar(int numero)
{
    return numero % 2 == 0;
}

static int SomarLista(List<int> numeros)
{
    int soma = 0;

    foreach (int numero in numeros)
    {
        soma += numero;
    }

    return soma;
}

static string InverterString(string texto)
{
    char[] caracteres = texto.ToCharArray();
    Array.Reverse(caracteres);

    return new string(caracteres);
}

static int CalcularIdade(DateTime nascimento)
{
    DateTime hoje = DateTime.Now;

    int idade = hoje.Year - nascimento.Year;

    if (nascimento.Date > hoje.AddYears(-idade))
    {
        idade--;
    }

    return idade;
}

static void Dobrar(ref int numero)
{
    numero *= 2;
}

static List<int> ObterPares(List<int> numeros)
{
    List<int> pares = new List<int>();

    foreach (int numero in numeros)
    {
        if (numero % 2 == 0)
        {
            pares.Add(numero);
        }
    }

    return pares;
}

static bool ValidarSenha(string senha)
{
    return senha == "1234";
}

// CLASSE DO EXERCÍCIO 40

class Produto
{
    public string Nome { get; set; }
    public double Preco { get; set; }

    public Produto(string nome, double preco)
    {
        Nome = nome;
        Preco = preco;
    }
}
