using System.Collections;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using CommunityToolkit.Mvvm.ComponentModel;

namespace CollectionViewDuplicateHeadersRepro;

public partial class MainPageViewModel : ObservableObject
{
    [ObservableProperty]
    private ObservableCollection<MyGroup> _items;

    public MainPageViewModel()
    {
        Items = new ObservableCollection<MyGroup>();

        FillItems();
    }

    private void FillItems()
    {
        for (var i = 0; i < 10; i++)
        {
            var group = new MyGroup
            {
                Header = $"Group {i}"
            };
            for (var j = 0; j < 3; j++)
            {
                group.Add($"Item {i} : {j}" + string.Join(' ', Enumerable.Repeat("filler", i*j)));
            }

            Items.Add(group);
        }
    }
}

public class MyGroup : ObservableCollection<string>
{
    public string Header { get; set; }
}