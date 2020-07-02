using Microcharts;
using SkiaSharp;
using System;
using System.Collections.Generic;
using System.Text;


namespace finalprojectv1.Model
{
    class Data
    {

		public static async System.Threading.Tasks.Task<string> labelMaker(String teacher) 
		{
			int x = await LinkingPage.getCovidClass(teacher);
			String y = Convert.ToString(x);
			return y;
		}

	
		


		public static async System.Threading.Tasks.Task<Chart[]> CreateXamarinSampleAsync()
		{
			var entries = new[]
			{
				new Entry(await LinkingPage.getCovidClass("Mr Smiths class"))
				{
					Label = "MrSmith's",
					ValueLabel = await labelMaker("Mr Smiths class"),
					Color = SKColor.Parse("#2c3e50")
				},
				new Entry(await LinkingPage.getCovidClass("Mr Thackerys class"))
				{
					Label = "MrThackery's",
					ValueLabel = await labelMaker("Mr Thackerys class"),
					Color = SKColor.Parse("#2c3e50")
				},
				new Entry(await LinkingPage.getCovidClass("Mr Johnnys class"))
				{
					Label = "MrJohnny's",
					ValueLabel = await labelMaker("Mr Johnnys class"),
					Color = SKColor.Parse("#2c3e50")
				},
				new Entry(await LinkingPage.getCovidClass("Mr Lawrences class"))
				{
					Label = "MrLawrences's",
					ValueLabel = await labelMaker("Mr Lawrences class"),
					Color = SKColor.Parse("#2c3e50")
				},
				new Entry(await LinkingPage.getCovidClass("Mr Philips class"))
				{
					Label = "MrPhilip's",
					ValueLabel = await labelMaker("Mr Philips class"),
					Color = SKColor.Parse("#2c3e50")
				},
				new Entry(await LinkingPage.getCovidClass("Mr Jeremys class"))
				{
					Label = "MrJeremy's",
					ValueLabel = await labelMaker("Mr Jeremys class"),
					Color = SKColor.Parse("#2c3e50")
				},
				new Entry(await LinkingPage.getCovidClass("Mr Harolds class"))
				{
					Label = "MrHarold's",
					ValueLabel = await labelMaker("Mr Harolds class"),
					Color = SKColor.Parse("#2c3e50")
				},

			};

			return new Chart[]
			{
			
				
				new LineChart()
				{
					Entries = entries,
					LineMode = LineMode.Straight,
					LineSize = 8,
					PointMode = PointMode.Square,
					PointSize = 18,
				},
				new DonutChart() { Entries = entries },
				new RadialGaugeChart() { Entries = entries },
				new RadarChart() { Entries = entries },
			};
		}



	}
	}
