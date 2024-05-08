using CalendarEmocia.ViewModel.Helpers;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;
using CalendarEmocia.Model;

namespace CalendarEmocia.ViewModel
{
    internal class VyborNastroeniaViewModel : BindingHelpers
    {
        Converter converter = new Converter();



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

        public BindableCommand Sohranenie { get; set; }//КНОПКАААААААААААААААААААААААААААААААААААААААААААААААААААА


        private bool ProverkaSvoboda;//проверка тыка на хуйню ту, гпт выдал короче эту тему
        public bool proverkasvoboda
        {
            get { return ProverkaSvoboda; }
            set
            {
                ProverkaSvoboda = value;
                OnPrioertyChanged();
            }
        }

        private bool ProverkaChill;
        public bool proverkachill
        {
            get { return ProverkaChill; }
            set
            {
                ProverkaChill = value;
                OnPrioertyChanged();
            }
        }

        private bool ProverkaDance;
        public bool proverkadance
        {
            get { return ProverkaDance; }
            set
            {
                ProverkaDance = value;
                OnPrioertyChanged();
            }
        }

        private bool ProverkaIoga;

        public bool proverkaioga
        {
            get { return ProverkaIoga; }
            set
            {
                ProverkaIoga = value;
                OnPrioertyChanged();
            }
        }

        //private string data; это говно было предназначено для даты, а именно биндинга, но я не придумал как связать это без потери даты, поэтому у меня тут все через жопу
        //public string Data
        //{
            //get { return data; }
            //set
            //{
                //data = value;
                //OnPrioertyChanged();
            //}
        //}

        private List<pervyivybor> vybor = new List<pervyivybor>();


        public VyborNastroeniaViewModel()//glavniy metod daby ne poteruat
        {
            DateTime date = DateTime.Now;
            svobodaKartinka = new BitmapImage(new Uri("C:\\Users\\nitz4\\Desktop\\calendar\\CalendarEmocia\\CalendarEmocia\\View\\images\\image (1).png", UriKind.Absolute));
            chillKartinka = new BitmapImage(new Uri("C:\\Users\\nitz4\\Desktop\\calendar\\CalendarEmocia\\CalendarEmocia\\View\\images\\Chill.png", UriKind.Absolute));
            danceKartinka = new BitmapImage(new Uri("C:\\Users\\nitz4\\Desktop\\calendar\\CalendarEmocia\\CalendarEmocia\\View\\images\\letsdance.png", UriKind.Absolute));
            iogaKartinka = new BitmapImage(new Uri("C:\\Users\\nitz4\\Desktop\\calendar\\CalendarEmocia\\CalendarEmocia\\View\\images\\IOga.png", UriKind.Absolute));
            Dancing = "Танцевать хочеца!";
            chilling = "Жоский чилл";
            Emociii = "Свободный";
            ioging = "Расслабон";
            Sohranenie = new BindableCommand(_ => Sohra());
            converter.Deserialization<List<pervyivybor>>("alo.json");//выгрузка из json
            //Data = date.ToString("dd MMMM yyyy г.");
            foreach(var item in vybor)
            {
                if (item.name == "Танцевать хочеца!")
                {
                    item.select = proverkadance;
                    pervyivybor Dance = new pervyivybor(Dancing, danceKartinka.ToString(), proverkadance);
                    vybor.Add(Dance);
                }
                else if (item.name == "Жоский чилл")
                {
                    item.select = proverkachill;
                    pervyivybor Chill = new pervyivybor(chilling, chillKartinka.ToString(), proverkachill);
                    vybor.Add(Chill);
                }
                else if (item.name == "Свободный")
                {
                    item.select = proverkasvoboda;
                    pervyivybor Svoboda = new pervyivybor(Emociii, svobodaKartinka.ToString(), proverkasvoboda);
                    vybor.Add(Svoboda);
                }
                else if (item.name == "Расслабон")
                {
                    item.select = proverkaioga;
                    pervyivybor Ioga = new pervyivybor(ioging, iogaKartinka.ToString(), proverkaioga);
                    vybor.Add(Ioga);
                }
            }
            
        }
        public void Sohra()
        {
            converter.Sirialize(vybor, "alo.json");
        }
    }
}
