﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
namespace sigel.Module.BusinessObjects.ORMDataModel1
{

    public partial class Usuario : XPObject
    {
        Persona fPersona;
        public Persona Persona
        {
            get { return fPersona; }
            set { SetPropertyValue<Persona>(nameof(Persona), ref fPersona, value); }
        }
    }

}
