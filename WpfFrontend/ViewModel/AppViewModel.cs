using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Collections.ObjectModel;

using BusinessLayer;
using Model.Entities;

namespace WpfFrontend.ViewModel
{
    public class AppViewModel : BaseViewModel
    {
        private ObservableCollection<ProductViewModel> _produits = null;

        private ProductViewModel _selectedProduit = null;

        public ObservableCollection<ProductViewModel> Produits
        {
            get { return _produits; }
            set
            {
                _produits = value;
                OnPropertyChanged("Produits");
            }
        }

        public ProductViewModel ProduitSelection {
            get
            {
                return _selectedProduit;
            }
            set
            {
                _selectedProduit = value;
                OnPropertyChanged("ProduitSelection");
            }
        }

        public AppViewModel()
        {
            _produits = new ObservableCollection<ProductViewModel>();

             foreach (Product p in BusinessManager.Instance.GetAllProducts())
             {
                 _produits.Add(new ProductViewModel(p));
             }
        }
    }
}
