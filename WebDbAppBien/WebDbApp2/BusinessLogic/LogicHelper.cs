using Models;
using WebDbApp2.Miscellaneous;

namespace WebDbApp2.BusinessLogic;

public class LogicHelper
{
    private readonly DataAccess _dataaccess;


    public LogicHelper(DataAccess dataaccess)
    {
        _dataaccess = dataaccess;
    }
    
    
    public List<NivelAcademico> GetNivelesAcademicos()
    {
        var niveles = _dataaccess.NivelAcademico.ToList();
        return niveles;
    }
}