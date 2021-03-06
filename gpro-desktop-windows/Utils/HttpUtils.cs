﻿using gpro_desktop_windows.Models;
using gpro_desktop_windows.Properties;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace gpro_desktop_windows.Utils
{
  class HttpUtils
  {
    /* Clientes */

    public static HttpResponseMessage getCliente(HttpClient client, string path, string payload)
    {
      HttpResponseMessage response = client.GetAsync(path + payload).Result;
      return response;
    }

    public static HttpResponseMessage getClientes(HttpClient client, string path)
    {
      HttpResponseMessage response = client.GetAsync(path).Result;
      return response;
    }

    public static HttpResponseMessage postCliente(HttpClient client, Cliente payload)
    {
      string stringData = JsonConvert.SerializeObject(payload);
      var contentData = new StringContent(stringData, Encoding.UTF8, "application/json");

      HttpResponseMessage response = client.PostAsync("/cliente/new/", contentData).Result;

      return response;
    }

    public static HttpResponseMessage putCliente(HttpClient client, Cliente payload)
    {
      string stringData = JsonConvert.SerializeObject(payload);
      var contentData = new StringContent(stringData, Encoding.UTF8, "application/json");

      HttpResponseMessage response = client.PutAsync("/cliente/update/", contentData).Result;

      return response;
    }


    /* Empleados */

    public static HttpResponseMessage getEmpleado(HttpClient client, string path, string payload)
    {
      HttpResponseMessage response = client.GetAsync(path + payload).Result;
      return response;
    }

    public static HttpResponseMessage getEmpleados(HttpClient client, string path)
    {
      HttpResponseMessage response = client.GetAsync(path).Result;
      return response;
    }

    public static HttpResponseMessage postEmpleado(HttpClient client, Empleado payload)
    {
      string stringData = JsonConvert.SerializeObject(payload);
      var contentData = new StringContent(stringData, Encoding.UTF8, "application/json");

      HttpResponseMessage response = client.PostAsync("/empleado/new/", contentData).Result;

      return response;
    }

    public static HttpResponseMessage putEmpleado(HttpClient client, Empleado payload)
    {
      string stringData = JsonConvert.SerializeObject(payload);
      var contentData = new StringContent(stringData, Encoding.UTF8, "application/json");

      HttpResponseMessage response = client.PutAsync("/empleado/update/", contentData).Result;

      return response;
    }


    /* Usuarios */

    public static HttpResponseMessage getUsuario(HttpClient client, string path, string payload)
    {
      HttpResponseMessage response = client.GetAsync(path + payload).Result;
      return response;
    }

    public static HttpResponseMessage postUsuario(HttpClient client, UsuarioRequest payload)
    {
      string stringData = JsonConvert.SerializeObject(payload);
      var contentData = new StringContent(stringData, Encoding.UTF8, "application/json");

      HttpResponseMessage response = client.PostAsync("/usuarios/register/", contentData).Result;

      return response;
    }

    public static HttpResponseMessage deleteUsuario(HttpClient client, string path, int payload)
    {
      HttpResponseMessage response = client.DeleteAsync(path + payload).Result;
      return response;
    }

    public static HttpResponseMessage putUsuario(HttpClient client, int id, UsuarioRequest payload)
    {
      string stringData = JsonConvert.SerializeObject(payload);
      var contentData = new StringContent(stringData, Encoding.UTF8, "application/json");

      HttpResponseMessage response = client.PutAsync("/usuarios/" + id, contentData).Result;

      return response;
    }

    public static HttpResponseMessage getUsuarios(HttpClient client, string path)
    {
      HttpResponseMessage response = client.GetAsync(path).Result;
      return response;
    }


    /* Roles */

    public static HttpResponseMessage getRoles(HttpClient client, string path)
    {
      HttpResponseMessage response = client.GetAsync(path).Result;
      return response;
    }


    /* Proyectos */

    public static HttpResponseMessage getProyectos(HttpClient client, string path)
    {
      HttpResponseMessage response = client.GetAsync(path).Result;
      return response;
    }

    public static HttpResponseMessage getProyecto(HttpClient client, string path, string payload)
    {
      HttpResponseMessage response = client.GetAsync(path + payload).Result;
      return response;
    }

    public static HttpResponseMessage postProyecto(HttpClient client, ProyectoRequest payload)
    {
      string stringData = JsonConvert.SerializeObject(payload);
      var contentData = new StringContent(stringData, Encoding.UTF8, "application/json");

      HttpResponseMessage response = client.PostAsync("/proyectos/", contentData).Result;

      return response;
    }

    public static HttpResponseMessage putProyecto(HttpClient client, int id, ProyectoRequest payload)
    {
      string stringData = JsonConvert.SerializeObject(payload);
      var contentData = new StringContent(stringData, Encoding.UTF8, "application/json");

      HttpResponseMessage response = client.PutAsync("/proyectos/" + id, contentData).Result;

      return response;
    }


    /* Perfiles */

    public static HttpResponseMessage getPerfiles(HttpClient client, string path)
    {
      HttpResponseMessage response = client.GetAsync(path).Result;
      return response;
    }


    /* Tareas */

    public static HttpResponseMessage getTareas(HttpClient client, string path)
    {
      HttpResponseMessage response = client.GetAsync(path).Result;
      return response;
    }

    public static HttpResponseMessage putTarea(HttpClient client, Tarea payload)
    {
      string stringData = JsonConvert.SerializeObject(payload);
      var contentData = new StringContent(stringData, Encoding.UTF8, "application/json");

      HttpResponseMessage response = client.PutAsync("/tarea/", contentData).Result;

      return response;
    }

    public static HttpResponseMessage getTarea(HttpClient client, string path, string payload)
    {
      HttpResponseMessage response = client.GetAsync(path + payload).Result;
      return response;
    }

    public static HttpResponseMessage postTarea(HttpClient client, Tarea payload)
    {
      string stringData = JsonConvert.SerializeObject(payload);
      var contentData = new StringContent(stringData, Encoding.UTF8, "application/json");

      HttpResponseMessage response = client.PostAsync("/tarea/", contentData).Result;

      return response;
    }


    /* Horas Trabajadas */

    public static HttpResponseMessage getHorasTrabajadas(HttpClient client, string path, string payload)
    {
      HttpResponseMessage response = client.GetAsync(path + payload).Result;
      return response;
    }

    public static HttpResponseMessage getHorasTrabajadasFecha(HttpClient client, string path, string payload_id, string payload_finicio, string payload_ffin)
    {
      HttpResponseMessage response = client.GetAsync(path + payload_id + "/" + payload_finicio + "/" + payload_ffin).Result;
      return response;
    }

    public static HttpResponseMessage postHorasTrabajadas(HttpClient client, HoraTrab payload)
    {
      string stringData = JsonConvert.SerializeObject(payload);
      var contentData = new StringContent(stringData, Encoding.UTF8, "application/json");

      HttpResponseMessage response = client.PostAsync("/horatrabajadas/", contentData).Result;

      return response;
    }


    /* Liquidaciones */

    public static HttpResponseMessage getLiquidaciones(HttpClient client, string path)
    {
      HttpResponseMessage response = client.GetAsync(path).Result;
      return response;
    }

    public static HttpResponseMessage postLiquidacion(HttpClient client, Liquidacion payload)
    {
      string stringData = JsonConvert.SerializeObject(payload);
      var contentData = new StringContent(stringData, Encoding.UTF8, "application/json");

      HttpResponseMessage response = client.PostAsync("/liquidacion/", contentData).Result;

      return response;
    }
  }
}
