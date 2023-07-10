using Microsoft.AspNetCore.Mvc;
using Models;
using WebDbApp2.Miscellaneous;

namespace WebDbApp2.Controllers;

[ApiController]
[Route("api/[controller]/[action]")]
[Produces("application/json")]
public class EscuelaController : Controller
{
    private readonly DataAccess _dataaccess;


    public EscuelaController(DataAccess dataaccess)
    {
        _dataaccess = dataaccess;
    }




    [HttpPost]
    public IActionResult CrearMat(Materia model)
    {
        // save materia
        _dataaccess.Materia.Add(model);
        _dataaccess.SaveChanges();

        return Ok(new { message = "Materia Creada.", model });
    }


    [HttpDelete]
    public IActionResult DeleteMat(int id)
    {
        // delete materia
        var materia = GetMateria(id);
        if ( String.IsNullOrEmpty(materia.Descripcion))
        {
            _dataaccess.Materia.Remove(materia);
            _dataaccess.SaveChanges();
        }
        else
        {
            ViewBag.MateriaNoExiste = "Materia no encontrada, id = " + id.ToString();
            return RedirectToAction("");
        }

        return Ok(new { message = "Materia Eliminada." });
    }


    [HttpGet]
    private Materia GetMateria(int id)
    {
        var materia = _dataaccess.Materia.Find(id);
        if (materia == null) //throw new KeyNotFoundException("Materia no encontrada");
        {
            return new Materia();
        }

        return materia;
    }


    [HttpGet]
    public Materia GetConsMateria(int id)
    {
        var materia = _dataaccess.Materia.Find(id);
        if (materia == null) //throw new KeyNotFoundException("Materia no encontrada");
        {
            return new Materia();
        }

        return (materia);
    }

    [HttpPost]
    public IActionResult ConsultarMateriaGrid(int id)
    {
        var mat = GetConsMateria(id);
        return View("ConsultaMateria", mat);
    }
}