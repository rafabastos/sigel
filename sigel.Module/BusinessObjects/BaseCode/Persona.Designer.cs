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

    public partial class Persona : XPObject
    {
        string fNombre;
        public string Nombre
        {
            get { return fNombre; }
            set { SetPropertyValue<string>(nameof(Nombre), ref fNombre, value); }
        }
        string fApelido;
        public string Apelido
        {
            get { return fApelido; }
            set { SetPropertyValue<string>(nameof(Apelido), ref fApelido, value); }
        }
        [PersistentAlias("[Nombre] + ' ' + [Apellido]")]
        public string NombreCompleto
        {
            get { return (string)(EvaluateAlias(nameof(NombreCompleto))); }
        }
        string fTipoDocumento;
        public string TipoDocumento
        {
            get { return fTipoDocumento; }
            set { SetPropertyValue<string>(nameof(TipoDocumento), ref fTipoDocumento, value); }
        }
        string fNumeroDeDocumento;
        public string NumeroDeDocumento
        {
            get { return fNumeroDeDocumento; }
            set { SetPropertyValue<string>(nameof(NumeroDeDocumento), ref fNumeroDeDocumento, value); }
        }
        string fTipoPersona;
        public string TipoPersona
        {
            get { return fTipoPersona; }
            set { SetPropertyValue<string>(nameof(TipoPersona), ref fTipoPersona, value); }
        }
        string fNumeroTelefono;
        public string NumeroTelefono
        {
            get { return fNumeroTelefono; }
            set { SetPropertyValue<string>(nameof(NumeroTelefono), ref fNumeroTelefono, value); }
        }
        string fNumeroCelular;
        public string NumeroCelular
        {
            get { return fNumeroCelular; }
            set { SetPropertyValue<string>(nameof(NumeroCelular), ref fNumeroCelular, value); }
        }
        string fEmail;
        public string Email
        {
            get { return fEmail; }
            set { SetPropertyValue<string>(nameof(Email), ref fEmail, value); }
        }
        string fNombreDelEstablecimiento;
        public string NombreDelEstablecimiento
        {
            get { return fNombreDelEstablecimiento; }
            set { SetPropertyValue<string>(nameof(NombreDelEstablecimiento), ref fNombreDelEstablecimiento, value); }
        }
        string fLocalidad;
        public string Localidad
        {
            get { return fLocalidad; }
            set { SetPropertyValue<string>(nameof(Localidad), ref fLocalidad, value); }
        }
        string fDepartamiento;
        public string Departamiento
        {
            get { return fDepartamiento; }
            set { SetPropertyValue<string>(nameof(Departamiento), ref fDepartamiento, value); }
        }
        [Association(@"RelacionReferencesPersona")]
        public XPCollection<Relacion> Relacions { get { return GetCollection<Relacion>(nameof(Relacions)); } }
    }

}
