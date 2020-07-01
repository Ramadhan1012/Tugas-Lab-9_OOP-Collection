using System;

namespace TugasLab9_OOP_Collection
{
    public abstract class Karyawan
    {
        public string name { get; set; }
        public string NIK { get; set; }
        public string JK { get; set; }
        public abstract double Gaji();
    }
}