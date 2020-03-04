﻿// Copyright (c) Microsoft Corporation.  All rights reserved.
// Licensed under the MIT License.  See License.txt in the project root for license information.

using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Microsoft.OData.ModelBuilder.Tests
{
    public class MyOrder
    {
        public int ID { get; set; }

        public string Name { get; set; }
        
        [Contained]
        public virtual ICollection<OrderLine> OrderLines { get; set; }

        [Required]
        [Contained]
        public virtual OrderHeader OrderHeader { get; set; }

        [Contained]
        public virtual OrderCancellation OrderCancellation { get; set; }
    }
}
