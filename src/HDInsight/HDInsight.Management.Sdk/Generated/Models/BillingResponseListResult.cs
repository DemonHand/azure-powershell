// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.HDInsight.Models
{
    using System.Linq;

    /// <summary>
    /// The response for the operation to get regional billingSpecs for a
    /// subscription.
    /// </summary>
    public partial class BillingResponseListResult
    {
        /// <summary>
        /// Initializes a new instance of the BillingResponseListResult class.
        /// </summary>
        public BillingResponseListResult()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the BillingResponseListResult class.
        /// </summary>

        /// <param name="vmSizes">The virtual machine sizes to include or exclude.
        /// </param>

        /// <param name="vmSizesWithEncryptionAtHost">The vm sizes which enable encryption at host.
        /// </param>

        /// <param name="vmSizeFilters">The virtual machine filtering mode. Effectively this can enabling or
        /// disabling the virtual machine sizes in a particular set.
        /// </param>

        /// <param name="vmSizeProperties">The vm size properties.
        /// </param>

        /// <param name="billingResources">The billing and managed disk billing resources for a region.
        /// </param>
        public BillingResponseListResult(System.Collections.Generic.IList<string> vmSizes = default(System.Collections.Generic.IList<string>), System.Collections.Generic.IList<string> vmSizesWithEncryptionAtHost = default(System.Collections.Generic.IList<string>), System.Collections.Generic.IList<VmSizeCompatibilityFilterV2> vmSizeFilters = default(System.Collections.Generic.IList<VmSizeCompatibilityFilterV2>), System.Collections.Generic.IList<VmSizeProperty> vmSizeProperties = default(System.Collections.Generic.IList<VmSizeProperty>), System.Collections.Generic.IList<BillingResources> billingResources = default(System.Collections.Generic.IList<BillingResources>))

        {
            this.VMSizes = vmSizes;
            this.VMSizesWithEncryptionAtHost = vmSizesWithEncryptionAtHost;
            this.VMSizeFilters = vmSizeFilters;
            this.VMSizeProperties = vmSizeProperties;
            this.BillingResources = billingResources;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets or sets the virtual machine sizes to include or exclude.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "vmSizes")]
        public System.Collections.Generic.IList<string> VMSizes {get; set; }

        /// <summary>
        /// Gets or sets the vm sizes which enable encryption at host.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "vmSizesWithEncryptionAtHost")]
        public System.Collections.Generic.IList<string> VMSizesWithEncryptionAtHost {get; set; }

        /// <summary>
        /// Gets or sets the virtual machine filtering mode. Effectively this can
        /// enabling or disabling the virtual machine sizes in a particular set.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "vmSizeFilters")]
        public System.Collections.Generic.IList<VmSizeCompatibilityFilterV2> VMSizeFilters {get; set; }

        /// <summary>
        /// Gets the vm size properties.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "vmSizeProperties")]
        public System.Collections.Generic.IList<VmSizeProperty> VMSizeProperties {get; private set; }

        /// <summary>
        /// Gets or sets the billing and managed disk billing resources for a region.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "billingResources")]
        public System.Collections.Generic.IList<BillingResources> BillingResources {get; set; }
    }
}