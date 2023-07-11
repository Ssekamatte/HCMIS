using Syncfusion.Blazor.Charts;

namespace HCMIS.Model
{
	public class SeriesModel
	{
		public string? SeriesName { get; set; }
		public string? GroupBy { get; set; }
		public string? YAxisTitle { get; set; }
		public ChartSeriesType ChartType { get; set; }
		public string? SeriesColor { get; set; }
		public double ColumnWidth { get; set; }
		public double Interval { get; set; }
		public List<DashboardModel>? Datasource { get; set; }
	}
}
