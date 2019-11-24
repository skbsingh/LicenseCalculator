using System.Collections.Generic;

namespace LicenseCalculator
{
    interface ICsvProcessor
    {
        List<LicenseDetails> loadCSV(string Filepath, string ApplicationID);

        int processRecords(List<LicenseDetails> dtCSVData);
    }
}
