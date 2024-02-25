﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Model
{
    class PatientModel
    {
        public int PatientID;
        public int PatientUUID;
        public string PatientName;
        public int PatientAge;
        public int PatientGender;
        public string PatientPhoneNumber;
        public string RegisterDate;

        public PatientModel() { }

        public PatientModel(int PatientID, int PatientUUID, string PatientName, int PatientAge,
            int PatientGender, string PatientPhoneNumber, string RegisterDate)
        {
            this.PatientID = PatientID;
            this.PatientUUID = PatientUUID;
            this.PatientName = PatientName;
            this.PatientAge = PatientAge;
            this.PatientGender = PatientGender;
            this.PatientPhoneNumber = PatientPhoneNumber;
            this.RegisterDate = RegisterDate;

        }
        public PatientModel(int PatientUUID, string PatientName, int PatientAge,
            int PatientGender, string PatientPhoneNumber, string RegisterDate)
        {
            this.PatientUUID = PatientUUID;
            this.PatientName = PatientName;
            this.PatientAge = PatientAge;
            this.PatientGender = PatientGender;
            this.PatientPhoneNumber = PatientPhoneNumber;
            this.RegisterDate = RegisterDate;

        }
    }
}
