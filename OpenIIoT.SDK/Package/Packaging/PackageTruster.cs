﻿using System;

namespace OpenIIoT.SDK.Package.Packaging
{
    public static class PackageTruster
    {
        #region Public Events

        public static event EventHandler<PackagingUpdateEventArgs> Updated;

        #endregion Public Events

        public static void TrustPackage(string packageFile, string privateKeyFile, string passphrase)
        {
            OnUpdated("Not yet implemented.");
        }

        private static void OnUpdated(string message)
        {
            if (Updated != null)
            {
                Updated(null, new PackagingUpdateEventArgs(PackagingOperation.Trust, message));
            }
        }
    }
}