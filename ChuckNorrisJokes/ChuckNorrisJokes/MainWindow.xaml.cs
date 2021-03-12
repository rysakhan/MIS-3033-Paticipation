using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
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

namespace ChuckNorrisJokes
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        string jokeURL = "https://api.chucknorris.io/jokes/random?category=";

        string categoryURL = "https://api.chucknorris.io/jokes/categories";

        string randomURL = "https://api.chucknorris.io/jokes/search?query=";

        public MainWindow()
        {
            InitializeComponent();

            

            using (var client = new HttpClient())
            {
                string CategoryData = client.GetStringAsync(categoryURL).Result;

                
                List<string> catergoryList = JsonConvert.DeserializeObject<List<string>>(CategoryData);
                //categoryAPI CatApi = JsonConvert.DeserializeObject<categoryAPI>(CategoryData);

                foreach (string categoryName in catergoryList)
                {
                    cbo_Categories.Items.Add(categoryName);
                }

                cbo_Categories.Items.Add("All");

            }

      
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string SelectedCategory = (string)cbo_Categories.SelectedItem;

            using (var client = new HttpClient())
            {
                string JokeStuff = client.GetStringAsync(jokeURL+SelectedCategory).Result;
                API jokeAPI = JsonConvert.DeserializeObject<API>(JokeStuff);

                //string RandomStuff = client.GetStringAsync(randomURL).Result;
                //API RandonJoke = JsonConvert.DeserializeObject<API>(RandomStuff);

                txt_Joke.Text = jokeAPI.value;

                //if (SelectedCategory.Contains("All"))
                //{
                    //txt_Joke.Text = RandonJoke.value;
                //}
            }

            
        }

       
    }
}
