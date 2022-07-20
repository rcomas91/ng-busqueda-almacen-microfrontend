using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using winatm.Models;

namespace Sistia.Models
{
    [Route("api/winatm")]
    [ApiController]
    public class RecursosWATMController : ControllerBase
    {
        private readonly WinatmDB _context;

        public RecursosWATMController(WinatmDB context)
        {
            _context = context;
        }

        // GET: api/Recursos
        [HttpGet]
        public IEnumerable<SomeModel> GetRecursos()
        {

            var query = _context.SomeModels.FromSql("SELECT dbo.GenericoProductos.Generico_Descrip,dbo.GenericoProductos.Generico_Id + " +
                "dbo.SubGenericosProductos.SubGProd_Codigo + dbo.EspecificoProductos.Especifico_Codigo + dbo.Mundo_Productos.mProducto_Surtido " +
                "AS codigo,dbo.Mundo_Productos.mProducto_Descrip,dbo.Productos_Almacen.ProdAlm_Um,dbo.Productos_Almacen.ProdAlm_Control," +
                "dbo.Productos_Almacen.ProdAlm_Existencia,dbo.Productos_Almacen.ProdAlm_seccion,dbo.Productos_Almacen.ProdAlm_estante," +
                "dbo.Productos_Almacen.ProdAlm_casilla,dbo.almacenes.Almacen_descrip,dbo.Mundo_Productos.mProducto_Precio," +
                "Almacenes.dbo.Mundo_Productos.mProducto_PrecioMN,Almacenes.dbo.Mundo_Productos.mProducto_PrecioMD,UltmMov = dbo.Productos_Almacen.ProdAlm_FechaAct " +
                "FROM   dbo.GenericoProductos " +
                "INNER JOIN dbo.SubGenericosProductos ON dbo.GenericoProductos.Generico_Id = dbo.SubGenericosProductos.Generico_Id INNER JOIN dbo.EspecificoProductos " +
                "ON dbo.SubGenericosProductos.SubGProd_Id = " +
                "dbo.EspecificoProductos.SubGProd_Id INNER JOIN dbo.Mundo_Productos ON dbo.EspecificoProductos.Especifico_Id = dbo.Mundo_Productos.Especifico_Id INNER " +
                "JOIN dbo.Productos_Almacen ON dbo.Mundo_Productos" +
                ".mProducto_Id = dbo.Productos_Almacen.mProducto_Id INNER JOIN dbo.almacenes ON  dbo.Productos_Almacen.almacen_Id = dbo.Almacenes.Almacen_Id WHERE  " +

                ".Productos_Almacen.Almacen_Id = '52' AND dbo.GenericoProductos.Generico_Id = '727'  OR  dbo.GenericoProductos.Generico_Id = '726' ORDER BY  dbo.GenericoProductos.Generico_Id + " +
                "dbo.SubGenericosProductos.SubGProd_Codigo + dbo.EspecificoProductos." +
                "Especifico_Codigo + dbo.Mundo_Productos.mProducto_Surtido").ToList();

            return query;
        }

        // GET: api/Recursos
        [Route("recursoFiltrado/{term}")]
        public IEnumerable<SomeModel> GetRecursosFiltro(string term)
    {
      

        var query = _context.SomeModels.FromSql("SELECT dbo.GenericoProductos.Generico_Descrip,dbo.GenericoProductos.Generico_Id + " +
            "dbo.SubGenericosProductos.SubGProd_Codigo + dbo.EspecificoProductos.Especifico_Codigo + dbo.Mundo_Productos.mProducto_Surtido " +
            "AS codigo,dbo.Mundo_Productos.mProducto_Descrip,dbo.Productos_Almacen.ProdAlm_Um,dbo.Productos_Almacen.ProdAlm_Control," +
            "dbo.Productos_Almacen.ProdAlm_Existencia,dbo.Productos_Almacen.ProdAlm_seccion,dbo.Productos_Almacen.ProdAlm_estante," +
            "dbo.Productos_Almacen.ProdAlm_casilla,dbo.almacenes.Almacen_descrip,dbo.Mundo_Productos.mProducto_Precio," +
            "Almacenes.dbo.Mundo_Productos.mProducto_PrecioMN,Almacenes.dbo.Mundo_Productos.mProducto_PrecioMD,UltmMov = dbo.Productos_Almacen.ProdAlm_FechaAct " +
            "FROM   dbo.GenericoProductos " +
            "INNER JOIN dbo.SubGenericosProductos ON dbo.GenericoProductos.Generico_Id = dbo.SubGenericosProductos.Generico_Id INNER JOIN dbo.EspecificoProductos " +
            "ON dbo.SubGenericosProductos.SubGProd_Id = " +
            "dbo.EspecificoProductos.SubGProd_Id INNER JOIN dbo.Mundo_Productos ON dbo.EspecificoProductos.Especifico_Id = dbo.Mundo_Productos.Especifico_Id INNER " +
            "JOIN dbo.Productos_Almacen ON dbo.Mundo_Productos" +
            ".mProducto_Id = dbo.Productos_Almacen.mProducto_Id INNER JOIN dbo.almacenes ON  dbo.Productos_Almacen.almacen_Id = dbo.Almacenes.Almacen_Id WHERE  " +
            "dbo.Productos_Almacen.ProdAlm_Existencia > 0 AND dbo" +
            ".Productos_Almacen.Almacen_Id = '52' AND dbo.GenericoProductos.Generico_Id = '727' OR  dbo.GenericoProductos.Generico_Id = '726' AND dbo.Mundo_Productos.mProducto_Descrip LIKE '"+term+"%'  ORDER BY  dbo.GenericoProductos.Generico_Id + " +
            "dbo.SubGenericosProductos.SubGProd_Codigo + dbo.EspecificoProductos." +
            "Especifico_Codigo + dbo.Mundo_Productos.mProducto_Surtido").ToList();

        return query;
    }
}
    }

    