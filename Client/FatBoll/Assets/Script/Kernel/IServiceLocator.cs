using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Fat.Kernel
{
    public interface IServiceLocator
    {
        void Register<InterType, ImpleType>() where ImpleType : InterType;



    }
}

