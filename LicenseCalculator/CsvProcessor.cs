using GenericParsing;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace LicenseCalculator
{
    public class CsvProcessor : ICsvProcessor
    {
        public List<LicenseDetails> loadCSV(string Filepath, string ApplicationID)
        {
            try
            {

                List<LicenseDetails> lstLicenseData = new List<LicenseDetails>();
                using (GenericParser parser = new GenericParser())
                {
                    parser.SetDataSource(Filepath);

                    parser.ColumnDelimiter = ',';
                    parser.FirstRowHasHeader = true;
                    parser.TextQualifier = '\"';

                    while (parser.Read())
                    {
                        if (parser["ApplicationID"] == ApplicationID)
                        {
                            LicenseDetails licenseDetails = new LicenseDetails();
                            licenseDetails.ComputerID = parser["ComputerID"];
                            licenseDetails.UserID = parser["UserID"];
                            licenseDetails.ApplicationID = parser["ApplicationID"];
                            licenseDetails.ComputerType = parser["ComputerType"];
                            licenseDetails.Comment = parser["Comment"];

                            lstLicenseData.Add(licenseDetails);
                        }
                    }
                }

                return lstLicenseData;
            }
            catch (Exception)
            {
                throw new Exception("File does not exist or bad data");
            }
        }

        public int processRecords(List<LicenseDetails> lstLicenseData)
        {
            // remove duplicates
            var grpResult = lstLicenseData.AsEnumerable().GroupBy(r => new { userID = r.UserID, computerID = r.ComputerID }).Select(g => g.First());

            // get total licence for each user id
            var totalResult = grpResult.AsEnumerable().GroupBy(r => r.UserID)
                                .Select(x => new
                                {
                                    UserID = x.Key,
                                    Count = x.Select(z => z.ComputerType.ToLower()).Contains("laptop") && x.Count() >= 2 ? x.Count() - 1 : x.Count(),
                                });

            // get total license count for all users
            var totalLicense = totalResult.Sum(x => x.Count);

            return totalLicense;
        }
    }
}
