using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Models;
using WebDbApp2.DTO;
using WebDbApp2.Miscellaneous;

namespace WebDbApp2.Controllers;

[ApiController]
[Route("api/[controller]/[action]")]
[Produces("application/json")]
public class MateriaController : Controller
{
    private readonly DataAccess _dataaccess;


    public MateriaController(DataAccess dataaccess)
    {
        _dataaccess = dataaccess;
    }
    
    [HttpGet]
    public List<MateriaBuscadorDTO> GetMaterias()
    {
        var materias = _dataaccess.Materia
            .Include(mat => mat.Depto )
            .ThenInclude(depto => depto.Decanato).ToList();
        var materiasClon = materias.ToList() ;
        materiasClon.AddRange(materias.ToList());
        materiasClon.AddRange(materias.ToList());
        materiasClon.AddRange(materias.ToList());
        materiasClon.AddRange(materias.ToList());
        materiasClon.AddRange(materias.ToList());
        materiasClon.AddRange(materias.ToList());
        materiasClon.AddRange(materias.ToList());
        materiasClon.AddRange(materias.ToList());
        materiasClon.AddRange(materias.ToList());
        materiasClon.AddRange(materias.ToList());


        var materiasDTO = materiasClon.Select(materia => ToBuscadorDTO(materia)).ToList();

        return materiasDTO;
    }
    
    private static MateriaBuscadorDTO ToBuscadorDTO(Materia materia)
    {
        return new MateriaBuscadorDTO()
        {
            Decanato = materia.Depto.Decanato.Descripcion,
            Departamento = materia.Depto.Descripcion,
            CodigoClase = materia.CodigoClase,
            Periodo = materia.Periodo,
            Descripcion = materia.Descripcion,
            UrlCurso = materia.UrlCurso,
            UrlDownload = materia.UrlDownload,
            NivelAsu = materia.NivelAsu,
            Version = materia.Version
        };
    }
}