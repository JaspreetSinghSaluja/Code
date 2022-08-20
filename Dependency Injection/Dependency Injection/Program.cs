using Dependency_Injection;

/// <summary>
/// Author - Jaspreet Saluja
/// Dependency Injection
/// </summary>
class Program
{
    static void Main(string[] args)
    {
        //conlog logc =new conlog();

        //Making dynamic
        //Filelog filelog = new Filelog();
        //DBlog dblog = new DBlog();

        ILogger lrg;
        string getconfig = "file";

        if (getconfig =="DB")
        {
            lrg = new DBlog();
        }
        else
        {
            lrg = new Filelog();
        }
        //Logger lognow = new Logger(dblog);
        Logger lognow = new Logger(lrg);
        try
        {
            throw new DivideByZeroException();
        }
        catch (Exception ex)
        {
            //logc.log(ex.Message);
            lognow.log(ex.Message);
            Console.Read();
        }
    }
}

// if we want to save in database not in file the commect the below method and create a logger class
//class conlog
//{
//    public void log(string msg)
//    {
//        Console.WriteLine("Log saved in text file: "+ msg);
//    }
//}