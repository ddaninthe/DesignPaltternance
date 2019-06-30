using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DesignPaltternance.Classes;
using DesignPaltternance.Classes.Niveaux;
using DesignPaltternance.Classes.Filieres;

namespace DesignPaltternanceTests
{
    [TestClass]
    public class BuilderTests
    {
        [TestMethod]
        public void Should_Build_4AL()
        {
            ClasseBuilder builder = new ClasseBuilder(Quatrieme.Name);
            builder.filiere(AL.Name);
            Classe classe = builder.build();

            Assert.AreEqual(AL.Name, classe.Filiere.GetName());
            Assert.AreEqual(Quatrieme.Name, classe.Niveau.GetName());
            Assert.AreEqual(2, classe.Matieres.Count);
        }

        [TestMethod]
        public void Should_Build_Premiere()
        {
            Classe classe = new ClasseBuilder(Premiere.Name).build();
            Assert.AreEqual(Premiere.Name, classe.Niveau.GetName());
            Assert.IsNull(classe.Filiere);
            Assert.AreNotEqual(0, classe.Matieres.Count);
        }
    }
}
