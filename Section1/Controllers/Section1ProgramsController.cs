using Section1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Section1.Controllers
{
    public class Section1ProgramsController : Controller
    {
        // GET: Section1Programs
        public ActionResult Index()
        {
            return View();
        }


        public ActionResult Question1()
        {
            return View();
        }

       
        public ActionResult Question2()
        {            
            return View();
        }


        public ActionResult Question3()
        {
            return View();
        }


        public ActionResult Question4()
        {
            return View();
        }


        [HttpPost]
        public ActionResult Question1(Question1 question1)
        {
            question1.Output = SchoolGradeTable(question1.m, question1.n);
            return View(question1);
        }

        [HttpPost]
        public ActionResult Question2(Question2 question2)
        {
            try
            {
                question2.Output = ReverseNumber(question2.Number);                
            }
            catch (Exception e)
            {
                question2.Output = e.Message;
            }
            return View(question2);
        }
        
        [HttpPost]
        public ActionResult Question3(Question3 question3)
        {
            question3.Output = FindDuplicateCharacters(question3.Input);         
            return View(question3);
        }

        [HttpPost]
        public ActionResult Question4(Question3 question3)
        {
            question3.Output = CheckStringIsDigitOnly(question3.Input);
            return View(question3);
        }

        private string SchoolGradeTable(int m, int n)
        {
            string output = "";
            for (int i = 1; i <= n; i++)
            {
                output += (i + " * " + m + " = " + (m * i) + Environment.NewLine);
            }
            return output;
        }

        private string ReverseNumber(uint number)
        {

            uint reverse = 0, rem = 0;
            try
            {
                while (number > 0)
                {
                    rem = number % 10;
                    reverse = (reverse * 10) + rem;
                    number /= 10;
                }
            }
            catch (DivideByZeroException e1)
            {
                throw e1;
            }
            catch (Exception e)
            {
                throw e;
            }
            return reverse.ToString();
        }

        public string FindDuplicateCharacters(string input)
        {

            string output = "";
            char[] characters = input.ToCharArray();

            foreach (var line in characters.GroupBy(info => info.ToString())
                        .Select(group => new
                        {
                            Metric = group.Key,
                            Count = group.Count()
                        })
                        .Where(x => x.Count > 1 && x.Metric != " ")
                        .OrderBy(x => x.Metric))
            {
                output = output + (line.Metric + " - " + line.Count + Environment.NewLine);
            }
            return output;
        }

        private string CheckStringIsDigitOnly(string input)
        {
            string output = "";
            double digit;
            if (double.TryParse(input, out digit))
            {
                return output = "The Given Input " + input + " is Only Digit";
            }
            else
            {
                return output = "The Given Input " + input + " is not Only Digit";
            }

        }

    }
}