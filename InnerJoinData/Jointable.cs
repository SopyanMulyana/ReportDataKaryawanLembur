using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InnerJoinData
{
    class Jointable
    {
        public string NOPEGAWAI { get; set; }
        public string NAMA { get; set; }
        public string MULAI { get; set; }
        public string SELESAI { get; set; }
        public string DIVISI { get; set; }
        public string DEPARTMENT { get; set; }
        public string JABATAN { get; set; }
        public string KELAS { get; set; }
        public string SECTION { get; set; }
        public string SUBSECTION { get; set; }
        public string GROUP { get; set; }
        public string SUBGROUP { get; set; }
        public string BAGIAN { get; set; }

        public Jointable() { }

        public Jointable(string noPegawai, string nama, string mulai, string selesai, string divisi, string departement, string jabatan, string kelas, string section, string subsection, string groups, string bagian)
        {
            this.NOPEGAWAI = noPegawai;
            this.NAMA = nama;
            this.MULAI = mulai;
            this.SELESAI = selesai;
            this.DIVISI = divisi;
            this.DEPARTMENT = departement;
            this.JABATAN = jabatan;
            this.KELAS = kelas;
            this.SECTION = section;
            this.SUBSECTION = subsection;
            this.GROUP = groups;
            this.BAGIAN = bagian;
        }

    }
}
