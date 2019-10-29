﻿
using UnityEngine;

namespace Microsoft.MixedReality.Toolkit.UI.Experimental
{
    /// <summary>
    /// Configuration for <see cref="BoundsControlScaleHandles"/> used in <see cref="BoundsControl"/>
    /// This class provides all data members needed to create scale handles for <see cref="BoundsControl"/>
    /// </summary>
    [CreateAssetMenu(fileName = "BoundsControlScaleHandlesConfiguration", menuName = "Mixed Reality Toolkit/Bounds Control/Scale Handles Configuration")]
    public class BoundsControlScaleHandlesConfiguration : BoundsControlHandlesBaseConfiguration
    {
        #region serialized fields
        [SerializeField]
        [Tooltip("Prefab used to display handles for 2D slate. If not set, default box shape will be used")]
        GameObject handleSlatePrefab = null;

        /// <summary>
        /// Prefab used to display handles for 2D slate. If not set, default box shape will be used
        /// </summary>
        public GameObject HandleSlatePrefab
        {
            get { return handleSlatePrefab; }
            set
            {
                if (handleSlatePrefab != value)
                {
                    handleSlatePrefab = value;
                    configurationChanged.Invoke();
                }
            }
        }

        [SerializeField]
        [Tooltip("Check to show scale handles")]
        private bool showScaleHandles = true;

        /// <summary>
        /// Public property to Set the visibility of the corner cube Scaling handles.
        /// </summary>
        public bool ShowScaleHandles
        {
            get
            {
                return showScaleHandles;
            }
            set
            {
                if (showScaleHandles != value)
                {
                    showScaleHandles = value;
                    visibilityChanged.Invoke();
                }
            }
        }

        #endregion serialized fields
    }
}
