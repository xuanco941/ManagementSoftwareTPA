﻿using ManagementSoftware.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementSoftware.DAL
{
    public class DALMachine
    {
        public void Add(Machine machine)
        {
            using (var context = new DataBaseContext())
            {
                context.Machines.Add(machine);
                context.SaveChanges();
            }
        }
        public void Update(Machine machine)
        {
            using (var context = new DataBaseContext())
            {
                var machineToUpdate = context.Machines.FirstOrDefault(m => m.MachineID == machine.MachineID);
                if (machineToUpdate != null)
                {
                    machineToUpdate.ApSuat = machine.ApSuat;
                    machineToUpdate.TheTich = machine.TheTich;
                    machineToUpdate.NameMachine = machine.NameMachine;
                    machineToUpdate.ResultID = machine.ResultID;
                    context.SaveChanges();
                }
            }
        }
        public void Delete(int machineID)
        {
            using (var context = new DataBaseContext())
            {
                var machineToDelete = context.Machines.FirstOrDefault(m => m.MachineID == machineID);
                if (machineToDelete != null)
                {
                    context.Machines.Remove(machineToDelete);
                    context.SaveChanges();
                }
            }
        }


    }
}
