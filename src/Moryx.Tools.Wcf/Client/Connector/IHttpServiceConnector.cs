// Copyright (c) 2020, Phoenix Contact GmbH & Co. KG
// Licensed under the Apache License, Version 2.0

using System;
using Moryx.Modules;

namespace Moryx.Tools.Wcf
{
    /// <summary>
    /// Interface for http service connectors
    /// </summary>
    public interface IHttpServiceConnector : IPlugin
    {
        /// <summary>
        /// Informs that the availabilty of the wcf client has changed
        /// </summary>
        event EventHandler AvailabilityChanged;

        /// <summary>
        /// Propertie the check the availability of the wcf client
        /// </summary>
        bool IsAvailable { get; }
    }
}
