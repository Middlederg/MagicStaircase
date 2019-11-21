using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MagicStaircase.Core.Model;
using System.Diagnostics;
using System.Reflection;
using System.Net.Http;

namespace MagicStaircase.Forms
{
    public partial class FrmMenuPrincipal : Form
    {
        public FrmMenuPrincipal()
        {
            InitializeComponent();
            //Icon = System.Drawing.Icon.FromHandle(IconChar.Magic.ToBitmap(98, Color.Black).GetHicon());
            Assembly assembly = Assembly.GetExecutingAssembly();
            Version.Text = $"Versíon: {assembly.GetName().Version.ToString()}";

          

            CargarPerfiles();
        }

        private void CargarPerfiles()
        {
            Lbx.BeginUpdate();
            Lbx.Items.Clear();
            foreach (var perfil in Data.Negocio.PerfilRepository.GetPerfiles())
            {
                Lbx.Items.Add(perfil);
            }
            Lbx.EndUpdate();
            renombrarToolStripMenuItem.Enabled = eliminarPerfilToolStripMenuItem.Enabled = Lbx.SelectedIndex != -1;
        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
            using (FrmPrincipal f = new FrmPrincipal())
            {
                Visible = false;
                f.ShowDialog();
                Visible = true;
            }
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            using (FrmMejoresPuntuaciones f = new FrmMejoresPuntuaciones())
            {
                Visible = false;
                f.ShowDialog();
                Visible = true;
            }
        }

        private void BtnExit_Click(object sender, EventArgs e) => Application.Exit();

        private void Lbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Lbx.SelectedIndex == -1)
            {
                Lbx.SelectedItem = Data.Negocio.PerfilRepository.GetPerfilActual();

            }
            else
            {
                var perfil = Lbx.SelectedItem as Perfil;
                Data.Negocio.PerfilRepository.SetPerfil(perfil.Id);
            }
            renombrarToolStripMenuItem.Enabled = eliminarPerfilToolStripMenuItem.Enabled = Lbx.SelectedIndex != -1;
        }

        private void NuevoPerfilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                using (FrmPerfil f = new FrmPerfil())
                {
                    f.Text = "Add new profile";
                    if (f.ShowDialog().Equals(DialogResult.OK))
                    {
                        Data.Negocio.PerfilRepository.AddNuevoPerfil(f.Contenido);
                        CargarPerfiles();
                    }              
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void RenombrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                var perfil = Data.Negocio.PerfilRepository.GetPerfilActual();
                using (FrmPerfil f = new FrmPerfil())
                {
                    f.Text = "Rename profile";
                    f.Contenido = perfil.Nombre;
                    if (f.ShowDialog().Equals(DialogResult.OK))
                    {
                        Data.Negocio.PerfilRepository.ModificarPerfil(perfil.Id, f.Contenido);
                        CargarPerfiles();
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void EliminarPerfilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var perfil = Data.Negocio.PerfilRepository.GetPerfilActual();
            if (DialogResult.Yes.Equals(MessageBox.Show(this, $"Are you sure you want to delete this profile:\n '{perfil.ToString()}'", "Eliminar perfil", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2)))
            {
                Data.Negocio.PerfilRepository.EliminarPerfil(perfil.Id);
                CargarPerfiles();
            }
        }

        private void Repo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/Middlederg/MagicStaircase");
        }

        private async void OnLoad(object sender, EventArgs e)
        {
            using (var client = new HttpClient())
            {
                //GET /repos/:owner/:repo/releases/latest
                HttpResponseMessage response = await client.GetAsync($"https://api.github.com/repos/Middlederg/MagicStaircase/releases/latest");
                if (response.IsSuccessStatusCode)
                {
                    string json = await response.Content.ReadAsStringAsync();
                   
                }
            }
            //Program.UpdatePath
        }
    }
}
