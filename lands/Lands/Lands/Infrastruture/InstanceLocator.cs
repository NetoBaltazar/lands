﻿
namespace Lands.Infrastruture
{
    using ViewModels;
    public class InstanceLocator
    {

        #region  Propertis
       public MainViewModel Main
        {
            get;
            set;
        }
        #endregion

        #region Contructor
        public InstanceLocator()
        {
            this.Main = new MainViewModel();
        }
        #endregion
    }
}
