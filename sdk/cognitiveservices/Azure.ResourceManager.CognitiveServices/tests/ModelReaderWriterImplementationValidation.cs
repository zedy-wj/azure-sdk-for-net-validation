// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using NUnit.Framework;

namespace Azure.ResourceManager.TestFramework
{
    public partial class ModelReaderWriterImplementationValidation
    {
        [OneTimeSetUp]
        public void SetExceptionList()
        {
            // This model is an option bag.
            ExceptionList = new string[] { "Azure.ResourceManager.CognitiveServices.Models.AgentApplicationCollectionGetAllOptions" };
        }
    }
}
