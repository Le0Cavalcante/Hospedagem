using SISTEMA_DE_HOSPEDAGEM.Models;

List <Pessoa> hospedes = new List<Pessoa>();

Pessoa p1 = new Pessoa (nome: "Hóspede", sobrenome: "1");
Pessoa p2 = new Pessoa (nome: "Hóspede", sobrenome: "2");

hospedes.Add(p1);
hospedes.Add(p2);

Suite suite = new Suite(tipoSuite: "Premium", capacidadeHospedes: 2, valorDiaria: 30);

Reserva reserva = new Reserva(diasReservados: 5);
reserva.CadastrarSuite(suite);
reserva.CadastrarHospedes(hospedes);

Console.WriteLine($"Hóspedes: {reserva.QtdeHospedes()}");
Console.WriteLine($"Valor diária: {reserva.CalcularValDiaria()}");

