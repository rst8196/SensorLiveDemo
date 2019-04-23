namespace SensorLiveDemo.ViewModels
{
    using System;

    public class SecondarySensorViewModel : DataModel
    {
        /// <summary>
        /// Called when [new data].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        internal override void OnNewData(object sender, EventArgs e)
        {
            var y2 = 2.0 * Math.Cos(((2 * Math.PI) * 0.8) * _t) + _random.NextDouble()*0.5;
            
            Series.Append(_t, y2);

            // Increment current time
            _t += _dt;
        }
    }
}