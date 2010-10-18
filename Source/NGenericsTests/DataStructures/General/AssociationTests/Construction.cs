/*  
  Copyright 2007-2010 The NGenerics Team
 (http://code.google.com/p/ngenerics/wiki/Team)

 This program is licensed under the GNU Lesser General Public License (LGPL).  You should 
 have received a copy of the license along with the source code.  If not, an online copy
 of the license can be found at http://www.gnu.org/copyleft/lesser.html.
*/
using NGenerics.DataStructures.General;
using NUnit.Framework;

namespace NGenerics.Tests.DataStructures.General.AssociationTests
{
    [TestFixture]
    public class Construction
    {

        [Test]
        public void Simple()
        {
            var assoc = new Association<int, string>(5, "aa");

            Assert.AreEqual(assoc.Key, 5);
            Assert.AreEqual(assoc.Value, "aa");

        }
        [Test]
        public void Equality()
        {
            var assoc = new Association<int, string>(5, "aa");
            var assoc2 = new Association<int, string>(5, "aa");
            Assert.AreEqual(assoc.Key, assoc2.Key);
            Assert.AreEqual(assoc.Key, assoc2.Key);
            Assert.AreEqual(assoc, assoc2);

        }

    }
}