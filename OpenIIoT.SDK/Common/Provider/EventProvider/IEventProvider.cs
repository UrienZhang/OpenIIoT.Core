﻿/*
      █▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀ ▀▀▀▀▀▀▀▀▀▀▀▀▀▀ ▀▀▀  ▀  ▀      ▀▀
      █
      █    ▄█     ▄████████                                         ▄███████▄
      █   ███    ███    ███                                        ███    ███
      █   ███▌   ███    █▀   █    █     ▄█████ ██▄▄▄▄      ██      ███    ███    █████  ██████   █    █   █  ██████▄     ▄█████    █████
      █   ███▌  ▄███▄▄▄     ██    ██   ██   █  ██▀▀▀█▄ ▀███████▄   ███    ███   ██  ██ ██    ██ ██    ██ ██  ██   ▀██   ██   █    ██  ██
      █   ███▌ ▀▀███▀▀▀     ██    ██  ▄██▄▄    ██   ██     ██  ▀ ▀█████████▀   ▄██▄▄█▀ ██    ██ ██    ██ ██▌ ██    ██  ▄██▄▄     ▄██▄▄█▀
      █   ███    ███    █▄  ██    ██ ▀▀██▀▀    ██   ██     ██      ███        ▀███████ ██    ██ ██    ██ ██  ██    ██ ▀▀██▀▀    ▀███████
      █   ███    ███    ███  █▄  ▄█    ██   █  ██   ██     ██      ███          ██  ██ ██    ██  █▄  ▄█  ██  ██   ▄██   ██   █    ██  ██
      █   █▀     ██████████   ▀██▀     ███████  █   █     ▄██▀    ▄████▀        ██  ██  ██████    ▀██▀   █   ██████▀    ███████   ██  ██
      █
 ▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄ ▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄ ▄▄  ▄▄ ▄▄   ▄▄▄▄ ▄▄     ▄▄     ▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄ ▄ ▄
 █████████████████████████████████████████████████████████████ ███████████████ ██  ██ ██   ████ ██     ██     ████████████████ █ █
      ▄
      █  Defines the interface for Event Providers; classes capable of providing Events.
      █
      █▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀ ▀▀▀▀▀▀▀▀▀▀▀ ▀ ▀▀▀     ▀▀               ▀
      █  The GNU Affero General Public License (GNU AGPL)
      █
      █  Copyright (C) 2016-2017 JP Dillingham (jp@dillingham.ws)
      █
      █  This program is free software: you can redistribute it and/or modify
      █  it under the terms of the GNU Affero General Public License as published by
      █  the Free Software Foundation, either version 3 of the License, or
      █  (at your option) any later version.
      █
      █  This program is distributed in the hope that it will be useful,
      █  but WITHOUT ANY WARRANTY; without even the implied warranty of
      █  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
      █  GNU Affero General Public License for more details.
      █
      █  You should have received a copy of the GNU Affero General Public License
      █  along with this program.  If not, see <http://www.gnu.org/licenses/>.
      █
      ▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀  ▀▀ ▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀██
                                                                                                   ██
                                                                                               ▀█▄ ██ ▄█▀
                                                                                                 ▀████▀
                                                                                                   ▀▀                            */

namespace OpenIIoT.SDK.Common.Provider.EventProvider
{
    /// <summary>
    ///     Defines the interface for Event Providers; classes capable of providing Events.
    /// </summary>
    public interface IEventProvider : IProvider
    {
        #region Public Properties

        /// <summary>
        ///     Gets the Event Provider name.
        /// </summary>
        string EventProviderName { get; }

        #endregion Public Properties
    }
}