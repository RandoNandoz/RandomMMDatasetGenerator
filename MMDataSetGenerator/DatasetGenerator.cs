using System;
using System.Collections.Generic;
using System.Linq;

namespace MMDataSetGenerator
{
    public class DatasetGenerator
    {
        public Dictionary<string, int> MnMDictionary = new Dictionary<string, int>();
        public void GenerateDataMnMDataset(int MnMs)
        {
            MnMDictionary.Clear();
            MnMDictionary.Add("Total M&Ms", MnMs);
            int blueMnMs = (int) (MnMs * 0.24);
            int brownMnMs = (int) (MnMs * 0.14);
            int greenMnMs = (int) (MnMs * 0.16);
            int orangeMnMs = (int) (MnMs * 0.20);
            int redMnMs = (int) (MnMs * 0.13);
            int yellowMnMs = (int) (MnMs * 0.14);
            MnMDictionary.Add("Blue M&Ms", blueMnMs);
            MnMDictionary.Add("Brown M&Ms", brownMnMs);
            MnMDictionary.Add("Green M&Ms", greenMnMs);
            MnMDictionary.Add("Orange M&Ms", orangeMnMs);
            MnMDictionary.Add("Red M&Ms", redMnMs);
            MnMDictionary.Add("Yellow M&Ms", yellowMnMs);
        }
    }
}