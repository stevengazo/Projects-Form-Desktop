﻿using Modelos;

namespace Negocios
{
    public class RolUsuarioNegocio
    {
        private DBContextProyectosAsfaltos dBContext = new DBContextProyectosAsfaltos();

        public RolUsuario? ObtenerRolUsuario(int idUsuario = 0, int rol = 0)
        {
            try
            {
                using (var db = new DBContextProyectosAsfaltos())
                {
                    var query = (from i in db.RolUsuarios
                                 where i.RolId == rol && i.UsuarioId == idUsuario
                                 select i).FirstOrDefault();
                    return query;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        public bool BorrarRolUsuario(RolUsuario rol)
        {
            try
            {
                using (var db = new DBContextProyectosAsfaltos())
                {
                    db.RolUsuarios.Remove(rol);
                    db.SaveChanges();
                }
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }

        }

        public bool AgregarRolUsuario(RolUsuario item)
        {
            try
            {
                using (var db = new DBContextProyectosAsfaltos())
                {
                    db.RolUsuarios.Add(item);
                    db.SaveChanges();
                }
                return true;
            }
            catch (Exception f)
            {
                Console.WriteLine(f.Message);
                return false;
            }
        }

        public bool VerificarRol(string login, int idRol)
        {
            try
            {
                using (var db = dBContext)
                {
                    var query = (
                            from item in db.RolUsuarios
                            join usuario in db.Usuarios on item.UsuarioId equals usuario.UsuarioId
                            where usuario.Login.ToUpper().Equals(login.ToUpper()) && item.RolId == idRol
                            select item
                                 ).FirstOrDefault();
                    if (query != null)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return false;
            }
        }


        public bool VerificarRol(int idUsuario, int idRol)
        {
            try
            {
                using (var db = new DBContextProyectosAsfaltos())
                {
                    var query = (from item in db.RolUsuarios
                                 where item.RolId == (int)idRol && item.UsuarioId == (int)idUsuario
                                 select item).ToList().Count();
                    if (query > 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return false;
            }
        }
    }
}
