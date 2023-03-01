using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Balance2;

// page
public class Page
{
    public Page(int id, string name)
    {
        ID = id;
        Name = name;
    }
    public int ID { get; set; }
    public string Name { get; set; }
}

// page / groups
public class Group
{
    public string Name { get; set; }
    public ObservableCollection<Page> Pages { get; }

    public Group(string name, IEnumerable<Page> pages)
    {
        Name = name;
        Pages = new ObservableCollection<Page>(pages);
    }
}

// Groups
public static class Groups
{
    public static List<Group> GetGroups()
    {
        var groups = new List<Group>();

        groups.Add(new Group("System", new Page[] {
            new Page(0, "Model"),
            new Page(1, "Layout"),
            new Page(2, "Farms"),
            new Page(3, "*Map")
        }));

        groups.Add(new Group("Data", new Page[] {
            new Page(11, "Observed Data"),
            new Page(12, "Farm Runoff")
        }));

        groups.Add(new Group("Crops & Irrigation", new Page[] {
            new Page(21, "Crop Demand"),
            new Page(22, "Farm Crops"),
            new Page(23, "Irrigation Demand")
        }));

        groups.Add(new Group("Simulation", new Page[] {
            new Page(31, "Zuurvlakte"),
            new Page(32, "Buffelspoort"),
            new Page(33, "Yzterplaat"),
            new Page(34, "Suikerbossie"),
            new Page(35, "Results")
        }));

        groups.Add(new Group("Scenarios", new Page[] {
            new Page(41, "Scenario 1"),
            new Page(42, "Scenario 2"),
            new Page(43, "Scenario 3")
        }));

        return groups;
    }
}

