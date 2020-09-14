using MediatR;
using PetClinic.Application.Appointments.Features.Schedules.Commands.Common;
using PetClinic.Application.Appointments.Shedules;
using PetClinic.Application.Common;
using PetClinic.Application.Contracts;
using PetClinic.Domain.AppointmentsBoundedContext.Factories.Schedules;
using System.Threading;
using System.Threading.Tasks;

namespace PetClinic.Application.Appointments.Features.Schedules.Commands
{
    public class AddAppointmentCommand : ScheduleCommand<AddAppointmentCommand>, IRequest<Result>
    {
        public class AddAppointmentCommandHandler : IRequestHandler<AddAppointmentCommand, Result>
        {
            private readonly ICurrentUser _currentUser;
            private readonly IScheduleRepository _scheduleRepository;
            private readonly IScheduleFactory _scheduleFactory;

            public AddAppointmentCommandHandler(
                ICurrentUser currentUser,
                IScheduleRepository scheduleRepository,
                IScheduleFactory scheduleFactory)
            {
                _currentUser = currentUser;
                _scheduleRepository = scheduleRepository;
                _scheduleFactory = scheduleFactory;
            }

            public async Task<Result> Handle(
                AddAppointmentCommand request,
                CancellationToken cancellationToken)
            {

                return Result.Success;
            }
        }
    }
}
