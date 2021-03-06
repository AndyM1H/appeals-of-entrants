//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EntrantsProj
{
    using System;
    using System.Collections.Generic;
    
    public partial class Entrant
    {
        private Nullable<float> _av_ball_cert;
        private string _error;

        public int Id { get; set; }
        public string f_name { get; set; }
        public string m_name { get; set; }
        public string l_name { get; set; }
        public Nullable<System.DateTime> dob { get; set; }
        public string address { get; set; }
        public string phone { get; set; }
        public string parents_info { get; set; }
        public string edu { get; set; }
        public string treatment_method { get; set; }
        public Nullable<System.DateTime> treatment_date { get; set; }
        public Nullable<int> prospective_spec { get; set; }
        public string dis_group { get; set; }
        public string diagnosis { get; set; }
        public Nullable<float> av_ball_cert
        {
            get
            {
                return _av_ball_cert;
            }
            set
            {
                if ((value < 5) && (value > 2) || value == null)
                {
                    _av_ball_cert = value;
                    _error = null;
                }
                else
                {
                    _error = "Неверное значение";
                }
            }
        }
        public string notes { get; set; }
        public Nullable<System.DateTime> yearOfEntry { get; set; }
        public bool gender { get; set; }
        public bool poa { get; set; }
        public string Error { get { return _error; } }

        public virtual Specialty Specialty { get; set; }
    }
}
