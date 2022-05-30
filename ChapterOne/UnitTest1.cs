using System;
using System.Linq;
using Xunit;

namespace ChapterOne
{
    public class UnitTest1
    {
        [Fact]
        public void Tripples()
        {
            var triple = (int x) => x * 3;
 
            var range = Enumerable.Range(1, 3);
 
            var triples = range.Select(triple);
 
            //triples // => [3, 6, 9]
        }
    }
}