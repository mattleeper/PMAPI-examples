/*
 *  Part of the Sign-Up.to Permission Marketing API v0.1 Redistributable
 *
 *
 *  Copyright (c) 2013 Sign-Up Technologies Ltd.
 *  All rights reserved.
 *
 *  Redistribution and use in source and binary forms, with or without
 *  modification, are permitted provided that the following conditions are met:
 *
 *  1. Redistributions of source code must retain the above copyright notice, this
 *     list of conditions and the following disclaimer.
 *  2. Redistributions in binary form must reproduce the above copyright notice,
 *     this list of conditions and the following disclaimer in the documentation
 *     and/or other materials provided with the distribution.
 *
 *  THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS" AND
 *  ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE IMPLIED
 *  WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE ARE
 *  DISCLAIMED. IN NO EVENT SHALL THE COPYRIGHT OWNER OR CONTRIBUTORS BE LIABLE FOR
 *  ANY DIRECT, INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES
 *  (INCLUDING, BUT NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES;
 *  LOSS OF USE, DATA, OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND
 *  ON ANY THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT
 *  (INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE USE OF THIS
 *  SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.
 *
 */
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SuT.PMAPI.Responses;
using SuT.PMAPI.Types.v1;

namespace SuT.PMAPI.Types.v1
{
    public class BounceRequest : Request<BounceResponse>
    {
        [CanGet]
        [MandatoryGetMultiple]
        public Int32? id
        {
            get { return getProperty<Int32?>("id"); }
            set { setProperty<Int32?>("id", value); }
        }

        [CanGet]
        [MandatoryGet]
        public string channel
        {
            get { return getProperty<string>("channel"); }
            set { setProperty<string>("channel", value); }
        }

        [CanGet]
        [MandatoryGetMultiple]
        public UInt32 subscriber_id
        {
            get { return getProperty<UInt32>("subscriber_id"); }
            set { setProperty("subscriber_id", value); }
        }

        [CanGet]
        [MandatoryGetMultiple]
        public UInt32 task_id
        {
            get { return getProperty<UInt32>("task_id"); }
            set { setProperty("task_id", value); }
        }

        public BounceRequest(PMAPIClient c)
            : base("bounce", c)            
        {
            setSortFields("id", "subscriber_id", "task_id");
        }
    }
}
