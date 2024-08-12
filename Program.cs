using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Cria os hóspedes
        List<Pessoa> hospedes = new()
        {
            new Pessoa("Hóspede 1"),
            new Pessoa("Hóspede 2")
        };

        // Cria a suíte
        Suite suite = new(tipoSuite: "Premium", capacidade: 2, valorDiaria: 30);

        // Cria uma nova reserva, passando a suíte e os hóspedes
        Reserva reserva = new(diasReservados: 5, suite: suite, hospedes: hospedes);

        // Aqui você pode adicionar mais lógica, como calcular o valor total da reserva
        Console.WriteLine($"Reserva para {reserva.DiasReservados} dias na suíte {suite.TipoSuite}.");
    }
}

internal class Pessoa
{
    public Pessoa(string nome)
    {
        Nome = nome;
    }

    public string Nome { get; }
}

internal class Suite
{
    public Suite(string tipoSuite, int capacidade, int valorDiaria)
    {
        TipoSuite = tipoSuite;
        Capacidade = capacidade;
        ValorDiaria = valorDiaria;
    }

    public string TipoSuite { get; }
    public int Capacidade { get; }
    public int ValorDiaria { get; }
}

internal class Reserva
{
    public Reserva(int diasReservados, Suite suite, List<Pessoa> hospedes)
    {
        DiasReservados = diasReservados;
        SuiteReservada = suite;
        Hospedes = hospedes;
    }

    public int DiasReservados { get; }
    public Suite SuiteReservada { get; }
    public List<Pessoa> Hospedes { get; }
}
