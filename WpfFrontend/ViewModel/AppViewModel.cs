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
        private ObservableCollection<ProduitViewModel> _produits = null;

        public ObservableCollection<ProduitViewModel> Produits
        {
            get { return _produits; }
            set
            {
                _produits = value;
                OnPropertyChanged("Produits");
            }
        }

        public ProduitViewModel ProduitSelection { get; set; }

        public AppViewModel()
        {
            _produits = new ObservableCollection<ProduitViewModel>();

             foreach (Product p in BusinessManager.Instance.GetAllProducts())
             {
                 _produits.Add(new ProduitViewModel(p));
             }
        }
    }
}
