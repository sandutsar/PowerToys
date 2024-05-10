﻿// Copyright (c) Microsoft Corporation
// The Microsoft Corporation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Diagnostics.Tracing;
using Microsoft.PowerToys.Telemetry;
using Microsoft.PowerToys.Telemetry.Events;

namespace WinGetCommandNotFound.Telemetry
{
    [EventData]
    public class CmdNotFoundFeedbackProvidedFailureEvent : EventBase, IEvent
    {
        public string Message { get; set; } = string.Empty;

        public PartA_PrivTags PartA_PrivTags => PartA_PrivTags.ProductAndServiceUsage;
    }
}
