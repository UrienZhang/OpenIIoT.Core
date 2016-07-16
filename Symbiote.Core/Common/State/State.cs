﻿/*
      █▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀ ▀▀▀▀▀▀▀▀▀▀▀▀▀▀ ▀▀▀  ▀  ▀      ▀▀ 
      █   
      █      ▄████████                                                 ▄████████                             
      █     ███    ███                                                ███    ███                             
      █     ███    █▀      ██      ▄█████      ██       ▄█████        ███    █▀  ██▄▄▄▄  ██   █     ▄▄██▄▄▄  
      █     ███        ▀███████▄   ██   ██ ▀███████▄   ██   █        ▄███▄▄▄     ██▀▀▀█▄ ██   ██  ▄█▀▀██▀▀█▄ 
      █   ▀███████████     ██  ▀   ██   ██     ██  ▀  ▄██▄▄         ▀▀███▀▀▀     ██   ██ ██   ██  ██  ██  ██ 
      █            ███     ██    ▀████████     ██    ▀▀██▀▀           ███    █▄  ██   ██ ██   ██  ██  ██  ██ 
      █      ▄█    ███     ██      ██   ██     ██      ██   █         ███    ███ ██   ██ ██   ██  ██  ██  ██ 
      █    ▄████████▀     ▄██▀     ██   █▀    ▄██▀     ███████        ██████████  █   █  ██████    █  ██  █  
      █   
 ▄ ▄▄ █ ▄▄▄▄▄▄▄▄▄  ▄▄▄▄ ▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄ ▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄ ▄▄  ▄▄ ▄▄   ▄▄▄▄ ▄▄     ▄▄     ▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄ ▄ ▄ 
 █ ██ █ █████████  ████ ██████████████████████████████████████ ███████████████ ██  ██ ██   ████ ██     ██     ████████████████ █ █ 
      █  
      █  Enumeration of the different component states.
      █  
      ▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀  ▀▀ ▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀██ 
                                                                                                   ██ 
                                                                                               ▀█▄ ██ ▄█▀ 
                                                                                                 ▀████▀   
                                                                                                   ▀▀                            */
namespace Symbiote.Core
{
    /// <summary>
    /// Enumeration of the different component states.
    /// </summary>
    public enum State
    {
        /// <summary>
        /// The default value.
        /// </summary>
        Undefined,

        /// <summary>
        /// The component has been initialized.
        /// </summary>
        Initialized,

        /// <summary>
        /// The component is starting.
        /// </summary>
        Starting,

        /// <summary>
        /// The component is running.
        /// </summary>
        Running,

        /// <summary>
        /// The component is stopping.
        /// </summary>
        Stopping,

        /// <summary>
        /// The component has stopped.
        /// </summary>
        Stopped,

        /// <summary>
        /// The component is faulted.
        /// </summary>
        Faulted
    }
}