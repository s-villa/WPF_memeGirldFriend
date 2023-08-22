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

namespace WPF_Quieres_Ser_Mi_Novia.UserControls
{
    /// <summary>
    /// Lógica de interacción para UCPresentation.xaml
    /// </summary>
    public partial class UCPresentation 
    {
        #region Propiedades

        #endregion

        #region Constructor
        public UCPresentation()
        {
            InitializeComponent();
        } 
        #endregion

        #region Events
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.navigator.Navigate(UserControlView.Question);
        } 
        #endregion
    }
}
