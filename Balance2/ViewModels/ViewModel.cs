using DevExpress.Mvvm;
using System.Collections.Generic;
using System.Windows;

namespace Balance2;

public class ViewModel : ViewModelBase
{
    public ViewModel()
    {
        PageGroups = Groups.GetGroups();
    }

    public List<Group> PageGroups { get; set; }

}

