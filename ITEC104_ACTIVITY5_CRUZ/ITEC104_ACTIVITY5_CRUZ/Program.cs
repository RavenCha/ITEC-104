 /*
 * Created by SharpDevelop.
 * User: Raven
 * Date: 10/27/2022
 * Time: 2:29 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Linq;
namespace ITEC104_ACTIVITY5_CRUZ
{
	class Program
	{
		public static void Main(string[] args)
		{
			
           static void Main(string[] args)
        {            
           List<int> mylist = test(new List<int>(new int[] { 10, 20, 35 , 65, 53, 48, 5, 1}));                  
           foreach(var i in mylist)
            {
               Console.Write(i.ToString()+" ");
            }     
        }                  
        public static List<int> test(List<int> nums)
          {
             return nums.Where(n => n % 10 != 5).ToList();
          }    
    }
}
