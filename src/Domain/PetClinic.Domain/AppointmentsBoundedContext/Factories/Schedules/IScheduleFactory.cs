using PetClinic.Domain.Common;
using PetClinic.Domain.AppointmentsBoundedContext.Models.Shedules;
using System;
using PetClinic.Domain.AppointmentsBoundedContext.Models.Shedules.Enumerations;
using PetClinic.Domain.SharedKernel;

namespace PetClinic.Domain.AppointmentsBoundedContext.Factories.Schedules
{
    public interface IScheduleFactory
        : IFactory<Schedule>
    {
        IScheduleFactory WithDoctor(string name);

        IScheduleFactory WithDoctor(Doctor doctor);

        IScheduleFactory WithClient(string name, string phoneNumber);

        IScheduleFactory WithClient(Client client);

        IScheduleFactory WithPatient(PetType petType, Age age, Client client);

        IScheduleFactory WithPatient(Patient patient);

        IScheduleFactory WithOfficeVisit(
            DateTime startDate,
            DateTime endDate,
            Doctor doctor,
            Patient patient,
            ExamRoom examRoom);

        IScheduleFactory WithOfficeVisit(OfficeVisit officeVisit);
          
        IScheduleFactory WithSurgery(
            DateTime startDate,
            DateTime endDate,
            Doctor doctor,
            Patient patient,
            OperationRoom operationRoom,
            RecoveryRoom recoveryRoom);

        IScheduleFactory WithSurgery(Surgery surgery);
      
        IScheduleFactory WithExamRoom(int examRoomNumber);

        IScheduleFactory WithExamRoom(ExamRoom examRoom);

        IScheduleFactory WithOperationRoom(int operationRoomNumber);

        IScheduleFactory WithOperationRoom(OperationRoom operationRoom);

        IScheduleFactory WithRecoveryRoom(int recoveryRoomNumber);

        IScheduleFactory WithRecoveryRoom(RecoveryRoom recoveryRoom);

        IScheduleFactory WithAge(int years, int months);

        IScheduleFactory WithAge(Age age);
    }
}
