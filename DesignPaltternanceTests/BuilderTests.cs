using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DesignPaltternance.Classes;
using DesignPaltternance.Classes.Niveaux;
using DesignPaltternance.Classes.Filieres;
using DesignPaltternance;

namespace DesignPaltternanceTests
{
    [TestClass]
    public class BuilderTests
    {
        [TestMethod]
        public void Should_Build_4AL()
        {
            Administration administration = new Administration();
            Classe classe = administration.CreateClasse(Quatrieme.Name, AL.Name);

            Assert.AreEqual(AL.Name, classe.Filiere.GetName());
            Assert.AreEqual(Quatrieme.Name, classe.Niveau.GetName());
            Assert.AreEqual(2, classe.Matieres.Count);
        }

        [TestMethod]
        public void Should_Build_Premiere()
        {
            Administration administration = new Administration();

            Classe classe = administration.CreateClasse(Premiere.Name);
            Assert.AreEqual(Premiere.Name, classe.Niveau.GetName());
            Assert.IsNull(classe.Filiere);
            Assert.AreNotEqual(0, classe.Matieres.Count);
        }
    }
}
