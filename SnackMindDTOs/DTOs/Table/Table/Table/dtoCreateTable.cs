﻿using System;

namespace SnackMindDTOs.DTOs.Table.Table.Table
{
    public class dtoCreateTable
    {
        public string Name { get; set; }
        public string Code { get; set; }
        public int Capacity { get; set; }
        public bool IsCanReserved { get; set; }

        public Guid ZoneRef { get; set; }
        public Guid TableStateRef { get; set; }

        public string Description { get; set; }
    }
}