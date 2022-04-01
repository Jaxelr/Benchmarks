using System.Collections.Generic;
using System.Linq;

namespace RailFenceCipherBenchmark
{
    public class RailFenceCipherLoop
    {
        private readonly int rails;

        public RailFenceCipherLoop(int rails)
        {
            this.rails = rails;
        }

        public string Encode(string input)
        {
            string[] railStr = new string[rails];
            int trackIdx = 0;
            int direction = 1;
            int directionCount = 0;
            for (int i = 0; i < input.Length; i++)
            {
                railStr[trackIdx] += input[i];
                trackIdx += direction;
                directionCount++;
                if (directionCount == rails - 1)
                {
                    direction *= -1;
                    directionCount = 0;
                }
            }
            return railStr.Aggregate("", (x, y) => x + y);
        }

        public string Decode(string input)
        {
            int[] trackLen = CalculateTrackLen(input);
            var list = FillTextToRails(input, trackLen);
            string decodeStr = string.Empty;
            int trackIdx = 0;
            int direction = 1;
            int directionCount = 0;
            for (int i = 0; i < input.Length; i++)
            {
                decodeStr += char.ToString(list[trackIdx].First());
                list[trackIdx] = list[trackIdx].Remove(0, 1);
                trackIdx += direction;
                directionCount++;
                if (directionCount == rails - 1)
                {
                    direction *= -1;
                    directionCount = 0;
                }
            }
            return decodeStr;
        }

        private List<string> FillTextToRails(string input, int[] trackLen)
        {
            var list = new List<string>();
            int cur = 0;
            foreach (int i in Enumerable.Range(0, rails))
            {
                string k = input.Substring(cur, trackLen[i]);
                list.Add(k);
                cur += trackLen[i];
            }
            return list;
        }

        private int[] CalculateTrackLen(string input)
        {
            string[] dumb = new string[rails];
            int indexTrack = 0;
            int direction = 1;
            int directionCount = 0;
            for (int i = 0; i < input.Length; i++)
            {
                dumb[indexTrack] += input[i];
                indexTrack += direction;
                directionCount++;
                if (directionCount == rails - 1)
                {
                    direction *= -1;
                    directionCount = 0;
                }
            }
            return dumb.Select(s => s.Length).ToArray();
        }
    }
}
