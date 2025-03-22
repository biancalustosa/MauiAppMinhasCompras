using SQLite;


namespace MauiAppMinhasCompras.Models;

public class Produto 
{
    String _descricao;
    Double _quantidade;
    Double _preco;

    [PrimaryKey, AutoIncrement]
    public int Id { get; set; }
    public string Descricao { 
        get => _descricao; 
        set {
            if(value == null){
                throw new Exception("Descrição não pode ser vazia");
            }
            _descricao = value;
        } 
    }
    public double Quantidade { 
        get => _quantidade;
        set {
            if(value < 1){
                throw new Exception("Quantidade deve ser maior ou igual a 1");
            }
            _quantidade = value;
        } 
    }
    public double Preco { 
        get => _preco; 
        set {
            if(value == 0){
                throw new Exception("Preço não pode ser vazio ou igual a zero");
            }
            
            if(value < 0){
                throw new Exception("Preço não pode ser menor que zero");
            
            }
        _preco = value;
    }
}

    public double Total { get => Quantidade * Preco; }
}

