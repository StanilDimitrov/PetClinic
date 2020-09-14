using PetClinic.Application.Contracts;
using PetClinic.Domain.AppointmentsBoundedContext.Models.Shedules;
using PetClinic.Domain.AppointmentsBoundedContext.Models.Shedules.Abstraction;
using System.Threading;
using System.Threading.Tasks;

namespace PetClinic.Application.Appointments.Shedules
{
    public interface IScheduleRepository : IRepository<Schedule>
    {
        Task<Schedule> Find(int id, CancellationToken cancellationToken = default);

        Task<bool> Delete(int id, CancellationToken cancellationToken = default);

        Task<Appointment> GetAppointment(
           int appointmentId,
           CancellationToken cancellationToken = default);


        Task<Patient> GetPatient(
            int patientId,
            CancellationToken cancellationToken = default);

        Task<Doctor> GetDoctor(
            int doctorId,
            CancellationToken cancellationToken = default);

        Task<ExamRoom> GetExamRoom(
            int examRoomId,
            CancellationToken cancellationToken = default);

        Task<OperationRoom> GetOperationRoom(
       int operationRoomId,
       CancellationToken cancellationToken = default);

        Task<RecoveryRoom> GetRecoveryRoom(
       int recoveryRoomId,
       CancellationToken cancellationToken = default);
    }
}
