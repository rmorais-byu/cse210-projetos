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
        if (_resitros.Count == 0)
        {
            Console.WriteLine("\nO diário está vazio.\n");
            return;
        }
        
    }