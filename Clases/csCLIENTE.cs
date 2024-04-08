using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace servicioProyecto.Clases
{
    public class csCLIENTE
    {
        private SPAAEntities1 DB = new SPAAEntities1();

        public CLIENTE CLIENTE {  get; set; }

        public string insertar()
        {
            try
            {
                DB.CLIENTEs.Add(CLIENTE);
                DB.SaveChanges();
                return "Se inserto el cliente:" + CLIENTE.NOMBRES;

            }catch (Exception ex)
            {
                return ex.Message;
            }
        } 



    }

}