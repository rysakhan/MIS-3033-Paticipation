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

namespace Pokemon
{
    /// <summary>
    /// Interaction logic for Pokemon.xaml
    /// </summary>
    public partial class Pokemon : Window
    {
        public Pokemon()
        {
            InitializeComponent();
        }

        InformationAPI info;

        public void newWindow(InformationAPI info)
        {
            this.info = info;
            img_pokemon.Source = new BitmapImage(new Uri(info.sprites.front_default));
            img_pokemon.Source = new BitmapImage(new Uri(info.sprites.back_default));
            txt_pokemonInfo.Text = info.ToString();
        }

        bool front = true;

        private void btn_pic_Click(object sender, RoutedEventArgs e)
        {
            if (front == true)
            {
                img_pokemon.Source = new BitmapImage(new Uri(info.sprites.front_default));
                front = false;
            }
            else
            {
                img_pokemon.Source = new BitmapImage(new Uri(info.sprites.back_default));
                front = true;
            }
        }
    }
}
