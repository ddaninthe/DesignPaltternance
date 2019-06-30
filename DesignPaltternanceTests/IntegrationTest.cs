using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DesignPaltternance;
using DesignPaltternance.Classes;
using DesignPaltternance.Classes.Niveaux;
using DesignPaltternance.Classes.Filieres;
using DesignPaltternance.Matieres;
using DesignPaltternance.Responsabilities;

namespace DesignPaltternanceTests
{
    [TestClass]
    public class IntegrationTest
    {
        Administration admin;

        [TestInitialize]
        public void setup()
        {
            admin = new Administration();
        }

        [TestMethod]
        public void Should_Add_Note_To_Eleve()
        {
            Classe c = admin.CreateClasse(Quatrieme.Name, AL.Name);
            IEleve eleve = admin.RegisterEleve("John", c);

            eleve.AddNote(DesignPattern.Name, 12, 3);
            eleve.AddNote(JEE.Name, 10, 1);

            Assert.AreEqual(11, eleve.GetMoyenne());
        }

        [TestMethod]
        public void Should_Validate_First_Year_Eleve()
        {
            Classe c = admin.CreateClasse(Premiere.Name);
            IEleve eleve = admin.RegisterEleve("Doe", c);

            eleve.AddNote(C.Name, 10, 3);
            admin.AddResponsability(eleve, new Delegue());

            Assert.IsTrue(admin.ValidateEleve(eleve));
        }

        [TestMethod]
        public void Should_Validate_MOC_Eleve_After_Responsability()
        {
            Classe c = admin.CreateClasse(Quatrieme.Name, MOC.Name);
            IEleve eleve = admin.RegisterEleve("Juan", c);

            eleve.AddNote(IOS.Name, 11, 4);
            Assert.IsFalse(admin.ValidateEleve(eleve));

            eleve.Responsabilities.Add(new BDE());
            Assert.IsTrue(admin.ValidateEleve(eleve));
        }
    }
}
