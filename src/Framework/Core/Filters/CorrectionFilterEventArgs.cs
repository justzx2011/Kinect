﻿using Kinect.Core.Eventing;
using System.Windows.Media.Media3D;


namespace Kinect.Core.Filters
{
    public class CorrectionFilterEventArgs : FilterEventArgs
    {
        private const string _name = "CorrectionFilterEventArgs";

        /// <summary>
        /// Name of the filter
        /// </summary>
        public override string Name
        {
            get { return _name; }
        }

        /// <summary>
        /// Gets the joint to correct.
        /// </summary>
        public xn.SkeletonJoint JointToCorrect { get; private set; }

        /// <summary>
        /// Gets the point.
        /// </summary>
        public Point3D Point {get; private set;}

        /// <summary>
        /// Gets the correction.
        /// </summary>
        public Point3D Correction {get; private set;}

        /// <summary>
        /// Initializes a new instance of the <see cref="CorrectionFilterEventArgs"/> class.
        /// </summary>
        /// <param name="jointToCorrect">The joint to correct.</param>
        /// <param name="point">The point.</param>
        /// <param name="correction">The correction.</param>
        public CorrectionFilterEventArgs(xn.SkeletonJoint jointToCorrect, Point3D point, Point3D correction)
        {
            JointToCorrect = jointToCorrect;
            Point = point;
            Correction = correction;
        }
    }
}
