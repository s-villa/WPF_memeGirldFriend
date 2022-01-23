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
    /// Lógica de interacción para UCQuestion.xaml
    /// </summary>
    public partial class UCQuestion : UserControl
    {
        #region Propiedades

        Random random;

        #endregion

        #region Constructor
        public UCQuestion()
        {
            InitializeComponent();
        }
        #endregion

        #region Events
        private void BrdYeh_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Utilities.navigator.Navigate(UserControlView.End);
        }
        private void BrdNao_MouseEnter(object sender, MouseEventArgs e)
        {
            ChangePosition();
        }
        #endregion

        #region Metodos

        private void ChangePosition()
        {
            random = new Random();

            int probability = random.Next(1, 3);
            int Pst1 = random.Next(10,1300);
            int Pst2 = random.Next(10,700);
            int Pst4 = random.Next(10,700);

            if (probability == 1)
            {
                BrdNao.Margin = new Thickness(Pst1, Pst2, 0, 0);
            }
            else
            {
                BrdNao.Margin = new Thickness(Pst1, 0, 0, Pst4);
            }
        }
        #endregion
    }
}
