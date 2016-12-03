using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DistanceCalculation.ModelsInterfaces;

namespace DistanceCalculation.ViewModels
{
    internal class MainViewModel
    {
        internal ObservableCollection<IPoint> Coordinates { get; set; }
        internal IPoint SelectedPoint { get; set; }
    }
}
