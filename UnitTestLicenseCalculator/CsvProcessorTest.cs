using LicenseCalculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace UnitTestLicenseCalculator
{
    [TestClass]
    public class CsvProcessorTest
    {
        [TestMethod]
        public void LoadCSVFile()
        {
            // Should be able to read the CSV file and load all records for that application ID in list
            CsvProcessor csvProcessor = new CsvProcessor();

            List<LicenseDetails> lstRecords = csvProcessor.loadCSV("testData.csv", "374");

            Assert.AreEqual(2, lstRecords.Count);
        }

        [TestMethod]
        public void ProcessCSVData()
        {
            // Should be able to process the CSV file and calculate the total license for an application ID.
            CsvProcessor csvProcessor = new CsvProcessor();

            List<LicenseDetails> lstRecords = csvProcessor.loadCSV("testData.csv", "375");
            var result = csvProcessor.processRecords(lstRecords);

            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void FileNotFound()
        {

            CsvProcessor csvProcessor = new CsvProcessor();

            try
            {
                csvProcessor.loadCSV("testData1.csv", "375");
            }
            catch (Exception ex)
            {
                Assert.AreEqual("File does not exist or bad data", ex.Message);
            }

        }

        [TestMethod]
        public void OneLicenseForTwoLaptops()
        {
            // Since there are two records for laptop and one laptop can be free provided there is one license.
            CsvProcessor csvProcessor = new CsvProcessor();

            List<LicenseDetails> lstRecords = csvProcessor.loadCSV("testData.csv", "374");
            var result = csvProcessor.processRecords(lstRecords);

            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void ThreeLicenseForApp375()
        {
            // Since there is only one record for laptop and three for desktop, so only three license are required.
            CsvProcessor csvProcessor = new CsvProcessor();

            List<LicenseDetails> lstRecords = csvProcessor.loadCSV("testData.csv", "375");
            var result = csvProcessor.processRecords(lstRecords);

            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void IgnoreDuplicateAndCalculate()
        {
            // Should consider only the first record and ignore the duplicate record for other entries with same computerID.
            CsvProcessor csvProcessor = new CsvProcessor();

            List<LicenseDetails> lstRecords = csvProcessor.loadCSV("testData.csv", "376");
            var result = csvProcessor.processRecords(lstRecords);

            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void OnlyOneLaptopIsFree()
        {
            // Since we have records for two laptops and two desktops. The number of license required should be 3
            CsvProcessor csvProcessor = new CsvProcessor();

            List<LicenseDetails> lstRecords = csvProcessor.loadCSV("testData.csv", "377");
            var result = csvProcessor.processRecords(lstRecords);

            Assert.AreEqual(3, result);
        }
    }
}
