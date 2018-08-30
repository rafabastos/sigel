using System;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
namespace sigel.Module.BusinessObjects.Gestiones
{

    public partial class GestionMonsanto
    {
        public GestionMonsanto(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

}
