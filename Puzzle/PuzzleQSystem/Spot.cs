using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace PuzzleQSystem
{
    public class Spot : INotifyPropertyChanged
    {
        private string _imagename = "";
        private string _path = "";

        public string StartupPath
        {
            get => _path;
            set
            {
                _path = value;
                this.InvokePropertyChanged(nameof(SpotImageWithPath));
            }
        }

        public string SpotImage
        {
            get => _imagename;
            set
            {
                _imagename = value;
                this.InvokePropertyChanged();
                this.InvokePropertyChanged(nameof(SpotImageWithPath));
            }
        }

        public string SpotImageWithPath => this.StartupPath + this.SpotImage;

        public event PropertyChangedEventHandler? PropertyChanged;

        private void InvokePropertyChanged([CallerMemberName] string propertyname = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyname));
        }

        public void Clear()
        {
            this.SpotImage = "";
        }
    }
}
