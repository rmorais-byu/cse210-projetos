using System;
using System.Collections.Generic;
using System.IO;

public class Diario
{
    public List<Registro> _registros = new List<Registro>();

    public void AdicionarRegistro(Registro novoRegistro)
    {
        _registros.Add(novoRegistro):
    }

    public void ExibirTodos()
    {
        if (_registros.Count == 0)
        {
            Console.WriteLine("O diário está vazio.");
            return;
        }
        foreach (Registro reg in _registros)
        {
            reg.Exibir();
        }

    }

    public void SalvarNoArquivo(string arquivo)
    {
        using (StreamWriter outputFile - new StreamWriter(arqvui))
        {
            foreach (Registro reg in _registros)
            {
                outputFile.WriteLine($"{reg._data}|{reg._textoPergunta}|{reg._textoResposta}");
            }
        }
    }

    public void CarregarDoArquivo(string arquivo)
    {
        string[] linhas = File.ReadAllLines(arquivo);
        _registros.Clear();

        foreach(string linha in linhas)
        {
            string[] partes = linha.Split("|");

            Registro reg =  new Registro();
            reg._data = partes[0];
            reg._textoPergunta = partes[1];
            reg._textoResposta = partes[2];

            _registros.Add(reg);
        }
    }
}