using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

//referencias
using LineaCrud.Server.Models;
using LineaCrud.Shared;
using Microsoft.EntityFrameworkCore;

namespace LineaCrud.Server.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class CursoController : ControllerBase
  {
    private readonly DbpruebaContext _dbContext;

    public CursoController(DbpruebaContext dbContext)
    {
      _dbContext = dbContext;
    }

    [HttpGet]
    [Route("Lista")]
    public async Task<IActionResult> Lista()
    {
      var responseApi = new ResponseAPI<List<AlumnoDTO>>();
      var listaAlumnosDTO = new List<AlumnoDTO>();

      try
      {
        foreach (var item in await _dbContext.Alumnos.ToListAsync())
        {
          listaAlumnosDTO.Add(new AlumnoDTO
          {
            IdAlumno = item.IdAlumno,
            Nombre = item.Nombre,
            Papellido = item.Papellido,
            Sapelldo = item.Sapelldo,
            IdUsuario = item.IdUsuario
          });
        }
        responseApi.EsCorrecto = true;
        responseApi.Valor = listaAlumnosDTO;
      }
      catch (Exception ex)
      {
        responseApi.EsCorrecto = false;
        responseApi.Msg = ex.Message;
      }
      return Ok(responseApi);
    }
  }
}
