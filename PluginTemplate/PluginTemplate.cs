﻿using System;
using Terraria;
using TerrariaApi.Server;

namespace PluginTemplate
{
    /// <summary>
    /// The main plugin class should always be decorated with an ApiVersion attribute. The current API Version is 2.00 and don't forget to add OTAPI
    /// </summary>
    [ApiVersion(2,00)]
    public class PluginTemplate : TerrariaPlugin
    {
        /// <summary>
        /// The name of the plugin.
        /// </summary>
        public override string Name
        {
            get { return "Template Plugin"; }
        }

        /// <summary>
        /// The version of the plugin in its current state.
        /// </summary>
        public override Version Version
        {
            get { return new Version(1, 0, 0); }
        }

        /// <summary>
        /// The author(s) of the plugin.
        /// </summary>
        public override string Author
        {
            get { return "Ijwu"; }
        }

        /// <summary>
        /// A short, one-line, description of the plugin's purpose.
        /// </summary>
        public override string Description
        {
            get { return "A simple, senseless, plugin used to demonstrate the code structure of a TShock and TS-API plugin."; }
        }

        /// <summary>
        /// The plugin's constructor
        /// Set your plugin's order (optional) and any other constructor logic here
        /// </summary>
        public PluginTemplate(Main game) : base(game)
        {

        }

        /// <summary>
        /// Performs plugin initialization logic.
        /// Add your hooks, config file read/writes, etc here
        /// </summary>
        public override void Initialize()
        {
            throw new System.NotImplementedException();
        }
        
        /// <summary>
        /// Performs plugin cleanup logic
        /// Remove your hooks and perform general cleanup here
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                //unhook
                //dispose child objects
                //set large objects to null
            }
            base.Dispose(disposing);
        }
    }
}
