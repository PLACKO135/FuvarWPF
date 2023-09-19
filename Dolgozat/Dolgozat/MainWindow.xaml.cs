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
using System.IO;


namespace Dolgozat
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        static List<Fuvar> Fuvar_lista = new List<Fuvar>();
        public MainWindow()
        {

            InitializeComponent();
            StreamReader sr = new StreamReader("fuvar.csv");
            sr.ReadLine();

            while (!sr.EndOfStream)
            {
                var mezok = sr.ReadLine().Split(';');



                Fuvar uj = new(int.Parse(mezok[0]), mezok[1], int.Parse(mezok[2]), double.Parse(mezok[3]), double.Parse(mezok[4]), double.Parse(mezok[5]), mezok[6]);
            }
            sr.Close();
        }

        private void btn_elso_Click(object sender, RoutedEventArgs e)
        {

            MessageBox.Show($"3.feladat {Fuvar_lista.Count} fuvar");
        }

        private void btn_masodik_Click(object sender, RoutedEventArgs e)
        {
            double bevetel = 0;
            int fuvarok_szama = 0;

            foreach (Fuvar item in Fuvar_lista)
            {

                if (item.Taxi_id == 6185)
                {
                    bevetel += item.Vitel_dij;

                    fuvarok_szama+=1;

                }
            }


            MessageBox.Show($"4.feladat {fuvarok_szama} fuvar alatt: {bevetel}$");
        }

        private void btn_harmadik_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btn_negyedik_Click(object sender, RoutedEventArgs e)
        {
            double tavolsag = 0;

            foreach (Fuvar item in Fuvar_lista)
            {
                tavolsag += item.Tavolsag * 1.6;
            }

            MessageBox.Show($"6.feladat{Math.Round(tavolsag, 2)}km");
        }

       private void btn_ötödik_Click(object sender, RoutedEventArgs e)
       {
            List<Fuvar> Hibak = new List<Fuvar>();

            StreamWriter sr = new StreamWriter("hibak.txt");
            sr.WriteLine("taxi_id,indulas,idotartam,tavolsag,vitel_dij,borravalo,fizetes_modja");

            for (int i = 0; i < Hibak.Count; i++)
            {

            }

       }
       }
    }
