using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualBasic;
using System.Collections;
using System.Text;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
	public class CalculatorController : Controller
	{

		public static int t = 0;
		public static ArrayList history = new ArrayList();
	   
		public ActionResult Index()
		{
			return View();
		}

		[HttpPost]
		public ActionResult Index(Calculator m)
		{

            float sum = 0;
			if(m.DataX != null && m.DataY != null) { 
			switch (m.Logic)
			{
				case "+":
					sum = float.Parse(m.DataX) + float.Parse(m.DataY);
					break;
				case "-":
					sum = float.Parse(m.DataX) - float.Parse(m.DataY);
					break;
				case "x":
					sum = float.Parse(m.DataX) * float.Parse(m.DataY);
					break;
				case "/":
					sum = float.Parse(m.DataX) / float.Parse(m.DataY);
					break;
					default:
					break;
			}   
				m.Sum = sum;
				t++;             
			}
			 else 
			 {
				 sum = 0;
			 }


			if (t == 0)
			{

				t = +1;
			}
			string Sub_str = "";
			if (m.DataX != null && m.DataY != null)
			{
				Sub_str = m.DataX.ToString() + " " + m.Logic.ToString() + " " + m.DataY.ToString() + " = " + m.Sum.ToString("n2");

				history.Add(Sub_str);
				m.historyIn = history;

            }
			Console.WriteLine("----------");

			Console.WriteLine(t);

			for (int k = 0; k < t; k++)
			{
				//Console.WriteLine();
				//Console.Write(m.GetHistory()[k] + " ");
				//ViewBag.ArrayData = ViewBag.ArrayData + "<p>" + m.History[k] + "</p>";
				Console.WriteLine();
			}
			Console.WriteLine("----------");
			//Console.ReadLine();
			//ViewData["mylist"] = mylist;
			return View(m);
		}
	   
	}
}
