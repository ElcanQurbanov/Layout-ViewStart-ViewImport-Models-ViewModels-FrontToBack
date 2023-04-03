using Layout_ViewModels.Models;
using Layout_ViewModels.ViewModels.Home;
using Layout_ViewModels.ViewModels.Product;
using Microsoft.AspNetCore.Mvc;

namespace Layout_ViewModels.Controllers
{
	public class HomeController : Controller
	{
		public IActionResult Index()
		{

			//ViewData["names"] = new string[] { "Elcan", "Pervin", "Aksin" };

			//ViewBag.numbers = new int[] { 10, 20, 30, 40 };

			//string name = (object)"Elcan";

			//List<int> nums = new List<int>() { 1, 2, 3, 4, 5 };

			//int num = 5;

			//ViewBag.name = "Elcan";

			//TempData["surname"] = "Qurbanov";

			//return RedirectToAction(nameof(Detail));

			//string name = "Xaker";
			//return View((object)name);


			Student stu1 = new()
			{
				Id = 1,
				FullName = "Pervin Rehimli",
				Age = 26
			};

			Student stu2 = new()
			{
				Id = 2,
				FullName = "Ali Talibov",
				Age = 21
			};

			Student stu3 = new()
			{
				Id = 3,
				FullName = "Mirze Besirli",
				Age = 27
			};

			List<Student> students = new List<Student> { stu1, stu2, stu3 };

			Product product = new()
			{
				Id = 1,
				Name = "Samsung 11",
				Count = 50,
				Price = 200,
				Desription = "Description"
			};

			ProductVM productVM = new()
			{
				Name = product.Name,
				Price = product.Price,
			};

			HomeVM model = new()
			{
				Students = students,
				Product = productVM
			};

			return View(model);


			////ViewBag.address = "Sumqayit";

			//return View(students);

		}

		//public IActionResult Detail()
		//{
		//	return View();
		//}
	}
}
