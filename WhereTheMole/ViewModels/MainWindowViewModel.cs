//Автор игры - Дмитриенко Ю.Е.


namespace WhereTheMole.ViewModels
{
    using Catel.Data;
    using Catel.MVVM;
    using Catel.Services;
    using System;
    using System.IO;
    using System.Threading.Tasks;
    using System.Windows.Media.Imaging;
    using System.Windows.Threading;
    using WhereTheMole.Models;

    public class MainWindowViewModel : ViewModelBase
    {
        private DispatcherTimer timer = null;
        private IMessageService _messageService;
        private int _counter;
        

        public MainWindowViewModel(IMessageService messageService)
        {
            _messageService = messageService;
        }

        public override string Title { get { return "WhereTheMole"; } }
                

        protected override async Task InitializeAsync()
        {
            await base.InitializeAsync();
            timerStart();   
        }

        protected override async Task CloseAsync()
        {
            
            await base.CloseAsync();
        }

      
        public int Count
        {
            get { return GetValue<int>(CountProperty); }
            set { SetValue(CountProperty, value); }
        }
                
        public static readonly PropertyData CountProperty = RegisterProperty("Count", typeof(int), 0);

        
        public BitmapImage Mole
        {
            get { return GetValue<BitmapImage>(MoleProperty); }
            set { SetValue(MoleProperty, value); }
        }
        public static readonly PropertyData MoleProperty = RegisterProperty("Mole", typeof(BitmapImage), null);

       
        public BitmapImage Mouse
        {
            get { return GetValue<BitmapImage>(MouseProperty); }
            set { SetValue(MouseProperty, value); }
        }
        public static readonly PropertyData MouseProperty = RegisterProperty("Mouse", typeof(BitmapImage), null);


        
        public BitmapImage Carrot
        {
            get { return GetValue<BitmapImage>(CarrotProperty); }
            set { SetValue(CarrotProperty, value); }
        }
        public static readonly PropertyData CarrotProperty = RegisterProperty("Carrot", typeof(BitmapImage), null);
                 
        
        public string MarginMole
        {
            get { return GetValue<string>(MarginMoleProperty); }
            set { SetValue(MarginMoleProperty, value); }
        }
              
        public static readonly PropertyData MarginMoleProperty = RegisterProperty("MarginMole", typeof(string), null);

        
        public string MarginMouse
        {
            get { return GetValue<string>(MarginMouseProperty); }
            set { SetValue(MarginMouseProperty, value); }
        }

        public static readonly PropertyData MarginMouseProperty = RegisterProperty("MarginMouse", typeof(string), null);
        

        
        private void timerStart()
        {
            timer = new DispatcherTimer();  // если надо, то в скобках указываем приоритет, например DispatcherPriority.Render
            timer.Tick += new EventHandler(timerTick);
            timer.Interval = new TimeSpan(0, 0, 0, 0, 500);
            timer.Start();
        }

        private void timerTick(object sender, EventArgs e)
        {
            Mole = new BitmapImage(new Uri(Directory.GetCurrentDirectory() + "/Images/mole.png", UriKind.Absolute));
            MarginMole = MoleRandom.GetRandomMargin();
            if (_counter == 12)
            {
                Carrot = new BitmapImage(new Uri(Directory.GetCurrentDirectory() + "/Images/carrots.png", UriKind.Absolute));

            }
            if (_counter > 12)
            {
                Carrot = null;
                _counter = 0;
            }
                  

            if (Count >= 10)
            {
                for (int x = 0; x < 1; x++)
                {
                    string _marginMouse = MoleRandom.GetRandomMargin();
                    if (_marginMouse.Equals(MarginMole))
                    {
                        x--;
                    }
                    Mouse = new BitmapImage(new Uri(Directory.GetCurrentDirectory() + "/Images/mouse.png", UriKind.Absolute));
                    MarginMouse = _marginMouse;
                    
                }
                

            }
                                   
        }
        
        public Command ClickMoleCommand
        {
            get
            {
                return new Command(() =>
                {
                    Count++;
                    _counter++;
                    _messageService.ShowAsync("Ваш счет: " + Count);
                    
                }); 
            }
        
        }

        private Command _clickLinkCommand;

        public Command ClickLinkCommand
        {
            get
            {
                return _clickLinkCommand ?? (_clickLinkCommand = new Command(() =>
                {
                    System.Diagnostics.Process p = new System.Diagnostics.Process();
                    p.StartInfo.FileName = "http://best-buy-now.ru/";
                    p.EnableRaisingEvents = true;
                    p.Start();
                }));

            }

        }


    }
}
