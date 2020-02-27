using Controlery;
using Controlery.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace RPS.ViewModel
{
    class MainViewModel : INotifyPropertyChanged
    {
        private KNP _player;
        private KNP _computer;

        private Random _rand;

        public MainViewModel()
        {
            Player = KNP.None;
            Computer = KNP.None;
            _rand = new Random();
            Play = new ParametrizedRelayCommand(
                (param) =>
                {
                    if (param is /*RSPResult*/ string)
                    {
                        switch (param)
                        {
                            case /*RSPResult.Rock*/ "1": Player = KNP.Rock; break;
                            case /*RSPResult.Scissors*/ "2": Player = KNP.Scissors; break;
                            case /*RSPResult.Paper*/ "3": Player = KNP.Paper; break;
                            default: Player = KNP.None; break;
                        }
                        Computer = (KNP)_rand.Next(3) + 1;
                    }

                },
                (param) => true
            );
        }

        public KNP Player
        {
            get
            {
                return _player;
            }
            set
            {
                _player = value;
                NotifyPropertyChanged();
            }
        }

        public KNP Computer
        {
            get
            {
                return _computer;
            }
            set
            {
                _computer = value;
                NotifyPropertyChanged();
            }
        }

        public ParametrizedRelayCommand Play { get; set; }

        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
