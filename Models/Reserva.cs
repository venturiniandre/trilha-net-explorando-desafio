namespace DesafioProjetoHospedagem.Models
{
   public class Reserva
{
    public List<Pessoa> Hospedes { get; set; }
    public Suite Suite { get; set; }
    public int DiasReservados { get; set; }

    public void CadastrarHospedes(List<Pessoa> hospedes)
    {
        if (hospedes.Count > Suite.Capacidade)
        {
            throw new Exception("A quantidade de hóspedes excede a capacidade da suíte.");
        }

        Hospedes = hospedes;
    }

    public void CadastrarSuite(Suite suite)
    {
        Suite = suite;
    }

    public int ObterQuantidadeHospedes()
    {
        return Hospedes.Count;
    }

    public decimal CalcularValorDiaria()
    {
        decimal valor = DiasReservados * Suite.ValorDiaria;

        if (DiasReservados >= 10)
        {
            valor *= 0.9m; // Aplica 10% de desconto
        }

        return valor;
    }
}

}
