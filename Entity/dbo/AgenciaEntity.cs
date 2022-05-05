﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class AgenciaEntity: EN
    {
        public AgenciaEntity()
        {
            Provincia = Provincia ?? new CatalogoProvinciaEntity();
            Canton = Canton ?? new CatalogoCantonEntity();
            Distrito = Distrito ?? new CatalogoDistritoEntity();
        }
        public int? AgenciaId { get; set; }
        public string Nombre { get; set; }

        public int? IdCatalogoProvincia { get; set; }
        public virtual CatalogoProvinciaEntity Provincia { get; set; }

        public int? IdCatalogoCanton { get; set; }
        public virtual CatalogoCantonEntity Canton { get; set; }

        public int? IdCatalogoDistrito { get; set; }
        public virtual CatalogoDistritoEntity Distrito { get; set; }
    }
}
