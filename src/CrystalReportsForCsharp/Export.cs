using CrystalDecisions.CrystalReports.Engine;
using System.Data;

namespace CrystalReportsForCsharp
{
    public class Export
    {
        public void Pdf()
        {
            var data = new DataTable();
            data.Columns.Add("ProductId", typeof(int));
            data.Columns.Add("Name", typeof(string));
            data.Columns.Add("Description", typeof(string));

            data.Rows.Add(1, "Panda Coffee Mug", "Ceramic, black & white pandabear coffee mug");
            data.Rows.Add(1, "Coffee Stir Sticks", "Disposable coffee stir sticks");

            var report = new ReportDocument();

        }
    }
}
