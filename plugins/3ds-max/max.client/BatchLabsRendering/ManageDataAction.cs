﻿using Autodesk.Max;

namespace BatchLabsRendering
{
    public class ManageDataAction : ActionBase
    {
        public override void InternalExecute()
        {            
            var Interface = GlobalInterface.Instance.COREInterface16;
            Interface.PushPrompt("Calling out to data UI in BatchLabs");

            LabsRequestHandler.CallBatchLabs("data");
        }

        public override string InternalActionText => "Monitor your Data";
    }
}