using System;
using DesignPaltternance.Notation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DesignPaltternanceTests
{
    [TestClass]
    public class NotationTests
    {
        [TestMethod]
        public void Should_Get_Moyenne_For_1_Note()
        {
            Bulletin bulletin = new Bulletin();
            Notes notes = new Notes();
            Note note = new Note(10, 2);
            notes.AddNote(note);
            bulletin.AddNotes(notes);

            Assert.AreEqual(10, bulletin.GetMoyenneGenerale());

            note.setNote(14);

            Assert.AreEqual(14, notes.GetMoyenne());
            Assert.AreEqual(14, bulletin.GetMoyenneGenerale());
        }

        [TestMethod]
        public void Should_Get_Moyenne_For_5_Notes()
        {
            Bulletin bulletin = new Bulletin();
            Notes notes1 = new Notes();
            Notes notes2 = new Notes();
            Note n = new Note(12, 3);
            notes2.AddNote(n);
            bulletin.AddNotes(notes2);

            notes2.AddNote(new Note(5, 2));
            Assert.AreEqual(9.2, Math.Round(notes2.GetMoyenne(), 1));
            n.setCoef(2);
            Assert.AreEqual(8.5, Math.Round(notes2.GetMoyenne(), 1));

            bulletin.AddNotes(notes1);
            notes1.AddNote(new Note(14, 1));
            notes1.AddNote(new Note(6, 1));
            notes1.AddNote(new Note(15, 3));
            Assert.AreEqual(13, Math.Round(notes1.GetMoyenne(), 1));

            Assert.AreEqual(10.8, Math.Round(bulletin.GetMoyenneGenerale(), 1));
        }
    }
}
