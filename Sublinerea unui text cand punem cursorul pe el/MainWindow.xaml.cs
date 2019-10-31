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

namespace Sublinerea_unui_text_cand_punem_cursorul_pe_el
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void TextSubliniat_MouseEnter(object sender, MouseEventArgs e)
        {
            TextSubliniat.TextDecorations = TextDecorations.Underline;
        }

        private void TextSubliniat_MouseLeave(object sender, MouseEventArgs e)
        {
            TextSubliniat.TextDecorations = null;
        }
    }
}
