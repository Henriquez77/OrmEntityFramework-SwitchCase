﻿using System;
using System.Collections.Generic;

#nullable disable

namespace OrmEntityFramework.Models
{
    public partial class Usuario
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int? Edad { get; set; }
    }
}
