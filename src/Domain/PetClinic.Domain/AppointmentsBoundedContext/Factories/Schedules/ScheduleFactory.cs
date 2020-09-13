using PetClinic.Domain.AppointmentsBoundedContext.Models.Shedules;
using PetClinic.Domain.AppointmentsBoundedContext.Models.Shedules.Enumerations;
using PetClinic.Domain.SharedKernel;
using System;

namespace PetClinic.Domain.AppointmentsBoundedContext.Factories.Schedules
{
    public class ScheduleFactory : IScheduleFactory
    {
        private Doctor scheduleDoctor = default!;
        private Patient schedulePatient = default!;
        private Client scheduleClient = default!;
        private OfficeVisit scheduleOfficeVisit = default!;
        private Surgery scheduleSurgery = default!;
        private ExamRoom scheduleExamRoom = default!;
        private OperationRoom scheduleOperationRoom = default!;
        private RecoveryRoom scheduleRecoveryRoom = default!;
        private Age scheduleAge = default!;

        private bool doctorSet = false;
        private bool patientSet = false;
        private bool clientSet = false;
        private bool officeVisitSet = false;
        private bool surgerySet = false;
        private bool examRoomSet = false;
        private bool operationRoomSet = false;
        private bool recoveryRoomSet = false;
        private bool ageSet = false;

        public Schedule Build()
        {
            throw new NotImplementedException();
        }

        public IScheduleFactory WithAge(int years, int months)
         => this.WithAge(new Age(years, months));

        public IScheduleFactory WithAge(Age age)
        {
            this.scheduleAge = age;
            this.ageSet = true;
            return this;
        }

        public IScheduleFactory WithClient(string name, string phoneNumber)
          => this.WithClient(new Client(name, phoneNumber));

        public IScheduleFactory WithClient(Client client)
        {
            this.scheduleClient = client;
            this.clientSet = true;
            return this;
        }

        public IScheduleFactory WithDoctor(string name)
       => this.WithDoctor(new Doctor(name));

        public IScheduleFactory WithDoctor(Doctor doctor)
        {
            this.scheduleDoctor = doctor;
            this.doctorSet = true;
            return this;
        }

        public IScheduleFactory WithExamRoom(int examRoomNumber)
       => this.WithExamRoom(new ExamRoom(examRoomNumber));

        public IScheduleFactory WithExamRoom(ExamRoom examRoom)
        {
            this.scheduleExamRoom = examRoom;
            this.examRoomSet = true;
            return this;
        }

        public IScheduleFactory WithOfficeVisit(DateTime startDate, DateTime endDate, Doctor doctor, Patient patient, ExamRoom examRoom)
         => this.WithOfficeVisit(new OfficeVisit(startDate, endDate, doctor, patient, examRoom));

        public IScheduleFactory WithOfficeVisit(OfficeVisit officeVisit)
        {
            this.scheduleOfficeVisit = officeVisit;
            this.officeVisitSet = true;
            return this;
        }

        public IScheduleFactory WithOperationRoom(int operationRoomNumber)
         => this.WithOperationRoom(new OperationRoom(operationRoomNumber));

        public IScheduleFactory WithOperationRoom(OperationRoom operationRoom)
        {
            this.scheduleOperationRoom = operationRoom;
            this.operationRoomSet = true;
            return this;
        }

        public IScheduleFactory WithPatient(PetType petType, Age age, Client client)
         => this.WithPatient(new Patient(petType, age, client));

        public IScheduleFactory WithPatient(Patient patient)
        {
            this.schedulePatient = patient;
            this.patientSet = true;
            return this;
        }

        public IScheduleFactory WithRecoveryRoom(int recoveryRoomNumber)
        => this.WithRecoveryRoom(new RecoveryRoom(recoveryRoomNumber));

        public IScheduleFactory WithRecoveryRoom(RecoveryRoom recoveryRoom)
        {
            this.scheduleRecoveryRoom = recoveryRoom;
            this.recoveryRoomSet = true;
            return this;
        }

        public IScheduleFactory WithSurgery(DateTime startDate, DateTime endDate, Doctor doctor, Patient patient, OperationRoom operationRoom, RecoveryRoom recoveryRoom)
         => this.WithSurgery(new Surgery(startDate, endDate, doctor, patient, operationRoom, recoveryRoom));

        public IScheduleFactory WithSurgery(Surgery surgery)
        {
            this.scheduleSurgery = surgery;
            this.surgerySet = true;
            return this;
        }
    }
}
