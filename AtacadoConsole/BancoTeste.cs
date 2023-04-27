using Atacado.BD.EF.Database;

namespace AtacadoConsole;

public class BancoTestes : BaseTestes
{
    public BancoTestes(AtacadoContext contexto) : base(contexto)
    {
    }

    public override void Imprimir()
    {
        Console.WriteLine("--- Exibindo Bancos ---");
        foreach (Banco item in context.Bancos.ToList())
         {
             Console.WriteLine($"{item.CodigoBanco} - {item.CodigoBacen} - {item.Descricao} - {item.SiteBanco}");
         }
         Console.WriteLine("--- Finalizando Bancos ---");
         Console.ReadLine();
    }
}