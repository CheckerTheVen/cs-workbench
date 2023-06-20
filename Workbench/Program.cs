using System.Collections;
using System.Data;

public class Rock
{
    public string Name;
    public double Density;
    public List<string> Minerals;
}

public class Program
{
    public static void Main()
    {
        Rock[] rocks =
        {
            new Rock
            {
                Name = "Limestone",
                Density = 2.5,
                Minerals = new List<string>{ "Calcite", "Clay", "Quartz", "Sand", "Silt" }
            },
            new Rock
            {
                Name = "Chalk",
                Density = 2.5,
                Minerals = new List<string>{ "Calcite", "Clay", "Quartz", "Sand" }
            },
            new Rock
            {
                Name = "Marble",
                Density = 2.6,
                Minerals = new List<string>{ "Graphite", "Quartz" }
            },
            new Rock
            {
                Name = "Quartzite",
                Density = 2.4,
                Minerals = new List<string>{ "Chlorite", "Magnetite", "Quartz"}
            },
            new Rock
            {
                Name = "Anthracite",
                Density = 1.7,
                Minerals = new List<string>{ "Calcite", "Clay" }
            },
            new Rock
            {
                Name = "Diorite",
                Density = 2.5,
                Minerals = new List<string>{ "Magnetite", "Quartz", "Sulfides", "Pyroxene" }
            },
            new Rock
            {
                Name = "Obsidian",
                Density = 2.6,
                Minerals = new List<string>{  }
            },
            new Rock
            {
                Name = "Basalt",
                Density = 3.0,
                Minerals = new List<string>{ "Pyroxene" }
            },
            new Rock
            {
                Name = "Harzburgite",
                Density = 2.5,
                Minerals = new List<string>{ "Chromite", "Pyroxene", "Magnesium" }
            },
        };

        var query = rocks.AsEnumerable().Where((rock) => rock.Density < 2.5 ).SelectMany(rock => rock.Minerals, (rock, minerals) => new
        {
            Mineral = minerals,
            Rock = rock.Name
        });

        foreach (var result in query)
        {
            Console.WriteLine(result.Mineral + " is found in " + result.Rock);
        }
    }
}