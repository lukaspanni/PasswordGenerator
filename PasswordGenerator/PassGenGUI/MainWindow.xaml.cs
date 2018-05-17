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
using System.Windows.Forms;
using static PasswordGeneratorFunctions.PasswordGeneratorFunctions;

namespace PassGenGUI {
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e) {
            if (String.IsNullOrWhiteSpace(len.Text))
                return;
            try {
                int length = Int32.Parse(len.Text);
                if(length > 0) {
                    outTxt.Text = generatePassword(length);
                    System.Windows.Forms.Clipboard.SetText(outTxt.Text);
                }
                else {
                    outTxt.Text = "Failed";
                }
            }
            catch (FormatException fe) {
                outTxt.Text = "Nur Zahlen Eingeben";
            }

        }
    }
}
