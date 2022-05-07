using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Summator
{
	public  class Summator
	{
		public long Sum(int[] arr)
		{

			long sum = 0;

				for (int i = 0; i < arr.Length; i++)
				{
					sum += arr[i];
				}

				return sum;

		}

		public double Avarage(double[] arr)
		{

			double sum = 0;

			for (int i = 0; i < arr.Length; i++)
			{
				sum += arr[i];
			}

			return sum/arr.Length;

		}
	}
}
