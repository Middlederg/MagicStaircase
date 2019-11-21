using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MagicStaircase.Core.Model;

namespace MagicStaircase.Data.Negocio
{
    public static class RegistrosRepository
    {
        public static IEnumerable<Registro> GetRegistros(int num = 10)
        {
            using (GameDBEntities db = new GameDBEntities())
            {
                return db.Registros
                    .OrderBy(x=> x.Puntuacion).ThenByDescending(x=> x.Segundos).ThenBy(x=> !x.Sistema)
                    .Take(num)
                    .Select(x=> new Registro()
                    {
                        Fecha = x.Fecha,
                        Nombre = x.Nombre,
                        Puntuacion = x.Puntuacion,
                        SegundosUtilizados = x.Segundos,
                        Sistema = x.Sistema
                    }).ToList();
            }
        }

        public static IEnumerable<Registro> GetRegistrosJugador(int num = 10)
        {
            using (GameDBEntities db = new GameDBEntities())
            {
                return db.Registros
                    .Where(x=> !x.Sistema)
                    .OrderBy(x => x.Puntuacion).ThenByDescending(x => x.Segundos)
                    .Take(num)
                    .Select(x => new Registro()
                    {
                        Fecha = x.Fecha,
                        Nombre = x.Nombre,
                        Puntuacion = x.Puntuacion,
                        SegundosUtilizados = x.Segundos,
                        Sistema = x.Sistema
                    }).ToList();
            }
        }

        public static void AddNuevoRegistro(int puntuacion, int segundos)
        {
            using (GameDBEntities db = new GameDBEntities())
            {
                db.Registros.Add(new Registros()
                {
                    Nombre = PerfilRepository.GetPerfilActual().Nombre,
                    Fecha = DateTime.Now,
                    Puntuacion = puntuacion,
                    Segundos = segundos,
                    Sistema = false
                });
                db.SaveChanges();
            }
        }

        public static void ResetRegistros()
        {
            using (GameDBEntities db = new GameDBEntities())
            {
                db.Registros.RemoveRange(db.Registros.Where(x=> !x.Sistema));
                db.SaveChanges();
            }
        }

    }
}
