﻿using System;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
namespace sigel.Module.BusinessObjects.ORMDataModel1
{

    public partial class GestionDetalle
    {
        public GestionDetalle(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

}
