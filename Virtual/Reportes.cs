using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Modelo.Escuela;

namespace Virtual
{
    public class Reportes
    {

        //materias -mall - lista de prerequisitos
        //public static Materia RepMateriaPreReg(string MateriaNombre)
        //{

        //   Materia materia = new Materia();
        //    using (var db=new SchoolContext())
        //    {
        //        materia = db.materias
        //            .Include(mat => mat.Malla)
        //                .ThenInclude(malla => malla.PreRequisitos)
        //            .ThenInclude(pre => pre.Materia)
        //            .Where(mat => mat.Nombre == MateriaNombre)
        //            .Single();
        //    }
        //    return materia;

        //}

    }
}
