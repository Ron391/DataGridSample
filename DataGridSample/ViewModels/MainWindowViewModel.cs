using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace DataGridSample.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        public ObservableCollection<Person> People { get; }

        public MainWindowViewModel()
        {
            var people = new List<Person>
        {
            new Person("Neil","Armstrong",false),
            new Person("Buzz","Lightyear",true),
            new Person("James","Kirk",true)
        };
            People = new ObservableCollection<Person>(people);
        }
    }
}