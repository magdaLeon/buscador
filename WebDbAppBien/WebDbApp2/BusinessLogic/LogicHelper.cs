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
    
    

}