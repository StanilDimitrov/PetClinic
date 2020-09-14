using PetClinic.Application.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace PetClinic.Application.Appointments.Features.Schedules.Commands.Common
{
    public abstract class ScheduleCommand<TCommand> : EntityCommand<int>
       where TCommand : EntityCommand<int>
    {
        public IReadOnlyCollection<int> Appointments { get; set; }
    }
}
