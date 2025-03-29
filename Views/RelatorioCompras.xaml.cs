using MauiAppMinhasCompras.Models;
using MauiAppMinhasCompras.ViewModels;


namespace MauiAppMinhasCompras.Views
{
    public partial class RelatorioCompras : ContentPage
    {
        
        public RelatorioCompras(List<Produto> produtos)
        {
            InitializeComponent();
            BindingContext = new RelatorioViewModels(produtos);
        }

    
    }

}
