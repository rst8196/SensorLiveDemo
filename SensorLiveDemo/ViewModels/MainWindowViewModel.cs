namespace SensorLiveDemo.ViewModels
{
    using Prism.Commands;
    using Prism.Regions;

    public class MainWindowViewModel : ViewModelBase
    {
        /// <summary>
        /// The region manager
        /// </summary>
        private readonly IRegionManager _regionManager;

        /// <summary>
        /// The title
        /// </summary>
        private string _title = "Sensor Live Demo";

        /// <summary>
        /// The primary sensor view model
        /// </summary>
        private PrimarySensorViewModel _primarySensorViewModel = new PrimarySensorViewModel();

        /// <summary>
        /// The secondary sensor view model
        /// </summary>
        private SecondarySensorViewModel _secondarySensorViewModel = new SecondarySensorViewModel();

        /// <summary>
        /// The fallback sensor view model
        /// </summary>
        private FallbackSensorViewModel _fallbackSensorViewModel = new FallbackSensorViewModel();

        /// <summary>
        /// Gets the navigate command.
        /// </summary>
        /// <value>
        /// The navigate command.
        /// </value>
        public DelegateCommand<string> NavigateCommand { get; private set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="MainWindowViewModel"/> class.
        /// </summary>
        /// <param name="regionManager">The region manager.</param>
        public MainWindowViewModel(IRegionManager regionManager)
        {
            _regionManager = regionManager;

            NavigateCommand = new DelegateCommand<string>(Navigate);
        }

        /// <summary>
        /// Gets or sets the primary sensor view model.
        /// </summary>
        /// <value>
        /// The primary sensor view model.
        /// </value>
        public PrimarySensorViewModel PrimarySensorViewModel
        {
            get => _primarySensorViewModel;
            set => SetProperty(ref _primarySensorViewModel, value);
        }

        /// <summary>
        /// Gets or sets the secondary sensor view model.
        /// </summary>
        /// <value>
        /// The secondary sensor view model.
        /// </value>
        public SecondarySensorViewModel SecondarySensorViewModel
        {
            get => _secondarySensorViewModel;
            set => SetProperty(ref _secondarySensorViewModel, value);
        }

        /// <summary>
        /// Gets or sets the fallback sensor view model.
        /// </summary>
        /// <value>
        /// The fallback sensor view model.
        /// </value>
        public FallbackSensorViewModel FallbackSensorViewModel
        {
            get => _fallbackSensorViewModel;
            set => SetProperty(ref _fallbackSensorViewModel, value);
        }

        /// <summary>
        /// Gets or sets the title.
        /// </summary>
        /// <value>
        /// The title.
        /// </value>
        public string Title
        {
            get => _title;
            set => SetProperty(ref _title, value);
        }

        /// <summary>
        /// Navigates the specified navigate path.
        /// </summary>
        /// <param name="navigatePath">The navigate path.</param>
        private void Navigate(string navigatePath)
        {
            if (navigatePath != null)
                _regionManager.RequestNavigate("ContentRegion", navigatePath);
        }
    }
}