﻿using System;
using System.Collections.Generic;

using System.Text;
using System.Threading.Tasks;

namespace GameEngine
{
    public abstract class Component
    {
        internal GameObject GameObject;

        public Transform Transform
        {
            get
            {
                return GameObject.Transform;
            }
        }

        internal virtual void Dispose()
        {

        }
        public virtual void Start()
        {

        }
        public virtual void Update()
        {

        }
    }
}
