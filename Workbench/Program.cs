using System.Data;
using System.Runtime.InteropServices;

public class Rock
{
    public string Name;
    public string Type;
    public List<string> Minerals;
    public double Density;
}

public class Program
{
    public static void Main()
    {
        Rock[] rocks =
        {
            new Rock
            {
                Name = "Anthracite",
                Type = "Sedimentary",
                Minerals = new List<string>{ "Calcite", "Clay" },
                Density = 2.5
            },
            new Rock
            {
                Name = "Flint",
                Type = "Sedimentary",
                Minerals = new List<string>{ "Silicon" },
                Density = 2.7
            },
            new Rock
            {
                Name = "Limestone",
                Type = "Sedimentary",
                Minerals = new List<string>{ "Calcite", "Clay", "Quartz", "Sand", "Silt" },
                Density = 2.3
            },
            new Rock
            {
                Name = "Coal",
                Type = "Sedimentary",
                Minerals = new List<string>{ "Calcite", "Chloride", "Chromide", "Clay", "Pyrite", "Quartz" },
                Density = 1.2
            },
            new Rock
            {
                Name = "Siltstone",
                Type = "Sedimentary",
                Minerals = new List<string>{ "Calcite", "Clay", "Quartz", "Sand", "Silt" },
                Density = 2.7
            },
            new Rock
            {
                Name = "Diorite",
                Type = "Igneous",
                Minerals = new List<string>{ "Magnetite", "Pyroxene", "Quartz", "Sulfides" },
                Density = 3.0
            },
            new Rock
            {
                Name = "Gabbro",
                Type = "Igneous",
                Minerals = new List<string>{ "Pyroxene" },
                Density = 3.2
            },
            new Rock
            {
                Name = "Andesite",
                Type = "Igneous",
                Minerals = new List<string>{ "Magnetite", "Pyroxene" },
                Density = 2.2
            },
            new Rock
            {
                Name = "Granite",
                Type = "Igenous",
                Minerals = new List<string>{ "Pyroxene", "Quartz" },
                Density = 2.7
            },
            new Rock
            {
                Name = "Rhyolite",
                Type = "Igneous",
                Minerals = new List<string>{ "Pyroxene", "Quartz" },
                Density = 2.5
            },
            new Rock
            {
                Name = "Pyrolite",
                Type = "Igneous",
                Minerals = new List<string>{ "Chromite", "Magnesium", "Pyroxene" },
                Density = 3.3
            },
            new Rock
            {
                Name = "Basalt",
                Type = "Igneous",
                Minerals = new List<string>{ "Pyroxene" },
                Density = 3.0
            },
            new Rock
            {
                Name = "Obsidian",
                Type = "Igneous",
                Minerals = new List<string>{  },
                Density = 2.6
            },
            new Rock
            {
                Name = "Theralite",
                Type = "Igneous",
                Minerals = new List<string>{ "Pyroxene" },
                Density = 2.7
            },
            new Rock
            {
                Name = "Anorthosite",
                Type = "Igneous",
                Minerals = new List<string>{ "Magnetite" },
                Density = 3.7
            },
            new Rock
            {
                Name = "Marble",
                Type = "Metamorphic",
                Minerals = new List<string>{ "Graphite", "Pyrite", "Quartz" },
                Density = 2.7
            },
            new Rock
            {
                Name = "Slate",
                Type = "Metamorphic",
                Minerals = new List<string>{ "Chlorite", "Graphite", "Magnetite", "Pyrite" },
                Density = 2.7
            },
            new Rock
            {
                Name = "Tuff",
                Type = "Igneous",
                Minerals = new List<string>{ "Calcite", "Chlorite" },
                Density = 1.3
            },
            new Rock
            {
                Name = "Shale",
                Type = "Sedimentary",
                Minerals = new List<string>{ "Calcite", "Chlorite", "Pyrite", "Quartz", "Silica", "Sulfides" },
                Density = 2.5
            },
            new Rock
            {
                Name = "Sandstone",
                Type = "Sedimentary",
                Minerals = new List<string>{ "Calcite", "Clay", "Quartz" },
                Density = 2.2
            },
            new Rock
            {
                Name = "Chalk",
                Type = "Sedimentary",
                Minerals = new List<string>{ "Calcite", "Clay", "Quartz", "Sand" },
                Density = 2.5
            }
        };

        // Defines a selection of rocks that contain Quartz.
        var rocksQuartz = rocks.AsEnumerable()
            .Where(rock => rock.Minerals.Contains("Quartz"));

        // Defines a selection of rocks that have at least a certain density.
        var rocksHighDensity = rocks.AsEnumerable()
            .Where(rock => rock.Density > 2.5);

        // Defines a selection of rocks that end with 'ite'.
        var rocksLongName = rocks.AsEnumerable()
            .Where(rock => rock.Name.EndsWith("ite"));

        // Defines a selection of all available materials.
        var minerals = rocks.AsEnumerable()
            .SelectMany(mineral => mineral.Minerals, (rock, mineral) => mineral).Distinct();

        Console.WriteLine(string.Join("\n", minerals));
    }
}