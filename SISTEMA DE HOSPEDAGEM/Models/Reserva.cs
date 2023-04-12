using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SISTEMA_DE_HOSPEDAGEM.Models
{
   public class Reserva
{
    public List<Pessoa> Hospedes { get; set; }
    public Suite Suite { get; set; }
    public decimal ValorDiaria { get; set; }
    public int DiasReservados { get; set; }
    
    public Reserva() {}

    public Reserva(int diasReservados)
    {
        DiasReservados = diasReservados;
    }

    public void CadastrarHospedes(List<Pessoa> hospedes)
    {
        if (Suite.CapacidadeHospedes >= hospedes.Count)
        {
            Hospedes = hospedes;
        }
        else
        {
            throw new Exception("Capacidade inferior ao nº de hospedes.");
        }
    }
    
    public void CadastrarSuite(Suite suite)
    {
        Suite = suite;
    }
    
    public int QtdeHospedes()
    {
        return Hospedes.Count;
    }

    public decimal CalcularValDiaria()
    {
        decimal valor = DiasReservados * Suite.ValorDiaria;
        if (DiasReservados >= 10)
        {
            valor -= (valor * 0.1m); // alteração: usar 0.1m para obter um valor decimal na divisão
        }
        return valor;
    }
}

}