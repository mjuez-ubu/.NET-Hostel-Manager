﻿using Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Service
{
    public interface ICheckInService
    {
        bool Create(CheckIn checkIn);

        bool DoCheckOut(CheckIn checkIn);
    }

    public class CheckInService : ICheckInService
    {


        public bool Create(CheckIn checkIn)
        {
            throw new NotImplementedException();
        }

        public bool DoCheckOut(CheckIn checkIn)
        {
            throw new NotImplementedException();
        }
    }
}
