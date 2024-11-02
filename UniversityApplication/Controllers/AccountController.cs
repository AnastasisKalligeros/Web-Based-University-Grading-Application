
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Dynamic;
using UniversityApplication.Models;


namespace UniversityApplication.Controllers
{
	public class AccountController : Controller
	{

		SqlConnection con = new SqlConnection();
		SqlCommand com = new SqlCommand();
		SqlCommand com1 = new SqlCommand();
		SqlCommand com2 = new SqlCommand();
		SqlCommand com3 = new SqlCommand();
		SqlCommand com4 = new SqlCommand();


		SqlDataReader dr, dk;


		[HttpGet]
		public ActionResult Login()
		{
			return View();
		}

		void connectionString()
		{
			con.ConnectionString = "data source=DESKTOP-AVTLD8A\\SQLEXPRESS01; database=applicationdb; integrated security = SSPI;";
		}








		public ActionResult AddRegister()
		{
			return View();
		}
		public ActionResult index(Account acc)
		{
			connectionString();		

			con.Open();
			com.Connection = con;
			com.CommandText = "select * from users where username='" + acc.Name + "' and password='" + acc.Password + "' and role='" + acc.Role + "' ";
			dr = com.ExecuteReader();
			if (dr.Read())
			{
				con.Close();
				return View("index");
			}
			else
			{
				con.Close();
				return View("ErrorLogin");
			}

		}
	
		public ActionResult Reg(Register reg)
		{
			connectionString();

			con.Open();
			com.Connection = con;
			com.CommandText = "SELECT * FROM users WHERE username='" + reg.Name + "'";
			dr = com.ExecuteReader();
			if (dr.Read())
			{
				return View("ErrorLogin");
			}
			else
			{
				dr.Close();
				com.CommandText = "INSERT INTO users VALUES ('" + reg.Name.ToString() + "','" + reg.Password.ToString() + "','" + reg.Role + "')";
				dr = com.ExecuteReader();
				con.Close();
				return View("index");
			}
		}

		public ActionResult Student()
		{
			return View();
		}

		public ActionResult Grade()
		{
			return View();
		}
		public ActionResult Total()
		{
			return View();
		}
		
		public ActionResult ViewTotal(Coursehasstudents cour)
		{
			connectionString();
			con.Open();
			com.Connection = con;
			com.CommandText ="SELECT idCOURSE,GradeCourseStudent FROM course_has_students WHERE RegistrationNumber='"+cour.registrationnumber+ "' AND GradeCourseStudent IS NOT NULL";
			List<Coursehasstudents> grades = new List<Coursehasstudents>();
			List<Course> coursenames = new List<Course>();
			MyViewModel myView = new MyViewModel();
			int i = 0;
			dk = com.ExecuteReader();
			while (dk.Read())
			{
				var cou = new Coursehasstudents();
				cou.courseid = (int)dk["idCOURSE"];
				cou.gradecoursestudent = (int)dk["GradeCourseStudent"];
				grades.Add(cou);
			}
			dk.Close();
			com1.Connection = con;
			while (i < grades.Count)
			{
				var c = new Course();
				com1.CommandText = "SELECT CourseTitle FROM course WHERE idCOURSE='" + grades[i].courseid + "'";
				dk = com1.ExecuteReader();
				while (dk.Read())
				{
					c.coursetitle = (string)dk["CourseTitle"];
				}
				coursenames.Add(c);
				i++;
				dk.Close();
			}
			int j;
			int totalgrades = 0;
			for (j = 0; j < grades.Count; j++)
			{
				totalgrades = totalgrades + grades[j].gradecoursestudent;
			}
			int total = 0;
			if (grades.Count!=0)
			{
				total = totalgrades / grades.Count;
			}
			var finalcou = new Course();
			var finalgrade = new Coursehasstudents();
			finalcou.coursetitle = "Total Grade:";
			finalgrade.gradecoursestudent = total;
			grades.Add(finalgrade);
			coursenames.Add(finalcou);
			myView.cour = coursenames;
			myView.cours = grades;
			return View(myView);
		}

		public ActionResult List()
		{
			return View();
		}
		public ActionResult Entry()
		{
			return View();
		}

		public ActionResult Registration()
		{
			return View();
		}

		public ActionResult ViewCourses()
		{
			connectionString();
			con.Open();
			var model = new List<Course>();
			var model1 = new List<int>();
			var model2 = new List<string>();
			var model3 = new List<Professor>();
			com1.Connection = con;
			com2.Connection = con;
			com3.Connection = con;
			com4.Connection = con;
			int i = 0;
			int j = 0;
			com1.CommandText = "SELECT CourseTitle, CourseSemester from course";
			SqlDataReader d = com1.ExecuteReader();
			while (d.Read())
			{
				com1.CommandText = "SELECT CourseTitle, CourseSemester from course";
				var course = new Course();
				course.coursetitle = (string)d["coursetitle"];
				course.coursesemester = (string)d["coursesemester"];
				model.Add(course);
			}
			d.Close();
			com2.CommandText = "SELECT AFM from course";
			SqlDataReader d1 = com2.ExecuteReader();
			while (d1.Read())
			{
				com2.CommandText = "SELECT AFM from course";
				model1.Add(d1.GetInt32(0));
			}
			d1.Close();
			com3.CommandText = "SELECT Surname from professors WHERE AFM='" + model1[i] + "'";
			while (i < (model1.Count))
			{
				SqlDataReader d2 = com3.ExecuteReader();
				var prof = new Professor();
				while (d2.Read())
				{

					com3.CommandText = "SELECT Surname from professors WHERE AFM='" + model1[i] + "'";
					model2.Add(d2.GetString(0));
				}
				prof.Surname = model2[j];
				model3.Add(prof);
				j++;
				i++;
				d2.Close();
				if (i != model1.Count)
				{
					com3.CommandText = "SELECT Surname from professors WHERE AFM='" + model1[i] + "'";
				}
			}

			MyViewModel viewModel = new MyViewModel();
			viewModel.cour = model;
			viewModel.prof = model3;

			return View(viewModel);




		}
		public ActionResult Assigning()
		{
			return View();
		}
		public ActionResult Declaration()
		{
			return View();
		}

		public ViewResult RegProfessor(Professor prof)
		{
			connectionString();
			con.Open();
			com.Connection = con;
			com.CommandText = "SELECT * FROM users WHERE username='" + prof.username + "'";
			dr = com.ExecuteReader();
			if (dr.Read())
			{
				dr.Close();
				com.CommandText = "SELECT * FROM professors WHERE username='" + prof.username + "'";
				dr = com.ExecuteReader();
				if (dr.Read())
				{
					con.Close();
					return View("ErrorUsernameAlreadyExists");
				}
				else
				{
					dr.Close();
					com.CommandText = "SELECT * FROM professors WHERE AFM ='" + prof.AFM + "'";
					dr = com.ExecuteReader();
					if (dr.Read())
					{
						con.Close();
						return View("ErrorAFMAlreadyExists");
					}
					else
					{
						dr.Close();
						com.CommandText = "INSERT INTO professors VALUES ('" + prof.AFM + "','" + prof.Name.ToString() + "','" + prof.Surname.ToString() + "','" + prof.Department.ToString() + "','" + prof.username.ToString() + "')";
						dr = com.ExecuteReader();
						con.Close();
						return View("index");
					}

				}
			}
			else
			{
				con.Close();
				return View("Error");
			}

		}
		public ViewResult RegStudent(Student stu)
		{
			connectionString();
			con.Open();
			com1.Connection = con;
			com1.CommandText = "SELECT * FROM users WHERE username='" + stu.username + "'";
			dk = com1.ExecuteReader();
			if (dk.Read())
			{
				dk.Close();
				com1.CommandText = "SELECT * FROM students WHERE username='" + stu.username + "'";
				dk = com1.ExecuteReader();
				if (dk.Read())
				{
					con.Close();
					return View("ErrorUsernameAlreadyExists");
				}
				else
				{
					dk.Close();
					com1.CommandText = "SELECT * FROM students WHERE RegistrationNumber ='" + stu.regnum + "'";
					dk = com1.ExecuteReader();
					if (dk.Read())
					{
						con.Close();
						return View("ErrorRegistrationNumberAlreadyExists");
					}
					else
					{
						dk.Close();
						com1.CommandText = "INSERT INTO students VALUES ('" + stu.regnum + "','" + stu.name.ToString() + "','" + stu.surname.ToString() + "','" + stu.department.ToString() + "','" + stu.username.ToString() + "')";
						dk = com1.ExecuteReader();
						con.Close();
						return View("index");
					}

				}
			}
			else
			{
				con.Close();
				return View("Error");
			}

		}



		public ViewResult RegCourse(Course cour)
		{
			connectionString();
			con.Open();
			com1.Connection = con;
			com1.CommandText = "SELECT * FROM professors WHERE AFM='" + cour.professorsAFM + "'";
			dk = com1.ExecuteReader();
			if (dk.Read())
			{
				dk.Close();
				com1.CommandText = "SELECT * FROM course WHERE AFM='" + cour.professorsAFM + "'";
				dk = com1.ExecuteReader();
				if (dk.Read())
				{
					con.Close();
					return View("ErrorAFMAlreadyExists");
				}
				else
				{
					dk.Close();
					com1.CommandText = "SELECT * FROM course WHERE idCOURSE ='" + cour.idcourse + "'";
					dk = com1.ExecuteReader();
					if (dk.Read())
					{
						con.Close();
						return View("ErrorIdCourseAlreadyExists");
					}
					else
					{
						dk.Close();
						com1.CommandText = "INSERT INTO course VALUES ('" + cour.idcourse + "','" + cour.coursetitle.ToString() + "','" + cour.coursesemester.ToString() + "','" + cour.professorsAFM + "')";
						dk = com1.ExecuteReader();
						con.Close();
						return View("index");
					}

				}
			}
			else
			{
				con.Close();
				return View("Error");
			}

		}


		public ViewResult AssigningCourse(Course cour, Professor prof)
		{
			connectionString();
			con.Open();
			com.Connection = con;
			com.CommandText = "SELECT * FROM professors WHERE AFM='" + prof.AFM + "'";
			dk = com.ExecuteReader();
			if (dk.Read())
			{
				dk.Close();
				com.CommandText = "SELECT * FROM course WHERE CourseTitle='" + cour.coursetitle + "'";
				dk = com.ExecuteReader();
				if (dk.Read())
				{
					dk.Close();
					com.CommandText = "UPDATE course SET AFM='" + prof.AFM + "' WHERE CourseTitle='" + cour.coursetitle + "'";
					dk = com.ExecuteReader();
					dk.Close();
					return View("index");

				}
				else
				{
					return View("Error");
				}
			}
			else
			{
				con.Close();
				return View("Error");
			}


		}

		public ViewResult DeclarationCourse(Student stu, Course cour)
		{
			connectionString();
			con.Open();
			com.Connection = con;
			com1.Connection = con;
			com.CommandText = "SELECT * FROM students WHERE RegistrationNumber='" + stu.regnum + "'";
			dk = com.ExecuteReader();
			if (dk.Read())
			{
				dk.Close();
				com.CommandText = "SELECT * FROM course WHERE CourseTitle='" + cour.coursetitle + "'";
				dk = com.ExecuteReader();
				if (dk.Read())
				{
					dk.Close();
					com1.CommandText = "SELECT idCOURSE FROM course WHERE CourseTitle='" + cour.coursetitle + "'";
					dk = com1.ExecuteReader();
					while (dk.Read())
					{
						cour.idcourse = dk.GetInt32(0);
					}
					dk.Close();
					com.CommandText = "INSERT INTO course_has_students(idCOURSE,RegistrationNumber) VALUES ('" + cour.idcourse + "', '" + stu.regnum + "')";
					dr = com.ExecuteReader();
					dr.Close();
					return View("index");
				}
				else
				{
					con.Close();
					return View("Error");
				}
			}
			else {
				con.Close();
				return View("Error");
			}
		}


		public ActionResult ListGrades(Course cour)
		{

			connectionString();
			con.Open();
			var model = new List<Coursehasstudents>();
			com.Connection = con;
			com1.Connection = con;
			com1.CommandText = "SELECT idCOURSE FROM course WHERE CourseTitle='" + cour.coursetitle + "'";
			dk = com1.ExecuteReader();
			while (dk.Read())
			{
				cour.idcourse = dk.GetInt32(0);
			}
			dk.Close();
			com.CommandText = "SELECT RegistrationNumber,GradeCourseStudent FROM course_has_students WHERE idCOURSE='" + cour.idcourse + "'";
			dk = com.ExecuteReader();

			while (dk.Read())
			{
				com.CommandText = "SELECT RegistrationNumber,GradeCourseStudent FROM course_has_students WHERE idCOURSE='" + cour.idcourse + "'";
				var cour1 = new Coursehasstudents();
				if (dk["GradeCourseStudent"].ToString().Length != 0)
				{
					cour1.registrationnumber = (int)dk["RegistrationNumber"];
					cour1.gradecoursestudent = (int)dk["GradeCourseStudent"];
					model.Add(cour1);

				}
				else
				{
					break;
				}
			}
			dk.Close();
			MyViewModel myView = new MyViewModel();
			myView.cours = model;
			return View(myView);

		}
		public ActionResult ViewList(MyViewModel courses)
		{

			return View(courses);
		}


		public ActionResult EntryCourse()
		{
			return View();
		}
		public ActionResult EntryCourse1(Course course, Coursehasstudents cour)
		{
			connectionString();
			con.Open();
			com.Connection = con;
			com.CommandText = "SELECT idCOURSE FROM course WHERE CourseTitle='" + course.coursetitle + "'";
			dk = com.ExecuteReader();
			if (dk.Read())
			{

				dk.Close();
				com.CommandText = "SELECT idCOURSE FROM course WHERE CourseTitle='" + course.coursetitle + "'";
				dk = com.ExecuteReader();
				while (dk.Read())
				{
					course.idcourse = dk.GetInt32(0);
				}
				dk.Close();
				com.CommandText = "SELECT GradeCourseStudent FROM course_has_students WHERE idCOURSE='" + course.idcourse + "' AND RegistrationNumber='" + cour.registrationnumber + "'";
				dk = com.ExecuteReader();
				while (dk.Read())
				{
					if (dk["GradeCourseStudent"].ToString().Length != 0)
					{
						return View("ErrorGrade");
					}
					else
					{
						dk.Close();
						com.CommandText = "UPDATE course_has_students SET GradeCourseStudent='" + cour.gradecoursestudent + "' WHERE RegistrationNumber='" + cour.registrationnumber + "' AND idCOURSE='" + course.idcourse + "'";
						dk = com.ExecuteReader();
						return View("index");
					}
				}
				return View("index");
			}
			else
			{
				con.Close();
				return View("ErrorGrade");
			}
			
		}

		public ActionResult ViewStudent(Coursehasstudents cour)
		{
			connectionString();
			con.Open();
			MyViewModel myView = new MyViewModel();
			List<Course> coursenames = new List<Course>();
			List<Coursehasstudents> grades = new List<Coursehasstudents>();
			int i = 0;
			com.Connection = con;
			com.CommandText = "SELECT idCOURSE,GradeCourseStudent FROM course_has_students WHERE RegistrationNumber='" + cour.registrationnumber + "' AND GradeCourseStudent IS NOT NULL";
			dk = com.ExecuteReader();
			while (dk.Read())
			{
				var cour1 = new Coursehasstudents();
				cour1.courseid = (int)dk["idCOURSE"];
				cour1.gradecoursestudent = (int)dk["GradeCourseStudent"];
				grades.Add(cour1);
			}
			dk.Close();
			com1.Connection = con;
			while(i<grades.Count){
				var c = new Course();
				com1.CommandText = "SELECT CourseTitle FROM course WHERE idCOURSE='" + grades[i].courseid + "'";
				dk = com1.ExecuteReader();
				while (dk.Read())
				{
					c.coursetitle = (string)dk["CourseTitle"];
				}
				coursenames.Add(c);
				i++;
				dk.Close();
			}
			myView.cour = coursenames;
			myView.cours = grades;
			return View(myView);

		}
	
		public ViewResult ViewGrade(Coursehasstudents cour, Course c)
		{
			connectionString();
			con.Open();
			com.Connection = con;
			MyViewModel myView = new MyViewModel();
			List<Coursehasstudents> grades = new List<Coursehasstudents>();
			List<Course> coursesemester = new List<Course>();
			int j = 0;
			com.Connection = con;
			com.CommandText = "SELECT idCOURSE,CourseTitle FROM course WHERE CourseSemester='" + c.coursesemester + "'";
			dk = com.ExecuteReader();
			while (dk.Read())
			{
				var course = new Course();
				course.idcourse = (int)dk["idCOURSE"];
				course.coursetitle = (string)dk["CourseTitle"];
				coursesemester.Add(course);
			}
			while (j < coursesemester.Count)
			{
				dk.Close();
				com.CommandText = "SELECT GradeCourseStudent FROM course_has_students WHERE RegistrationNumber='" + cour.registrationnumber + "' AND idCOURSE='"+coursesemester[j].idcourse+"'";
				dk = com.ExecuteReader();
				while (dk.Read())
				{
					var cour1 = new Coursehasstudents();
					cour1.gradecoursestudent = (int)dk["GradeCourseStudent"];
					grades.Add(cour1);
				}
				j++;
			}
			dk.Close();
			myView.cour = coursesemester;
			myView.cours = grades;
			return View(myView);

		}


		






	}
}


