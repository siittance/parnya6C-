using CalendarEmocia1.ViewModel.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace CalendarEmocia1.ViewModel
{
    internal class VyborNastroeniaViewModel : BindingHelpers
    {
        private BitmapImage SvobodaKartinka;
        public BitmapImage svobodaKartinka
        {
            get { return SvobodaKartinka; }
            set
            {
                SvobodaKartinka = value;
                OnPrioertyChanged();
            }
        }

        private string dancing;//это надпись, я не менял название, которое у тебя было в xaml, я угарну, если он и так выводить не будет 
        //я понял, что поменял порядок, насрать крч
        public string Dancing
        {
            get { return dancing; }
            set
            {
                dancing = value;
                OnPrioertyChanged();
            }
        }



        private BitmapImage ChillKartinka;

        public BitmapImage chillKartinka
        {
            get { return ChillKartinka; }
            set
            {
                ChillKartinka = value;
                OnPrioertyChanged();
            }
        }

        private string Chilling;

        public string chilling //надпись чилла
        {
            get { return Chilling; }
            set
            {
                Chilling = value;
                OnPrioertyChanged();
            }
        }


        private BitmapImage DanceKartinka;
        public BitmapImage danceKartinka
        {
            get { return DanceKartinka; }
            set
            {
                DanceKartinka = value;
                OnPrioertyChanged();
            }
        }

        private BitmapImage IogaKartinka;
        public BitmapImage iogaKartinka
        {

            get { return IogaKartinka; }
            set
            {
                IogaKartinka = value;
                OnPrioertyChanged();
            }
        }


        private string emociii;

        public string Emociii//свобода надписьв
        {
            get { return emociii; }
            set
            {
                emociii = value;
                OnPrioertyChanged();
            }
        }


        private string Ioging;//это короче йога надпись

        public string ioging
        {
            get { return Ioging; }
            set
            {
                Ioging = value;
                OnPrioertyChanged();
            }
        }

        public BindableCommand Sohranenie { get; set; }


        public VyborNastroeniaViewModel()//glavniy metod daby ne poteruat
        {
            svobodaKartinka = new BitmapImage(new Uri("C:\\Users\\nitz4\\Desktop\\calendar\\CalendarEmocia\\CalendarEmocia\\View\\images\\image (1).png", UriKind.Absolute));
            chillKartinka = new BitmapImage(new Uri("C:\\Users\\nitz4\\Desktop\\calendar\\CalendarEmocia\\CalendarEmocia\\View\\images\\Chill.png", UriKind.Absolute));
            danceKartinka = new BitmapImage(new Uri("C:\\Users\\nitz4\\Desktop\\calendar\\CalendarEmocia\\CalendarEmocia\\View\\images\\letsdance.png", UriKind.Absolute));
            iogaKartinka = new BitmapImage(new Uri("C:\\Users\\nitz4\\Desktop\\calendar\\CalendarEmocia\\CalendarEmocia\\View\\images\\IOga.png", UriKind.Absolute));
            Dancing = "Танцевать хочеца!";
            chilling = "Жоский чилл";
            Emociii = "Свободный";
            ioging = "Расслабон";
        }

    }
}

