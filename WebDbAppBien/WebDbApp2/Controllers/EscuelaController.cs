using Microsoft.AspNetCore.Mvc;
using Models;
using WebDbApp.Miscellaneous;

namespace WebDbApp.Controllers;

[ApiController]
[Route("api/[controller]/[action]")]
[Produces("application/json")]
public class EscuelaController : Controller
{
        private readonly ILogger<HomeController> _logger;
    private DataAccess _dataaccess;


    public EscuelaController(DataAccess dataaccess, ILogger<HomeController> logger)
    {
        _dataaccess = dataaccess;
        _logger = logger;
    }


    [HttpGet]
    public IActionResult Niveles()
    {
        var niveles = _dataaccess.NivelAcademico.ToList();
        return Ok(niveles);
    }

    [HttpPost]
    public IActionResult CrearMat(Materia model)
    {
        // save materia
        _dataaccess.Materia.Add(model);
        _dataaccess.SaveChanges();

        return Ok(new { message = "Materia Creada.", model});
    }


    [HttpDelete]
    public IActionResult DeleteMat(int id)
    {
        // delete materia
        var materia = getMateria(id);
        if (materia != null)
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
    private Materia getMateria(int id)
    {
        var materia = _dataaccess.Materia.Find(id);
        if (materia == null) //throw new KeyNotFoundException("Materia no encontrada");
        {
        }

        return materia;
    }


    [HttpGet]
    public Materia getConsMateria(int id)
    {
        var materia = _dataaccess.Materia.Find(id);
        if (materia == null) //throw new KeyNotFoundException("Materia no encontrada");
        {
        }

        return (materia);
    }

    [HttpPost]
    public IActionResult ConsultarMateriaGrid(int id)
    {
        var mat = getConsMateria(id);
        return View("ConsultaMateria", mat);
    }
}