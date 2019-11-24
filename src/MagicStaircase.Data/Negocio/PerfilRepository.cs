using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using MagicStaircase.Core;

namespace MagicStaircase.Data.Negocio
{
    public static class PerfilRepository
    {
        public static Player GetPerfilActual()
        {
            using (GameDBEntities db = new GameDBEntities())
            {
                var p = db.Perfiles.FirstOrDefault(x=> x.Id == Properties.Settings.Default.IdPerfil);
                return new Player(p.Id, p.Nombre);
            }
        }


        public static void SetPerfil(int id)
        {
            using (GameDBEntities db = new GameDBEntities())
            {
                var perfil = db.Perfiles.FirstOrDefault(x => x.Id == id);
                if (perfil != null)
                {
                    Properties.Settings.Default.IdPerfil = id;
                }
            }
        }

        public static IEnumerable<Player> GetPerfiles()
        {
            using (GameDBEntities db = new GameDBEntities())
            {
                return db.Perfiles.AsEnumerable().Select(x=> new Player(x.Id, x.Nombre)).ToList();
            }
        }

        public static void AddNuevoPerfil(string nombre)
        {
            using (GameDBEntities db = new GameDBEntities())
            {
                db.Perfiles.Add(new Perfiles() { Nombre = nombre });
                db.SaveChanges();
                int? id = db.Perfiles.FirstOrDefault(x => x.Id == db.Perfiles.Max(p => p.Id))?.Id;
                if (id.HasValue)
                    Properties.Settings.Default.IdPerfil = id.Value;
            }
        }

        public static void ModificarPerfil(int id, string nombre)
        {
            using (GameDBEntities db = new GameDBEntities())
            {
                var perfil = db.Perfiles.FirstOrDefault(x => x.Id == id);
                if (perfil != null)
                {
                    perfil.Nombre = nombre;
                    db.Entry(perfil).State = EntityState.Modified;
                    db.SaveChanges();
                }
            }
        }

        public static void EliminarPerfil(int id)
        {
            using (GameDBEntities db = new GameDBEntities())
            {
                var perfil = db.Perfiles.FirstOrDefault(x => x.Id == id);
                if (perfil != null)
                {
                    db.Entry(perfil).State = EntityState.Deleted;
                    db.SaveChanges();
                }
            }
        }

    }
}
