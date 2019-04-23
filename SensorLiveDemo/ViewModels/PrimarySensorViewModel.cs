namespace SensorLiveDemo.ViewModels
{
    using System;

    public class PrimarySensorViewModel : DataModel
    {
        /// <summary>
        /// Called when [new data].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        internal override void OnNewData(object sender, EventArgs e)
        {
            var y1 = 3.0 * Math.Sin(((2 * Math.PI) * 1.4) * _t) + _random.NextDouble()*0.5;
            
            Series.Append(_t, y1);

            // Increment current time
            _t += _dt;
        }
    }
}