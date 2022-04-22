using System.Collections.ObjectModel;

namespace OuterListbox
{
    public class Question
    {
        public string Text { get; set; }
        public ObservableCollection<Person> Qestions { get; set; }
        
    }
}
