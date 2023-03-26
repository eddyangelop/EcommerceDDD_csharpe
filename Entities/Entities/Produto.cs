﻿using Entities.Notifications;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Entities
{
    [Table("Product")]
    public class Produto : Notifies
    {
        [Column("PROD_ID")]
        [Display(Name = "Código")]
        public int Id { get; set; }

        [Column("PROD_NOME")]
        [Display(Name = "Nome")]
        public string Nome { get; set; }

        [Column("PROD_VALO")]
        [Display(Name = "Valor")]
        public decimal Valor { get; set; }


        [Column("PROD_ESTADO")]
        [Display(Name = "Estado")]
        public bool Estado { get; set; }

    }
}
