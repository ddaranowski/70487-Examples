﻿using System.ServiceModel;

namespace ConcurrentServices.Services
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerCall,
                     ConcurrencyMode = ConcurrencyMode.Single,
                     UseSynchronizationContext = true)]
    public class PerCall_Single_Service : BaseService
    {
    }
}
