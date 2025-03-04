using SQLite; /*Os using no C# funcionam como atalhos que nos permitem acessar funcionalidades específicas de 
bibliotecas e frameworks sem precisar repetir todo o caminho de seus namespaces.*/


namespace MauiAppMinhasCompras.Models; //Ele permite agrupar classes, funções e variáveis sob um mesmo identificador

public class Produto 
{
    [PrimaryKey, AutoIncrement]
    public int Id { get; set; }
    public string Descricao { get; set; }
    public double Quantidade { get; set; }
    public double Preco { get; set; }
}
