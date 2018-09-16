using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaterialDesignSample.MainModule.ViewModels
{
    public class ViewAViewModel : BindableBase
    {
        private string _message;
        public string Message
        {
            get { return _message; }
            set { SetProperty(ref _message, value); }
        }

        public List<string> ComboItems { get; private set; } = new List<string>() { "a1", "b2", "c3" };

        public ViewAViewModel()
        {
            Message = "View A from your Prism Module";
        }
    }
}
