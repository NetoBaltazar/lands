
namespace Lands.Infrastruture
{
    using ViewModels;
    public class InstanceLocator
    {
        #region  Propertis
       public MainViewModels Main
       {
            get;
            set;
        }
        #endregion

        #region Contructor
        public InstanceLocator()
        {
            this.Main = new MainViewModels();
        }
        #endregion
    }
}
