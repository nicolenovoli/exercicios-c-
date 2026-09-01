// Exercício 1: Escreva um programa em C# que crie uma classe Pessoa com Nome e Idade.
{
    Pessoa01 pessoa = new Pessoa01();

    pessoa.Nome = "Nicole";
    pessoa.Idade = 21;

    Console.WriteLine("Nome: " + pessoa.Nome);
    Console.WriteLine("Idade: " + pessoa.Idade);
}

// Exercício 2: Escreva um programa em C# que crie método Apresentar() que exiba os dados.
{
    Pessoa02 pessoa = new Pessoa02("Nicole", 21);

    pessoa.Apresentar();
}

// Exercício 3: Escreva um programa em C# que crie construtor que receba Nome.
{
    Pessoa03 pessoa = new Pessoa03("Nicole");
    Console.WriteLine("Nome: " + pessoa.Nome);
}

// Exercício 4: Escreva um programa em C# que crie construtor que receba Nome e Idade.
{
    Pessoa04 pessoa = new Pessoa04("Nicole", 21);

    Console.WriteLine("Nome: " + pessoa.Nome);
    Console.WriteLine("Idade: " + pessoa.Idade);
}

// Exercício 5: Escreva um programa em C# que implemente validação para não permitir idade negativa.
{
    Pessoa05 pessoa = new Pessoa05("Nicole");

    pessoa.Idade = -5;

    Console.WriteLine("Idade: " + pessoa.Idade);
}

// Exercício 6: Escreva um programa em C# que crie classe Produto com Nome e Preço.
{
    Produto06 produto = new Produto06("Caderno", 25.90);

    Console.WriteLine("Produto: " + produto.Nome);
    Console.WriteLine("Preço: R$ " + produto.Preco.ToString("F2"));
}

// Exercício 7: Escreva um programa em C# que não permita preço menor ou igual a zero.
{
    Produto07 produto = new Produto07("Caneta");

    produto.Preco = 0;

    Console.WriteLine("Preço: R$ " + produto.Preco.ToString("F2"));
}

// Exercício 8: Escreva um programa em C# que crie método AplicarDesconto(double percentual).
{
    Produto08 produto = new Produto08("Mochila", 100.00);

    produto.AplicarDesconto(10);

    Console.WriteLine("Preço com desconto: R$ " + produto.Preco.ToString("F2"));
}

// Exercício 9: Escreva um programa em C# que crie classe ContaBancaria com saldo privado.
{
    ContaBancaria09 conta = new ContaBancaria09();

    conta.Depositar(500);

    Console.WriteLine("Saldo: R$ " + conta.ConsultarSaldo().ToString("F2"));
}

// Exercício 10: Escreva um programa em C# que implemente métodos Depositar e Sacar.
{
    ContaBancaria10 conta = new ContaBancaria10();

    conta.Depositar(500);
    conta.Sacar(100);

    Console.WriteLine("Saldo: R$ " + conta.ConsultarSaldo().ToString("F2"));
}

// Exercício 11: Escreva um programa em C# que não permita sacar valor maior que saldo.
{
    ContaBancaria11 conta = new ContaBancaria11();

    conta.Depositar(500);
    conta.Sacar(600);

    Console.WriteLine("Saldo: R$ " + conta.ConsultarSaldo().ToString("F2"));
}

// Exercício 12: Escreva um programa em C# que crie classe Aluno com Nota.
{
    Aluno12 aluno = new Aluno12("Nicole", 8.5);

    Console.WriteLine("Aluno: " + aluno.Nome);
    Console.WriteLine("Nota: " + aluno.Nota);
}

// Exercício 13: Escreva um programa em C# que crie método Aprovado() retornando bool.
{
    Aluno13 aluno = new Aluno13("Nicole", 8.5);

    Console.WriteLine("Aprovado: " + aluno.Aprovado());
}

// Exercício 14: Escreva um programa em C# que crie propriedade somente leitura.
{
    Pessoa14 pessoa = new Pessoa14("Nicole");

    Console.WriteLine("Nome: " + pessoa.Nome);
}

// Exercício 15: Escreva um programa em C# que crie propriedade com private set.
{
    Aluno15 aluno = new Aluno15("Nicole", 9.0);

    Console.WriteLine("Nome: " + aluno.Nome);
    Console.WriteLine("Nota: " + aluno.Nota);
}

// Exercício 16: Escreva um programa em C# que crie classe com campo readonly.
{
    Configuracao16 configuracao = new Configuracao16();

    Console.WriteLine("Código: " + configuracao.Codigo);
}

// Exercício 17: Escreva um programa em C# que crie uma constante PI.
{
    Console.WriteLine("PI: " + Matematica17.PI);
}

// Exercício 18: Escreva um programa em C# que crie método estático Somar.
{
    int resultado = Matematica18.Somar(10, 20);

    Console.WriteLine("Soma: " + resultado);
}

// Exercício 19: Escreva um programa em C# que crie classe com contador estático de instâncias.
{
    Contador19 objeto1 = new Contador19();
    Contador19 objeto2 = new Contador19();
    Contador19 objeto3 = new Contador19();

    Console.WriteLine("Quantidade de instâncias: " + Contador19.Quantidade);
}

// Exercício 20: Escreva um programa em C# que sobrescreva ToString().
{
    Pessoa20 pessoa = new Pessoa20("Nicole", 21);

    Console.WriteLine(pessoa.ToString());
}

// Exercício 21: Escreva um programa em C# que crie classe Carro com método Acelerar.
{
    Carro21 carro = new Carro21();

    carro.Acelerar();
}

// Exercício 22: Escreva um programa em C# que use this no construtor. *****************
{
    Pessoa22 pessoa = new Pessoa22("Nicole", 21);

    Console.WriteLine("Nome: " + pessoa.Nome);
    Console.WriteLine("Idade: " + pessoa.Idade);
}

// Exercício 23: Escreva um programa em C# que crie classe com propriedade calculada.
{
    Retangulo23 retangulo = new Retangulo23(10, 5);

    Console.WriteLine("Área: " + retangulo.Area);
}

// Exercício 24: Escreva um programa em C# que crie classe Pedido com Id gerado automaticamente.
{
    Pedido24 pedido1 = new Pedido24();
    Pedido24 pedido2 = new Pedido24();

    Console.WriteLine("Pedido 1: " + pedido1.Id);
    Console.WriteLine("Pedido 2: " + pedido2.Id);
}

// Exercício 25: Escreva um programa em C# que implemente método com expressão lambda.
{
    Calculadora25 calculadora = new Calculadora25();

    Console.WriteLine("Resultado: " + calculadora.Somar(10, 20));
}

// Exercício 26: Escreva um programa em C# que crie método com parâmetro opcional.
{
    Mensagem26 mensagem = new Mensagem26();

    mensagem.Exibir();
    mensagem.Exibir("Olá, Nicole!");
}

// Exercício 27: Escreva um programa em C# que crie classe com init-only property.
{
    Pessoa27 pessoa = new Pessoa27
    {
        Nome = "Nicole",
        Idade = 21
    };

    Console.WriteLine("Nome: " + pessoa.Nome);
    Console.WriteLine("Idade: " + pessoa.Idade);
}

// Exercício 28: Escreva um programa em C# que crie record Cliente.
{
    Cliente28 cliente = new Cliente28("Nicole", "44999999999");

    Console.WriteLine("Nome: " + cliente.Nome);
    Console.WriteLine("Telefone: " + cliente.Telefone);
}

// Exercício 29: Escreva um programa em C# que crie classe com método que retorna string formatada.
{
    Pessoa29 pessoa = new Pessoa29("Nicole", 21);

    Console.WriteLine(pessoa.ObterDados());
}

// Exercício 30: Escreva um programa em C# que implemente encapsulamento completo em uma classe Funcionario.
{
    Funcionario30 funcionario = new Funcionario30("Nicole", 2500);

    funcionario.AumentarSalario(500);

    Console.WriteLine(funcionario.ObterDados());
}

// Exercício 31: Escreva um programa em C# que crie classe Animal.
{
    Animal31 animal = new Animal31("Animal");

    animal.EmitirSom();
}

// Exercício 32: Escreva um programa em C# que crie classe Cachorro herdando Animal.
{
    Cachorro32 cachorro = new Cachorro32("Luke");

    cachorro.EmitirSom();
}

// Exercício 33: Escreva um programa em C# que adicione método EmitirSom() virtual.
{
    Animal33 animal = new Animal33("Animal");

    animal.EmitirSom();
}

// Exercício 34: Escreva um programa em C# que sobrescreva em Cachorro.
{
    Cachorro34 cachorro = new Cachorro34("Luke");

    cachorro.EmitirSom();
}

// Exercício 35: Escreva um programa em C# que crie classe Gato.
{
    Gato35 gato = new Gato35("Sasuke");

    gato.EmitirSom();
}

// Exercício 36: Escreva um programa em C# que use polimorfismo com lista de Animal.
{
    List<Animal36> animais = new List<Animal36>
    {
        new Cachorro36("Luke"),
        new Gato36("Sasuke")
    };

    foreach (Animal36 animal in animais)
    {
        animal.EmitirSom();
    }
}

// Exercício 37: Escreva um programa em C# que crie classe Veiculo.
{
    Veiculo37 veiculo = new Veiculo37("Veículo");

    veiculo.MostrarDados();
}

// Exercício 38: Escreva um programa em C# que crie classe Carro herdando Veiculo.
{
    Carro38 carro = new Carro38("Carro");

    carro.MostrarDados();
}

// Exercício 39: Escreva um programa em C# que crie classe Moto.
{
    Moto39 moto = new Moto39("Moto");

    moto.MostrarDados();
}

// Exercício 40: Escreva um programa em C# que use base() no construtor.
{
    Carro40 carro = new Carro40("Honda");

    carro.MostrarDados();
}

// Exercício 41: Escreva um programa em C# que crie método virtual CalcularConsumo.
{
    Veiculo41 veiculo = new Veiculo41();

    Console.WriteLine("Consumo: " + veiculo.CalcularConsumo());
}

// Exercício 42: Escreva um programa em C# que sobrescreva em classes filhas.
{
    Veiculo42 carro = new Carro42();
    Veiculo42 moto = new Moto42();

    Console.WriteLine("Consumo do carro: " + carro.CalcularConsumo());
    Console.WriteLine("Consumo da moto: " + moto.CalcularConsumo());
}

// Exercício 43: Escreva um programa em C# que use sealed em uma classe.
{
    Carro43 carro = new Carro43();

    carro.Mostrar();
}

// Exercício 44: Escreva um programa em C# que use sealed override.
{
    Cachorro44 cachorro = new Cachorro44();

    cachorro.EmitirSom();
}

// Exercício 45: Escreva um programa em C# que crie classe Pessoa.
{
    Pessoa45 pessoa = new Pessoa45("Nicole");

    Console.WriteLine("Nome: " + pessoa.Nome);
}

// Exercício 46: Escreva um programa em C# que crie classe Funcionario herdando Pessoa.
{
    Funcionario46 funcionario = new Funcionario46("Nicole", 2500);

    funcionario.MostrarDados();
}

// Exercício 47: Escreva um programa em C# que crie classe Gerente herdando Funcionario.
{
    Gerente47 gerente = new Gerente47("Nicole", 5000);

    gerente.MostrarDados();
}

// Exercício 48: Escreva um programa em C# que teste herança em múltiplos níveis.
{
    Gerente48 gerente = new Gerente48("Nicole", 5000);

    gerente.MostrarPessoa();
    gerente.MostrarFuncionario();
    gerente.MostrarGerente();
}

// Exercício 49: Escreva um programa em C# que use protected em atributo.
{
    Funcionario49 funcionario = new Funcionario49("Nicole");

    funcionario.MostrarNome();
}

// Exercício 50: Escreva um programa em C# que acesse membro protected na classe filha.
{
    Funcionario50 funcionario = new Funcionario50("Nicole");

    funcionario.MostrarNome();
}

// Exercício 51: Escreva um programa em C# que crie método virtual com implementação base.
{
    Animal51 animal = new Animal51();

    animal.EmitirSom();
}

// Exercício 52: Escreva um programa em C# que sobrescreva parcialmente usando base.Metodo().
{
    Cachorro52 cachorro = new Cachorro52();

    cachorro.EmitirSom();
}

// Exercício 53: Escreva um programa em C# que crie classe Conta.
{
    Conta53 conta = new Conta53(1000);

    Console.WriteLine("Saldo: R$ " + conta.Saldo.ToString("F2"));
}

// Exercício 54: Escreva um programa em C# que crie ContaCorrente e ContaPoupanca.
{
    ContaCorrente54 corrente = new ContaCorrente54(1000);
    ContaPoupanca54 poupanca = new ContaPoupanca54(1000);

    Console.WriteLine("Saldo corrente: R$ " + corrente.Saldo.ToString("F2"));
    Console.WriteLine("Saldo poupança: R$ " + poupanca.Saldo.ToString("F2"));
}

// Exercício 55: Escreva um programa em C# que sobrescreva método Sacar.
{
    ContaCorrente55 corrente = new ContaCorrente55(1000);
    ContaPoupanca55 poupanca = new ContaPoupanca55(1000);

    corrente.Sacar(100);
    poupanca.Sacar(100);

    Console.WriteLine("Saldo corrente: R$ " + corrente.Saldo.ToString("F2"));
    Console.WriteLine("Saldo poupança: R$ " + poupanca.Saldo.ToString("F2"));
}

// Exercício 56: Escreva um programa em C# que crie hierarquia de 4 níveis.
{
    Nivel4_56 objeto = new Nivel4_56();

    objeto.MostrarNivel1();
    objeto.MostrarNivel2();
    objeto.MostrarNivel3();
    objeto.MostrarNivel4();
}

// Exercício 57: Escreva um programa em C# que teste casting entre tipos.
{
    Animal57 animal = new Cachorro57();

    Cachorro57 cachorro = (Cachorro57)animal;

    cachorro.Latir();
}

// Exercício 58: Escreva um programa em C# que use is e as.
{
    Animal58 animal = new Cachorro58();

    if (animal is Cachorro58)
    {
        Console.WriteLine("O objeto é um cachorro.");
    }

    Cachorro58 cachorro = animal as Cachorro58;

    if (cachorro != null)
    {
        cachorro.Latir();
    }
}

// Exercício 59: Escreva um programa em C# que crie método que receba classe base como parâmetro.
{
    Cachorro59 cachorro = new Cachorro59();

    cachorro.EmitirSom();
}

// Exercício 60: Escreva um programa em C# que demonstre polimorfismo via referência base.
{
    Animal60 animal = new Cachorro60();

    animal.EmitirSom();
}

// Exercício 61: Escreva um programa em C# que crie classe abstrata Forma.
{
    Quadrado61 quadrado = new Quadrado61(5);

    Console.WriteLine("Área: " + quadrado.CalcularArea());
}

// Exercício 62: Escreva um programa em C# que declare método abstrato CalcularArea().
{
    Forma62 forma = new Quadrado62(5);

    Console.WriteLine("Área: " + forma.CalcularArea());
}

// Exercício 63: Escreva um programa em C# que crie classe Quadrado.
{
    Quadrado63 quadrado = new Quadrado63(6);

    Console.WriteLine("Área do quadrado: " + quadrado.CalcularArea());
}

// Exercício 64: Escreva um programa em C# que crie classe Circulo.
{
    Circulo64 circulo = new Circulo64(3);

    Console.WriteLine("Área do círculo: " + circulo.CalcularArea());
}

// Exercício 65: Escreva um programa em C# que use polimorfismo com lista de Forma.
{
    List<Forma65> formas = new List<Forma65>
    {
        new Quadrado65(5),
        new Circulo65(3)
    };

    foreach (Forma65 forma in formas)
    {
        Console.WriteLine("Área: " + forma.CalcularArea());
    }
}

// Exercício 66: Escreva um programa em C# que crie propriedade abstrata.
{
    Quadrado66 quadrado = new Quadrado66(5);

    Console.WriteLine("Área: " + quadrado.Area);
}

// Exercício 67: Escreva um programa em C# que implemente em classe concreta.
{
    Circulo67 circulo = new Circulo67(3);

    Console.WriteLine("Área: " + circulo.Area);
}

// Exercício 68: Escreva um programa em C# que crie classe abstrata Funcionario.
{
    Desenvolvedor68 funcionario = new Desenvolvedor68("Nicole");

    Console.WriteLine("Funcionário: " + funcionario.Nome);
}

// Exercício 69: Escreva um programa em C# que declare método abstrato CalcularSalario().
{
    Desenvolvedor69 funcionario = new Desenvolvedor69("Nicole", 3000);

    Console.WriteLine("Salário: R$ " + funcionario.CalcularSalario().ToString("F2"));
}

// Exercício 70: Escreva um programa em C# que crie Desenvolvedor.
{
    Desenvolvedor70 desenvolvedor = new Desenvolvedor70("Nicole", 3500);

    Console.WriteLine("Salário: R$ " + desenvolvedor.CalcularSalario().ToString("F2"));
}

// Exercício 71: Escreva um programa em C# que crie Gerente.
{
    Gerente71 gerente = new Gerente71("Nicole", 5000);

    Console.WriteLine("Salário: R$ " + gerente.CalcularSalario().ToString("F2"));
}

// Exercício 72: Escreva um programa em C# que use construtor na classe abstrata.
{
    Desenvolvedor72 desenvolvedor = new Desenvolvedor72("Nicole");

    desenvolvedor.MostrarNome();
}

// Exercício 73: Escreva um programa em C# que use protected no construtor.
{
    Desenvolvedor73 desenvolvedor = new Desenvolvedor73("Nicole");

    desenvolvedor.MostrarNome();
}

// Exercício 74: Escreva um programa em C# que misture método abstrato e método virtual.
{
    Desenvolvedor74 desenvolvedor = new Desenvolvedor74("Nicole", 3000);

    Console.WriteLine("Salário: R$ " + desenvolvedor.CalcularSalario().ToString("F2"));
    desenvolvedor.MostrarTipo();
}

// Exercício 75: Escreva um programa em C# que crie classe abstrata que implementa interface.
{
    Relatorio75 relatorio = new Relatorio75();

    relatorio.Imprimir();
}

// Exercício 76: Escreva um programa em C# que crie interface IImprimivel.
{
    Documento76 documento = new Documento76("Lista 03");

    documento.Imprimir();
}

// Exercício 77: Escreva um programa em C# que implemente em classe Documento.
{
    Documento77 documento = new Documento77("Documento de exemplo");

    documento.Imprimir();
}

// Exercício 78: Escreva um programa em C# que crie interface IAutenticavel.
{
    Administrador78 administrador = new Administrador78("admin", "1234");

    Console.WriteLine("Autenticado: " + administrador.Autenticar("admin", "1234"));
}

// Exercício 79: Escreva um programa em C# que implemente em Administrador.
{
    Administrador79 administrador = new Administrador79("admin", "1234");

    Console.WriteLine("Autenticado: " + administrador.Autenticar("admin", "1234"));
}

// Exercício 80: Escreva um programa em C# que implemente em Cliente.
{
    Cliente80 cliente = new Cliente80("Nicole", "1234");

    Console.WriteLine("Autenticado: " + cliente.Autenticar("Nicole", "1234"));
}

// Exercício 81: Escreva um programa em C# que crie classe implementando duas interfaces.
{
    Usuario81 usuario = new Usuario81("Nicole", "1234");

    usuario.Imprimir();
    Console.WriteLine("Autenticado: " + usuario.Autenticar("Nicole", "1234"));
}

// Exercício 82: Escreva um programa em C# que crie interface com propriedade.
{
    Produto82 produto = new Produto82("Caderno", 25.90);

    Console.WriteLine("Nome: " + produto.Nome);
    Console.WriteLine("Preço: R$ " + produto.Preco.ToString("F2"));
}

// Exercício 83: Escreva um programa em C# que crie interface com método que retorna bool.
{
    Autenticador83 autenticador = new Autenticador83();

    Console.WriteLine("Resultado: " + autenticador.Validar("1234"));
}

// Exercício 84: Escreva um programa em C# que use interface como parâmetro.
{
    Documento84 documento = new Documento84("Contrato");

    documento.Imprimir();
}

// Exercício 85: Escreva um programa em C# que crie classe Pagamento.
{
    Pagamento85 pagamento = new Pagamento85(100);

    pagamento.Processar();
}

// Exercício 86: Escreva um programa em C# que crie classe PagamentoPix.
{
    PagamentoPix86 pix = new PagamentoPix86(150);

    pix.Processar();
}

// Exercício 87: Escreva um programa em C# que crie classe PagamentoCartao.
{
    PagamentoCartao87 cartao = new PagamentoCartao87(200);

    cartao.Processar();
}

// Exercício 88: Escreva um programa em C# que use lista de IPagamento.
{
    List<IPagamento88> pagamentos = new List<IPagamento88>
    {
        new PagamentoPix88(100),
        new PagamentoCartao88(200)
    };

    foreach (IPagamento88 pagamento in pagamentos)
    {
        pagamento.Processar();
    }
}

// Exercício 89: Escreva um programa em C# que crie método que receba IPagamento.
{
    IPagamento89 pagamento = new PagamentoPix89(250);

    pagamento.Processar();
}

// Exercício 90: Escreva um programa em C# que demonstre polimorfismo usando interface e herança juntos.
{
    List<IPagamento90> pagamentos = new List<IPagamento90>
    {
        new PagamentoPix90(100),
        new PagamentoCartao90(200)
    };

    foreach (IPagamento90 pagamento in pagamentos)
    {
        pagamento.Processar();
    }
}

// Exercício 1
class Pessoa01
{
    public string Nome { get; set; } = "";
    public int Idade { get; set; }
}

// Exercício 2
class Pessoa02
{
    public string Nome { get; set; } = "";
    public int Idade { get; set; }

    public Pessoa02(string nome, int idade)
    {
        Nome = nome;
        Idade = idade;
    }

    public void Apresentar()
    {
        Console.WriteLine("Nome: " + Nome);
        Console.WriteLine("Idade: " + Idade);
    }
}

// Exercício 3
class Pessoa03
{
    public string Nome { get; set; } = "";

    public Pessoa03(string nome)
    {
        Nome = nome;
    }
}

// Exercício 4
class Pessoa04
{
    public string Nome { get; set; } = "";
    public int Idade { get; set; }

    public Pessoa04(string nome, int idade)
    {
        Nome = nome;
        Idade = idade;
    }
}

// Exercício 5
class Pessoa05
{
    public string Nome { get; set; } = "";

    private int idade;

    public int Idade
    {
        get
        {
            return idade;
        }
        set
        {
            if (value >= 0)
            {
                idade = value;
            }
            else
            {
                idade = 0;
                Console.WriteLine("Idade negativa não permitida.");
            }
        }
    }

    public Pessoa05(string nome)
    {
        Nome = nome;
    }
}

// Exercício 6
class Produto06
{
    public string Nome { get; set; } = "";
    public double Preco { get; set; }

    public Produto06(string nome, double preco)
    {
        Nome = nome;
        Preco = preco;
    }
}

// Exercício 7
class Produto07
{
    public string Nome { get; set; } = "";

    private double preco;

    public double Preco
    {
        get
        {
            return preco;
        }
        set
        {
            if (value > 0)
            {
                preco = value;
            }
            else
            {
                preco = 0;
                Console.WriteLine("Preço deve ser maior que zero.");
            }
        }
    }

    public Produto07(string nome)
    {
        Nome = nome;
    }
}

// Exercício 8
class Produto08
{
    public string Nome { get; set; } = "";
    public double Preco { get; private set; }

    public Produto08(string nome, double preco)
    {
        Nome = nome;
        Preco = preco;
    }

    public void AplicarDesconto(double percentual)
    {
        Preco = Preco - (Preco * percentual / 100);
    }
}

// Exercício 9
class ContaBancaria09
{
    private double saldo;

    public void Depositar(double valor)
    {
        if (valor > 0)
        {
            saldo += valor;
        }
    }

    public double ConsultarSaldo()
    {
        return saldo;
    }
}

// Exercício 10
class ContaBancaria10
{
    private double saldo;

    public void Depositar(double valor)
    {
        if (valor > 0)
        {
            saldo += valor;
        }
    }

    public void Sacar(double valor)
    {
        if (valor > 0 && valor <= saldo)
        {
            saldo -= valor;
        }
    }

    public double ConsultarSaldo()
    {
        return saldo;
    }
}

// Exercício 11
class ContaBancaria11
{
    private double saldo;

    public void Depositar(double valor)
    {
        if (valor > 0)
        {
            saldo += valor;
        }
    }

    public void Sacar(double valor)
    {
        if (valor <= saldo)
        {
            saldo -= valor;
        }
        else
        {
            Console.WriteLine("Saldo insuficiente.");
        }
    }

    public double ConsultarSaldo()
    {
        return saldo;
    }
}

// Exercício 12
class Aluno12
{
    public string Nome { get; set; } = "";
    public double Nota { get; set; }

    public Aluno12(string nome, double nota)
    {
        Nome = nome;
        Nota = nota;
    }
}

// Exercício 13
class Aluno13
{
    public string Nome { get; set; } = "";
    public double Nota { get; set; }

    public Aluno13(string nome, double nota)
    {
        Nome = nome;
        Nota = nota;
    }

    public bool Aprovado()
    {
        return Nota >= 7;
    }
}

// Exercício 14
class Pessoa14
{
    public string Nome { get; }

    public Pessoa14(string nome)
    {
        Nome = nome;
    }
}

// Exercício 15
class Aluno15
{
    public string Nome { get; private set; }
    public double Nota { get; private set; }

    public Aluno15(string nome, double nota)
    {
        Nome = nome;
        Nota = nota;
    }
}

// Exercício 16
class Configuracao16
{
    public readonly int Codigo;

    public Configuracao16()
    {
        Codigo = 100;
    }
}

// Exercício 17
class Matematica17
{
    public const double PI = 3.14159;
}

// Exercício 18
class Matematica18
{
    public static int Somar(int numero1, int numero2)
    {
        return numero1 + numero2;
    }
}

// Exercício 19
class Contador19
{
    public static int Quantidade = 0;

    public Contador19()
    {
        Quantidade++;
    }
}

// Exercício 20
class Pessoa20
{
    public string Nome { get; set; } = "";
    public int Idade { get; set; }

    public Pessoa20(string nome, int idade)
    {
        Nome = nome;
        Idade = idade;
    }

    public override string ToString()
    {
        return "Nome: " + Nome + " - Idade: " + Idade;
    }
}

// Exercício 21
class Carro21
{
    public void Acelerar()
    {
        Console.WriteLine("O carro está acelerando.");
    }
}

// Exercício 22
class Pessoa22
{
    public string Nome { get; set; } = "";
    public int Idade { get; set; }

    public Pessoa22(string nome, int idade)
    {
        this.Nome = nome;
        this.Idade = idade;
    }
}

// Exercício 23
class Retangulo23
{
    public double Largura { get; set; }
    public double Altura { get; set; }

    public double Area
    {
        get
        {
            return Largura * Altura;
        }
    }

    public Retangulo23(double largura, double altura)
    {
        Largura = largura;
        Altura = altura;
    }
}

// Exercício 24
class Pedido24
{
    private static int proximoId = 1;

    public int Id { get; }

    public Pedido24()
    {
        Id = proximoId;
        proximoId++;
    }
}

// Exercício 25
class Calculadora25
{
    public Func<int, int, int> Somar = (numero1, numero2) => numero1 + numero2;
}

// Exercício 26
class Mensagem26
{
    public void Exibir(string mensagem = "Mensagem padrão.")
    {
        Console.WriteLine(mensagem);
    }
}

// Exercício 27
class Pessoa27
{
    public string Nome { get; init; } = "";
    public int Idade { get; init; }
}

// Exercício 28
record Cliente28(string Nome, string Telefone);

// Exercício 29
class Pessoa29
{
    public string Nome { get; set; } = "";
    public int Idade { get; set; }

    public Pessoa29(string nome, int idade)
    {
        Nome = nome;
        Idade = idade;
    }

    public string ObterDados()
    {
        return "Nome: " + Nome + " | Idade: " + Idade;
    }
}

// Exercício 30
class Funcionario30
{
    private string nome;
    private double salario;

    public Funcionario30(string nome, double salario)
    {
        this.nome = nome;
        this.salario = salario;
    }

    public void AumentarSalario(double valor)
    {
        if (valor > 0)
        {
            salario += valor;
        }
    }

    public string ObterDados()
    {
        return "Funcionário: " + nome + " | Salário: R$ " + salario.ToString("F2");
    }
}

// Exercício 31
class Animal31
{
    public string Nome { get; set; } = "";

    public Animal31(string nome)
    {
        Nome = nome;
    }

    public void EmitirSom()
    {
        Console.WriteLine("O animal emitiu um som.");
    }
}

// Exercício 32
class Cachorro32 : Animal32
{
    public Cachorro32(string nome) : base(nome)
    {
    }
}

class Animal32
{
    public string Nome { get; set; } = "";

    public Animal32(string nome)
    {
        Nome = nome;
    }

    public virtual void EmitirSom()
    {
        Console.WriteLine("Som de animal.");
    }
}

// Exercício 33
class Animal33
{
    public string Nome { get; set; } = "";

    public Animal33(string nome)
    {
        Nome = nome;
    }

    public virtual void EmitirSom()
    {
        Console.WriteLine("Som de animal.");
    }
}

// Exercício 34
class Animal34
{
    public string Nome { get; set; } = "";

    public Animal34(string nome)
    {
        Nome = nome;
    }

    public virtual void EmitirSom()
    {
        Console.WriteLine("Som de animal.");
    }
}

class Cachorro34 : Animal34
{
    public Cachorro34(string nome) : base(nome)
    {
    }

    public override void EmitirSom()
    {
        Console.WriteLine("Au au!");
    }
}

// Exercício 35
class Animal35
{
    public string Nome { get; set; } = "";

    public Animal35(string nome)
    {
        Nome = nome;
    }

    public virtual void EmitirSom()
    {
        Console.WriteLine("Som de animal.");
    }
}

class Gato35 : Animal35
{
    public Gato35(string nome) : base(nome)
    {
    }

    public override void EmitirSom()
    {
        Console.WriteLine("Miau!");
    }
}

// Exercício 36
class Animal36
{
    public string Nome { get; set; } = "";

    public Animal36(string nome)
    {
        Nome = nome;
    }

    public virtual void EmitirSom()
    {
        Console.WriteLine("Som de animal.");
    }
}

class Cachorro36 : Animal36
{
    public Cachorro36(string nome) : base(nome)
    {
    }

    public override void EmitirSom()
    {
        Console.WriteLine("Au au!");
    }
}

class Gato36 : Animal36
{
    public Gato36(string nome) : base(nome)
    {
    }

    public override void EmitirSom()
    {
        Console.WriteLine("Miau!");
    }
}

// Exercício 37
class Veiculo37
{
    public string Nome { get; set; } = "";

    public Veiculo37(string nome)
    {
        Nome = nome;
    }

    public void MostrarDados()
    {
        Console.WriteLine("Veículo: " + Nome);
    }
}

// Exercício 38
class Veiculo38
{
    public string Nome { get; set; } = "";

    public Veiculo38(string nome)
    {
        Nome = nome;
    }

    public virtual void MostrarDados()
    {
        Console.WriteLine("Veículo: " + Nome);
    }
}

class Carro38 : Veiculo38
{
    public Carro38(string nome) : base(nome)
    {
    }
}

// Exercício 39
class Veiculo39
{
    public string Nome { get; set; } = "";

    public Veiculo39(string nome)
    {
        Nome = nome;
    }

    public virtual void MostrarDados()
    {
        Console.WriteLine("Veículo: " + Nome);
    }
}

class Moto39 : Veiculo39
{
    public Moto39(string nome) : base(nome)
    {
    }
}

// Exercício 40
class Veiculo40
{
    public string Nome { get; set; } = "";

    public Veiculo40(string nome)
    {
        Nome = nome;
    }

    public void MostrarDados()
    {
        Console.WriteLine("Nome: " + Nome);
    }
}

class Carro40 : Veiculo40
{
    public Carro40(string nome) : base(nome)
    {
    }
}

// Exercício 41
class Veiculo41
{
    public virtual double CalcularConsumo()
    {
        return 10;
    }
}

// Exercício 42
class Veiculo42
{
    public virtual double CalcularConsumo()
    {
        return 10;
    }
}

class Carro42 : Veiculo42
{
    public override double CalcularConsumo()
    {
        return 12;
    }
}

class Moto42 : Veiculo42
{
    public override double CalcularConsumo()
    {
        return 20;
    }
}

// Exercício 43
sealed class Carro43
{
    public void Mostrar()
    {
        Console.WriteLine("Classe Carro é sealed.");
    }
}

// Exercício 44
class Animal44
{
    public virtual void EmitirSom()
    {
        Console.WriteLine("Som de animal.");
    }
}

class Cachorro44 : Animal44
{
    public sealed override void EmitirSom()
    {
        Console.WriteLine("Au au!");
    }
}

// Exercício 45
class Pessoa45
{
    public string Nome { get; set; } = "";

    public Pessoa45(string nome)
    {
        Nome = nome;
    }
}

// Exercício 46
class Pessoa46
{
    public string Nome { get; set; } = "";

    public Pessoa46(string nome)
    {
        Nome = nome;
    }
}

class Funcionario46 : Pessoa46
{
    public double Salario { get; set; }

    public Funcionario46(string nome, double salario) : base(nome)
    {
        Salario = salario;
    }

    public void MostrarDados()
    {
        Console.WriteLine("Nome: " + Nome);
        Console.WriteLine("Salário: R$ " + Salario.ToString("F2"));
    }
}

// Exercício 47
class Pessoa47
{
    public string Nome { get; set; } = "";

    public Pessoa47(string nome)
    {
        Nome = nome;
    }
}

class Funcionario47 : Pessoa47
{
    public double Salario { get; set; }

    public Funcionario47(string nome, double salario) : base(nome)
    {
        Salario = salario;
    }

    public virtual void MostrarDados()
    {
        Console.WriteLine("Funcionário: " + Nome);
        Console.WriteLine("Salário: R$ " + Salario.ToString("F2"));
    }
}

class Gerente47 : Funcionario47
{
    public Gerente47(string nome, double salario) : base(nome, salario)
    {
    }

    public override void MostrarDados()
    {
        Console.WriteLine("Gerente: " + Nome);
        Console.WriteLine("Salário: R$ " + Salario.ToString("F2"));
    }
}

// Exercício 48
class Pessoa48
{
    public string Nome { get; set; } = "";

    public Pessoa48(string nome)
    {
        Nome = nome;
    }

    public void MostrarPessoa()
    {
        Console.WriteLine("Pessoa: " + Nome);
    }
}

class Funcionario48 : Pessoa48
{
    public double Salario { get; set; }

    public Funcionario48(string nome, double salario) : base(nome)
    {
        Salario = salario;
    }

    public void MostrarFuncionario()
    {
        Console.WriteLine("Salário: R$ " + Salario.ToString("F2"));
    }
}

class Gerente48 : Funcionario48
{
    public Gerente48(string nome, double salario) : base(nome, salario)
    {
    }

    public void MostrarGerente()
    {
        Console.WriteLine("Cargo: Gerente");
    }
}

// Exercício 49
class Pessoa49
{
    protected string nome;

    public Pessoa49(string nome)
    {
        this.nome = nome;
    }
}

class Funcionario49 : Pessoa49
{
    public Funcionario49(string nome) : base(nome)
    {
    }

    public void MostrarNome()
    {
        Console.WriteLine("Nome: " + nome);
    }
}

// Exercício 50
class Pessoa50
{
    protected string nome;

    public Pessoa50(string nome)
    {
        this.nome = nome;
    }
}

class Funcionario50 : Pessoa50
{
    public Funcionario50(string nome) : base(nome)
    {
    }

    public void MostrarNome()
    {
        Console.WriteLine("Membro protected: " + nome);
    }
}

// Exercício 51
class Animal51
{
    public virtual void EmitirSom()
    {
        Console.WriteLine("Som padrão do animal.");
    }
}

// Exercício 52
class Animal52
{
    public virtual void EmitirSom()
    {
        Console.WriteLine("Som padrão do animal.");
    }
}

class Cachorro52 : Animal52
{
    public override void EmitirSom()
    {
        base.EmitirSom();
        Console.WriteLine("Au au!");
    }
}

// Exercício 53
class Conta53
{
    public double Saldo { get; protected set; }

    public Conta53(double saldo)
    {
        Saldo = saldo;
    }

    public virtual void Sacar(double valor)
    {
        if (valor <= Saldo)
        {
            Saldo -= valor;
        }
    }
}

// Exercício 54
class Conta54
{
    public double Saldo { get; protected set; }

    public Conta54(double saldo)
    {
        Saldo = saldo;
    }

    public virtual void Sacar(double valor)
    {
        if (valor <= Saldo)
        {
            Saldo -= valor;
        }
    }
}

class ContaCorrente54 : Conta54
{
    public ContaCorrente54(double saldo) : base(saldo)
    {
    }
}

class ContaPoupanca54 : Conta54
{
    public ContaPoupanca54(double saldo) : base(saldo)
    {
    }
}

// Exercício 55
class Conta55
{
    public double Saldo { get; protected set; }

    public Conta55(double saldo)
    {
        Saldo = saldo;
    }

    public virtual void Sacar(double valor)
    {
        if (valor <= Saldo)
        {
            Saldo -= valor;
        }
    }
}

class ContaCorrente55 : Conta55
{
    public ContaCorrente55(double saldo) : base(saldo)
    {
    }

    public override void Sacar(double valor)
    {
        if (valor <= Saldo)
        {
            Saldo -= valor;
        }
    }
}

class ContaPoupanca55 : Conta55
{
    public ContaPoupanca55(double saldo) : base(saldo)
    {
    }

    public override void Sacar(double valor)
    {
        if (valor + 5 <= Saldo)
        {
            Saldo -= valor + 5;
        }
    }
}

// Exercício 56
class Nivel1_56
{
    public void MostrarNivel1()
    {
        Console.WriteLine("Nível 1");
    }
}

class Nivel2_56 : Nivel1_56
{
    public void MostrarNivel2()
    {
        Console.WriteLine("Nível 2");
    }
}

class Nivel3_56 : Nivel2_56
{
    public void MostrarNivel3()
    {
        Console.WriteLine("Nível 3");
    }
}

class Nivel4_56 : Nivel3_56
{
    public void MostrarNivel4()
    {
        Console.WriteLine("Nível 4");
    }
}

// Exercício 57
class Animal57
{
}

class Cachorro57 : Animal57
{
    public void Latir()
    {
        Console.WriteLine("Au au!");
    }
}

// Exercício 58
class Animal58
{
}

class Cachorro58 : Animal58
{
    public void Latir()
    {
        Console.WriteLine("Au au!");
    }
}

// Exercício 59
class Animal59
{
    public virtual void EmitirSom()
    {
        Console.WriteLine("Som de animal.");
    }
}

class Cachorro59 : Animal59
{
    public override void EmitirSom()
    {
        Console.WriteLine("Au au!");
    }
}


// Exercício 60
class Animal60
{
    public virtual void EmitirSom()
    {
        Console.WriteLine("Som de animal.");
    }
}

class Cachorro60 : Animal60
{
    public override void EmitirSom()
    {
        Console.WriteLine("Au au!");
    }
}

// Exercício 61
abstract class Forma61
{
    public abstract double CalcularArea();
}

class Quadrado61 : Forma61
{
    private double lado;

    public Quadrado61(double lado)
    {
        this.lado = lado;
    }

    public override double CalcularArea()
    {
        return lado * lado;
    }
}

// Exercício 62
abstract class Forma62
{
    public abstract double CalcularArea();
}

class Quadrado62 : Forma62
{
    private double lado;

    public Quadrado62(double lado)
    {
        this.lado = lado;
    }

    public override double CalcularArea()
    {
        return lado * lado;
    }
}

// Exercício 63
abstract class Forma63
{
    public abstract double CalcularArea();
}

class Quadrado63 : Forma63
{
    private double lado;

    public Quadrado63(double lado)
    {
        this.lado = lado;
    }

    public override double CalcularArea()
    {
        return lado * lado;
    }
}

// Exercício 64
abstract class Forma64
{
    public abstract double CalcularArea();
}

class Circulo64 : Forma64
{
    private double raio;

    public Circulo64(double raio)
    {
        this.raio = raio;
    }

    public override double CalcularArea()
    {
        return 3.14159 * raio * raio;
    }
}

// Exercício 65
abstract class Forma65
{
    public abstract double CalcularArea();
}

class Quadrado65 : Forma65
{
    private double lado;

    public Quadrado65(double lado)
    {
        this.lado = lado;
    }

    public override double CalcularArea()
    {
        return lado * lado;
    }
}

class Circulo65 : Forma65
{
    private double raio;

    public Circulo65(double raio)
    {
        this.raio = raio;
    }

    public override double CalcularArea()
    {
        return 3.14159 * raio * raio;
    }
}

// Exercício 66
abstract class Forma66
{
    public abstract double Area { get; }
}

class Quadrado66 : Forma66
{
    private double lado;

    public Quadrado66(double lado)
    {
        this.lado = lado;
    }

    public override double Area
    {
        get
        {
            return lado * lado;
        }
    }
}

// Exercício 67
abstract class Forma67
{
    public abstract double Area { get; }
}

class Circulo67 : Forma67
{
    private double raio;

    public Circulo67(double raio)
    {
        this.raio = raio;
    }

    public override double Area
    {
        get
        {
            return 3.14159 * raio * raio;
        }
    }
}

// Exercício 68
abstract class Funcionario68
{
    public string Nome { get; protected set; }

    protected Funcionario68(string nome)
    {
        Nome = nome;
    }

    public abstract double CalcularSalario();
}

class Desenvolvedor68 : Funcionario68
{
    public Desenvolvedor68(string nome) : base(nome)
    {
    }

    public override double CalcularSalario()
    {
        return 3000;
    }
}

// Exercício 69
abstract class Funcionario69
{
    public string Nome { get; protected set; }

    public Funcionario69(string nome)
    {
        Nome = nome;
    }

    public abstract double CalcularSalario();
}

class Desenvolvedor69 : Funcionario69
{
    private double salario;

    public Desenvolvedor69(string nome, double salario) : base(nome)
    {
        this.salario = salario;
    }

    public override double CalcularSalario()
    {
        return salario;
    }
}

// Exercício 70
abstract class Funcionario70
{
    public string Nome { get; protected set; }

    public Funcionario70(string nome)
    {
        Nome = nome;
    }

    public abstract double CalcularSalario();
}

class Desenvolvedor70 : Funcionario70
{
    private double salario;

    public Desenvolvedor70(string nome, double salario) : base(nome)
    {
        this.salario = salario;
    }

    public override double CalcularSalario()
    {
        return salario;
    }
}

// Exercício 71
abstract class Funcionario71
{
    public string Nome { get; protected set; }

    public Funcionario71(string nome)
    {
        Nome = nome;
    }

    public abstract double CalcularSalario();
}

class Gerente71 : Funcionario71
{
    private double salario;

    public Gerente71(string nome, double salario) : base(nome)
    {
        this.salario = salario;
    }

    public override double CalcularSalario()
    {
        return salario;
    }
}

// Exercício 72
abstract class Funcionario72
{
    public string Nome { get; protected set; }

    protected Funcionario72(string nome)
    {
        Nome = nome;
    }
}

class Desenvolvedor72 : Funcionario72
{
    public Desenvolvedor72(string nome) : base(nome)
    {
    }

    public void MostrarNome()
    {
        Console.WriteLine("Nome: " + Nome);
    }
}

// Exercício 73
abstract class Funcionario73
{
    public string Nome { get; protected set; }

    protected Funcionario73(string nome)
    {
        Nome = nome;
    }
}

class Desenvolvedor73 : Funcionario73
{
    public Desenvolvedor73(string nome) : base(nome)
    {
    }

    public void MostrarNome()
    {
        Console.WriteLine("Nome: " + Nome);
    }
}

// Exercício 74
abstract class Funcionario74
{
    public string Nome { get; protected set; }

    protected Funcionario74(string nome)
    {
        Nome = nome;
    }

    public abstract double CalcularSalario();

    public virtual void MostrarTipo()
    {
        Console.WriteLine("Tipo: Funcionário");
    }
}

class Desenvolvedor74 : Funcionario74
{
    private double salario;

    public Desenvolvedor74(string nome, double salario) : base(nome)
    {
        this.salario = salario;
    }

    public override double CalcularSalario()
    {
        return salario;
    }

    public override void MostrarTipo()
    {
        base.MostrarTipo();
        Console.WriteLine("Cargo: Desenvolvedor");
    }
}

// Exercício 75
interface IImprimivel75
{
    void Imprimir();
}

abstract class RelatorioBase75 : IImprimivel75
{
    public abstract void Imprimir();
}

class Relatorio75 : RelatorioBase75
{
    public override void Imprimir()
    {
        Console.WriteLine("Relatório impresso.");
    }
}

// Exercício 76
interface IImprimivel76
{
    void Imprimir();
}

class Documento76 : IImprimivel76
{
    public string Texto { get; set; } = "";

    public Documento76(string texto)
    {
        Texto = texto;
    }

    public void Imprimir()
    {
        Console.WriteLine(Texto);
    }
}

// Exercício 77
interface IImprimivel77
{
    void Imprimir();
}

class Documento77 : IImprimivel77
{
    private string texto;

    public Documento77(string texto)
    {
        this.texto = texto;
    }

    public void Imprimir()
    {
        Console.WriteLine("Documento: " + texto);
    }
}

// Exercício 78
interface IAutenticavel78
{
    bool Autenticar(string usuario, string senha);
}

class Administrador78 : IAutenticavel78
{
    private string usuario;
    private string senha;

    public Administrador78(string usuario, string senha)
    {
        this.usuario = usuario;
        this.senha = senha;
    }

    public bool Autenticar(string usuario, string senha)
    {
        return this.usuario == usuario && this.senha == senha;
    }
}

// Exercício 79
interface IAutenticavel79
{
    bool Autenticar(string usuario, string senha);
}

class Administrador79 : IAutenticavel79
{
    private string usuario;
    private string senha;

    public Administrador79(string usuario, string senha)
    {
        this.usuario = usuario;
        this.senha = senha;
    }

    public bool Autenticar(string usuario, string senha)
    {
        return this.usuario == usuario && this.senha == senha;
    }
}

// Exercício 80
interface IAutenticavel80
{
    bool Autenticar(string usuario, string senha);
}

class Cliente80 : IAutenticavel80
{
    private string nome;
    private string senha;

    public Cliente80(string nome, string senha)
    {
        this.nome = nome;
        this.senha = senha;
    }

    public bool Autenticar(string usuario, string senha)
    {
        return nome == usuario && this.senha == senha;
    }
}

// Exercício 81
interface IImprimivel81
{
    void Imprimir();
}

interface IAutenticavel81
{
    bool Autenticar(string usuario, string senha);
}

class Usuario81 : IImprimivel81, IAutenticavel81
{
    private string nome;
    private string senha;

    public Usuario81(string nome, string senha)
    {
        this.nome = nome;
        this.senha = senha;
    }

    public void Imprimir()
    {
        Console.WriteLine("Usuário: " + nome);
    }

    public bool Autenticar(string usuario, string senha)
    {
        return nome == usuario && this.senha == senha;
    }
}

// Exercício 82
interface IProduto82
{
    string Nome { get; }
    double Preco { get; }
}

class Produto82 : IProduto82
{
    public string Nome { get; set; } = "";
    public double Preco { get; set; }

    public Produto82(string nome, double preco)
    {
        Nome = nome;
        Preco = preco;
    }
}

// Exercício 83
interface IValidador83
{
    bool Validar(string senha);
}

class Autenticador83 : IValidador83
{
    public bool Validar(string senha)
    {
        return senha == "1234";
    }
}

// Exercício 84
interface IImprimivel84
{
    void Imprimir();
}

class Documento84 : IImprimivel84
{
    private string nome;

    public Documento84(string nome)
    {
        this.nome = nome;
    }

    public void Imprimir()
    {
        Console.WriteLine("Imprimindo: " + nome);
    }
}


// Exercício 85
class Pagamento85
{
    protected double Valor;

    public Pagamento85(double valor)
    {
        Valor = valor;
    }

    public virtual void Processar()
    {
        Console.WriteLine("Pagamento de R$ " + Valor.ToString("F2"));
    }
}

// Exercício 86
abstract class PagamentoBase86
{
    protected double Valor;

    public PagamentoBase86(double valor)
    {
        Valor = valor;
    }

    public abstract void Processar();
}

class PagamentoPix86 : PagamentoBase86
{
    public PagamentoPix86(double valor) : base(valor)
    {
    }

    public override void Processar()
    {
        Console.WriteLine("Pagamento PIX: R$ " + Valor.ToString("F2"));
    }
}

// Exercício 87
abstract class PagamentoBase87
{
    protected double Valor;

    public PagamentoBase87(double valor)
    {
        Valor = valor;
    }

    public abstract void Processar();
}

class PagamentoCartao87 : PagamentoBase87
{
    public PagamentoCartao87(double valor) : base(valor)
    {
    }

    public override void Processar()
    {
        Console.WriteLine("Pagamento com cartão: R$ " + Valor.ToString("F2"));
    }
}

// Exercício 88
interface IPagamento88
{
    void Processar();
}

class PagamentoPix88 : IPagamento88
{
    private double valor;

    public PagamentoPix88(double valor)
    {
        this.valor = valor;
    }

    public void Processar()
    {
        Console.WriteLine("PIX: R$ " + valor.ToString("F2"));
    }
}

class PagamentoCartao88 : IPagamento88
{
    private double valor;

    public PagamentoCartao88(double valor)
    {
        this.valor = valor;
    }

    public void Processar()
    {
        Console.WriteLine("Cartão: R$ " + valor.ToString("F2"));
    }
}

// Exercício 89
interface IPagamento89
{
    void Processar();
}

class PagamentoPix89 : IPagamento89
{
    private double valor;

    public PagamentoPix89(double valor)
    {
        this.valor = valor;
    }

    public void Processar()
    {
        Console.WriteLine("PIX: R$ " + valor.ToString("F2"));
    }
}


// Exercício 90
interface IPagamento90
{
    void Processar();
}

abstract class Pagamento90 : IPagamento90
{
    protected double Valor;

    public Pagamento90(double valor)
    {
        Valor = valor;
    }

    public abstract void Processar();
}

class PagamentoPix90 : Pagamento90
{
    public PagamentoPix90(double valor) : base(valor)
    {
    }

    public override void Processar()
    {
        Console.WriteLine("PIX: R$ " + Valor.ToString("F2"));
    }
}

class PagamentoCartao90 : Pagamento90
{
    public PagamentoCartao90(double valor) : base(valor)
    {
    }

    public override void Processar()
    {
        Console.WriteLine("Cartão: R$ " + Valor.ToString("F2"));
    }
}
