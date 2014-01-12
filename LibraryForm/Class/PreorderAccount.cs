﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace bibliothek
{
    class PreorderAccount
    {
        List<Sample> sampleList;


        public List<Sample> SampleList
        {
            get { return sampleList; }
            set { this.sampleList = value; }
        }


        public void addSample(Sample sample)
        {
            sampleList.Add(sample);
        }


        public void removeSample(Sample sample)
        {
            sampleList.Remove(sample);
        }
    }
}
