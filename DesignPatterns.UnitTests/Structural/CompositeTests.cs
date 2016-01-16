using System.Collections.Generic;
using DesignPatterns.Structural.Composite;
using NUnit.Framework;

namespace DesignPatterns.UnitTests.Structural
{
    [TestFixture]
    public class CompositeTests
    {
        [Test]
        public void Test()
        {
            var c = new Partition(@"C");
                c.AddChild(new Directory(@"Program Files"));
                c.AddChild(new Directory(@"Program Files (x86)"));
                var users = new Directory(@"Users");
                    var johnSmith = new Directory("John Smith");
                        var downloads = new Directory("Downloads");
                            var email = new ArchiveFile("email.zip", 84);
                                var pictures = new Directory("pictures");
                                    pictures.AddChild(new File("1.jpg", 28));
                                    pictures.AddChild(new File("2.jpg", 32));
                                email.AddChild(pictures);
                                email.AddChild(new File("report.docx", 52));
                            downloads.AddChild(email);
                        johnSmith.AddChild(downloads);
                    users.AddChild(johnSmith);
                c.AddChild(users);
            var windows = new Directory(@"Windows");
                windows.AddChild(new Directory("System"));
                var system32 = new Directory("System32");
                    system32.AddChild(new File("accessor.dll", 708));
                    system32.AddChild(new File("accessibilitycpl.dll", 3725));
                    system32.AddChild(new File("ActionCenter.dll", 874));
                windows.AddChild(system32);
                windows.AddChild(new File("explorer.exe", 2443));
                windows.AddChild(new File("regedit.exe", 151));
            c.AddChild(windows);

            CollectionAssert.AreEqual(new List<string>
            {
                @"C:\",
                @"| Program Files",
                @"| Program Files (x86)",
                @"| Users",
                @"| | John Smith",
                @"| | | Downloads",
                @"| | | | email.zip 84 KB",
                @"| | | | | pictures",
                @"| | | | | | 1.jpg 28 KB",
                @"| | | | | | 2.jpg 32 KB",
                @"| | | | | report.docx 52 KB",
                @"| Windows",
                @"| | System",
                @"| | System32",
                @"| | | accessor.dll 708 KB",
                @"| | | accessibilitycpl.dll 3725 KB",
                @"| | | ActionCenter.dll 874 KB",
                @"| | explorer.exe 2443 KB",
                @"| | regedit.exe 151 KB"
            }, c.Render());

            windows.RemoveChild(system32);

            CollectionAssert.AreEqual(new List<string>
            {
                @"C:\",
                @"| Program Files",
                @"| Program Files (x86)",
                @"| Users",
                @"| | John Smith",
                @"| | | Downloads",
                @"| | | | email.zip 84 KB",
                @"| | | | | pictures",
                @"| | | | | | 1.jpg 28 KB",
                @"| | | | | | 2.jpg 32 KB",
                @"| | | | | report.docx 52 KB",
                @"| Windows",
                @"| | System",
                @"| | explorer.exe 2443 KB",
                @"| | regedit.exe 151 KB"
            }, c.Render());
        }
    }
}