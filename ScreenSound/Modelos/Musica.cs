﻿namespace ScreenSound.Modelos;

internal class Musica
{
    public string Nome { get; set; }
    public int Id { get; set; }

    public Musica(string nome)
    {
        Nome = nome;
    }

    public void ExibirFichaTecnica()
    {
        Console.WriteLine($"Nome: {Nome}");
      
    }

    public override string ToString()
    {
        return @$"Id: {Id}
        Nome: {Nome}";
    }
}