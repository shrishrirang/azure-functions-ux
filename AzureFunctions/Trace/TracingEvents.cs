﻿using Serilog.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AzureFunctions.Trace
{
    public static class TracingEvents
    {
        // EventId = 0
        public static readonly TracingEvent ErrorInGetFunctionTemplate = new TracingEvent
        {
            Message = "TemplatesManager.GetFunctionTemplate({templateFolderName}), {Exception}",
            EventId = 0
        };

        // EventId = 1
        public static readonly TracingEvent ErrorInGetFunctionContainer = new TracingEvent
        {
            Message = "AzureFunctionsController.GetFunctionContainer()",
            EventId = 1
        };

        // EventId = 2
        public static readonly TracingEvent ErrorInCreateFunctionsContainer = new TracingEvent
        {
            Message = "AzureFunctionsController.CreateFunctionsContainer({subscriptionId}, {location}, {serverFarmId}) {Exception}",
            EventId = 2
        };

        // EventId = 3
        public static readonly TracingEvent ErrorInCreateTrialFunctionContainer = new TracingEvent
        {
            Message = "CreateTrialFunctionsContainer() {Exception}",
            EventId = 3
        };

        // EventId = 4
        public static readonly TracingEvent CompletedOperationTemplate = new TracingEvent
        {
            Message = "Completed {TimedOperationId}: {OperationName} started {StartedTime} in {TimedOperationElapsed} ({TimeTakenMsec} ms) {OperationResult}",
            EventId = 4
        };
    }
}