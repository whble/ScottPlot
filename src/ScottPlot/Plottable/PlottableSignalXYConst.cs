﻿using ScottPlot.MinMaxSearchStrategies;
using System;

namespace ScottPlot.Plottable
{
    public class PlottableSignalXYConst<TX, TY> : PlottableSignalXYGeneric<TX, TY> where TX : struct, IComparable where TY : struct, IComparable
    {
        public bool TreesReady => (minmaxSearchStrategy as SegmentedTreeMinMaxSearchStrategy<TY>)?.TreesReady ?? false;

        public PlottableSignalXYConst() : base()
        {
            minmaxSearchStrategy = new SegmentedTreeMinMaxSearchStrategy<TY>();
        }

        public override string ToString()
        {
            string label = string.IsNullOrWhiteSpace(this.label) ? "" : $" ({this.label})";
            return $"PlottableSignalXYConst{label} with {PointCount} points ({typeof(TX).Name}, {typeof(TY).Name})";
        }
    }
}