using System.Security.Policy;
using System.Windows;

namespace ProjektSemestralny_Aleksandra_Mazur_16547
{
    public partial class MainWindow : Window
    {
        private GeneratorHasel _generator;
        private PlikZHaslami _repo;

        public MainWindow()
        {
            InitializeComponent();

            string path = @"hasla.txt";

            _generator = new GeneratorHasel();
            _repo = new PlikZHaslami(path);
        }

        private void Generuj_Haslo(object sender, RoutedEventArgs e)
        {
            int length = int.Parse(Dlugosc_Hasla.Text);

            string password = _generator.Generate(length);

            _repo.AddPassword(password);

            Haslo.Text = password;
        }

        private void Lista_Plikow(object sender, RoutedEventArgs e)
        {
            var passwords = _repo.GetAllPasswords();

            MessageBox.Show(string.Join(Environment.NewLine, passwords), "Hasła");
        }
    }
}