using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace БашкінВаріант17.Models
{
    public class Challenge
    {
        [Display(Name = "iD")]
        public int Id { get; set; }
        [Display(Name = "Код виклику")]
        public string Callcode { get; set; }
        [Display(Name = "Дата і час")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]

        public DateTime Date { get; set; }
        [Display(Name = "Скарга")]
        public string Complaint { get; set; }
        [Display(Name = "Адреса")]
        public string Address { get; set; }
        [Display(Name = "ПІБ")]
        public string Name { get; set; }
        [Display(Name = "Тел. Номер")]
        public string Phone { get; set; }
        [Display(Name = "Код бригади")]
        public string Brigadecode { get; set; }
        [Display(Name = "Звіт бригади")]
        public string Brigadereport { get; set; }
    }
}