using System;
using System.Collections.Generic;
using System.Text;

namespace raketero_xamarin.Abstractions
{
    public interface IModalView
    {
        string ModalTitle { get; set; }
        bool Frozen { get; set; }
    }
}
