using DecoracionesEvento.Bases;
using DecoracionesEvento.Entidades;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoracionesEvento.Negocio
{
    public class GestionCarga
    {
        public List<ReporteBase> LeerReservasDesdeExcel()
        {
            var productos = new List<ReporteBase>();
            using (var stream = new MemoryStream(Properties.Resources.Plantilla))
            {
                using (var workbook = new XLWorkbook(stream))
                {
                    var worksheet = workbook.Worksheet(1);
                    var rows = worksheet.RowsUsed().Skip(1);
                    foreach (var row in rows)
                    {
                        var producto = new Producto
                        {
                            Id = int.Parse(row.Cell(1).Value.ToString()),
                            Eventos = row.Cell(2).Value.ToString(),
                            Servicios = row.Cell(3).Value.ToString(),
                            Eventos = row.Cell(4).Value.ToString(),

                        };
                        productos.Add(producto);
                    }
                }
            }
            return productos;
        }
    }
}
