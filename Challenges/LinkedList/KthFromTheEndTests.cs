using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenges.LinkedList
{
    public class KthFromTheEndTests
    {
        [Fact]
        // Happy Path Test
        public void Kth_from_the_end_returns_correct_value()

        // Arrange
        List list = new LinkedList();
        list.Insert(2); // all numbers in the list
        list.Insert(8);
        list.Insert(3);
        list.Insert(1);

        // Act
        int result = list.KthFromTheEnd(2); // grabbing the int 2 of the list. Or what the number is at the 2 place

        // Assert
        Assert.Equal(3, result); // 3 is what we expect to show up in the output when 2 is entered








    }
}
