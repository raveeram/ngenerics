/*  
  Copyright 2007-2013 The NGenerics Team
 (https://github.com/ngenerics/ngenerics/wiki/Team)

 This program is licensed under the GNU Lesser General Public License (LGPL).  You should 
 have received a copy of the license along with the source code.  If not, an online copy
 of the license can be found at http://www.gnu.org/copyleft/lesser.html.
*/
using System;
using NGenerics.Patterns.Visitor;
using NUnit.Framework;

namespace NGenerics.Tests.Patterns.Visitor.OrderedVisitorTests
{
    [TestFixture]
    public class Construction
    {
        [Test]
        public void Simple()
        {
            var visitor = new TrackingVisitor<int>();
            var orderedVisitor = new OrderedVisitor<int>(visitor);

            Assert.IsFalse(orderedVisitor.HasCompleted);
            Assert.AreSame(orderedVisitor.VisitorToUse, visitor);
        }

        [Test]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ExceptionNullVisitor()
        {
            new OrderedVisitor<int>(null);
        }
    }
}