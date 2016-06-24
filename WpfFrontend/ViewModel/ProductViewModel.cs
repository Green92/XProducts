using BusinessLayer;
using Cours2_ExempleMVVM.ViewModels.Common;
using Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WpfFrontend.ViewModel
{
    public class ProductViewModel : BaseViewModel
    {
        private RelayCommand _persistOperation;

        public int Id { get; set; }

        public string Code { get; set; }

        public string Libelle { get; set; }

        public string Description { get; set; }

        public bool Actif { get; set; }

        public int Stock { get; set; }

        public int Prix { get; set; }

        public Category Category { get; set; }

        public String ErrorMessage { get; set; }

        public ProductViewModel(Product product)
        {
            Id = product.Id;
            Category = product.Category;
            Libelle = product.Name;
        }

        public ICommand PersistOperation
        {
            get
            {
                if (_persistOperation == null)
                {
                    _persistOperation = new RelayCommand(() => this.Persist());
                }

                return _persistOperation;
            }
        }

        private void Persist()
        {
            try {
                Product product = new Product();
                product.Category = Category;
                product.Id = Id;
                product.Name = Libelle;

                BusinessManager.Instance.EditProduct(product);
            } catch (Exception e)
            {
                ErrorMessage = e.Message;
                View.ErrorWindow errorWindow = new View.ErrorWindow();
                errorWindow.DataContext = this;
                errorWindow.ShowDialog();
            }
        }
    }
}
