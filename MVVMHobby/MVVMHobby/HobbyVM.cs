using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight;
using System.Windows.Media.Imaging;
using System.Collections.ObjectModel;
using GalaSoft.MvvmLight.Command;
using System.Windows;

namespace MVVMHobby.ViewModel
{
    public class HobbyVM : ViewModelBase
    {
        private Model.Hobby Hobby;

        public string Categorie
        {
            get { return Hobby.Categorie; }
            set
            {
                Hobby.Categorie = value;
                RaisePropertyChanged("Categorie");
            }
        }

        public string Activiteit
        {
            get { return Hobby.Activiteit; }
            set
            {
                Hobby.Activiteit = value;
            RaisePropertyChanged("Activiteit"};
        }


        public BitmapImage Symbool
        {
            get { return Hobby.Symbool; }
            set
            {
                Hobby.Symbool = value;
                RaisePropertyChanged("Symbool");
            }
        }



        public HobbyVM(Model.Hobby hobby)
        {
            this.Hobby = hobby;
        }
    }

    public class HobbyLijstVM : ViewModelBase
    {

        private ObservableCollection<HobbyVM> hobbyLijst = new ObservableCollection<HobbyVM>() ;

        public ObservableCollection<HobbyVM> HobbyLijst
        {
            get { return hobbyLijst ; }
            set
            {
                hobbyLijst = value;
                RaisePropertyChanged("HobbyLijst");
            }
        }

        private HobbyVM selectedHobby;

        public HobbyVM SelectedHobby
        {
            get 
            { 
            return selectedHobby;
            }

            set
            {
                selectedHobby = value;
                RaisePropertyChanged("SelectedHobby");
            }
        }

        public RelayCommand<RoutedEventArgs> VerwijderCommand
        {
            get
            { return new RelayCommand<RoutedEventArgs>(Verwijder); }
        }

        public HobbyLijstVM()
        {
            HobbyLijst.Add(new HobbyVM(new Model.Hobby("sport","atletiek",new BitmapImage(new Uri("Images/atletiek.jpg")))));
            HobbyLijst.Add(new HobbyVM(new Model.Hobby("sport", "basketbal", new BitmapImage(new Uri("Images/basketbal.jpg")))));
            HobbyLijst.Add(new HobbyVM(new Model.Hobby("muziek", "drum", new BitmapImage(new Uri("Images/drum.jpg")))));
            HobbyLijst.Add(new HobbyVM(new Model.Hobby("muziek", "gitaar", new BitmapImage(new Uri("Images/gitaar.jpg")))));
            HobbyLijst.Add(new HobbyVM(new Model.Hobby("muziek", "piano", new BitmapImage(new Uri("Images/piano.jpg")))));
            HobbyLijst.Add(new HobbyVM(new Model.Hobby("sport", "tennis", new BitmapImage(new Uri("Images/tennis.jpg")))));
            HobbyLijst.Add(new HobbyVM(new Model.Hobby("muziek", "trompet", new BitmapImage(new Uri("Images/trompet.jpg")))));
            HobbyLijst.Add(new HobbyVM(new Model.Hobby("sport", "turnen", new BitmapImage(new Uri("Images/turnen.jpg")))));
            HobbyLijst.Add(new HobbyVM(new Model.Hobby("sport", "voetbal", new BitmapImage(new Uri("Images/voetbal.jpg")))));


        }

        private void Verwijder(RoutedEventArgs e)
        {
            HobbyLijst.Remove(SelectedHobby);
        }
    }
}
