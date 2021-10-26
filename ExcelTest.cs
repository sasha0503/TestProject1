using Microsoft.VisualStudio.TestTools.UnitTesting;
using LabCalculator;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace TestProject1
{
    [TestClass]
    public class ExcelTest
    {
        [TestMethod]
        public void Form1Test()
        {
            Form1 form = new Form1(30, 30);

            // Check column naming
            Assert.AreEqual(form.getDataGridView().Columns[0].Name, "A");
            Assert.AreEqual(form.getDataGridView().Columns[3].Name, "D");
            Assert.AreEqual(form.getDataGridView().Columns[25].Name, "Z");
            Assert.AreEqual(form.getDataGridView().Columns[26].Name, "AA");
            // Check row naming
            Assert.AreEqual(form.getDataGridView().Rows[0].HeaderCell.Value, "0");
            Assert.AreEqual(form.getDataGridView().Rows[4].HeaderCell.Value, "4");
        }

        [TestMethod]
        public void getDataGridViewTest()
        {
            Form1 form = new Form1(30, 30);
            Assert.IsInstanceOfType(form.getDataGridView(), typeof(DataGridView), "wrong type!");
        }
    }
}
