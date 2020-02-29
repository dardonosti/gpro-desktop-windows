﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using gpro_desktop_windows.Models;
using System.Net.Http;
using gpro_desktop_windows.Utils;
using Newtonsoft.Json;
using MetroFramework;
using gpro_desktop_windows.Forms;


namespace gpro_desktop_windows.UsersControls
{
  public partial class ucProyectos : MetroFramework.Controls.MetroUserControl
  {
    public ucProyectos()
    {
      InitializeComponent();
      mgProyectos.Visible = false;      
      ///* Botón Editar en DataGrid */
      //DataGridViewButtonColumn btnEditar = new DataGridViewButtonColumn();
      //btnEditar.Name = "Editar";
      //mgProyectos.Columns.Add(btnEditar);
      //mgProyectos.Columns[8].HeaderText = "";

      ///* Botón Ver en DataGrid */
      //DataGridViewButtonColumn btnVer = new DataGridViewButtonColumn();
      //btnVer.Name = "Ver";
      //mgProyectos.Columns.Add(btnVer);
      //mgProyectos.Columns[9].HeaderText = "";

    }

    //private void mgClientes_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
    //{
    //  if (e.ColumnIndex >= 0 && this.mgProyectos.Columns[e.ColumnIndex].Name == "Editar" && e.RowIndex >= 0)
    //  {
    //    e.Paint(e.CellBounds, DataGridViewPaintParts.All);

    //    DataGridViewButtonCell cellButtonEditar = this.mgProyectos.Rows[e.RowIndex].Cells["Editar"] as DataGridViewButtonCell;
    //    Icon icoEditar = Properties.Resources.editar;
    //    e.Graphics.DrawIcon(icoEditar, e.CellBounds.Left + 3, e.CellBounds.Top + 3);

    //    this.mgProyectos.Rows[e.RowIndex].Height = icoEditar.Height + 8;
    //    this.mgProyectos.Columns[e.ColumnIndex].Width = icoEditar.Width + 8;

    //    DataGridViewCell cell = this.mgProyectos.Rows[e.RowIndex].Cells[e.ColumnIndex];
    //    cell.ToolTipText = "Editar";

    //    e.Handled = true;
    //  }

    //  if (e.ColumnIndex >= 0 && this.mgProyectos.Columns[e.ColumnIndex].Name == "Ver" && e.RowIndex >= 0)
    //  {
    //    e.Paint(e.CellBounds, DataGridViewPaintParts.All);

    //    DataGridViewButtonCell cellButtonVer = this.mgProyectos.Rows[e.RowIndex].Cells["Ver"] as DataGridViewButtonCell;
    //    Icon icoVer = Properties.Resources.ver;
    //    e.Graphics.DrawIcon(icoVer, e.CellBounds.Left + 3, e.CellBounds.Top + 3);

    //    this.mgProyectos.Rows[e.RowIndex].Height = icoVer.Height + 8;
    //    this.mgProyectos.Columns[e.ColumnIndex].Width = icoVer.Width + 8;

    //    DataGridViewCell cell = this.mgProyectos.Rows[e.RowIndex].Cells[e.ColumnIndex];
    //    cell.ToolTipText = "Ver";

    //    e.Handled = true;
    //  }
    //}

    //private void mgClientes_CellClick(object sender, DataGridViewCellEventArgs e)
    //{
    //  if (e.ColumnIndex >= 0 && this.mgProyectos.Columns[e.ColumnIndex].Name == "Editar" && e.RowIndex >= 0)
    //  {
    //    string Id = mgProyectos.Rows[e.RowIndex].Cells["Id"].Value.ToString();
    //    EditarClienteForm editarClienteForm = new EditarClienteForm(Id);
    //    DataGridViewRow editarCliente = mgProyectos.Rows[e.RowIndex];
    //    editarClienteForm.textBoxidCliente.Text = editarCliente.Cells["idCliente"].Value.ToString();
    //    editarClienteForm.textBoxRSocial.Text = editarCliente.Cells["razonSocialCliente"].Value.ToString();
    //    editarClienteForm.textBoxApellido.Text = editarCliente.Cells["apellidoCliente"].Value.ToString();
    //    editarClienteForm.textBoxNombre.Text = editarCliente.Cells["nombreCliente"].Value.ToString();
    //    editarClienteForm.textBoxDomicilio.Text = editarCliente.Cells["direccionCliente"].Value.ToString();
    //    editarClienteForm.textBoxTelefono.Text = editarCliente.Cells["telefonoCliente"].Value.ToString();
    //    editarClienteForm.textBoxEMail.Text = editarCliente.Cells["emailCliente"].Value.ToString();
    //    editarClienteForm.ShowDialog();
    //    string cuit = editarClienteForm.cuit;
    //    if (!string.IsNullOrEmpty(cuit))
    //      buscarCliente("/cliente/cuit/", cuit, true);
    //  }
    //  if (e.ColumnIndex >= 0 && this.mgProyectos.Columns[e.ColumnIndex].Name == "Ver" && e.RowIndex >= 0)
    //  {
    //    VerClienteForm verClienteForm = new VerClienteForm();
    //    DataGridViewRow verCliente = mgProyectos.Rows[e.RowIndex];
    //    verClienteForm.textBoxidCliente.Text = verCliente.Cells["idCliente"].Value.ToString();
    //    verClienteForm.textBoxRSocial.Text = verCliente.Cells["razonSocialCliente"].Value.ToString();
    //    verClienteForm.textBoxApellido.Text = verCliente.Cells["apellidoCliente"].Value.ToString();
    //    verClienteForm.textBoxNombre.Text = verCliente.Cells["nombreCliente"].Value.ToString();
    //    verClienteForm.textBoxDomicilio.Text = verCliente.Cells["direccionCliente"].Value.ToString();
    //    verClienteForm.textBoxTelefono.Text = verCliente.Cells["telefonoCliente"].Value.ToString();
    //    verClienteForm.textBoxEMail.Text = verCliente.Cells["emailCliente"].Value.ToString();
    //    verClienteForm.Show();
    //  }
    //}

    private void btnCrearProyecto_Click(object sender, EventArgs e)
    {
      //CrearClienteForm crearClienteForm = new CrearClienteForm();
      //crearClienteForm.ShowDialog();
    }

    private void btnLimpiar_Click(object sender, EventArgs e)
    {
      textBoxProyecto.Clear();
      textBoxEstado.Clear();
    }

    private void btnBuscar_Click(object sender, EventArgs e)
    {
      string path = "";
      string payload = "";
      bool getbyestado = false;

      if (string.IsNullOrEmpty(textBoxProyecto.Text) && string.IsNullOrEmpty(textBoxEstado.Text))
      {
        MessageBox.Show(this,"Complete el formulario para realizar la búsqueda.", "Oops!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        return;
      }

      if (string.IsNullOrEmpty(textBoxEstado.Text))
      {
        path = "/proyectos/porTitulo/";
        payload = textBoxProyecto.Text;
        buscarProyecto(path, payload, getbyestado);
      }
      else
      {
        path = "/proyectos/porEstado/";
        payload = textBoxEstado.Text;
        getbyestado = true;
        buscarProyecto(path, payload, getbyestado);
      }
    }

    private void buscarProyecto(string path, string payload, bool getbyestado)
    {
      List<Proyecto> proyectoResponses = null;

      HttpClient client = HttpUtils.configHttpClient();
      HttpResponseMessage response = HttpUtils.getProyecto(client, path, payload);

      string stringCR = response.Content.ReadAsStringAsync().Result;

      proyectoResponses = JsonConvert.DeserializeObject<List<Proyecto>>(stringCR);
      

      if (response.IsSuccessStatusCode)
      {
        mgProyectos.Visible = true;
        mgProyectos.DataSource = proyectoResponses;
      }
      else
      {
        MessageBox.Show("No se encontró el proyecto.", "Oops!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        textBoxProyecto.Clear(); textBoxEstado.Clear();
      }
    }

    private void getProyectos()
    {
      List<Proyecto> proyectoResponses = null;

      HttpClient client = HttpUtils.configHttpClient();
      HttpResponseMessage response = HttpUtils.getProyectos(client, "/proyectos/");

      string stringCR = response.Content.ReadAsStringAsync().Result;



      if (response.IsSuccessStatusCode)
      {
        mgProyectos.Visible = true;
        proyectoResponses = JsonConvert.DeserializeObject<List<Proyecto>>(stringCR);
        mgProyectos.DataSource = proyectoResponses;
      }
      else
      {
        MessageBox.Show("No se encontró el proyecto.", "Oops!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        textBoxProyecto.Clear(); textBoxEstado.Clear();
      }
    }

    private void btnVerTodosProyectos_Click(object sender, EventArgs e)
    {
      getProyectos();
    }
  }
}


