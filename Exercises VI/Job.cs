using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises_VI
{
    internal class Job
    {
        private string jobType;
        private double workTime;
        private double chargeForHour;
        private double totalFee;
        public Job(string jobType, double workTime, double chargeForHour)
        {
            this.jobType = jobType;
            this.workTime = workTime;
            this.chargeForHour = chargeForHour;
            Fee();
        }


        public string JobType
        { get
            {
                return jobType;
            }
            set
            {
                jobType = value;
            }
        }
        public double WorkTime
        {
            get
            {
                return workTime;
            }
            set
            {
                workTime = value;
                Fee();
            }
        }
        public double ChargeForHour
        {
            get
            {
                return chargeForHour;
            }
            set
            {
                chargeForHour = value;
                Fee();
            }
        }
        public double TotalFee
        {
            get
            {
                return totalFee;
            }
        }

        public void Fee()
        {
            totalFee = workTime * chargeForHour;
        }


        public static Job operator +(Job j1, Job j2)
        {
            Job newJob = new Job(j1.JobType + " and " + j2.JobType, j1.WorkTime + j2.WorkTime, (j1.ChargeForHour + j2.ChargeForHour) / 2);
            return newJob;
        }


        }
}
