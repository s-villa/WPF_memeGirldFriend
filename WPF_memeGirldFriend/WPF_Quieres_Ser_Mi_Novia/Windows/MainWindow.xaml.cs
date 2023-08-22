using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WPF_Quieres_Ser_Mi_Novia.Class;

namespace WPF_Quieres_Ser_Mi_Novia
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        #region "Propiedades"
        public static Navigator navigator { get; set; }

        #endregion

        #region Constructor
        public MainWindow()
        {
            InitializeComponent();

            SetUserControl();
        }
        #endregion

        #region Metodos

        private void SetUserControl()
        {
            try
            {
                if (navigator == null)
                {
                    navigator = new Navigator();
                }

                navigator.Navigate(UserControlView.Presentation);

                DataContext = navigator;
            }
            catch (Exception ex)
            {
            }
        }

        #endregion
    }
}
