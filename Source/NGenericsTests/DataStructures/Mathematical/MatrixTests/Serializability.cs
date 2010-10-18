/*  
  Copyright 2007-2010 The NGenerics Team
 (http://code.google.com/p/ngenerics/wiki/Team)

 This program is licensed under the GNU Lesser General Public License (LGPL).  You should 
 have received a copy of the license along with the source code.  If not, an online copy
 of the license can be found at http://www.gnu.org/copyleft/lesser.html.
*/
using NGenerics.Tests.Util;
using NUnit.Framework;

namespace NGenerics.Tests.DataStructures.Mathematical.MatrixTests
{
    [TestFixture]
    public class Serializability
    {

        [Test]
        public void Simple()
        {
            var matrix = MatrixTest.GetTestMatrix();
            var newMatrix = SerializeUtil.BinarySerializeDeserialize(matrix);

            Assert.AreNotSame(matrix, newMatrix);
            Assert.AreEqual(matrix.Rows, newMatrix.Rows);
            Assert.AreEqual(matrix.Columns, newMatrix.Columns);

            Assert.IsTrue(matrix.Equals(newMatrix));
        }

    }
}