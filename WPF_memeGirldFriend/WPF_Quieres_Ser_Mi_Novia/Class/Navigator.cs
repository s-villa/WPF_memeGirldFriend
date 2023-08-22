using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using WPF_Quieres_Ser_Mi_Novia.UserControls;

namespace WPF_Quieres_Ser_Mi_Novia.Class
{
    public class Navigator : INotifyPropertyChanged
    {
        #region Events
        public event PropertyChangedEventHandler PropertyChanged;
        #endregion

        #region Variables
        private UserControl _view;

        public UserControl View
        {
            get
            {
                return _view;
            }
            set
            {
                _view = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(View)));
            }
        }
        #endregion

        #region Metodos
        public void Navigate(UserControlView newWindow, object data = null) => Application.Current.Dispatcher.Invoke((Action)delegate
        {
            try
            {
                switch (newWindow)
                {
                    case UserControlView.Presentation:
                        View = new UCPresentation();
                        break;
                    case UserControlView.Question:
                        View = new UCQuestion();
                        break;
                    case UserControlView.End:
                        View = new UCEnd();
                        break;
                }
            }
            catch (Exception ex)
            {
            }
            GC.Collect();
        });
        #endregion
    }
}
