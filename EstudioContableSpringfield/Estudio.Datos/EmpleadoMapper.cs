﻿using Estudio.Entidades.Entidades;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudio.Datos
{
    public class EmpleadoMapper
    {
        public List<Empleado> TraerTodos()
        {
            string json = WebHelper.Get("/EstudioContable/Empleados");
            List<Empleado> resultado = MapList(json);
            return resultado;
        }

        private List<Empleado> MapList(string json)
        {
            List<Empleado> lista = JsonConvert.DeserializeObject<List<Empleado>>(json);
            return lista;
        }

        public TransactionResult Agregar(Empleado empleado)
        {
            NameValueCollection parametros = ReverseMap(empleado);
            string json = WebHelper.Post("/EstudioContable/Empleados", parametros);
            TransactionResult resultado = JsonConvert.DeserializeObject<TransactionResult>(json);
            return resultado;
        }

        private NameValueCollection ReverseMap(Empleado empleado)
        {
            
            NameValueCollection n = new NameValueCollection();
            /*
            n.Add("idCategoria", empleado.IdCategoria.ToString());
            n.Add("idEmpresa", empleado.IdEmpresa.ToString());
            n.Add("cuil", empleado.Cuil.ToString());
            n.Add("nombre", empleado.Nombre.ToString());
            n.Add("apellido", empleado.Apellido.ToString());
            n.Add("fechaNacimiento", empleado.FechaNacimiento.ToString("yyyy-MM-dd"));
            n.Add("fechaAlta", empleado.FechaAlta.ToString("yyyy-MM-dd"));
            n.Add("id", empleado.Legajo.ToString());
            */
            return n;
        }

        public TransactionResult Modificar(Empleado empleado)
        {
            NameValueCollection parametros = ReverseMap(empleado);
            string json = WebHelper.Put("/EstudioContable/Empleados", parametros);
            TransactionResult resultado = JsonConvert.DeserializeObject<TransactionResult>(json);
            return resultado;
        }

        public TransactionResult Eliminar(Empleado empleado)
        {
            NameValueCollection parametros = ReverseMap(empleado);
            string json = WebHelper.Delete("/EstudioContable/Empleados", parametros);
            TransactionResult resultado = JsonConvert.DeserializeObject<TransactionResult>(json);
            return resultado;
        }


    }
}
