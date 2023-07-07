﻿using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using WebDbApp.Miscellaneous;
using System.Web;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using Models;

namespace WebDbApp.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private DataAccess _dataaccess;


    public HomeController(DataAccess dataaccess, ILogger<HomeController> logger)
    {
        _dataaccess = dataaccess;
        _logger = logger;
    }


    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    public IActionResult AltaMateria()
    {
        return View();
    }

    public IActionResult BajaMateria()
    {
        return View();
    }

    [HttpGet]
    public IActionResult MateriaGrid()
    {
        IEnumerable<Materia>? mat = _dataaccess.Materia;
        return View("MateriasGrid", mat);
    }

    [HttpGet]
    public IActionResult NivelGrid()
    {
        IEnumerable<NivelAcademico>? niveles = _dataaccess.NivelAcademico;
        return View("NivelesGrid", niveles);
    }

    public IActionResult CrearMat(Materia model)
    {
        // save materia
        _dataaccess.Materia.Add(model);
        _dataaccess.SaveChanges();

        return Ok(new { message = "Materia Creada." });
    }


    [HttpPost]
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
            return RedirectToAction("BajaMateria");
        }

        return Ok(new { message = "Materia Eliminada." });
    }


    private Materia getMateria(int id)
    {
        var materia = _dataaccess.Materia.Find(id);
        if (materia == null) //throw new KeyNotFoundException("Materia no encontrada");
        {
        }

        return materia;
    }


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


    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}