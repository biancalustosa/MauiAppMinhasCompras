using System;
using System.Collections.ObjectModel;
using MauiAppMinhasCompras.Models;

namespace MauiAppMinhasCompras.ViewModels;

public class RelatorioViewModels
{
    public ObservableCollection<RelatorioCategorias> Relatorio { get; set; }

        public RelatorioViewModels(List<Produto> produtos)
        {
        

            Relatorio = new ObservableCollection<RelatorioCategorias>(
                produtos.GroupBy(p => p.Categoria)
                        .Select(g => new RelatorioCategorias
                        {
                            Categoria = g.Key,
                            Total = g.Sum(p => p.Total)
                        })
                        .ToList()
            );
            
        }
}
