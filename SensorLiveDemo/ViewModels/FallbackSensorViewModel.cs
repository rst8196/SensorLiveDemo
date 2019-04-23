namespace SensorLiveDemo.ViewModels
{
    using System;

    public class FallbackSensorViewModel : DataModel
    {
        /// <summary>
        /// Called when [new data].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        internal override void OnNewData(object sender, EventArgs e)
        {
            var y3 = 1.0 * Math.Sin(((2 * Math.PI) * 2.2) * _t) + _random.NextDouble()*0.5;

            Series.Append(_t, y3);

            // Increment current time
            _t += _dt;
        }
    }
}