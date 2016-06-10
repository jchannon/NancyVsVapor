using System.Collections.Generic;

namespace NancyVsVapor
{
    public class JsonModel
    {
        public int[] Array => new int[] { 1, 2, 3 };

        public Dictionary<string, int> Dict => new Dictionary<string, int>() { { "one", 1 }, { "two", 2 }, { "three", 3 } };

        public int Int => 42;

        public string String => "test";

        public double Double => 3.14;

        public string Null => null;
    }
}