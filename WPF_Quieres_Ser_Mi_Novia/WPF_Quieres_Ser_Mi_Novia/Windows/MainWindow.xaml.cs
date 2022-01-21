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
                if (Utilities.navigator == null)
                {
                    Utilities.navigator = new Navigator();
                }

                Utilities.navigator.Navigate(UserControlView.Presentation);

                DataContext = Utilities.navigator;
            }
            catch (Exception ex)
            {
            }
        }

        #endregion
    }
}
