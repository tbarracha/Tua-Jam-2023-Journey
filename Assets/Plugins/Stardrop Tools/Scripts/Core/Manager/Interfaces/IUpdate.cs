﻿
namespace StardropTools
{
    public interface IUpdate
    {
        /// <summary>
        /// Adds object to the Update list in the FrameworkManager
        /// </summary>
        public void StartUpdate();

        /// <summary>
        /// Removes object to the Update list in the FrameworkManager
        /// </summary>
        public void StopUpdate();

        public void HandleUpdate();
    }
}