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
using System.Windows.Shapes;

namespace WorkAssistant.View
{
    /// <summary>
    /// Interaction logic for WorkAssistant.xaml
    /// </summary>
    public partial class WorkAssistant : Window
    {
        public WorkAssistant()
        {
            InitializeComponent();
        }

        private void Button_DpiChanged(object sender, DpiChangedEventArgs e)
        {

        }
    }
}
