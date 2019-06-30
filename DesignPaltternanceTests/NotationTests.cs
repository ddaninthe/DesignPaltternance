using System;
using DesignPaltternance.Notation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DesignPaltternanceTests
{
    [TestClass]
    public class NotationTests
    {
        [TestMethod]
        public void Should_Get_Moyenne_For_1_Note_With_Update()
        {
            Notes notes = new Notes();
            Note note = new Note(10, 2);
            notes.AddNote(note);

            Assert.AreEqual(10, notes.GetMoyenne());

            note.setNote(14);
            Assert.AreEqual(14, notes.GetMoyenne());
        }

        [TestMethod]
        public void Should_Get_Moyenne_For_3_Notes_With_Update()
        {
            Notes notes1 = new Notes();
            notes1.AddNote(new Note(14, 1));
            notes1.AddNote(new Note(6, 1));
            notes1.AddNote(new Note(15, 3));
            Assert.AreEqual(13, Math.Round(notes1.GetMoyenne(), 1));

            Notes notes2 = new Notes();
            Note n = new Note(12, 3);
            notes2.AddNote(n);
            notes2.AddNote(new Note(5, 2));
            Assert.AreEqual(9.2, Math.Round(notes2.GetMoyenne(), 1));
            n.setCoef(2);
            Assert.AreEqual(8.5, Math.Round(notes2.GetMoyenne(), 1));
        }
    }
}
