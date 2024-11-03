// See https://aka.ms/new-console-template for more information

using System;
using System.Text;
using log4net;

ILog log = LogHelper.Log4NetHelper.GetLogger();

string me = "sono Antonio!"; 

log.Info(String.Format("Ciao Mondo, {0}",me));
log.Debug("Riga di debug");
log.Warn("Riga di Avvertimento");
try
{
    int divisore = 0;

    Console.WriteLine("Inserisci un dividendo: \n");

    int dividendo = int.Parse(Console.ReadLine());

    decimal divisione = dividendo / divisore;

}catch(DivideByZeroException ex)
{
    log.Error($"Eccezione rilevata (divisione per 0) : {ex.Message.ToString()}");

}
catch(Exception ex)
{
    log.Error($"Eccezione rilevata : {ex.Message.ToString()}");
}
