namespace SensorLiveDemo.ViewModels
{
    using System;
    using System.Timers;
    using System.Windows;
    using SciChart.Charting.Model.DataSeries;
    using SciChart.Core.Utility;

    public class DataModel : ViewModelBase
    {
        /// <summary>
        /// Data Sample Rate (sec)  - 100 Hz
        /// </summary>
        protected double _dt = 0.01;

        /// <summary>
        /// The fifo size
        /// </summary>
        protected int FifoSize = 500;

        protected Timer _timerNewDataUpdate;

        /// <summary>
        /// The current time
        /// </summary>
        protected double _t;

        /// <summary>
        /// The random
        /// </summary>
        protected readonly Random _random = new Random();

        /// <summary>
        /// The series
        /// </summary>
        private XyDataSeries<double, double> _series = new XyDataSeries<double, double>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DataModel"/> class.
        /// </summary>
        public DataModel()
        {
            
            _timerNewDataUpdate = new Timer(_dt * 1000);
            _timerNewDataUpdate.AutoReset = true;
            _timerNewDataUpdate.Elapsed += OnNewData;

            _timerNewDataUpdate.Start();
            
            CreateDataSetAndSeries();
        }

        /// <summary>
        /// Gets or sets the series.
        /// </summary>
        /// <value>
        /// The series.
        /// </value>
        public XyDataSeries<double, double> Series
        {
            get => _series;
            set => SetProperty(ref _series, value);
        }

        /// <summary>
        /// Creates the data set and series.
        /// </summary>
        private void CreateDataSetAndSeries()
        {
            // Create new Dataseries of type X=double, Y=double
            _series = new XyDataSeries<double, double>();
            Series.FifoCapacity = FifoSize;
        }

        /// <summary>
        /// Called when [new data].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        internal virtual void OnNewData(object sender, EventArgs e)
        {

        }
    }
}