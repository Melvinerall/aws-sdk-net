/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the guardduty-2017-11-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.GuardDuty.Model
{
    /// <summary>
    /// Container for the parameters to the CreateThreatIntelSet operation.
    /// Create a new ThreatIntelSet. ThreatIntelSets consist of known malicious IP addresses.
    /// GuardDuty generates findings based on ThreatIntelSets.
    /// </summary>
    public partial class CreateThreatIntelSetRequest : AmazonGuardDutyRequest
    {
        private bool? _activate;
        private string _detectorId;
        private ThreatIntelSetFormat _format;
        private string _location;
        private string _name;

        /// <summary>
        /// Gets and sets the property Activate. A boolean value that indicates whether GuardDuty
        /// is to start using the uploaded ThreatIntelSet.
        /// </summary>
        public bool Activate
        {
            get { return this._activate.GetValueOrDefault(); }
            set { this._activate = value; }
        }

        // Check to see if Activate property is set
        internal bool IsSetActivate()
        {
            return this._activate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DetectorId. The unique ID of the detector that you want
        /// to update.
        /// </summary>
        public string DetectorId
        {
            get { return this._detectorId; }
            set { this._detectorId = value; }
        }

        // Check to see if DetectorId property is set
        internal bool IsSetDetectorId()
        {
            return this._detectorId != null;
        }

        /// <summary>
        /// Gets and sets the property Format. The format of the file that contains the ThreatIntelSet.
        /// </summary>
        public ThreatIntelSetFormat Format
        {
            get { return this._format; }
            set { this._format = value; }
        }

        // Check to see if Format property is set
        internal bool IsSetFormat()
        {
            return this._format != null;
        }

        /// <summary>
        /// Gets and sets the property Location. The URI of the file that contains the ThreatIntelSet.
        /// For example (https://s3.us-west-2.amazonaws.com/my-bucket/my-object-key).
        /// </summary>
        public string Location
        {
            get { return this._location; }
            set { this._location = value; }
        }

        // Check to see if Location property is set
        internal bool IsSetLocation()
        {
            return this._location != null;
        }

        /// <summary>
        /// Gets and sets the property Name. A user-friendly ThreatIntelSet name that is displayed
        /// in all finding generated by activity that involves IP addresses included in this ThreatIntelSet.
        /// </summary>
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

    }
}