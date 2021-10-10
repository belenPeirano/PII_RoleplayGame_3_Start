using NUnit.Framework;

namespace RoleplayGame
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void CharNameTest()
        {
            SpellsBook book = new SpellsBook();
            book.Spells = new Spell[]{ new Spell() };

            Wizard gandalf = new Wizard("Gandalf");
            gandalf.Staff = new Staff();
            gandalf.SpellsBook = book;
            string expected = "Gandalf";
            Assert.AreEqual(gandalf.Name,expected);
        }

        [Test]
        public void CharItemTest()
        {
            SpellsBook book = new SpellsBook();
            book.Spells = new Spell[]{ new Spell() };

            Wizard gandalf = new Wizard("Gandalf");

            Staff staff = new Staff();

            gandalf.Staff = staff;

            Assert.AreEqual(gandalf.Staff,staff);
        }
        [Test]
        public void CharHealthTest()
        {


            SpellsBook book = new SpellsBook();
            book.Spells = new Spell[]{ new Spell() };

            Wizard gandalf = new Wizard("Gandalf");
            gandalf.Staff = new Staff();
            gandalf.SpellsBook = book;

            Dwarf gimli = new Dwarf("Gimli");
            gimli.Axe = new Axe();
            gimli.Helmet = new Helmet();
            gimli.Shield = new Shield();
            
            gimli.ReceiveAttack(gandalf.AttackValue);
            int expected = 100;
            gimli.Cure();
            Assert.AreEqual(expected,gimli.Health);
        }
    }
}