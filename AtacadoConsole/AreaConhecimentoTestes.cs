using Atacado.BD.EF.Database;

namespace AtacadoConsole;

public class AreaConhecimentoTestes : BaseTestes
{
    public AreaConhecimentoTestes(AtacadoContext contexto) : base(contexto)
    {
    }

    public override void Imprimir()
    {
        Console.WriteLine("--- Exibindo Área Conhecimento ---");
        foreach (AreaConhecimento item in context.AreaConhecimentos.ToList())
         {
             Console.WriteLine($"{item.CodigoArea} - {item.Descricao} - {item.Situacao}");
         }
         Console.WriteLine("--- Finalizando Área Conhecimento ---");
         Console.ReadLine();
    }
}