/* 
 * Forge SDK
 *
 * The Forge Platform contains an expanding collection of web service components that can be used with Autodesk cloud-based products or your own technologies. Take advantage of Autodesk’s expertise in design and engineering.
 *
 * OpenAPI spec version: 0.1.0
 * Contact: forge.help@autodesk.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *      http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Autodesk.Forge.Model
{
    /// <summary>
    /// WorkItemResp
    /// </summary>
    [DataContract]
    public partial class WorkItemResp :  IEquatable<WorkItemResp>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WorkItemResp" /> class.
        /// </summary>
        /// <param name="Id">Id.</param>
        /// <param name="Arguments">Arguments.</param>
        /// <param name="Status">Status.</param>
        /// <param name="StatusDetail">StatusDetail.</param>
        /// <param name="AvailabilityZone">AvailabilityZone.</param>
        /// <param name="ActivityId">ActivityId.</param>
        /// <param name="Version">Version.</param>
        /// <param name="Timestamp">Timestamp.</param>
        /// <param name="TimeQueued">TimeQueued.</param>
        /// <param name="TimeInputTransferStarted">TimeInputTransferStarted.</param>
        /// <param name="TimeScriptStarted">TimeScriptStarted.</param>
        /// <param name="TimeScriptEnded">TimeScriptEnded.</param>
        /// <param name="TimeOutputTransferEnded">TimeOutputTransferEnded.</param>
        /// <param name="BytesTranferredIn">BytesTranferredIn.</param>
        /// <param name="BytesTranferredOut">BytesTranferredOut.</param>
        public WorkItemResp(string Id = null, Object Arguments = null, string Status = null, Object StatusDetail = null, string AvailabilityZone = null, string ActivityId = null, int? Version = null, string Timestamp = null, string TimeQueued = null, string TimeInputTransferStarted = null, string TimeScriptStarted = null, string TimeScriptEnded = null, string TimeOutputTransferEnded = null, int? BytesTranferredIn = null, int? BytesTranferredOut = null)
        {
            this.Id = Id;
            this.Arguments = Arguments;
            this.Status = Status;
            this.StatusDetail = StatusDetail;
            this.AvailabilityZone = AvailabilityZone;
            this.ActivityId = ActivityId;
            this.Version = Version;
            this.Timestamp = Timestamp;
            this.TimeQueued = TimeQueued;
            this.TimeInputTransferStarted = TimeInputTransferStarted;
            this.TimeScriptStarted = TimeScriptStarted;
            this.TimeScriptEnded = TimeScriptEnded;
            this.TimeOutputTransferEnded = TimeOutputTransferEnded;
            this.BytesTranferredIn = BytesTranferredIn;
            this.BytesTranferredOut = BytesTranferredOut;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="Id", EmitDefaultValue=false)]
        public string Id { get; set; }
        /// <summary>
        /// Gets or Sets Arguments
        /// </summary>
        [DataMember(Name="Arguments", EmitDefaultValue=false)]
        public Object Arguments { get; set; }
        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name="Status", EmitDefaultValue=false)]
        public string Status { get; set; }
        /// <summary>
        /// Gets or Sets StatusDetail
        /// </summary>
        [DataMember(Name="StatusDetail", EmitDefaultValue=false)]
        public Object StatusDetail { get; set; }
        /// <summary>
        /// Gets or Sets AvailabilityZone
        /// </summary>
        [DataMember(Name="AvailabilityZone", EmitDefaultValue=false)]
        public string AvailabilityZone { get; set; }
        /// <summary>
        /// Gets or Sets ActivityId
        /// </summary>
        [DataMember(Name="ActivityId", EmitDefaultValue=false)]
        public string ActivityId { get; set; }
        /// <summary>
        /// Gets or Sets Version
        /// </summary>
        [DataMember(Name="Version", EmitDefaultValue=false)]
        public int? Version { get; set; }
        /// <summary>
        /// Gets or Sets Timestamp
        /// </summary>
        [DataMember(Name="Timestamp", EmitDefaultValue=false)]
        public string Timestamp { get; set; }
        /// <summary>
        /// Gets or Sets TimeQueued
        /// </summary>
        [DataMember(Name="TimeQueued", EmitDefaultValue=false)]
        public string TimeQueued { get; set; }
        /// <summary>
        /// Gets or Sets TimeInputTransferStarted
        /// </summary>
        [DataMember(Name="TimeInputTransferStarted", EmitDefaultValue=false)]
        public string TimeInputTransferStarted { get; set; }
        /// <summary>
        /// Gets or Sets TimeScriptStarted
        /// </summary>
        [DataMember(Name="TimeScriptStarted", EmitDefaultValue=false)]
        public string TimeScriptStarted { get; set; }
        /// <summary>
        /// Gets or Sets TimeScriptEnded
        /// </summary>
        [DataMember(Name="TimeScriptEnded", EmitDefaultValue=false)]
        public string TimeScriptEnded { get; set; }
        /// <summary>
        /// Gets or Sets TimeOutputTransferEnded
        /// </summary>
        [DataMember(Name="TimeOutputTransferEnded", EmitDefaultValue=false)]
        public string TimeOutputTransferEnded { get; set; }
        /// <summary>
        /// Gets or Sets BytesTranferredIn
        /// </summary>
        [DataMember(Name="BytesTranferredIn", EmitDefaultValue=false)]
        public int? BytesTranferredIn { get; set; }
        /// <summary>
        /// Gets or Sets BytesTranferredOut
        /// </summary>
        [DataMember(Name="BytesTranferredOut", EmitDefaultValue=false)]
        public int? BytesTranferredOut { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WorkItemResp {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Arguments: ").Append(Arguments).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  StatusDetail: ").Append(StatusDetail).Append("\n");
            sb.Append("  AvailabilityZone: ").Append(AvailabilityZone).Append("\n");
            sb.Append("  ActivityId: ").Append(ActivityId).Append("\n");
            sb.Append("  Version: ").Append(Version).Append("\n");
            sb.Append("  Timestamp: ").Append(Timestamp).Append("\n");
            sb.Append("  TimeQueued: ").Append(TimeQueued).Append("\n");
            sb.Append("  TimeInputTransferStarted: ").Append(TimeInputTransferStarted).Append("\n");
            sb.Append("  TimeScriptStarted: ").Append(TimeScriptStarted).Append("\n");
            sb.Append("  TimeScriptEnded: ").Append(TimeScriptEnded).Append("\n");
            sb.Append("  TimeOutputTransferEnded: ").Append(TimeOutputTransferEnded).Append("\n");
            sb.Append("  BytesTranferredIn: ").Append(BytesTranferredIn).Append("\n");
            sb.Append("  BytesTranferredOut: ").Append(BytesTranferredOut).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as WorkItemResp);
        }

        /// <summary>
        /// Returns true if WorkItemResp instances are equal
        /// </summary>
        /// <param name="other">Instance of WorkItemResp to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WorkItemResp other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.Arguments == other.Arguments ||
                    this.Arguments != null &&
                    this.Arguments.Equals(other.Arguments)
                ) && 
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                ) && 
                (
                    this.StatusDetail == other.StatusDetail ||
                    this.StatusDetail != null &&
                    this.StatusDetail.Equals(other.StatusDetail)
                ) && 
                (
                    this.AvailabilityZone == other.AvailabilityZone ||
                    this.AvailabilityZone != null &&
                    this.AvailabilityZone.Equals(other.AvailabilityZone)
                ) && 
                (
                    this.ActivityId == other.ActivityId ||
                    this.ActivityId != null &&
                    this.ActivityId.Equals(other.ActivityId)
                ) && 
                (
                    this.Version == other.Version ||
                    this.Version != null &&
                    this.Version.Equals(other.Version)
                ) && 
                (
                    this.Timestamp == other.Timestamp ||
                    this.Timestamp != null &&
                    this.Timestamp.Equals(other.Timestamp)
                ) && 
                (
                    this.TimeQueued == other.TimeQueued ||
                    this.TimeQueued != null &&
                    this.TimeQueued.Equals(other.TimeQueued)
                ) && 
                (
                    this.TimeInputTransferStarted == other.TimeInputTransferStarted ||
                    this.TimeInputTransferStarted != null &&
                    this.TimeInputTransferStarted.Equals(other.TimeInputTransferStarted)
                ) && 
                (
                    this.TimeScriptStarted == other.TimeScriptStarted ||
                    this.TimeScriptStarted != null &&
                    this.TimeScriptStarted.Equals(other.TimeScriptStarted)
                ) && 
                (
                    this.TimeScriptEnded == other.TimeScriptEnded ||
                    this.TimeScriptEnded != null &&
                    this.TimeScriptEnded.Equals(other.TimeScriptEnded)
                ) && 
                (
                    this.TimeOutputTransferEnded == other.TimeOutputTransferEnded ||
                    this.TimeOutputTransferEnded != null &&
                    this.TimeOutputTransferEnded.Equals(other.TimeOutputTransferEnded)
                ) && 
                (
                    this.BytesTranferredIn == other.BytesTranferredIn ||
                    this.BytesTranferredIn != null &&
                    this.BytesTranferredIn.Equals(other.BytesTranferredIn)
                ) && 
                (
                    this.BytesTranferredOut == other.BytesTranferredOut ||
                    this.BytesTranferredOut != null &&
                    this.BytesTranferredOut.Equals(other.BytesTranferredOut)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                if (this.Arguments != null)
                    hash = hash * 59 + this.Arguments.GetHashCode();
                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();
                if (this.StatusDetail != null)
                    hash = hash * 59 + this.StatusDetail.GetHashCode();
                if (this.AvailabilityZone != null)
                    hash = hash * 59 + this.AvailabilityZone.GetHashCode();
                if (this.ActivityId != null)
                    hash = hash * 59 + this.ActivityId.GetHashCode();
                if (this.Version != null)
                    hash = hash * 59 + this.Version.GetHashCode();
                if (this.Timestamp != null)
                    hash = hash * 59 + this.Timestamp.GetHashCode();
                if (this.TimeQueued != null)
                    hash = hash * 59 + this.TimeQueued.GetHashCode();
                if (this.TimeInputTransferStarted != null)
                    hash = hash * 59 + this.TimeInputTransferStarted.GetHashCode();
                if (this.TimeScriptStarted != null)
                    hash = hash * 59 + this.TimeScriptStarted.GetHashCode();
                if (this.TimeScriptEnded != null)
                    hash = hash * 59 + this.TimeScriptEnded.GetHashCode();
                if (this.TimeOutputTransferEnded != null)
                    hash = hash * 59 + this.TimeOutputTransferEnded.GetHashCode();
                if (this.BytesTranferredIn != null)
                    hash = hash * 59 + this.BytesTranferredIn.GetHashCode();
                if (this.BytesTranferredOut != null)
                    hash = hash * 59 + this.BytesTranferredOut.GetHashCode();
                return hash;
            }
        }
    }

}

