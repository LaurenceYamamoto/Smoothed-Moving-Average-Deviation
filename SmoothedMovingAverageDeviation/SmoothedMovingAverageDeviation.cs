using System;
using cAlgo.API;
using cAlgo.API.Collections;
using cAlgo.API.Indicators;
using cAlgo.API.Internals;

namespace cAlgo
{
    [Indicator(IsOverlay = false, TimeZone = TimeZones.UTC, AccessRights = AccessRights.None)]
    public class SmoothedMovingAverageDeviation : Indicator
    {
        [Parameter()]
        public DataSeries Source { get; set; }
        
        [Parameter("Moving Average Period", DefaultValue = 120, MinValue = 1)]
        public int MovingAveragePeriod { get; set; }
        
        [Parameter("Moving Average Type", DefaultValue = MovingAverageType.Simple)]
        public MovingAverageType MovingAverageMethod { get; set; }
        
        [Parameter("Smooth Period", DefaultValue = 6, MinValue = 1)]
        public int SmoothPeriod { get; set; }
        
        [Parameter("Smooth Method", DefaultValue = MovingAverageType.DoubleExponential)]
        public MovingAverageType SmoothMethod { get; set; }

        [Output("Smoothed Moving Average Deviation")]
        public IndicatorDataSeries Result { get; set; }
        
        private MovingAverage _ma;
        private IndicatorDataSeries _deviation;
        private MovingAverage _smoothedDeviation;

        protected override void Initialize()
        {
            _ma = Indicators.MovingAverage(Source, MovingAveragePeriod, MovingAverageMethod);
            _deviation = CreateDataSeries();
            _smoothedDeviation = Indicators.MovingAverage(_deviation, SmoothPeriod, SmoothMethod);
        }

        public override void Calculate(int index)
        {
            _deviation[index] = (Source[index] - _ma.Result[index]) / _ma.Result[index];
            Result[index] = _smoothedDeviation.Result[index];
        }
    }
}