﻿using System;
using System.Collections.Generic;
using System.Text;

namespace sedc.videorental.data.BaseModels
{
    public class BaseEntity
    {
        public int Id { get; set; }
        public DateTime CreatedOn { get; set; }

        public BaseEntity()
        {
            CreatedOn = DateTime.Now;

        }
    }
}
