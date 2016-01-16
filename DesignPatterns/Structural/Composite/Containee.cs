using System.Collections.Generic;
using System.Linq;

namespace DesignPatterns.Structural.Composite
{
    public class Partition : Composite
    {
        private readonly List<Composite> _container;

        public Partition(string driveLetter)
        {
            _container = new List<Composite>();
            DriveLetter = driveLetter;
        }

        public string DriveLetter { get; }

        public override void AddChild(Composite composite)
        {
            _container.Add(composite);
        }

        public override void RemoveChild(Composite composite)
        {
            _container.Remove(composite);
        }

        public override ICollection<string> Render()
        {
            var list = new List<string> {$@"{DriveLetter}:\"};

            list.AddRange(from child in _container from item in child.Render() select $"| {item}");

            return list;
        }
    }

    public class Directory : Composite
    {
        private readonly List<Composite> _container;

        public Directory(string name)
        {
            _container = new List<Composite>();
            Name = name;
        }

        public string Name { get; }

        public override void AddChild(Composite composite)
        {
            _container.Add(composite);
        }

        public override void RemoveChild(Composite composite)
        {
            _container.Remove(composite);
        }

        public override ICollection<string> Render()
        {
            var list = new List<string> {Name};

            list.AddRange(from child in _container from item in child.Render() select $"| {item}");

            return list;
        }
    }

    public class File : Composite
    {
        public File(string name, long sizeInKilloBytes)
        {
            Name = name;
            SizeInKilloBytes = sizeInKilloBytes;
        }

        public string Name { get; }
        public long SizeInKilloBytes { get; }

        public override void AddChild(Composite composite)
        {
            // Safety over transparency
        }

        public override void RemoveChild(Composite composite)
        {
            // Safety over transparency
        }

        public override ICollection<string> Render()
        {
            return new List<string> {$"{Name} {SizeInKilloBytes} KB"};
        }
    }

    public class ArchiveFile : File
    {
        private readonly List<Composite> _container;

        public ArchiveFile(string name, long sizeInKilloBytes) : base(name, sizeInKilloBytes)
        {
            _container = new List<Composite>();
        }

        public override void AddChild(Composite composite)
        {
            _container.Add(composite);
        }

        public override void RemoveChild(Composite composite)
        {
            _container.Remove(composite);
        }

        public override ICollection<string> Render()
        {
            var collection = new List<string>(base.Render());

            collection.AddRange(from child in _container from item in child.Render() select $"| {item}");

            return collection;
        }
    }
}